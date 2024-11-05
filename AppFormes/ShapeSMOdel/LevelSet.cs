using System.Drawing;

namespace ShapeSMOdel
{
    public class LevelSet
    {
        private int _difficulty;
        private bool _isFinished;
        private Level[] _levels;

        public LevelSet(int difficulty, bool isFinished)
        {
            _difficulty = difficulty;
            _isFinished = isFinished;
            _levels = [];
        }


        //TODO position every shape//////////////////////////////////////////////////////////////////////////////
        public Shape CreateTangleShapeByTheme(string theme, Shape[] tangledshapes)
        {
            string dir = Utilities.FindDirectory(theme);

            Shape shapeToAdd;
            do
            {
                Random rand = new Random();
                string shapeName = Directory.GetFiles(dir)[rand.Next(Directory.GetFiles(dir).Length)];
                shapeToAdd = new Shape(shapeName, Point.Empty, theme);
            }
            while (tangledshapes.FirstOrDefault((Shape s) => s.Name == shapeToAdd.Name) != null);

            return shapeToAdd;
        }




        public SelectableShape[] InitializeSelectableShapes(Shape[] tangledShapes)
        {
            SelectableShape[] selectableShapes = [];
            foreach (Shape s in tangledShapes)
            {
                selectableShapes.Append(new SelectableShape(s));
            }
            return selectableShapes;
        }

        public SelectableShape CreateAnswer(string theme, SelectableShape[] selectableShapes)
        {
            string dir = Utilities.FindDirectory(theme);
            SelectableShape shapeToAdd;
            do
            {
                Random rand = new Random();
                string shapeName = Directory.GetFiles(dir)[rand.Next(Directory.GetFiles(dir).Length)];
                shapeToAdd = new SelectableShape(new Shape(shapeName, Point.Empty, theme));

            }
            while (selectableShapes.FirstOrDefault((SelectableShape s) => s.getName == shapeToAdd.getName) != null);
            return shapeToAdd;
        }

        public string[] getRandomThemes(int number)
        {
            string themeName;
            string dir = Utilities.FindAssetsDirectory();
            string[] themes = [];

            for (int i = 0; i < number; i++)
            {
                do
                {
                    Random rand = new Random();
                    themeName = Directory.GetFiles(dir)[rand.Next(Directory.GetFiles(dir).Length)];
                }
                while (themes.Contains(themeName));
                themes.Append(themeName);
            }
            return themes;
        }

        public void NextLevel()
        {
            if (_isFinished || _levels.Length >= 5)
            {
                return;
            }


            Shape[] tangledShapes = [];

            switch (_difficulty)
            {
                case 1:
                    string[] answerThemes = getRandomThemes(6);
                    string[] tangledThemes = Utilities.ChoseTangledThemes(answerThemes, 3);
                    foreach (string theme in tangledThemes)
                    {
                        tangledShapes.Append(CreateTangleShapeByTheme(theme, tangledShapes));
                    }

                    _levels.Append(new Level());
                    break;
                default:
                    break;
            }
        }
    }
}

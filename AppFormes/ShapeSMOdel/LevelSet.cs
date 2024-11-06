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

        public bool IsShapeInTangledShapes(SelectableShape shape, Shape[] tangledShapes)
        {
            foreach (Shape s in tangledShapes)
            {
                if (s.Name == shape.GetName())
                {
                    return true;
                }
            }
            return false;
        }

        public Shape CreateTangleShapeByTheme(string theme, Shape[] tangledshapes, SelectableShape[] selectableShapes)
        {
            Shape[] shapes = [];
            foreach (SelectableShape shape in selectableShapes)
            {
                if (shape.GetTheme() == theme && !IsShapeInTangledShapes(shape, tangledshapes))
                {
                    shapes.Append(new Shape(shape, Point.Empty));
                }
            }
            Random rand = new Random();
            return shapes[rand.Next(shapes.Length)];
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

        //public Level CreateLevelDiffTheme(int numberThemes)
        //{
        //    Shape[] tangledShapes = [];
        //    SelectableShape[] selectableShapes = [];
        //    string[] answerThemes = Utilities.GetRandomThemes(numberThemes);
        //    string[] tangledThemes = Utilities.ChoseTangledThemes(answerThemes, 3);

        //    foreach (string theme in answerThemes)
        //    {
        //        selectableShapes.Append(CreateAnswer(theme, selectableShapes));
        //    }
        //    foreach (string theme in tangledThemes)
        //    {
        //        tangledShapes.Append(CreateTangleShapeByTheme(theme, tangledShapes, selectableShapes));
        //    }
        //    return(new Level(tangledShapes, selectableShapes));
        //}

        public Level CreateLevelWithThemes(int numberThemes, int numberAnswer)
        {
            Shape[] tangledShapes = [];
            SelectableShape[] selectableShapes = [];
            string[] answerThemes = Utilities.GetRandomThemes(numberThemes);
            string[] tangledThemes = Utilities.ChoseTangledThemes(answerThemes, Math.Min(3, numberThemes));
            foreach (string theme in answerThemes)
            {
                for (int i = 0; i < numberAnswer / numberThemes; i++)
                {
                    selectableShapes.Append(CreateAnswer(theme, selectableShapes));
                }
            }
            while (tangledShapes.Length < 3)
            {
                foreach (string theme in tangledThemes)
                {
                    tangledShapes.Append(CreateTangleShapeByTheme(theme, tangledShapes, selectableShapes));
                }
            }

            return (new Level(tangledShapes, selectableShapes));
        }

        public Level CreateAbstractLevel(int numberAnswer)
        {
            Shape[] tangledShapes = [];
            SelectableShape[] selectableShapes = [];
            for (int i = 0; i < numberAnswer; i++)
            {
                selectableShapes.Append(CreateAnswer("Abstract", selectableShapes));
            }
            for (int i = 0; i < 3; i++)
            {
                tangledShapes.Append(CreateTangleShapeByTheme("Abstract", tangledShapes, selectableShapes));
            }
            return (new Level(tangledShapes, selectableShapes));
        }

        public void NextLevel()
        {
            if (_isFinished || _levels.Length >= 5)
            {
                return;
            }

            if (!_levels.Last().IsLevelFinished())
            {
                return;
            }
            switch (_difficulty)
            {
                case 1:
                    CreateLevelWithThemes(6, 6);
                    break;
                case 2:
                    CreateLevelWithThemes(9, 9);
                    break;
                case 3:
                    CreateLevelWithThemes(3, 9);
                    break;
                case 4:
                    CreateLevelWithThemes(1, 9);
                    break;
                case 5:
                    CreateAbstractLevel(9);
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    break;
            }
        }

        public bool IsSetFinished()
        {
            if (_isFinished)
            {
                return true;
            }
            if (_levels.Length >= 5 && _levels.Last().IsLevelFinished())
            {
                return true;
            }
            return false;
        }

        public TimeSpan GetTotalTime()
        {
            TimeSpan totalTimer = TimeSpan.Zero;
            foreach (Level level in _levels)
            {
                totalTimer.Add(level.Timer);
            }
            return totalTimer;
        }

        public double CalcStats()
        {
            double correctAnswers = 0;
            foreach (Level level in _levels)
            {
                correctAnswers += level.CalcNumberCorrectAnswers();
            }
            return correctAnswers / (_levels.Length * 3);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
            IEnumerable<Shape> shapesQuery =
                from s in tangledShapes
                where s.Name == shape.GetName()
                select s;

            return shapesQuery.Any();
        }

        public Shape CreateTangleShapeByTheme(string theme, Shape[] tangledshapes, SelectableShape[] selectableShapes)
        {

            IEnumerable<Shape> shapes =
                from s in selectableShapes
                where s.GetTheme() == theme && !IsShapeInTangledShapes(s, tangledshapes)
                select s.Shape;


            Random rand = new Random();
            return shapes.ElementAt(rand.Next(shapes.Count()));
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
            while (selectableShapes.FirstOrDefault((SelectableShape s) => s.GetName() == shapeToAdd.GetName()) != null);
            return shapeToAdd;
        }


        public Level CreateLevelWithThemes(int numberThemes, int numberAnswer)
        {
            if (numberThemes % 3 != 0)
            {
                throw new ArgumentException("Theme number must be a multiple of Tangled Shapes number.");
            }
            Shape[] tangledShapes = [];
            SelectableShape[] selectableShapes = [];
            string[] answerThemes = Utilities.GetRandomThemes(numberThemes);

            string[] tangledThemes = Utilities.ChoseTangledThemes(answerThemes, 3);
            foreach (string theme in answerThemes)
            {
                for (int i = 0; i < numberAnswer / numberThemes; i++)
                {
                    selectableShapes.Append(CreateAnswer(theme, selectableShapes));
                }
            }
            foreach (string theme in tangledThemes)
            {
                tangledShapes.Append(CreateTangleShapeByTheme(theme, tangledShapes, selectableShapes));
            }

            return (new Level(tangledShapes, selectableShapes));
        }



        public Level CreateMonoThemeLevel(int numberAnswer, string ThemeName)
        {
            Shape[] tangledShapes = [];
            SelectableShape[] selectableShapes = [];
            for (int i = 0; i < numberAnswer; i++)
            {
                selectableShapes.Append(CreateAnswer(ThemeName, selectableShapes));
            }
            for (int i = 0; i < 3; i++)
            {
                tangledShapes.Append(CreateTangleShapeByTheme(ThemeName, tangledShapes, selectableShapes));
            }
            return (new Level(tangledShapes, selectableShapes));
        }

        public void NextLevel()
        {

            if (_isFinished || _levels.Length >= 5 || !_levels.Last().IsLevelFinished())
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
                    CreateMonoThemeLevel(9, Utilities.GetRandomTheme());
                    break;
                case 5:
                    CreateMonoThemeLevel(9, "Abstract");
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
            return _isFinished || _levels.Length >= 5 && _levels.Last().IsLevelFinished();
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

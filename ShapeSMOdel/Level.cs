namespace ShapeSMOdel
{
    public class Level
    {
        private bool _isFinished;
        private TimeSpan _timer;
        private SelectableShape[] _selectableShapes;
        private Shape[] _tangledShapes;

        public Level(Shape[] tangledShapes, SelectableShape[] selectableShapes)
        {
            _selectableShapes = selectableShapes;
            _tangledShapes = tangledShapes;
            _timer = TimeSpan.Zero;
            _isFinished = false;

        }

        public TimeSpan Timer { get => _timer; set => _timer = value; }

        public bool IsShapeInTheDrawing(SelectableShape shape)
        {
            foreach (Shape s in _tangledShapes)
            {
                if (s.Name == shape.getName())
                {
                    return true;
                }
            }
            return false;
        }

        public int CalcNumberCorrectAnswers()
        {
            int goodAnswers = 0;
            foreach (SelectableShape s in _selectableShapes)
            {
                if (IsShapeInTheDrawing(s))
                {
                    goodAnswers++;
                }
            }
            return goodAnswers;
        }

        public bool IsLevelFinished()
        {
            if (_isFinished)
            {
                return true;
            }

            int numSelect = 0;
            foreach (SelectableShape s in _selectableShapes)
            {
                if (s.IsSelected)
                {
                    numSelect++;
                }
            }
            if (numSelect >= 3) // 3 réponses sont attendues
            {
                _isFinished = true;
                return true;
            }
            return false;
        }
    }
}

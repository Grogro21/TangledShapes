using System.Drawing;

namespace ShapeSMOdel
{
    public class SelectableShape
    {
        private bool _isSelected;
        private Point _positionAnswer;
        private Shape _shape;

        public SelectableShape(Shape shape, Point position)
        {
            _shape = shape;
            _positionAnswer = position;
            _isSelected = false;
        }

        public bool Selected { get => _isSelected; set => _isSelected = value; }

        public string getName()
        {
            return _shape.Name;
        }
        public bool Select()
        {
            if (!_isSelected)
            {
                _isSelected = true;
                return true;
            }
            return false;
        }
    }
}

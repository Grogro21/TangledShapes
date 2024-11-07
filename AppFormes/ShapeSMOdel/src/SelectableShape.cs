namespace ShapeSMOdel
{
    public class SelectableShape
    {
        private bool _isSelected;
        private Shape _shape;

        public SelectableShape(Shape shape)
        {
            _shape = shape;
            _isSelected = false;
        }

        public bool IsSelected { get => _isSelected; set => _isSelected = value; }
        public Shape Shape { get => _shape; }

        public string GetName()
        {
            return _shape.Name;
        }

        public string GetTheme()
        {
            return _shape.Theme;
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

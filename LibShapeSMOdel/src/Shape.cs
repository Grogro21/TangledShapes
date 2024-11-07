﻿using System.Drawing;

namespace ShapeSMOdel
{
    public class Shape
    {
        private string _name;
        private Point _position;
        private string _theme;

        public Shape(string name, Point position, string theme)
        {
            _name = name;
            _position = position;
            _theme = theme;
        }

        public Shape(SelectableShape selectableShape, Point realPosition) : this(selectableShape.GetName(), realPosition, selectableShape.GetTheme())
        { }

        public string Name { get => _name; }
        public Point Position { get => _position; set => _position = value; }
        public string Theme { get => _theme; }
    }
}
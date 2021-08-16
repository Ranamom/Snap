﻿using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Graphical.Grids
{
    public abstract class Cell
    {
        private static Color BorderColor = new Color(0, 0, 0, 50);

        public int Id
        {
            get;
            private set;
        }

        public abstract Vector2f Center
        {
            get;
        }

        public abstract Vector2f Position
        {
            get;
        }

        public abstract Shape Shape
        {
            get;
            set;
        }
        public Cell(int id)
        {
            this.Id = id;
        }

        public abstract void BuildShape();

        public abstract bool Contains(Vector2f position);

        public override string ToString()
        {
            return "Cell ("+Id+")";
        }

        public void DrawShape(RenderWindow window)
        {
            window.Draw(Shape, RenderStates.Default);
        }
    }
}

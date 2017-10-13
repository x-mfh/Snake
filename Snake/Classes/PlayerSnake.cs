using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class PlayerSnake
    {
        private int _Length = 3;
        public int Length
        {
            get { return _Length; }
            set { _Length = value; }
        }

        public enum Alive
        {
            Alive,
            Dead
        }
        public static Color test;

        public void GetStatus(Alive alive)
        {
            switch (alive)
            {
                case Alive.Alive:

                    break;
                case Alive.Dead:

                    break;
                default:

                    break;
            }
        }

        public enum Color
        {
            Red,
            Blue,
            Green,
            Yellow
        }

        public void SelectColor(Color color)
        {
            switch (color)

            {
                case Color.Red:

                    break;
                case Color.Blue:

                    break;
                case Color.Green:

                    break;
                case Color.Yellow:

                    break;

                default:
                    break;
            }
        }
}
}

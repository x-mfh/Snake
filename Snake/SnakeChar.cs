using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class SnakeChar
    {

        private int _lenght;
        public int Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }

        enum Color
        {
            Red, 
            Green,
            Black,
            Yellow,
            Blue

        }

        enum Status
        {
            Dead,
            Alive
        }



        /*void Test(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Black:
                    break;
                case Color.Yellow:
                    break;
                case Color.Blue:
                    break;
                default:
                    break;
            }
        }*/

    }
}

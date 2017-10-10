using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeV2
{
    class Snake
    {

        public enum Color
        {
            red,
            blue,
            green,
            yellow
        }

        public enum status
        {
            dead,
            alive
        }

        private int _lenght;
        public int Lenght { get { return _lenght; } set { _lenght = value; } }
    }
}

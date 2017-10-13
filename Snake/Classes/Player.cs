using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Player
    {
        private int _Score;
        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }

        private int _Lives;
        public int Lives
        {
            get { return _Lives; }
            set { _Lives = value; }
        }

    }
}

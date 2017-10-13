using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {
        public bool Border;

        public int food_x;
        public int food_y;


        public enum Difficulty
        {
            Easy,
            Hard
        }

        public void GetDifficulty(Difficulty dif)
        {
            switch (dif)
            {
                case Difficulty.Easy:
                    Border = false;
                    break;
                case Difficulty.Hard:
                    Border = true;
                    break;
                default:

                    break;
            }
        }

        public void FoodGen(int max_X, int max_Y)
        {
            Random Food = new Random();
            food_x = Food.Next(1, max_X);
            food_y = Food.Next(1, max_Y);

        }

        public static void BorderGen(Difficulty test, Window3 window)
        {

          

            //if (Border == true)
            //{
            //    // Gen border
            //}
        }

    }
}

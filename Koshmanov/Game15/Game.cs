﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Koshmanov.Game15
{
    

    class Game
    {
        //int x;
        static Random rand = new Random();
        //int y;
        int size; // count of rows or columns (in first try it is 4)
        int[,] map;
        int space_x, space_y;
        public Game(int size)
        {
            this.size = size;
            map = new int[size, size];
        }

        public void start()
        {
            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                    map[y, x] = coords_to_position(x, y) + 1;
            space_x = size - 1;
            space_y = size - 1;
            map[size - 1, size - 1] = 0;
        }

        public void shift(int position) //разрешение на смещение
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) == 1)
                {
                    map[space_y, space_x] = map[y, x];
                    map[y, x] = 0;
                    space_x = x;
                    space_y = y;
                }
        }

        public int get_number(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (x < 0 || x > size) return 0;
            if (y < 0 || y > size) return 0;
            return map[y, x];
        }

        private int coords_to_position(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }
         
        public void shift_random()
        {
            //shift(rand.Next(0, size * size));
            int a = rand.Next(0, 4);
            int x = space_x;
            int y = space_y;
            switch (a)
            {
                case 0:x--;
                    break;
                case 1:x++;
                    break;
                case 2:y--;
                    break;
                case 3:y++;
                    break;
            }
            shift(coords_to_position(x, y));
        }

        private void position_to_coords(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position%size;
            y = position / size;
        }

        public bool check_game()
        {
            if (!(space_x == size - 1 &&
                space_y == size - 1))
                return false;
            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                    if (!(x == size - 1 && y == size - 1))
                        if (map[y, x] != coords_to_position(x, y) + 1)
                        return false;
            return true;

        }
    }
}

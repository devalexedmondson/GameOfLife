﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure game = new Adventure();
            game.RunGame();
            Console.ReadKey();
        }
    }
}

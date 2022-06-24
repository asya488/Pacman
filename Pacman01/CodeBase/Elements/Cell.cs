﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.Moves;
using CodeBase.GameProcess;

namespace CodeBase.Elements
{
    public class Cell : Element
    {
        public Cell (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override void Draw()
        {
            Console.Write(' ');
        }
        public override bool isObstacle()
        {
            return false;
        }
        public override bool isEaten()
        {
            return false;
        }
        public override int X
        {
            get; set;
        }
        public override int Y
        {
            get; set;
        }
        public override void Action(Game game) { }
        public override string Name()
        {
            return "cell";
        }
    }
}

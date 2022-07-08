﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase.Utilities
{
    public static class Utility
    {
        public struct Coords
        {
            public int x, y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static Coords CoordsUpdate(char direction)
        {
            switch (direction)
            {
                case 'd':
                    return new Coords(1, 0);
                case 'u':
                    return new Coords(-1, 0);
                case 'r':
                    return new Coords(0, 1);
                case 'l':
                    return new Coords(0, -1);
                default:
                    return new Coords(0, 0);
            }
        }
        public static Design DesignInfo(int key)
        {
            Dictionary<int, Design> designInfo = new Dictionary<int, Design>();
            designInfo.Add(0, new Design(appearace: 'o', price: 0));
            designInfo.Add(1, new Design(appearace: 'O', price: 20));
            designInfo.Add(2, new Design(appearace: 'Q', price: 50));
            designInfo.Add(3, new Design(appearace: 'G', price: 100));

            return designInfo[key];
        }

        public static LevelInfo LevelInfo(int lvl)
        {
            Dictionary<int, LevelInfo> levelInfo = new Dictionary<int, LevelInfo>();
            levelInfo.Add(1, new LevelInfo(path: "lvl1.txt", pathOutput: "lvl1Output.txt"));
            levelInfo.Add(2, new LevelInfo(path: "lvl2.txt", pathOutput: "lvl2Output.txt"));
            levelInfo.Add(3, new LevelInfo(path: "lvl3.txt", pathOutput: "lvl3Output.txt"));
            //levelInfo.Add(4, new Level(path: "RandomLevel.txt", pathOutput: "RandomLevel.txt"));

            return levelInfo[lvl];
        }

        public static int BiggerCells(int lvl)
        {
            if (lvl == 1) return 50;
            if (lvl == 2) return 40;
            return 30;
        }

    }
}


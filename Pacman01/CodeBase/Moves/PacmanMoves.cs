﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBase.Elements;
using CodeBase.Utilities;
using CodeBase.GameProcess;

namespace CodeBase.Moves
{
    public class PacmanMoves
    {
        public static char GetDirection(ConsoleKeyInfo keyPressed)
        {
            char dir = 'r'; //direction pacman
            if (keyPressed.Key == ConsoleKey.W)
                dir = 'u';
            if (keyPressed.Key == ConsoleKey.S)
                dir = 'd';
            if (keyPressed.Key == ConsoleKey.A)
                dir = 'l';
            if (keyPressed.Key == ConsoleKey.D)
                dir = 'r';
            if (keyPressed.Key == ConsoleKey.P)
                dir = 'p';
            return dir;
        }
        public static void FieldScared(Field field)
        {
            if (field.Scared)
                field.ScaredTime++;
            if (field.ScaredTime == 10)
            {
                field.Scared = false;
                field.ScaredTime = 0;
            }
        }
        public static void Step(Game game, char dir, GameFunctions.Draw draw, GameFunctions.DrawStats drawStats)
        {
            CurrentLevel currentLevel = game.CurrentLevel;
            Pacman pacman = currentLevel.Pacman;
            FieldScared(currentLevel.Field);

            //empty cell on the place where pacman was
            currentLevel.Field[pacman.X, pacman.Y] = new Cell(pacman.X, pacman.Y);
            draw(currentLevel.Field[pacman.X, pacman.Y]);
            
            if (!currentLevel.Field[pacman.X + Utility.CoordsUpdate(dir).x, pacman.Y + Utility.CoordsUpdate(dir).y].isObstacle())
            {
                pacman.X += Utility.CoordsUpdate(dir).x;
                pacman.Y += Utility.CoordsUpdate(dir).y;
                ThorMap.Step(currentLevel.Field, pacman);
            }
            currentLevel.FieldEnemies[pacman.X, pacman.Y].Action(game);
            if (game.Finished)
                return;
            currentLevel.Field[pacman.X, pacman.Y].Action(game);

            //pacman on its new place
            currentLevel.Field[pacman.X, pacman.Y] = pacman;
            draw(currentLevel.Field[pacman.X, pacman.Y]);

            drawStats(game);
        }
    }
}
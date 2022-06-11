﻿using System;


namespace Pacman
{
    public static class Program
    {
     
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int design = 0, generalScore = 0; 

            while (true)
            {
                int lvl = Interface.Choose_level();

                Elements.Field field = new Elements.Field(Utilities.Utility.LevelInfo(lvl).height, Utilities.Utility.LevelInfo(lvl).width);
                Elements.Field fieldEnemies = new Elements.Field(Utilities.Utility.LevelInfo(lvl).height, Utilities.Utility.LevelInfo(lvl).width);
                Elements.Pacman pacman = new Elements.Pacman(Utilities.Utility.LevelInfo(lvl).pacmanCoords.x, Utilities.Utility.LevelInfo(lvl).pacmanCoords.y, design);
                Elements.Enemy[] enemies = new Elements.Enemy[Utilities.Utility.LevelInfo(lvl).numberOfEnemies];

                Start(field, fieldEnemies, Utilities.Utility.LevelInfo(lvl).path, enemies, lvl);
                Interface.DrawField(Utilities.Utility.LevelInfo(lvl).pathOutput, generalScore);

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                while (true)
                {

                    keyPressed = (Console.KeyAvailable == false) ? keyPressed : Console.ReadKey(true);//checking if new key is pressed, if not - use the old one (inertia)
                    char key = PacmanStep.GetDirection(keyPressed);
                    if (key == 'p') //pause
                    {
                        keyPressed = Pause(field);
                        continue;
                    }
                        
                    PacmanStep.StepPacman(pacman, field, fieldEnemies, key, generalScore, lvl);//pacman makes its step
                    if (field.GameOver)
                    {
                        Interface.Game_over();
                        return;
                    }
                    for (int i = 0; i < Utilities.Utility.LevelInfo(lvl).numberOfEnemies; i++) //all the enemies make their step
                    {
                        StepEnemy(enemies[i], field, fieldEnemies, RandomDir(fieldEnemies, enemies[i]), lvl);
                        if (field.GameOver)
                        {
                            Interface.Game_over();
                            return;
                        }
                    }

                    if (field.Score == Utilities.Utility.LevelInfo(lvl).points)
                    {
                        generalScore += field.Score;
                        Interface.Victory(generalScore);
                        ConsoleKeyInfo key_pressed1 = Console.ReadKey();
                        if (key_pressed1.Key == ConsoleKey.N)
                            return;
                        else if (key_pressed1.Key == ConsoleKey.S)//shop
                            design = Shop_purchase(ref generalScore, design);
                        break;
                    }
                }
            }
        }

        public static ConsoleKeyInfo Pause(Elements.Field field)
        {
            Console.SetCursorPosition(30, field.Height + 2);
            Console.Write("Paused");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.SetCursorPosition(30, field.Height + 2);
            Console.Write("      ");
            return key;
        }
       
        public static int Shop_purchase(ref int generalScore, int design)
        {
            Interface.Shop(generalScore, Utilities.Utility.DesignInfo(design).appearance);
            int chosenDesign = design;

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        chosenDesign = 1;
                        break;
                    case ConsoleKey.D2:
                        chosenDesign = 2;
                        break;
                    case ConsoleKey.D3:
                        chosenDesign = 3;
                        break;
                    case ConsoleKey.D9: //пасхалка на добавление монет
                        generalScore += 10;
                        Interface.Shop(generalScore, Utilities.Utility.DesignInfo(design).appearance);
                        continue;
                }

                if (generalScore >= Utilities.Utility.DesignInfo(chosenDesign).price)
                {
                    generalScore -= Utilities.Utility.DesignInfo(chosenDesign).price;
                    Interface.Shop(generalScore, Utilities.Utility.DesignInfo(chosenDesign).appearance);
                    Console.WriteLine("Purchase was successfully made. Returning to the game...");
                    Thread.Sleep(3000);
                    return chosenDesign;
                }
                else
                {
                    Interface.Shop(generalScore, Utilities.Utility.DesignInfo(design).appearance);
                    Console.WriteLine("You do not have enough money for this purchase :(");
                }

            } while (keyPressed.Key != ConsoleKey.D4);

              return chosenDesign;
        }
        public static bool CycleCheck(char dir, char prev)
        {
            if (prev == 'u' && dir == 'd') return false;
            if (prev == 'd' && dir == 'u') return false;
            if (prev == 'l' && dir == 'r') return false;
            if (prev == 'r' && dir == 'l') return false;
            return true;
        }

        public static char RandomDir(Elements.Field field, Elements.Enemy enemy)
        {
            char direction = 'u';
            Random rnd = new Random();
            int dir = rnd.Next();

            while (field[enemy.X + Utilities.Utility.CoordsUpdate(direction).x, enemy.Y + Utilities.Utility.CoordsUpdate(direction).y].isObstacle() || !CycleCheck(direction, enemy.Prev))
            {
                dir++;
                switch (dir % 4)
                {
                    case 0:
                        direction = 'u';
                        break;
                    case 1:
                        direction = 'd';
                        break;
                    case 2:
                        direction = 'r';
                        break;
                    case 3:
                        direction = 'l';
                        break;
                }

            }
            enemy.Prev = direction;
            return direction;
        }

       public static void EnemyStatus(Elements.Enemy enemy, Elements.Field field)
        {
            if (enemy.Eaten)
                enemy.TimeEaten++;
            if (enemy.TimeEaten == 20)
            {
                enemy.Eaten = false;
                enemy.TimeEaten = 0;
            }

            if (field.Scared)
                enemy.Scared = true;
            else
                enemy.Scared = false;

            if (field[enemy.X, enemy.Y] is Elements.Pacman && field.Scared)
                enemy.Eaten = true;

        }

        public static void StepEnemy(Elements.Enemy enemy, Elements.Field field, Elements.Field fieldEnemies, char dir, int lvl)
        {
           EnemyStatus(enemy, field);

            if (!(field[enemy.X, enemy.Y] is Elements.Pacman))
            {
                Console.SetCursorPosition(enemy.Y, enemy.X);
                enemy.Draw();
            }

            if (!enemy.Eaten)
            {    
                Console.SetCursorPosition(enemy.Y, enemy.X);
                field[enemy.X, enemy.Y].Draw();
                Console.SetCursorPosition(enemy.Y + Utilities.Utility.CoordsUpdate(dir).y, enemy.X + Utilities.Utility.CoordsUpdate(dir).x);
                enemy.Draw();

               if (field[enemy.X + Utilities.Utility.CoordsUpdate(dir).x, enemy.Y + Utilities.Utility.CoordsUpdate(dir).y] is Elements.Pacman && !field.Scared)
                   field.GameOver = true;
               if (field[enemy.X + Utilities.Utility.CoordsUpdate(dir).x, enemy.Y + Utilities.Utility.CoordsUpdate(dir).y] is Elements.Pacman && field.Scared)
                   enemy.Eaten = true;


                fieldEnemies[enemy.X, enemy.Y] = new Elements.Cell();
                enemy.X += Utilities.Utility.CoordsUpdate(dir).x;
                enemy.Y += Utilities.Utility.CoordsUpdate(dir).y;
                fieldEnemies[enemy.X, enemy.Y] = enemy;
            }
        }


        public static void Start(Pacman.Elements.Field field, Pacman.Elements.Field fieldEnemies, string path, Elements.Enemy[] enemies, int lvl)
        {
            //filling Field
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int enemyNumber = 0;
                for (int i = 0; i < field.Height; i++)
                {
                    line = reader.ReadLine();
                    for (int j = 0; j < field.Width; j++)
                    {
                        if (line[j] == '#')
                        {
                            field[i, j] = new Elements.Wall();
                            fieldEnemies[i, j] = new Elements.Wall();
                        }
                        if (line[j] == '.')
                        {
                            field[i, j] = new Elements.Coin();
                            fieldEnemies[i, j] = new Elements.Cell();
                        }
                        if (line[j] == ' ')
                        {
                            field[i, j] = new Elements.Cell();
                            fieldEnemies[i, j] = new Elements.Cell();
                        }
                        if (line[j] == '@')
                        {
                            field[i, j] = new Elements.Energizer();
                            fieldEnemies[i, j] = new Elements.Cell();
                        }
                        if (line[j] == 'o')
                        {
                            field[i, j] = new Elements.Pacman(i, j, 0);
                            fieldEnemies[i, j] = new Elements.Cell();
                        }
                        if (line[j] == 'A')
                        {
                            field[i, j] = new Elements.Coin();
                            fieldEnemies[i, j] = new Elements.Enemy(i, j);
                            enemies[enemyNumber] = new Elements.Enemy(i, j);
                            enemyNumber++;
                        }
                    }
                }
                if (lvl == 3)
                {
                    fieldEnemies[6, 0] = new Elements.Wall();
                    fieldEnemies[6, 37] = new Elements.Wall();
                }
            }
        }
         
    }
}


        
    


    

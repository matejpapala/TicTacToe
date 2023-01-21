using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[] deska = { '1', '2', '3', '4', '5', '6', '7', '8', '9' , '0'};
        static bool end = false;
        static int choice;
        static int player = 2;
        static bool check = true;
        static bool wrong = false;
        static void Main(string[] args)
        {
            do
            {
                if (player % 2 == 0)
                {
                    Board();
                    Console.WriteLine("Player 1 has X, Player 2 has O");
                    do
                    {
                        do
                        {
                            Console.WriteLine("Player 1 chooses:");
                            wrong = false;
                            choice = int.Parse(Console.ReadLine());
                            if (choice > 9 || choice <= 0)
                            {
                                Console.WriteLine("Number is too big or too small");
                                wrong = true;
                            }
                        } while (wrong);
                        check = true;
                        if (deska[choice - 1] != 'X' && deska[choice - 1] != 'O')
                        {
                            deska[choice - 1] = 'X';
                            check = false;
                            player = 3;
                        }
                        else
                        {
                            Console.WriteLine("This position is alredy taken");
                        }
                    } while (check);
                    CheckWin();
                } else
                {
                    Board();
                    Console.WriteLine("Player 1 has X, Player 2 has O");
                    do
                    {
                        do
                        {
                            Console.WriteLine("Player 2 chooses:");
                            wrong = false;
                            choice = int.Parse(Console.ReadLine());
                            if (choice > 9 || choice <= 0)
                            {
                                Console.WriteLine("Number is too big or too small");
                                wrong = true;
                            }
                        } while (wrong);
                        check = true;
                        if (deska[choice - 1] != 'X' && deska[choice - 1] != 'O')
                        {
                            deska[choice - 1] = 'O';
                            check = false;
                            player = 2;
                        }
                        else
                        {
                            Console.WriteLine("This position is alredy taken");
                        }
                    } while (check);
                    CheckWin();
                }
            }while(end == false);
        }

        static void Board()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", deska[0], deska[1], deska[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", deska[3], deska[4], deska[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", deska[6], deska[7], deska[8]);
            Console.WriteLine("     |     |      ");
        }

        static void CheckWin()
        {
            int eog = 0;
            //First line horizontally
            if (deska[0] == deska[1] && deska[1] == deska[2] && deska[0] == 'X')
            {
                eog = 1;
            } else if (deska[0] == deska[1] && deska[1] == deska[2] && deska[0] == 'O')
            {
                eog = 2;
            }
            //Second line horizontally
            if (deska[3] == deska[4] && deska[4] == deska[5] && deska[5] == 'X')
            {
                eog = 1;
            } else if (deska[3] == deska[4] && deska[4] == deska[5] && deska[5] == 'O')
            {
                eog = 2;
            }
            //Third line horizontally
            if (deska[6] == deska[7] && deska[7] == deska[8] && deska[6] == 'X')
            {
                eog = 1;
            }
            else if (deska[6] == deska[7] && deska[7] == deska[8] && deska[6] == 'O')
            {
                eog = 2;
            }
            //First line vertically
            if (deska[0] == deska[3] && deska[3] == deska[6] && deska[0] == 'X')
            {
                eog = 1;
            }
            else if (deska[0] == deska[3] && deska[3] == deska[6] && deska[0] == 'O')
            {
                eog = 2;
            }
            //Second line vertically
            if (deska[1] == deska[4] && deska[4] == deska[7] && deska[1] == 'X')
            {
                eog = 1;
            }
            else if (deska[1] == deska[4] && deska[4] == deska[7] && deska[1] == 'O')
            {
                eog = 2;
            }
            //Third line vertically
            if (deska[2] == deska[5] && deska[5] == deska[8] && deska[2] == 'X')
            {
                eog = 1;
            }
            else if (deska[2] == deska[5] && deska[5] == deska[8] && deska[2] == 'O')
            {
                eog = 2;
            }
            //Diagonals
            if (deska[0] == deska[4] && deska[4] == deska[8] && deska[0] == 'X')
            {
                eog = 1;
            }
            else if (deska[0] == deska[4] && deska[4] == deska[8] && deska[0] == 'O')
            {
                eog = 2;
            }
            if (deska[2] == deska[4] && deska[4] == deska[6] && deska[2] == 'X')
            {
                eog = 1;
            }
            else if (deska[2] == deska[4] && deska[4] == deska[6] && deska[2] == 'O')
            {
                eog = 2;
            }
            //Draw
            if (deska[0] != '1' && deska[1] != '2' && deska[2] != '3' && deska[3] != '4' && deska[4] != '5' && deska[5] != '6' && deska[6] != '7' && deska[7] != '8' && deska[8] != '9' && eog == 0)
            {
                eog = 3;
            }
            //Deciding if anyone won
            if(eog == 1)
            {
                Board();
                Console.WriteLine("Player 1 won!");
                Console.ReadLine();
                end = true;
            } else if (eog == 2)
            {
                Board();
                Console.WriteLine("Player 2 won!");
                Console.ReadLine();
                end = true;
            } else if (eog == 3)
            {
                Board();
                Console.WriteLine("Draw!");
                Console.ReadLine();
                end = true;
            }
        }
    }
}

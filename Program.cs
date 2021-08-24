using System;

namespace TicTacToe
{
    class Program
    {

        static char[,] playField = {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
        };
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;



            do
            {
                if (IsWinner())
                {
                    SetField();
                    System.Console.WriteLine("player " + player + " won... Play again (y/n)?");
                    string playAgain;

                    do
                    {
                        playAgain = Console.ReadLine();

                        if (playAgain != "y" && playAgain != "n")
                        {
                            System.Console.WriteLine("Please insert eith 'y' or 'n'");
                        }

                    } while (playAgain != "y" && playAgain != "n");


                    if (playAgain == "y")
                    {
                        ResetPlayField();
                    }
                    else
                    {
                        break;
                    }
                }
                if (player == 2)
                {
                    player = 1;
                }
                else
                {
                    player = 2;
                }

                SetField();
                input = AskPlayerForTurn(player);

                //makes the update
                switch (input)
                {
                    case 1:
                        {
                            playField[0, 0] = playerSymbol(player);
                            break;
                        }
                    case 2:
                        {
                            playField[0, 1] = playerSymbol(player);
                            break;
                        }
                    case 3:
                        {
                            playField[0, 2] = playerSymbol(player);
                            break;
                        }
                    case 4:
                        {
                            playField[1, 0] = playerSymbol(player);
                            break;
                        }
                    case 5:
                        {
                            playField[1, 1] = playerSymbol(player);
                            break;
                        }
                    case 6:
                        {
                            playField[1, 2] = playerSymbol(player);
                            break;
                        }
                    case 7:
                        {
                            playField[2, 0] = playerSymbol(player);
                            break;
                        }
                    case 8:
                        {
                            playField[2, 1] = playerSymbol(player);
                            break;
                        }
                    case 9:
                        {
                            playField[2, 2] = playerSymbol(player);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Did not match");
                            break;
                        }
                }





            } while (true);
            System.Console.WriteLine("Thanks For playing!!");
        }


        public static void SetField()
        {

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }
        public static int AskPlayerForTurn(int player)
        {
            bool validInput;
            int input = 666;

            Console.WriteLine("Player " + player + ", Its Your Turn");

            do
            {
                validInput = true;

                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input != 1 && input != 2 && input != 3 && input != 4 && input != 5 && input != 6 && input != 7 && input != 8 && input != 9)
                    {
                        throw new Exception();
                    }
                    if ((input == 1 && playField[0, 0] != '1') || (input == 2 && playField[0, 1] != '2') || (input == 3 && playField[0, 2] != '3') || (input == 4 && playField[1, 0] != '4') || (input == 5 && playField[1, 1] != '5') || (input == 6 && playField[1, 2] != '6') || (input == 7 && playField[2, 0] != '7') || (input == 8 && playField[2, 1] != '8') || (input == 9 && playField[2, 2] != '9'))
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    System.Console.WriteLine("Please Enter a valid number that has not been used yet");
                    validInput = false;
                }


            } while (!validInput);
            return input;

        }
        public static bool IsWinner()
        {
            if ((playField[0, 0] == playField[0, 1] && playField[0, 0] == playField[0, 2]) || (playField[1, 0] == playField[1, 1] && playField[1, 1] == playField[1, 2]) || (playField[2, 0] == playField[2, 1] && playField[2, 1] == playField[2, 2]) || (playField[0, 0] == playField[1, 0] && playField[1, 0] == playField[2, 0]) || (playField[0, 1] == playField[1, 1] && playField[1, 1] == playField[2, 1]) || (playField[0, 2] == playField[1, 2] && playField[1, 2] == playField[2, 2]) || (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2]) || (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static char playerSymbol(int player)
        {
            if (player == 1)
                return 'X';
            else
                return 'O';
        }
        public static void ResetPlayField()
        {
            playField[0, 0] = '1';
            playField[0, 1] = '2';
            playField[0, 2] = '3';
            playField[1, 0] = '4';
            playField[1, 1] = '5';
            playField[1, 2] = '6';
            playField[2, 0] = '7';
            playField[2, 1] = '8';
            playField[2, 2] = '9';

        }

    }
}

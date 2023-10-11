using System;
 

namespace TicTacToe
{
    class Program
    {

        public static int player = 2;
        public static int input = 0;
        public static int boardFinishCount = 0;


        public static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},

        };


        static void Main(string[] args)
        {
            player = 1;
            FieldVisual();


            //Game Loop
            while (input != -1)
            {
                Console.WriteLine("Choose your coordinate, X for player1 or O for player2:");
                Console.WriteLine("Current Player:{0}", player);
                Console.WriteLine("Enter -1 to exit the game.");

                try
                {
                    //TryParse or Parse also can be used
                    //Convert class was used to make sure no any null value is passed.
                    //Get input from the user, update the visual, check game state.
                    input = Convert.ToInt32(Console.ReadLine());
                    ChangeCoordinatePlace(input, player);
                    FieldVisual();
                    CheckGameIsFinished();
                    CheckWinCondition();
                }
                catch
                {
                    Console.WriteLine("Please enter a valid input number coordination");
                }


            }




            Console.ReadKey();

        }


        public static void FieldVisual()
        {
            Console.Clear();
            Console.WriteLine("TIC TAC TOE!");
            Console.WriteLine("By FocusSoft");
            Console.WriteLine("______________");
            Console.WriteLine("______________");
            Console.WriteLine(" |    |     |");
            Console.WriteLine("{0}-----{1}------{2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine(" |____|_____|");
            Console.WriteLine("{0}-----{1}------{2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine(" |____|_____|");
            Console.WriteLine("{0}-----{1}------{2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine(" |    |     |");
            Console.WriteLine("______________");
            Console.WriteLine("______________");


        }

        public static void ChangeCoordinatePlace(int enteredInput, int playerNumber)
        {
            if (playerNumber == 1)
            {
                switch (enteredInput)
                {

                    case 1:
                        if (playField[0, 0] == '1')
                        {
                            playField[0, 0] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 2:
                        if (playField[0, 1] == '2')
                        {
                            playField[0, 1] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 3:
                        if (playField[0, 2] == '3')
                        {
                            playField[0, 2] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }

                        break;
                    case 4:
                        if (playField[1, 0] == '4')
                        {
                            playField[1, 0] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 5:
                        if (playField[1, 1] == '5')
                        {
                            playField[1, 1] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 6:
                        if (playField[1, 2] == '6')
                        {
                            playField[1, 2] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 7:
                        if (playField[2, 0] == '7')
                        {
                            playField[2, 0] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 8:
                        if (playField[2, 1] == '8')
                        {
                            playField[2, 1] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;
                    case 9:
                        if (playField[2, 2] == '9')
                        {
                            playField[2, 2] = 'X';
                            player = 2;
                            boardFinishCount++;
                        }
                        break;

                }
            }

            else if (playerNumber == 2)
            {
                switch (enteredInput)
                {

                    case 1:
                        if (playField[0, 0] == '1')
                        {
                            playField[0, 0] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 2:
                        if (playField[0, 1] == '2')
                        {
                            playField[0, 1] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 3:
                        if (playField[0, 2] == '3')
                        {
                            playField[0, 2] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 4:
                        if (playField[1, 0] == '4')
                        {
                            playField[1, 0] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 5:
                        if (playField[1, 1] == '5')
                        {
                            playField[1, 1] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 6:
                        if (playField[1, 2] == '6')
                        {
                            playField[1, 2] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 7:
                        if (playField[2, 0] == '7')
                        {
                            playField[2, 0] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 8:
                        if (playField[2, 1] == '8')
                        {
                            playField[2, 1] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;
                    case 9:
                        if (playField[2, 2] == '9')
                        {
                            playField[2, 2] = 'O';
                            player = 1;
                            boardFinishCount++;
                        }
                        break;


                }

            }


        }

        public static void CheckGameIsFinished()
        {
            if (boardFinishCount >= 9)
            {
                input = -1;
                Console.WriteLine("Game is finished, restart the program");
                Console.WriteLine("Draw");
                 
            }

        }

        public static void CheckWinCondition()
        {
            //TODO implement solution that can be
            //scale with the array's size.
            //you can make it using array2D.GetLength(row) and array2D.GetLength(column)
            //With nested loops.

            for (int i = 0; i < 3; i++)
            {

                if (playField[i,0] == playField[i,1] && playField[i, 1] == playField[i, 2])
                {
                    input = -1;
                     
                }

                if(playField[0,i] == playField[1, i] && playField[1, i] == playField[2, i])
                {
                    input = -1;
                     
                }

                if(playField[0,2] == playField[1, 1] && playField[1, 1] == playField[2, 0])
                {
                    input = -1;
                     
                }

                if (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2])
                {
                    input = -1;
                     

                }

            }
            if(input == -1)
            {
                Console.WriteLine("Game is finished, restart to play again");
            }

        }

    }

}

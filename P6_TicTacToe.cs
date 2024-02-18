using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class P6_TicTacToe
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {
            List<int> board = new List<int>();
            board.Add(0);
            board.Add(1);
            board.Add(2);
            board.Add(3);
            board.Add(4);
            board.Add(5);
            board.Add(6);
            board.Add(7);
            board.Add(8);
            board.Add(9);
            
            foreach (int i in board)
            {
                Console.WriteLine(i);
            }

            int playerOneChoice, playerTwoChoice;
            int player = 1;
            bool gameover = false;

            printInstructions();

            while (!gameover)
            {
                if (player == 1)
                {
                    Console.Write($"It's player {player}'s turn: ");
                    try
                    {
                        playerOneChoice = int.Parse(Console.ReadLine().ToLower());
                        while (playerOneChoice < 1 || playerOneChoice > 9)
                        {
                            Console.Write("Invalid input, please try again: ");
                            playerOneChoice = int.Parse(Console.ReadLine().ToLower());
                        }
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (board[i] == playerOneChoice)
                            {
                                do
                                {
                                    if (arr[i] == 'L')
                                    {
                                        Console.Write("This grid is taken: ");
                                        playerOneChoice = int.Parse(Console.ReadLine().ToLower());
                                        printBoard(playerOneChoice);
                                    }
                                    else
                                    {
                                        arr[i] = 'X';
                                        break;
                                    }
                                } while (arr[i] == 'L');
                            }
                        }
                        player = 2;
                        printBoard(playerOneChoice);
                    } catch (Exception) { Console.WriteLine("Error: You can only enter numbers!" ); }

                } else if (player == 2)
                {
                    Console.Write($"It's player {player}'s turn: ");
                    try
                    {
                        playerTwoChoice = int.Parse(Console.ReadLine().ToLower());
                        while (playerTwoChoice < 1 || playerTwoChoice > 9)
                        {
                            Console.Write("Invalid input, please try again: ");
                            playerTwoChoice = int.Parse(Console.ReadLine().ToLower());
                        }
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (board[i] == playerTwoChoice)
                            {
                                if (arr[i] == 'X')
                                {
                                    break;
                                } 
                                else
                                {
                                    arr[i] = 'L';
                                    break;
                                }
                            }
                        }
                        player = 1;
                        printBoard(playerTwoChoice);
                    } catch (Exception) { Console.WriteLine("Error: You can only enter numbers!"); }
                }
            }

        }
        static void printBoard(int choice)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

        }

        static void printInstructions()
        {
            Console.WriteLine("Welcome to tic-tac-toe!");
            Console.WriteLine("To choose a grid, please pick 1 through 9, as depicted below.\n");
            Console.WriteLine("     |     |     \r\n" +
                              "  1  |  2  |  3  \r\n" +
                              "_____|_____|_____\r\n" +
                              "     |     |     \r\n" +
                              "  4  |  5  |  6  \r\n" +
                              "_____|_____|_____\r\n" +
                              "     |     |     \r\n" +
                              "  7  |  8  |  9  \r\n" +
                              "     |     |     \r\n");
            Console.WriteLine("-----------------");
        }
    }

}

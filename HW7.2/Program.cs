
internal class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static int choice;
    static int flag = 0;
    static void Main(string[] args)
    {

        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2's turn");
            }
            else
            {
                Console.WriteLine("Player 1's turn");
            }
            Console.WriteLine("\n");
            DrawBoard();

            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out choice);

            if (!validInput || choice < 1 || choice > 9)
            {
                Console.WriteLine("Please choose a number from 1 to 9.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                if (player % 2 == 0)
                {
                    board[choice - 1] = 'O';
                }
                else
                {
                    board[choice - 1] = 'X';
                }
                player++;
            }
            else
            {
                Console.WriteLine("This cell is already taken! Choose another.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            flag = CheckWin();

        } while (flag != 1 && flag != -1);

        Console.Clear();
        DrawBoard();

        if (flag == 1)
        {
            Console.WriteLine("Player {0} won!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Draw!");
        }
        Console.ReadLine();
    }

    static void DrawBoard()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
        Console.WriteLine("     |     |     ");
    }

    static int CheckWin()
    {
        #region Horizontal
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Check Draw
        else if (board[0] != '1' && board[1] != '2' && board[2] != '3' &&
                 board[3] != '4' && board[4] != '5' && board[5] != '6' &&
                 board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }
}
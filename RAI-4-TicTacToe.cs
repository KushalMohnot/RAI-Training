using System;
class Program
{
    public static char playerWho = ' ';

    static int turn = 0;

    static char[] Board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("  |       |       |       |");
        Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Board[0], Board[1], Board[2]);
        Console.WriteLine("  |       |       |       |");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("  |       |       |       |");
        Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Board[3], Board[4], Board[5]);
        Console.WriteLine("  |       |       |       |");
        Console.WriteLine("  -------------------------");
        Console.WriteLine("  |       |       |       |");
        Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", Board[6], Board[7], Board[8]);
        Console.WriteLine("  |       |       |       |");
    }
    public static void play(int player, int input)
    {
        if (player == 1) playerWho = 'X';
        else if (player == 2) playerWho = 'O';

        switch (input)
        {
            case 1: Board[0] = playerWho; break;
            case 2: Board[1] = playerWho; break;
            case 3: Board[2] = playerWho; break;
            case 4: Board[3] = playerWho; break;
            case 5: Board[4] = playerWho; break;
            case 6: Board[5] = playerWho; break;
            case 7: Board[6] = playerWho; break;
            case 8: Board[7] = playerWho; break;
            case 9: Board[8] = playerWho; break;
        }
    }
    public static void Hwin()
    {
        char[] players = { 'X', 'O' };
        foreach (char player in players)
        {
            if (((Board[0] == player) && (Board[1] == player) && (Board[2] == player))
                    || ((Board[3] == player) && (Board[4] == player) && (Board[5] == player))
                    || ((Board[6] == player) && (Board[7] == player) && (Board[8] == player)))
            {
                Console.Clear();
                if (player == 'X')
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (player == 'O')
                {
                    Console.WriteLine("Player 2 wins");
                }




                break;
            }
        }
    }


    public static void Vwin()
    {
        char[] players = { 'X', 'O' };
        foreach (char player in players)
        {
            if (((Board[0] == player) && (Board[3] == player) && (Board[6] == player))
                    || ((Board[1] == player) && (Board[4] == player) && (Board[7] == player))
                    || ((Board[2] == player) && (Board[5] == player) && (Board[8] == player)))
            {
                Console.Clear();
                if (player == 'X')
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (player == 'O')
                {
                    Console.WriteLine("Player 2 wins");
                }




                break;
            }
        }
    }

    public static void DiagWin()
    {
        char[] players = { 'X', 'O' };
        foreach (char player in players)
        {
            if (((Board[0] == player) && (Board[4] == player) && (Board[8] == player))
                    || ((Board[2] == player) && (Board[4] == player) && (Board[6] == player)))
            {
                Console.Clear();
                if (player == 'X')
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (player == 'O')
                {
                    Console.WriteLine("Player 2 wins");
                }




                break;
            }
        }
    }

    public static void Draw()
    {
        Console.WriteLine("Draw");
    }

    static void Main(string[] args)
    {
        int player = 2;
        int input = 0;
        bool inputP = true;

        do
        {
            if (player == 2)
            {
                player = 1;
                play(player, input);
            }
            else if (player == 1)
            {
                player = 2;
                play(player, input);


            }

            DrawBoard();
            turn = turn + 1;
            Hwin();
            Vwin();
            DiagWin();

            if (turn == 10)
            {
                Draw();
            }

            do
            {
                Console.WriteLine("Player {0}: turn", player);
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter number");

                }
                if ((input == 1) && (Board[0] == '1'))
                    inputP = true;
                else if ((input == 2) && (Board[1] == '2'))
                    inputP = true;
                else if ((input == 3) && (Board[2] == '3'))
                    inputP = true;
                else if ((input == 4) && (Board[3] == '4'))
                    inputP = true;
                else if ((input == 5) && (Board[4] == '5'))
                    inputP = true;
                else if ((input == 6) && (Board[5] == '6'))
                    inputP = true;
                else if ((input == 7) && (Board[6] == '7'))
                    inputP = true;
                else if ((input == 8) && (Board[7] == '8'))
                    inputP = true;
                else if ((input == 9) && (Board[8] == '9'))
                    inputP = true;
                else
                {
                    Console.WriteLine("invalid value");
                    inputP = false;
                }
            } while (!inputP);

        } while (true);
    }

}
    
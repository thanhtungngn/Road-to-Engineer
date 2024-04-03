// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
//Console.WriteLine(Exist(board: [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], word: "ABCCED"));
//Console.WriteLine(Exist(board: [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], word: "SEE"));
//Console.WriteLine(Exist(board: [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], word: "ABCB"));
Console.WriteLine(Exist(board: [['L', 'L', 'A', 'B','L','D'], ['G', 'A', 'B', 'A', 'L', 'L'], ['A', 'B', 'C', 'B', 'J', 'A'], ['L', 'E', 'D', 'H', 'I', 'L']], word: "ABCDHIJLABAG"));
//Console.WriteLine(Exist(board: [['C', 'A', 'A'], ['A', 'A', 'A'], [ 'B', 'C', 'D']], word: "AAB"));

bool Exist(char[][] board, string word)
{
    if(word.Length > board.Length * board[0].Length)
    {
        return false;
    }
    Queue<char> original = new Queue<char>();
    for (int i = 0; i < word.Length; i++)
    {
        original.Enqueue(word[i]);
    }

    var row = 0;
    var col = 0;
    var result = false;

    var queue = new Queue<char>(original);

    while (row < board.Length)
    {
        while (col < board[0].Length)
        {
            var passedBy = new List<string>();
            if (board[row][col] == queue.Peek())
            {
                queue.Dequeue();
                passedBy.Add("" + row + col);
                result = Validate(board, queue, row, col, passedBy);
                if (result && passedBy.Count == word.Length)
                {
                    return true;
                }
                queue = new Queue<char>(original);

            }
            col++;
        }
        col = 0;
        row++;
    }
    return false;
}

bool Validate(char[][] board, Queue<char> queue, int row, int col, List<string> passedBy)
{
    var result = queue.Count == 0;
    var currentQueue = new Queue<char>(queue);
    if (row - 1 >= 0 && !result)
    {
        if (board[row - 1][col] == queue.Peek() && !passedBy.Contains(""+(row-1)+col))
        {
            queue.Dequeue();
            passedBy.Add("" + (row - 1) + col);
            result = Validate(board, queue, row - 1, col, passedBy);
            if (!result)
            {
                queue = new Queue<char>(currentQueue);
                passedBy.Remove("" + (row - 1) + col);

            }
        }
    }
    if (row + 1 < board.Length && !result)
    {
        if (board[row + 1][col] == queue.Peek() && !passedBy.Contains("" + (row + 1) + col))
        {
            queue.Dequeue();
            passedBy.Add("" + (row + 1) + col);

            result = Validate(board,queue, row + 1, col, passedBy);
            if (!result)
            {
                queue = new Queue<char>(currentQueue);

                passedBy.Remove("" + (row + 1) + col);

            }
        }
    }
    if (col - 1 >= 0 && !result)
    {
        if (board[row][col - 1] == queue.Peek() && !passedBy.Contains("" + (row) + (col-1)))
        {
            queue.Dequeue();
            passedBy.Add("" + (row) + (col-1));

            result = Validate(board, queue, row, col - 1, passedBy);
            if (!result)
            {
                queue = new Queue<char>(currentQueue);

                passedBy.Remove("" + (row) + (col - 1));

            }
        }
    }
    if (col + 1 < board[0].Length && !result)
    {
        if (board[row][col + 1] == queue.Peek() && !passedBy.Contains("" + (row) + (col + 1)))
        {
            queue.Dequeue();
            passedBy.Add("" + (row) + (col + 1));

            result = Validate(board, queue, row, col + 1, passedBy);
            if (!result)
            {
                queue = new Queue<char>(currentQueue);

                passedBy.Remove("" + (row) + (col + 1));

            }
        }
    }
    
    return result;
}


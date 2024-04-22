// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine(AsteroidCollision([10, 2, -5]).Print());
Console.WriteLine(AsteroidCollision([-2, -1, 1, 2]).Print());
Console.WriteLine(AsteroidCollision([-2, -2, 1, -2]).Print());

int[] AsteroidCollision(int[] asteroids)
{
    Stack<int> stack = new Stack<int>();
    for (int i = 0; i < asteroids.Length; i++)
    {
        int currentValue = 0;
        var canPeek = stack.TryPeek(out currentValue);
        if(!canPeek)
        {
            stack.Push(asteroids[i]);
        }
        else
        {
            if(currentValue * asteroids[i] > 0 || currentValue < 0)
            {
                stack.Push(asteroids[i]);
            }
            else
            {
                var isExplode = false;
                while(stack.Count > 0 && !isExplode)
                {
                    var lastItem = stack.Pop();
                    if(lastItem * asteroids[i] > 0)
                    {
                        stack.Push(lastItem);
                        stack.Push(asteroids[i]);
                        isExplode = true;
                    }
                    else if(lastItem > 0 && asteroids[i]*-1 > lastItem && stack.Count == 0)
                    {
                        stack.Push(asteroids[i]);
                        isExplode = true;
                    }
                    else if ( lastItem < 0 && -1 * lastItem  > asteroids[i] && stack.Count == 0)
                    {
                        stack.Push(asteroids[i]);
                        isExplode = true;
                    }
                    else if (lastItem == -1 * asteroids[i])
                    {
                        isExplode = true;
                    }

                    else if ((lastItem > 0 && asteroids[i] * -1 < lastItem) || (lastItem < 0 && -1 * lastItem < asteroids[i]))
                    {
                        stack.Push(lastItem);
                        isExplode = true;
                    }

                }
            }
        }
        
    }
    var result = new int[stack.Count];
    for( int i = result.Length-1; i >= 0; i-- )
    {
        result[i] = stack.Pop();
    }
    return result;
}
namespace DSA
{
    public static class EightQueens
    {
        public static long Queens(int n, bool[,] table)
        {
            if (n == 0)
            {
                return 1;
            }

            long total = 0;

            int i = n - 1;
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    bool canPlaceQueen = true;

                    int[] dx = { 1,  1,  1 };
                    int[] dy = { 0, -1,  1 };

                    for (int di = 0; canPlaceQueen && di < dx.Length; di++)
                    {
                        int x = i;
                        int y = j;

                        while (x >= 0 && x < table.GetLength(0)
                        && y >= 0 && y < table.GetLength(1))
                        {
                            if (table[x, y])
                            {
                                canPlaceQueen = false;
                                break;
                            }

                            x += dx[di];
                            y += dy[di];
                        }
                    }

                    if (canPlaceQueen)
                    {
                        table[i, j] = true;
                        total += Queens(n - 1, table);
                        table[i, j] = false;
                    }
                }
                
            return total;
        }
    }
}
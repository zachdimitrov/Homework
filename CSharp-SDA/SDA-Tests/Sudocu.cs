namespace DSA
{
    public static class Sudocu
    {
        public static bool Solve(int[,] table, int row = 0, int col = 0)
        {
            if (col == 9)
            {
                row++;
                col = 0;

                if (row == 9)
                {
                    return true;
                }
            }

            if (table[row, col] > 0)
            {
                return Solve(table, row, col + 1);
            }

            for (int i = 1; i <= 9; i++)
            {
                bool isOK = true;

                for (int k = 0; k < 9; k++)
                {
                    if (table[row, k] == i || table[k, col] == i
                    || table[row / 3 * 3 + k / 3, col / 3 * 3 + k % 3] == i)
                    {
                        isOK = false;
                        break;
                    }
                }

                if (!isOK) continue;
                table[row, col] = i;


                if (Solve(table, row, col + 1))
                {
                    return true;
                }

                table[row, col] = 0;
            }

            return false;
        }
    }
}
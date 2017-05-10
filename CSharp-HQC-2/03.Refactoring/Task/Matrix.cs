using System;

namespace MatrixCreator
{
    public class Matrix
    {
        /// <summary>
        /// Changes direction of path
        /// </summary>
        /// <param name="dx">x direction</param>
        /// <param name="dy">y direction</param>
        public static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] deltaX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] deltaY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirection = 0;
            for (int directionIndex = 0; directionIndex < 8; directionIndex++)
            {
                if (deltaX[directionIndex] == dx && deltaY[directionIndex] == dy)
                {
                    currentDirection = directionIndex;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                dx = deltaX[0]; dy = deltaY[0];
                return;
            }

            dx = deltaX[currentDirection + 1];
            dy = deltaY[currentDirection + 1];
        }

        /// <summary>
        /// Finds if the next cell is occupied
        /// </summary>
        /// <param name="matrix">the Matrix</param>
        /// <param name="row">row</param>
        /// <param name="col">column</param>
        /// <returns></returns>
        public static bool CheckIfNextCellIsEmpty(int[,] matrix, int row, int col)
        {
            int[] deltaX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] deltaY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            var matrixSize = matrix.GetLength(0);
            for (int dirIndex = 0; dirIndex < 8; dirIndex++)
            {
                if (row + deltaX[dirIndex] >= matrixSize || row + deltaX[dirIndex] < 0)
                {
                    deltaX[dirIndex] = 0;
                }

                if (col + deltaY[dirIndex] >= matrixSize || col + deltaY[dirIndex] < 0)
                {
                    deltaY[dirIndex] = 0;
                }
            }

            for (int dirIndex = 0; dirIndex < 8; dirIndex++)
            {
                if (matrix[row + deltaX[dirIndex], col + deltaY[dirIndex]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Finds the next empty cell that is available
        /// </summary>
        /// <param name="matrix">the Matrix</param>
        /// <param name="row">row</param>
        /// <param name="col">column</param>
        static void FindEmptyCellToGo(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;

            var matrixSize = matrix.GetLength(0);
            for (int rowIndex = 0; rowIndex < matrixSize; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrixSize; colIndex++)
                {
                    if (matrix[rowIndex, colIndex] == 0)
                    {
                        row = rowIndex;
                        col = colIndex;
                        return;
                    }
                }      
            }    
        }

        public static void Main()
        {
            int matrixSize = 3;
            int[,] theMatrix = new int[matrixSize, matrixSize];
            var cextCellNum = 1;
            var rowCoor = 0;
            var colCoor = 0;

            FillUntillEndDead(theMatrix, ref rowCoor, ref colCoor, ref cextCellNum);
            FindEmptyCellToGo(theMatrix, out rowCoor, out colCoor);
            while (rowCoor != 0 && colCoor != 0)
            {
                cextCellNum++;
                FillUntillEndDead(theMatrix, ref rowCoor, ref colCoor, ref cextCellNum);
                FindEmptyCellToGo(theMatrix, out rowCoor, out colCoor);
            }

            PrintTheMatrix(theMatrix);
        }

        /// <summary>
        /// Fill the matrix untill nowere can be moved
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rowCoor"></param>
        /// <param name="colCoor"></param>
        /// <param name="nextCellValue"></param>
        private static void FillUntillEndDead(int[,] matrix, ref int rowCoor, ref int colCoor, ref int nextCellValue)
        {
            var deltaX = 1;
            var deltaY = 1;
            var matrixSize = matrix.GetLength(0);

            while (true)
            {
                matrix[rowCoor, colCoor] = nextCellValue;
                if (!CheckIfNextCellIsEmpty(matrix, rowCoor, colCoor))
                {
                    break;
                }

                var nextCoordinateForRow = rowCoor + deltaX;
                var nextCoordinateForCol = colCoor + deltaY;
                var isOutOfBounds = CheckIfCoordsWentOut(matrixSize, nextCoordinateForRow, nextCoordinateForCol);
                while (isOutOfBounds || matrix[nextCoordinateForRow, nextCoordinateForCol] != 0)
                {
                    ChangeDirection(ref deltaX, ref deltaY);

                    nextCoordinateForRow = rowCoor + deltaX;
                    nextCoordinateForCol = colCoor + deltaY;
                    isOutOfBounds = CheckIfCoordsWentOut(matrixSize, nextCoordinateForRow, nextCoordinateForCol);
                }

                rowCoor += deltaX;
                colCoor += deltaY;
                nextCellValue++;
            }
        }

        /// <summary>
        /// Matrix printer
        /// </summary>
        /// <param name="matrix"></param>
        private static void PrintTheMatrix(int[,] matrix)
        {
            var matrixSize = matrix.GetLength(0);
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks if we moved out of bounds
        /// </summary>
        /// <param name="matrixSize"></param>
        /// <param name="rowCandidate"></param>
        /// <param name="colCandidate"></param>
        /// <returns></returns>
        private static bool CheckIfCoordsWentOut(int matrixSize, int rowCandidate, int colCandidate)
        {
            var isRowOutOfBounds = rowCandidate < 0 || matrixSize <= rowCandidate;
            var isColOutOfBounds = colCandidate < 0 || matrixSize <= colCandidate;
            var isOutOfBounds = isRowOutOfBounds || isColOutOfBounds;

            return isOutOfBounds;
        }
    }
}

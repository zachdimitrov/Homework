namespace DefineClasses2.Matrices
{
    using System;
    using System.Text;
    // Problem 8. matrix

    /// <summary>
    /// class for simple 2D matrix with attributes, indexers ant operators
    /// </summary>
    /// <typeparam name="T"></typeparam>

    [Version(1, 0)]
    public class Matrix<T> where T : struct, IComparable, IComparable<T>
    {
        // fields
        private int row;
        private int col;
        private T[,] array;
        // properties
        public int RowCount
        {
            set { this.row = value; }
            get { return this.row; }
        }

        public int ColCount
        {
            set { this.col = value; }
            get { return this.col; }
        }
        // Problem 9. matrix indexer
        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < this.RowCount && col >= 0 && col < this.ColCount)
                {
                    return this.array[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was out of range!");
                }
            }
            set
            {
                this.array[row, col] = value;
            }
        }
        // default constructor
        public Matrix(int Rows, int Cols)
        {
            this.row = Rows;
            this.col = Cols;
            this.array = new T[row, col];
        }
        // extended constructor
        public Matrix(int Rows, int Cols, params T[] Numbers)
        {
            this.row = Rows;
            this.col = Cols;
            this.array = new T[row, col];
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (k >= Numbers.Length)
                {
                    break;
                }
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (k >= Numbers.Length)
                    {
                        break;
                    }
                    if (Numbers.Length > row * col)
                    {
                        throw new IndexOutOfRangeException("Too many numbers!");
                    }
                    else
                    {
                        array[i, j] = Numbers[k];
                    }
                    k++;
                }
            }
        }
        // methods
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    str.AppendFormat("{0, 3}, ", array[i, j]);
                }
                str.AppendFormat("{0, 3}", array[i, array.GetLength(1) - 1]);
                str.AppendLine("");
            }
            return str.ToString();
        }
        // Problem 10. operators override
        // operator +
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            int newRow = m1.RowCount >= m2.RowCount ? m1.RowCount : m2.RowCount;
            int smallestRow = m1.RowCount <= m2.RowCount ? m1.RowCount : m2.RowCount;
            int newCol = m1.ColCount >= m2.ColCount ? m1.ColCount : m2.ColCount;
            int smallestCol = m1.ColCount >= m2.ColCount ? m1.ColCount : m2.ColCount;

            Matrix<T> result = new Matrix<T>(newRow, newCol);
            for (int i = 0; i < newRow; i++)
            {
                if (i < smallestRow)
                {
                    for (int j = 0; j < newCol; j++)
                    {
                        if (j <= smallestCol)
                        {
                            result[i, j] = (dynamic)m1[i, j] + m2[i, j];
                        }
                        else
                        {
                            result[i, j] = m1.ColCount >= m2.ColCount ? m1[i, j] : m2[i, j];
                        }
                    }
                }
                else
                {
                    for (int j = smallestRow; j < newCol; j++)
                    {
                        result[i, j] = m1.RowCount >= m2.RowCount ? m1[i, j] : m2[i, j];
                    }
                }
            }
            return result;
        }
        // operator -
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.ColCount != m2.ColCount || m1.RowCount != m2.RowCount)
            {
                throw new ArgumentException("Matrices cannot be substracted!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(m1.RowCount, m1.ColCount);
                for (int i = 0; i < m1.RowCount; i++)
                {
                    for (int j = 0; j < m1.ColCount; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - m2[i, j];
                    }
                }
                return result;
            }
        }
        // operator *
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            int n = 0;
            int m = 0;
            int r = 0;

            if (m1.RowCount == m2.ColCount || m2.RowCount == m1.ColCount)
            {
                if (m1.RowCount == m2.ColCount)
                {
                    n = m1.RowCount; // = m2.ColCount
                    m = m1.ColCount;
                    r = m2.RowCount;
                }
                else
                {
                    r = m2.RowCount; // = m1.ColCount
                    m = m2.ColCount;
                    n = m1.RowCount;
                }

                Matrix<T> result = new Matrix<T>(n, r);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        T res = new T();
                        for (int k = 0; k < m; k++)
                        {
                            res += (dynamic)m1[i, k] * m2[k, j];
                        }
                        result[i, j] = res;
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("Matrices cannot be multiplied!");
            }
        }
        // operator true
        public static bool operator true(Matrix<T> matrix)
        {
            bool b = false;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColCount; j++)
                {
                    b = (dynamic)matrix[i, j] != 0;
                }
            }
            return b;
        }
        // operator false
        public static bool operator false(Matrix<T> matrix)
        {
            bool b = true;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColCount; j++)
                {
                    b = (dynamic)matrix[i, j] == 0;
                }
            }
            return b;
        }
    }
}

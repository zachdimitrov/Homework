namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class GameStart
	{
		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] field = CreatePlayField();
			char[,] bombs = PlaceBombs();
			int counter = 0;
			bool boom = false;
			List<Score> highScore = new List<Score>(6);
			int row = 0;
			int column = 0;
			bool flagTop = true;
			const int maxCounter = 35;
			bool flagBase = false;

			do
			{
				if (flagTop)
				{
					Console.WriteLine(" Let's play “Mines”. \n\n Try your luck and find fields without mines. \n" +
                    " ............................... \n" +
                    " Commands: \n" +
					" 'top' ------- shows high-score. \n" +
                    " 'restart' --- starts a new game. \n"+
                    " 'exit' ------ exits the game \n"+
                    " ............................... \n" + 
                    " Good luck!");

					redrawGameBoard(field);
					flagTop = false;
				}
				Console.Write("Input ROW and COLUMN separated by 'space': ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						scoreBoard(highScore);
						break;
					case "restart":
						field = CreatePlayField();
						bombs = PlaceBombs();
						redrawGameBoard(field);
						boom = false;
						flagTop = false;
						break;
					case "exit":
						Console.WriteLine("Good bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								playersTurn(field, bombs, row, column);
								counter++;
							}
							if (maxCounter == counter)
							{
								flagBase = true;
							}
							else
							{
								redrawGameBoard(field);
							}
						}
						else
						{
							boom = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Wrong command input!\n");
						break;
				}
				if (boom)
				{
					redrawGameBoard(bombs);
					Console.Write("\nOh no! You are dead with {0} points. " +
						"Please write your name: ", counter);
					string niknejm = Console.ReadLine();
					Score currentScore = new Score(niknejm, counter);
					if (highScore.Count < 5)
					{
						highScore.Add(currentScore);
					}
					else
					{
						for (int i = 0; i < highScore.Count; i++)
						{
							if (highScore[i].Points < currentScore.Points)
							{
								highScore.Insert(i, currentScore);
								highScore.RemoveAt(highScore.Count - 1);
								break;
							}
						}
					}
					highScore.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
					highScore.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
					scoreBoard(highScore);

					field = CreatePlayField();
					bombs = PlaceBombs();
					counter = 0;
					boom = false;
					flagTop = true;
				}
				if (flagBase)
				{
					Console.WriteLine("\nGood game! You opened all 35 fields without any damage.");
					redrawGameBoard(bombs);
					Console.WriteLine("Please write your name: ");
					string name = Console.ReadLine();
					Score points = new Score(name, counter);
					highScore.Add(points);
					scoreBoard(highScore);
					field = CreatePlayField();
					bombs = PlaceBombs();
					counter = 0;
					flagBase = false;
					flagTop = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Thank you for playing!");
			Console.WriteLine("Good bye!");
			Console.Read();
		}

		private static void scoreBoard(List<Score> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} fields open",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void playersTurn(char[,] field,
			char[,] bombs, int red, int colona)
		{
			char numberOfBombs = countOfMines(bombs, red, colona);
			bombs[red, colona] = numberOfBombs;
			field[red, colona] = numberOfBombs;
		}

		private static void redrawGameBoard(char[,] board)
		{
			int rows = board.GetLength(0);
			int columns = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < columns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int columns = 10;
			char[,] playField = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					playField[i, j] = '-';
				}
			}

			List<int> randomList = new List<int>();
			while (randomList.Count < 15)
			{
				Random random = new Random();
				int randomNumber = random.Next(50);
				if (!randomList.Contains(randomNumber))
				{
					randomList.Add(randomNumber);
				}
			}

			foreach (int number in randomList)
			{
				int column = (number / columns);
				int row = (number % columns);
				if (row == 0 && number != 0)
				{
					column--;
					row = columns;
				}
				else
				{
					row++;
				}
				playField[column, row - 1] = '*';
			}

			return playField;
		}

		private static void calculate(char[,] field)
		{
			int col = field.GetLength(0);
			int row = field.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (field[i, j] != '*')
					{
						char minesCount = countOfMines(field, i, j);
						field[i, j] = minesCount;
					}
				}
			}
		}

		private static char countOfMines(char[,] symbol, int row, int column)
		{
			int count = 0;
			int rows = symbol.GetLength(0);
			int columns = symbol.GetLength(1);

			if (row - 1 >= 0)
			{
				if (symbol[row - 1, column] == '*')
				{ 
					count++; 
				}
			}
			if (row + 1 < rows)
			{
				if (symbol[row + 1, column] == '*')
				{ 
					count++; 
				}
			}
			if (column - 1 >= 0)
			{
				if (symbol[row, column - 1] == '*')
				{ 
					count++;
				}
			}
			if (column + 1 < columns)
			{
				if (symbol[row, column + 1] == '*')
				{ 
					count++;
				}
			}
			if ((row - 1 >= 0) && (column - 1 >= 0))
			{
				if (symbol[row - 1, column - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row - 1 >= 0) && (column + 1 < columns))
			{
				if (symbol[row - 1, column + 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row + 1 < rows) && (column - 1 >= 0))
			{
				if (symbol[row + 1, column - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row + 1 < rows) && (column + 1 < columns))
			{
				if (symbol[row + 1, column + 1] == '*')
				{ 
					count++; 
				}
			}
			return char.Parse(count.ToString());
		}
	}
}
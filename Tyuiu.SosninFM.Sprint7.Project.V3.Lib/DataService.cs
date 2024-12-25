using System.Text;
using System.IO;

namespace Tyuiu.SosninFM.Sprint7.Project.V3.Lib
{
	public class DataService
	{
		public string[,] LoadFromDataFile(string path)
		{
			string[] str = File.ReadAllLines(path);

			//определение количества столбцов и строк
			int columns = str[0].Split(';').Length;
			int rows = str.Length;

			string[,] matrix = new string[rows, columns];

			for (int i = 0; i < str.Length; i++)
			{
				string strIndexI = str[i];
				string[] strArr = strIndexI.Split(';');
				for (int c = 0; c < strArr.Length; c++)
				{
					matrix[i, c] = strArr[c];
				}
			}
			return matrix;
		}

		public int MIN(string[,] matrix, int id)
		{

			int min = int.MaxValue;
			for (int i = 0; i < matrix.GetLength(1) - 1; i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (j == id)
					{

						if (Convert.ToInt32(matrix[i, j]) < min)
						{
							min = Convert.ToInt32(matrix[i, j]);
						}
					}
				}
			}
			return min;
		}

		public int MAX(string[,] matrix, int id)
		{
			int max = int.MinValue;
			for (int i = 0; i < matrix.GetLength(0) - 1; i++)
			{
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					if (j == id)
					{

						if (Convert.ToInt32(matrix[i, j]) > max)
						{
							max = Convert.ToInt32(matrix[i, j]);
						}
					}
				}
			}
			return max;
		}


	}
}

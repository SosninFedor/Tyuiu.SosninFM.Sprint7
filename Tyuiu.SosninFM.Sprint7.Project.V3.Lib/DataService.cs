using System;
using System.IO;

namespace Tyuiu.SosninFM.Sprint7.Project.V3.Lib
{
	public class DataService
	{
		public string[,] LoadFromDataFile(string path)
		{
			string[] str = File.ReadAllLines(path);
			int columns = str[0].Split(';').Length;
			int rows = str.Length;
			string[,] matrix = new string[rows, columns];

			for (int i = 0; i < str.Length; i++)
			{
				string strIndexI = str[i];
				string[] strArr = strIndexI.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
				for (int c = 0; c < strArr.Length; c++)
				{
					matrix[i, c] = strArr[c].Trim();
				}
			}
			return matrix;
		}

		public string GetStatisticsBySurname(string[,] matrix, string surname)
		{
			for (int i = 1; i < matrix.GetLength(0); i++) // Start from 1 to skip headers
			{
				string fullName = matrix[i, 0].Trim();
				string[] nameParts = fullName.Split(' ');
				if (nameParts.Length > 1 && nameParts[0].Contains(surname))
				{
					// Ensure the indices are within the bounds of the array
					if (matrix.GetLength(1) > 2)
					{
						return $"{fullName}, {matrix[i, 1]}, {matrix[i, 2]}";
					}
					else
					{
						return "Неверный формат данных.";
					}
				}
			}
			return "Нет совпадений.";
		}

		public (string[], int[], int[]) GetAllStatistics(string[,] matrix)
		{
			int rows = matrix.GetLength(0);
			string[] names = new string[rows - 1]; // Skip the header row
			int[] experiences = new int[rows - 1];
			int[] statistics = new int[rows - 1];

			for (int i = 1; i < rows; i++) // Start from 1 to skip headers
			{
				if (matrix.GetLength(1) > 2)
				{
					names[i - 1] = matrix[i, 0]; // Name
					experiences[i - 1] = int.Parse(matrix[i, 1]); // Experience
					statistics[i - 1] = matrix[i, 2].Contains("высшей") ? 1 : 0; // Statistics
				}
				else
				{
					return (new string[0], new int[0], new int[0]); // Return empty arrays if the format is incorrect
				}
			}

			return (names, experiences, statistics);
		}
	}
}

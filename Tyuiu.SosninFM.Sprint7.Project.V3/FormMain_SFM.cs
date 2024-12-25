using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SosninFM.Sprint7.Project.V3.Lib;

namespace Tyuiu.SosninFM.Sprint7.Project.V3
{
	public partial class FormMain_SFM : Form
	{
		private DataService dataService;
		private string[,] dataMatrix;

		public FormMain_SFM()
		{
			InitializeComponent();
			dataService = new DataService();
			string filePath = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint7\Tyuiu.SosninFM.Sprint7.Project.V3\bin\Debug\net8.0-windows\Info.csv";
			try
			{
				if (File.Exists(filePath))
				{
					dataMatrix = dataService.LoadFromDataFile(filePath);
					MessageBox.Show("���� �������� �������.");
				}
				else
				{
					MessageBox.Show("���� �� ������.");
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show($"������ ������� � �����: {ex.Message}");
			}
		}

		private void buttonMain_SFM_Click(object sender, EventArgs e)
		{
			FormAbout_SFM formAbout_SFM = new FormAbout_SFM();
			formAbout_SFM.ShowDialog();
		}

		private void buttonSearch_SFM_Click(object sender, EventArgs e)
		{
			string searchTerm = textBoxInput_SFM.Text;

			if (dataMatrix != null)
			{
				string result = dataService.GetStatisticsBySurname(dataMatrix, searchTerm);
				listBoxResult_SFM.Items.Clear();
				listBoxResult_SFM.Items.Add(result);

				// Create chart for the searched teacher
				CreateChart(searchTerm, result);
			}
			else
			{
				listBoxResult_SFM.Items.Clear();
				listBoxResult_SFM.Items.Add("���� �� ��������.");
			}
		}

		private void buttonHelp_SFM_Click(object sender, EventArgs e)
		{
			FormAbout_SFM formAbout_SFM = new FormAbout_SFM();
			formAbout_SFM.ShowDialog();
		}

		private void CreateChart(string surname, string statistics)
		{
			// Parse statistics
			string[] stats = statistics.Split(',');
			if (stats.Length >= 3)
			{
				string experience = stats[1].Trim();
				string teachingStats = stats[2].Trim();

				// Clear previous data
				chartStatistics.Series.Clear();
				chartStatistics.ChartAreas.Clear();

				// Add new chart area
				ChartArea area = new ChartArea();
				chartStatistics.ChartAreas.Add(area);

				// Add new series
				Series series = new Series
				{
					Name = "Statistics",
					ChartType = SeriesChartType.Bar,
					IsValueShownAsLabel = true
				};

				// Add data points
				series.Points.AddXY("����", int.Parse(experience));
				series.Points.AddXY("����������", teachingStats.Contains("������") ? 1 : 0);

				// Add series to chart
				chartStatistics.Series.Add(series);
			}
		}

		private void listBoxResult_SFM_SelectedIndexChanged(object sender, EventArgs e)
		{
			// ���������� �������, ���� ����������
		}
	}
}
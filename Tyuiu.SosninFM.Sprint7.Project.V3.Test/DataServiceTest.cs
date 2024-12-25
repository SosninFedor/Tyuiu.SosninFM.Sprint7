using Tyuiu.SosninFM.Sprint7.Project.V3.Lib;
using System.IO;

namespace Tyuiu.SosninFM.Sprint7.Project.V3.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();

			string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint7\Info.csv";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExist = fileInfo.Exists;
			Assert.AreEqual(true, fileExist);
		}
	}
}

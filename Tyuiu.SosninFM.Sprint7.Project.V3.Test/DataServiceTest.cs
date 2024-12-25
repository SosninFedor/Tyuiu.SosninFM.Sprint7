using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninFM.Sprint7.Project.V3.Lib;

namespace Tyuiu.SosninFM.Sprint7.Project.V3.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();

			string path = @"C:\Users\User\Desktop\V3.csv";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExist = fileInfo.Exists;
			Assert.AreEqual(true, fileExist);
		}
	}
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint4.Task6.V7.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var subjects = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };
            int res = ds.Calculate(subjects);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}

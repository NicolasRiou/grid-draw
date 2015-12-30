using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;
using System.Windows.Controls;
using System.Windows;

namespace UnitTestProject1
{
    [TestClass]
    public class GridTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var g = new WpfApplication1.Grid(new Canvas(), 20);

            g.Width = 20;

            var p = new Point(45,66);
            var expected = new Point(40, 60);


            var result = g.GridPosition(p);

            Assert.AreEqual(expected, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint0.Task2.V0.Lib;

namespace Tiuiu.SikachevaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //область создания методов тестирования, методов из библиотеки 
            var name = "Лиза";
            var res = DataService.GetMessage(name);

            //вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Лиза", res);
        }
    }
}

using Tyuiu.RomanovMV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.RomanovMV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubValid()
        {
            Assert.AreEqual(5, DataService.Sub(10, 5));
        }
        [TestMethod]
        public void CheckMulValid()
        {
            Assert.AreEqual(50, DataService.Mul(10, 5));
        }
        [TestMethod]
        public void CheckDivValid()
        {
            Assert.AreEqual(3, DataService.Div(9, 3));
        }
    }
}

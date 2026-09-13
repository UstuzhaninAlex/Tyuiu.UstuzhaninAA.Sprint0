
using Tyuiu.UstuzhaninAA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheakedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}

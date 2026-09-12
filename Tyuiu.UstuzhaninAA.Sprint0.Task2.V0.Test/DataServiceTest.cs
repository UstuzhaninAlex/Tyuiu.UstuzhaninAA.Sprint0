using Tyuiu.UstuzhaninAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алексей";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Алексей", res);
        }
    }
}

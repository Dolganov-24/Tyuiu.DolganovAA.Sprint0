using Tyuiu.DolganovAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DolganovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Саня";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет . . . , Саня", res);
        }
    }
}
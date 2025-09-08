namespace Tyuiu.TsvetkovRA.Sprint0.Task2.V0.Test
{
    using Tyuiu.TsvetkovRA.Sprint0.Task2.V0.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Роман";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Роман", res);
        }
    }
}

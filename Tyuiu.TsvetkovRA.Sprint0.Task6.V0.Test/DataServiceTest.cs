using Tyuiu.TsvetkovRA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.TsvetkovRA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        public void CheckSubtractionArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        public void CheckMultArray()
        {
            var numbers = new int[] { 1,2, 3, 4,5 };
            var res = DataService.MultArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}

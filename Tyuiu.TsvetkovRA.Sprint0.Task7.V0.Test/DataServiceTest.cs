﻿using Tyuiu.TsvetkovRA.Sprint0.Task7.V0.Lib;
namespace Tyuiu.TsvetkovRA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2 };
            int[] res = DataService.AdditionArray(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}

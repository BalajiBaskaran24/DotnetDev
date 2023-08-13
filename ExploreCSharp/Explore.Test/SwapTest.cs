namespace Explore.Test
{
    [TestClass]
    public class SwapTest
    {
        [TestMethod]
        public void Test_Swap_Proper()
        {
            int Input1 = 5;
            int Input2 = 6;
            ExploreCSharp.Electronics.ExploreEle.Swap(ref Input1, ref Input2);
            Assert.AreEqual(Input1, 6);
            Assert.AreEqual(Input2, 5);
        }

        [TestMethod]
        public void Test_Swap_SameRef()
        {
            int Input1 = 5;
            ExploreCSharp.Electronics.ExploreEle.Swap(ref Input1, ref Input1);
            Assert.AreNotEqual(Input1, 0);//The output will be 0. Swap using XOR fails, if we pass same reference as parameter. Since ip1^ip2 returns 0 in step-1
        }

        /// <summary>
        /// This method will not be considered as test case and will not be executed
        /// </summary>
        public void WithoutTestMthdDec()
        {
            Assert.Equals(0, 0);
        }
    }
}
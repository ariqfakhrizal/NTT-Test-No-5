namespace NTT_Test_No_5.MSTest
{
    [TestClass]
    public class UnitTestNo5
    {
        [TestMethod]
        public void SoalA_functionSelisih_ReturnTrue()
        {
            int[] dataArray = new int[] { 2, 5, 3, 6 };

            var result = NTT.NTT_Test_No_5.functionSelisih(dataArray);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SoalB_functionSelisih_ReturnTrue()
        {
            int[] dataArray = new int[] { 3, 1, 2, 4, 3 };

            var result = NTT.NTT_Test_No_5.functionSelisih(dataArray);
            Assert.AreEqual(1, result);
        }

    }
}
namespace NTT_Test_No_5.MSTest
{
    [TestClass]
    public class UnitTestNo5
    {
        [TestMethod]
        [DataRow(new int[] { 2, 5, 3, 6 })]
        public void SoalA_functionSelisih_ReturnTrue(int[] numberEnteredTest)
        {
            var actualResult = NTT.NTT_Test_No_5.functionSelisih(numberEnteredTest);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        [DataRow(new int[] { 3, 1, 2, 4, 3 })]
        public void SoalB_functionSelisih_ReturnTrue(int[] numberEnteredTest)
        {
            var actualResult = NTT.NTT_Test_No_5.functionSelisih(numberEnteredTest);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
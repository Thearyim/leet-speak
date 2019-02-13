namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void GetLeetSpeak_WordWithLetterE_True()
        {
          LeetSpeak testLeetSpeak = new LeetSpeak();
          string[] result = testLeetSpeak.GetLeetSpeak(e);
          CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
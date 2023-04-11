using AnalyserProgram;
namespace AnalyserProgramTest
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //ARRANGE
            string expectedop = "Sad Mood";
            string msg = "I am very sad ";
            AbilityToAnalyse check = new AbilityToAnalyse();

            //ACT
            string result = check.AnalyseMood(msg);

            //ASSERT
            Assert.AreEqual(expectedop, result);
        }

        [TestMethod]
        public void GivenHappyMoodShouldReturnHAPPY()
        {
            //ARRANGE
            string expectedop = "Happy Mood";
            string msg = "I am very Happy ";
            AbilityToAnalyse check = new AbilityToAnalyse();

            //ACT
            string result = check.AnalyseMood(msg);

            //ASSERT
            Assert.AreEqual(expectedop, result);
        }
    }
}

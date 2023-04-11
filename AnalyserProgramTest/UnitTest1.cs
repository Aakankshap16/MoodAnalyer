using AnalyserProgram;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("I m in happy mood")]
        [DataRow(null )]
        [TestMethod]
        public void GivenHappyMoodShouldReturnHAPPY(string message)
        {
            //ARRANGE
            string expectedop = "Happy Mood";
           
            MoodAnalyser check = new MoodAnalyser(message); 

            //ACT
            string result = check.AnalyseMood();

            //ASSERT
            Assert.AreEqual(expectedop, result);
        }
    }
}
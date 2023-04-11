using AnalyserProgram;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Given_Empty_Mood_ShouldThrowCustomException_Show_EmptyMood()
        {
            try

            {
                //ARRANGE
                string msg = "";
                MoodAnalyser check = new MoodAnalyser(msg);
 
                //ACT
                string result = check.AnalyseMood();
            }
            catch (MoodAnalyserCustomException ex)
            {
                //ASSERT
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))] //try catch not required directly we can use 

        public void Given_Null_Mood_ShouldThrowCustomException_Show_Null()
        {
            
                //ARRANGE
                string msg = null;
               
                MoodAnalyser check = new MoodAnalyser(msg);

                //ACT
                string result = check.AnalyseMood();
                
                //ASSERT
               //when we use [expected excetion (typeof())] not required assert
                //Assert.AreEqual("Mood should not be null", ex.Message);
            
        }
    }
}
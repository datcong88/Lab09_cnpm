using StudentServiceLib;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject1
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void getLetterScoreA ()
        {
            Student s1 = new Student();

            s1.Score = 8;

            char result = s1.getLetterScore();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void getLetterScoreB()
        {  
            Student s1 = new Student();

            s1.Score = 8;

            char result = s1.getLetterScore();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void getLetterScoreC()
        {
            Student s1 = new Student();

            s1.Score = -5;

            char result = s1.getLetterScore();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void getLetterScoreD()
        {
            Student s1 = new Student();

            s1.Score = 8;

            char result = s1.getLetterScore();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void ScoreIs11_ReturnException()
        {
            String expectedMessage = "Score must not exceed 10.0";
            String meesage = null;
            Student s = new Student();
            try
            {
                s.Score = 11;
            }
            catch(Exception e)
            {
                meesage = e.Message;
            }
            Assert.AreEqual(expectedMessage, meesage);

        }


        [TestMethod]
        public void ScoreIsMinus5_ReturnException()
        {
            String expectedMessage = "Score must not exceed 10.0";
            String meesage = null;
            Student s = new Student();
            try
            {
                s.Score = -5;
            }
            catch (Exception e)
            {
                meesage = e.Message;
            }
            Assert.AreEqual(expectedMessage, meesage);

        }


        [TestMethod]
        public void ScoreIs12_ReturnException()
        {
            String expectedMessage = "Score must not exceed 10.0";
            String meesage = null;
            Student s = new Student();
            try
            {
                s.Score = 12;
            }
            catch (Exception e)
            {
                meesage = e.Message;
            }
            Assert.AreEqual(expectedMessage, meesage);

        }


        [TestMethod]
        public void ScoreIs13_ReturnException()
        {
            String expectedMessage = "Score must not exceed 10.0";
            String meesage = null;
            Student s = new Student();
            try
            {
                s.Score = 13;
            }
            catch (Exception e)
            {
                meesage = e.Message;
            }
            Assert.AreEqual(expectedMessage, meesage);

        }



    }
}
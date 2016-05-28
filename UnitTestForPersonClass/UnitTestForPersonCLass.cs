using COMP123_S2016_Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForLab2
{
    /**
     * This class is used to test Person class under COMP123S2016-Lab2 project
     * Used for development only
     * 
     * @class UnitTestForPersonCLass
     * */
    [TestClass]
    public class UnitTestForPersonCLass
    {

        /**
         * This Method is used to test SayHello Method under COMP123S2016-Lab2 Person class
         * Used for development only
         * 
         * @method TestMethodForPersonSaysHello
         * */

        [TestMethod]
        public void TestMethodForPersonSaysHello()
        {
            //Arrange
            string name = "Mamun";
            int age = 30;
            double height = 5.7;
            string gender = "male";
            string expectedResult = "Mamun305.71";

            // Act
            Person person = new Person(name,age,height,gender);
            string result = person.Name+person.Age+  person.Height.ToString()+person.Gender.ToString();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        /**
        * This Method is used to test ShowAge Method under COMP123S2016-Lesson3 Person class
        * Used for development only
        * 
        * @method TestMethodForPersonShowAge
        * */

        [TestMethod]
        public void TestMethodForPersonShowAge()
        {
            //Arrange
            int age = 50;
            string expectedResult = "50 years old.";

            // Act
            Person person = new Person();
            // private static Person personName = new Person(name);
            // Person personAge = new Person(age);
            string result = person.ShowAge(age);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

using COMP123_S2016_Lession3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForLession3
{
    /**
     * This class is used to test Person class under COMP123S2016-Lesson3 project
     * Used for development only
     * 
     * @class UnitTestForPersonCLass
     * */
    [TestClass]
    public class UnitTestForPersonCLass
    {

        /**
         * This Method is used to test SayHello Method under COMP123S2016-Lesson3 Person class
         * Used for development only
         * 
         * @method TestMethodForPersonSayHello
         * */

        [TestMethod]
        public void TestMethodForPersonSayHello()
        {
            //Arrange
            string name = "Tom";
            string expectedResult = "Tom is ";

            // Act
            Person person = new Person();
            // private static Person personName = new Person(name);
            // Person personAge = new Person(age);
            string result = person.SayHello(name);

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

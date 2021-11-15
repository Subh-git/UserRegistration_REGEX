using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression01;

namespace RegularExpEmailTest
{
    [TestClass]
    public class UserRegTest
    {
        [TestMethod]
        //The following test case should return Valid name
        public void TestFirstName()
        {
            //Arrange
            string fname = "Subhadeep";
            string expected = "Valid";

            //Act
            string reg = RegularExp.FirstName(fname);          //since sstatic methods so no need of class obj creation

            //Assert
            Assert.AreEqual(expected, reg);
        }

        [TestMethod]
        //The following test case should return Invalid
        public void TestFirstName_Invlaid()
        {
            try
            {
                //Arrange
                string fname = "Su";
                string expected = "Invalid";                       //this returns invalid since the minimum letter in first name should be 3

                //Act
                string reg = RegularExp.FirstName(fname);          //since sstatic methods so no need of class obj creation

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid", e.Message);
            }            
        }

        [TestMethod]
        //The following test case should return Invalid  as entry is null
        public void TestFirstName_NullException()
        {
            string fname = null;
            try
            {
                //Arrange
               
                string expected = "Invalid";                       //this returns invalid since the minimum letter in first name should be 3

                //Act
                string reg = RegularExp.FirstName(fname);          //since sstatic methods so no need of class obj creation

                //Assert
                expected.Equals(reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }
        }

        [TestMethod]
        //The following test case should return Valid Last name
        public void TestLastName_Valid()
        {
            //Arrange
            string name = "Bhattacharjee";
            string expected = "Valid";

            //Act
            string reg = RegularExp.LastName(name);          //since sstatic methods so no need of class obj creation

            //Assert
            Assert.AreEqual(expected, reg);
        }

        [TestMethod]
        //The following test case should return invalid Last name
        public void TestLastName_Invalid()
        {
            try
            {
                //Arrange
                string name = "bhattacharjee";                 //This returns invalid as the first letter is not capital
                string expected = "Invalid";

                //Act
                string reg = RegularExp.LastName(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch(CustomException e)
            {
                Assert.AreEqual("Invalid", e.Message);
            }
           
        }
        [TestMethod]
        //The following test case should return excepiton as argument null
        public void TestLastName_NullExeption()
        {
            try
            {
                //Arrange
                string name = null;                 //This returns invalid as the first letter is not capital
                string expected = "Invalid";

                //Act
                string reg = RegularExp.LastName(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        [TestMethod]
        //The following test case should return valid phone number
        public void TestPhoneNumber_Valid()
        {
            //Arrange
            string name = "91 8596978965";
            string expected = "Valid";

            //Act
            string reg = RegularExp.Mobile(name);          

            //Assert
            Assert.AreEqual(expected, reg);
        }
        [TestMethod]

        //The following test case should return invalid phone number
        public void TestPhoneNumber_Invalid()
        {
            try
            {
                //Arrange
                string name = "8596978965";                    //since there is no country code
                string expected = "Invalid";

                //Act
                string reg = RegularExp.Mobile(name);

                //Assert
                Assert.AreEqual(expected, reg);
            }
            catch(CustomException e)
            {
                Assert.AreEqual("Invalid", e.Message);
            }
          
        }

        [TestMethod]

        //The following test case should return null exception
        public void TestPhoneNumber_NullException()
        {
            try
            {
                //Arrange
                string name = null;                    //since there is no country code
                string expected = "Invalid";

                //Act
                string reg = RegularExp.Mobile(name);

                //Assert
                Assert.AreEqual(expected, reg);
            }
            catch (CustomException e)                          //Argument null exception
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        [TestMethod]
        //The following test case should return valid password
        public void TestPassword_Valid()
        {
            //Arrange
            string name = "ADEdvfed47@af&";
            string expected = "Valid";

            //Act
            string reg = RegularExp.PassWord(name);         

            //Assert
            Assert.AreEqual(expected, reg);
        }

        [TestMethod]
        //The following test case should return invalid password
        public void TestPassword_Invalid()
        {
            try
            {
                //Arrange
                string name = "ADEdvfedaf";                     //Missing atleast one number, and special character
                string expected = "Invalid";

                //Act
                string reg = RegularExp.PassWord(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch(CustomException e)
            {
                Assert.AreEqual("Invalid", e.Message);
            }
          
        }

        public void TestPassword_NullException()
        {
            try
            {
                //Arrange
                string name = null;                     //Missing atleast one number, and special character
                string expected = "Invalid";

                //Act
                string reg = RegularExp.PassWord(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }

        }

        [TestMethod]
        //The following test cases should return valid email for all these email samples
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc@gmail.com")]
        [DataRow("1.abc@yahoo.com")]
        [DataRow("2.abc-100@yahoo.com")]
        [DataRow("3.abc.100@yahoo.com")]
        [DataRow("2.abc111@abc.com")]
        [DataRow("4.abc-100@abc.net")]
        [DataRow("5.abc.100@abc.com.au")]
        [DataRow("6.abc@1.com")]
        [DataRow("7.abc@gmail.com.com")]
        [DataRow("8.abc+100@gmail.com")]
        public void Testemail_Valid(string name)                          //parameterised test for testing multiple email entries.
        {
            //Arrange
            string expected = "Valid";

            //Act
            string reg = RegularExp.Email(name);

            //Assert
            Assert.AreEqual(expected, reg);
        }
        [TestMethod]
        //The following test cases should return Invalid email for all these invalid email samples
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Testemail_Invalid(string name)
        {
            try
            {
                //Arrange
                string expected = "Invalid";

                //Act
                string reg = RegularExp.Email(name);

                //Assert
                Assert.AreEqual(expected, reg);

            }
            catch(CustomException e)
            {
                Assert.AreEqual("Invalid", e.Message);
            }
             
        } 

        [TestMethod]
        public void TestEmail_NullException()                   //argument null excewption
        {
            try
            {
                string email = null;
                string reg = RegularExp.Email(email);
                Assert.AreEqual("Valid", reg);
            }
            catch(CustomException e)
            {
                Assert.AreEqual("Entry cannot be null", e.Message);
            }
        }
    }
}

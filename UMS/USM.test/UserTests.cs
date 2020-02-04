using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLogic;


namespace USM.test
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserRightCodeToMatchesRightId()
        {
            //Assign
            //Right teise = new Right(2);
            //User vartotojas = new User(1, "Jonas", teise );
            User vartotojas = new User(1, "Jonas", new Right(2));

            //Act
            string rightCode = vartotojas.GetRightCode();
            //Assert
            Assert.AreEqual("FullAccess", rightCode);
        }
        [TestMethod]
        public void UserRightCodeToMatchesNewRight()
        {
            //Assign
            //Right teise = new Right(2);
            //User vartotojas = new User(1, "Jonas", teise );
            User vartotojas = new User(1, "Jonas", new Right(2));

            //Act
            vartotojas.ChangeRight(new Right(3));
            string rightCode = vartotojas.GetRightCode();
            //Assert
            Assert.AreEqual("READONLY", rightCode);
        }


    }
}

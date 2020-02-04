using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLogic;

namespace USM.test
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestMethod]
        public void UserRepositoryShouldRetrieveKnownUser()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            User vartotojas = userRepository.Retrieve(5);
            //Assert
            Assert.AreEqual("Eva", vartotojas.Name);
            
        }
        [TestMethod]
        public void UserRepositoryAddShouldUser()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            User vartotojas = userRepository.Retrieve(5);
            //Assert
            Assert.AreEqual("Eva", vartotojas.Name);

        }
        [TestMethod]
        public void UserRepositoryDeleteShouldList()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            User vartotojas = userRepository.Retrieve(5);
            //Assert
            Assert.AreEqual("Eva", vartotojas.Name);

        }
    }
}

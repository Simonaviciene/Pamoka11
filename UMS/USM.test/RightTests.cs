using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLogic;

namespace USM.test
{
    [TestClass]
    public class RightTests
    {
        [TestMethod]
        public void RightId2IsFullAccess()
        {
            //Assign
            Right right = new Right(2);

            //Act
            string code = right.Code;

            //Assert
            Assert.AreEqual("FullAccess", code);
        }
        [TestMethod]
        public void RightIdNotValidIsReadOnly()
        {
            //Assign
            Right right = new Right(15);

            //Act
            string code = right.Code;

            //Assert
            Assert.AreEqual("READONLY", code);
        }
        [TestMethod]
        public void RightIdIs1IsApprove_Reject()
        {
            //Assign
            Right right = new Right(1);

            //Act
            string code = right.Code;

            //Assert
            Assert.AreEqual("Approve_Reject", code);
        }

    }
}

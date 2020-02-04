using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UMSBusinesLogic;
using System.Collections.Generic;



namespace USM.test
{
    [TestClass]
    public class ReportGeneratorTests
    {
        [TestMethod]
        public void MetodasGenerateTuriGrazintiTiekEiluciuKiekVartotoju()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            List<User> vartotojuSarasas = userRepository.Retrieve();
            ReportGenerator reportGenerator = new ReportGenerator(vartotojuSarasas);
            //Act
            List<ReportItem> ataskaitosEilutes = reportGenerator.Generate();
            int vartotojuKiekis = vartotojuSarasas.Count;
            int eiluciuKiekis = ataskaitosEilutes.Count;
            //Assert
            Assert.AreEqual(vartotojuKiekis, eiluciuKiekis);
        }
        [TestMethod]
        public void MetodasGenerateTuriGrazintiTiekEiluciuKiekVartotojuSuTeise0()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            List<User> vartotojuSarasas = userRepository.Retrieve();
            ReportGenerator reportGenerator = new ReportGenerator(vartotojuSarasas);
            //Act
            List<ReportItem> ataskaitosEilutes = reportGenerator.Generate(0);
           
            int eiluciuKiekis = ataskaitosEilutes.Count;
            //Assert
            Assert.AreEqual(4, eiluciuKiekis);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1CsharpogUnittests;

namespace UnitTestBog
{
    [TestClass]
    public class UnitTestBog
    {
        private Bog _bog;

        [TestInitialize]
        public void Init()
        {
            _bog = new Bog();
        }

        #region UsingTest

        [TestMethod]
        public void TestTitel()
        {
            //Act
            _bog.Titel = "Hej med dig 1";

            //Assert
            Assert.AreEqual("Hej med dig 1", _bog.Titel);
        }

        [TestMethod]
        public void TestSideTal()
        {
            //Act
            _bog.SideTal = 200;

            //Assert
            Assert.AreEqual(200, _bog.SideTal);
        }

        [TestMethod]
        public void TestForfatter()
        {
            //Act
            _bog.Forfatter = "Anton";

            //Assert
            Assert.AreEqual("Anton", _bog.Forfatter);
        }

        [TestMethod]
        public void TestIsbn()
        {
            //Act
            _bog.Isbn = "1234567890123";

            //Assert
            Assert.AreEqual("1234567890123", _bog.Isbn);
        }

        #endregion

        #region ExceptionTest

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTalOverIllegal()
        {
            //Act
            _bog.SideTal = 10000;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTalUnderIllegal()
        {
            //Act
            _bog.SideTal = 1;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestIsbnIllegal()
        {
            //Act
            _bog.Isbn = "10000";
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestForfatterIllegal()
        {
            //Act
            _bog.Forfatter = "i";
        }

        #endregion

        #region NullTest

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestIsbnNull()
        {
            //Act
            _bog.Isbn = null;
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestForfatterNull()
        {
            //Act
            _bog.Forfatter = null;
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void TestTitelNull()
        {
            //Act
            _bog.Titel = null;
        }

        #endregion
    }
}

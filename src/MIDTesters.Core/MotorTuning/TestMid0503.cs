﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.MotorTuning;

namespace MIDTesters.MotorTuning
{
    [TestClass]
    [TestCategory("MotorTuning")]
    public class TestMid0503 : DefaultMidTests<Mid0503>
    {
        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ASCII")]
        public void Mid0503Revision1()
        {
            string package = "00200503            ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(Mid0503), mid.GetType());
            AssertEqualPackages(package, mid, true);
        }

        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ByteArray")]
        public void Mid0503ByteRevision1()
        {
            string package = "00200503            ";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse(bytes);

            Assert.AreEqual(typeof(Mid0503), mid.GetType());
            AssertEqualPackages(bytes, mid, true);
        }
    }
}

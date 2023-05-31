﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.AutomaticManualMode;

namespace MIDTesters.AutomaticManualMode
{
    [TestClass]
    [TestCategory("AutomaticManualMode")]
    public class TestMid0402 : DefaultMidTests<Mid0402>
    {
        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ASCII")]
        public void Mid0402Revision1()
        {
            string package = "00200402            ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(Mid0402), mid.GetType());
            AssertEqualPackages(package, mid, true);
        }

        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ByteArray")]
        public void Mid0402ByteRevision1()
        {
            string package = "00200402            ";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse(bytes);

            Assert.AreEqual(typeof(Mid0402), mid.GetType());
            AssertEqualPackages(bytes, mid, true);
        }
    }
}

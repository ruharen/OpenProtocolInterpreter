﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.Tool;

namespace MIDTesters.Tool
{
    [TestClass]
    [TestCategory("Tool")]
    public class TestMid0040 : DefaultMidTests<Mid0040>
    {
        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("Revision 2"), TestCategory("Revision 3"), TestCategory("Revision 4"), TestCategory("Revision 5"), TestCategory("ASCII")]
        public void Mid0040Revisions1To5()
        {
            string package = "00200040004         ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(Mid0040), mid.GetType());
            AssertEqualPackages(package, mid);
        }

        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("Revision 2"), TestCategory("Revision 3"), TestCategory("Revision 4"), TestCategory("Revision 5"), TestCategory("ByteArray")]
        public void Mid0040ByteRevisions1To5()
        {
            string package = "00200040004         ";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse(bytes);

            Assert.AreEqual(typeof(Mid0040), mid.GetType());
            AssertEqualPackages(bytes, mid);
        }

        [TestMethod]
        [TestCategory("Revision 6"), TestCategory("Revision 7"), TestCategory("ASCII")]
        public void Mid0040Revisions6And7()
        {
            string package = "00260040007         010001";
            var mid = _midInterpreter.Parse<Mid0040>(package);

            Assert.IsNotNull(mid.ToolNumber);
            AssertEqualPackages(package, mid);
        }

        [TestMethod]
        [TestCategory("Revision 6"), TestCategory("Revision 7"), TestCategory("ByteArray")]
        public void Mid0040ByteRevisions6And7()
        {
            string package = "00260040007         010001";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse<Mid0040>(bytes);

            Assert.IsNotNull(mid.ToolNumber);
            AssertEqualPackages(bytes, mid);
        }
    }
}

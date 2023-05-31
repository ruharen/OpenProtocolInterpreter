﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.Tool;

namespace MIDTesters.Tool
{
    [TestClass]
    [TestCategory("Tool")]
    public class TestMid0042 : DefaultMidTests<Mid0042>
    {
        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ASCII")]
        public void Mid0042Revision1()
        {
            string package = "00200042            ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(Mid0042), mid.GetType());
            AssertEqualPackages(package, mid, true);
        }

        [TestMethod]
        [TestCategory("Revision 1"), TestCategory("ByteArray")]
        public void Mid0042ByteRevision1()
        {
            string package = "00200042            ";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse(bytes);

            Assert.AreEqual(typeof(Mid0042), mid.GetType());
            AssertEqualPackages(bytes, mid, true);
        }

        [TestMethod]
        [TestCategory("Revision 2"), TestCategory("ASCII")]
        public void Mid0042Revision2()
        {
            string package = "00300042002         0100420201";
            var mid = _midInterpreter.Parse<Mid0042>(package);

            Assert.IsNotNull(mid.ToolNumber);
            Assert.IsNotNull(mid.DisableType);
            AssertEqualPackages(package, mid);
        }

        [TestMethod]
        [TestCategory("Revision 2"), TestCategory("ByteArray")]
        public void Mid0042ByteRevision2()
        {
            string package = "00300042002         0100420200";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse<Mid0042>(bytes);

            Assert.IsNotNull(mid.ToolNumber);
            Assert.IsNotNull(mid.DisableType);
            AssertEqualPackages(bytes, mid);
        }
    }
}

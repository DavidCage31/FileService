using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService.Tests
{
    [TestClass()]
    public class NorFileTests
    {
        [TestMethod()]
        public void NorFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NorFileTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NorFileTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindTest()
        {
            NorFile f = new NorFile("123 qwerty, pop 00 qwert wer 1223", "file1");

            string expected = "qwerty qwert wer";
            string result = string.Join(" ", f.Find(@"(\w*)we(\w*)"));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ReplaceTest()
        {
            NorFile f = new NorFile("123 qwerty, pop 00 qwert wer 1223", "file1");
            
            f.Replace(@"(\w*)we(\w*)", "0");

            string expected = "123 0, pop 00 0 0 1223";
            string result = f.Text;

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RewriteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;
using System;

namespace MyClassTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExistes(@"C:\Windows\Regedit.exe");
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExistes(@"C:\Regedit.exe");
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowArgumentNullException()
        {
            FileProcess fp = new FileProcess();
            fp.FileExistes("");
        }
    }
}

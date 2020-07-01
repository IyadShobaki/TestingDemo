using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using System.IO;

namespace DemoLibrary.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Example.ExampleLoadTextFile("This is a valid name.");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            //Assert.Throws<FileNotFoundException>(() => Example.ExampleLoadTextFile(""));
            Assert.Throws<ArgumentException>("file",() => Example.ExampleLoadTextFile(""));
        }
    }
}

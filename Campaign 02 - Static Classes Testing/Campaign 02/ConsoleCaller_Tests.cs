using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace Campaign_02
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    class ConsoleCaller_Tests
    {
        [Test]
        public void WriteLine_Was_Called()
        {
            var consoleMock = Substitute.For<IConsole>();
            
            // the console caller should get an interface for wrapping to console or a mock
            //var sut = new ConsoleCaller(consoleMock);
            
            consoleMock.Received(1).WriteLine("Hello World");
        }
    }
}

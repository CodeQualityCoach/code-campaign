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

            var sut = new ConsoleCaller(consoleMock);
            sut.DoSomething();

            consoleMock.Received(1).WriteLine("Hello World");
        }
        
        [Test]
        public void ReadLine_Was_Called()
        {
            var consoleMock = Substitute.For<IConsole>();
            consoleMock.ReadLine().Returns("Hulk");

            var sut = new ConsoleCaller(consoleMock);
            sut.GetSomething();

            consoleMock.Received(1).ReadLine();
            consoleMock.Received(1).WriteLine("Hello Hulk");
        }
    }
}

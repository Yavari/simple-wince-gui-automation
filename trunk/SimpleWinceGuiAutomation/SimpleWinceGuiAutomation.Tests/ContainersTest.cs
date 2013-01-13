﻿using System.Collections.Generic;
using NUnit.Framework;

namespace SimpleWinceGuiAutomation.Tests
{
    [TestFixture]
    public class ContainersTest : WinceTest
    {
        [Test]
        public void TestReadAllContainers()
        {
            List<WinceContainer> pictureBoxes = application.MainWindow.Containers.All;
            Assert.AreEqual(2, pictureBoxes.Count);
        }
    }
}
using System;
using Xunit;
using HomeLibraryApp.Model;

namespace HomeLibraryAppTest
{
    public class UnitTest1
    {
        //Test that the progress item validates its inputs correctly
        //to make sure we never go over or under our range of 0-100
        [Fact]
        public void TestProgress()
        {
            Progress progress = new Progress(0);
            Assert.Equal(0, progress.ProgressAmmount);
            progress.ProgressAmmount = 1000;
            Assert.Equal(100, progress.ProgressAmmount);
            progress.ProgressAmmount = 100;
            Assert.Equal(100, progress.ProgressAmmount);
            progress.ProgressAmmount = 50;
            Assert.Equal(50, progress.ProgressAmmount);
            progress.ProgressAmmount = -1;
            Assert.Equal(0, progress.ProgressAmmount);
        }
    }
}

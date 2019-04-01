using ClassEnum;
using Xunit;
using System;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Test_CourseType_Contains_WorldHistory()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseType));

            Assert.Contains(enumNames, type => type == "WorldHistory");
        }

        [Fact]
        public void Test_CourseType_Contains_Geography()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseType));

            Assert.Contains(enumNames, type => type == "Geography");
        }

        [Fact]
        public void Test_CourseType_Contains_AtLeastEightSubjects()
        {
            string[] enumNames = Enum.GetNames(typeof(CourseType));

            Assert.True(enumNames.Length > 7);
        }
    }
}

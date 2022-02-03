using System;
using ExpanseManager.Extensions;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class MappingTest
    {
        [Fact]
        public void ShouldCreateDate(int year, int month, int day, DateTime expected)
        {
            DateTime actual = DateExtension;
        }
    }
}

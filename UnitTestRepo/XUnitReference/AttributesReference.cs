using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitReference
{
    public class AttributesReference
    {
        [Fact]
        public void ShouldAddTwoNumbers_Fact()
        {
            Assert.Equal(4, 2 + 2);
        }


        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(2, 2, 4)]
        public void ShouldAddTwoNumbers_Theory(int a, int b, int expected)
        {
            Assert.Equal(expected, a + b);
        }


        [Trait("Category", "Math")]
        [Fact]
        public void ShouldAddTwoNumbers_Trait()
        {
            Assert.Equal(4, 2 + 2);
        }



        [Fact(Skip = "Skipping for now")]
        public void ShouldAddTwoNumbers_Skip()
        {
            Assert.Equal(4, 2 + 2);
        }

    }
}

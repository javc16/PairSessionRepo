using PairSessionRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PairSessionTestRepo
{
    public class TestingCodeTests
    {
        [Fact]
        public void Answer_Should_be_Hola()
        {
            TestingCode programClass = new TestingCode();
            decimal result = programClass.sum(2, 2);
            Assert.Equal(4, result);

        }

        [Fact]
        public void Answer_Should_Be_NotImplementedException_Error()
        {
            TestingCode programClass = new TestingCode();           
            Assert.Throws<NotImplementedException>(() => programClass.sum(6, 6));
        }
    }
}

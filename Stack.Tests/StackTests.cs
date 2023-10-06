using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    class Stack
    {
        public int Count { get; set; }

        public void Push(int v)
        {
            Count++;
        }
    }

    public class StackTests
    {

        [Fact]
        public void NewStachShouldBeEmpty()
        {
            var stack = new Stack();

            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void AddOneElementShouldIncreaseCount()
        {
            var stack = new Stack();
            stack.Push(2);

            Assert.Equal(1, stack.Count);
        }
    }
}

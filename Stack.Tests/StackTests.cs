using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    class Stack
    {
        int[] _values = new int[2];

        public int Count { get; set; }

        public void Push(int v)
        {
            if(_values.Length <= Count)
            {
                ExtendArray();
            }
            _values[Count] = v;
            Count++;
        }
                

        public int Pop()
        {
            Count--;
            return _values[Count];
        }



        private void ExtendArray()
        {
            var tmp = new int[_values.Length * 2];
            for (var i = 0; i < _values.Length; i++)
            {
                tmp[i] = _values[i];
            }
            _values = tmp;
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

        [Fact]
        public void PushShouldStoreTheValue()
        {
            var stack = new Stack();
            stack.Push(7);
            
            Assert.Equal(7, stack.Pop());
        }

        [Fact]
        public void ShouldBeAbleToPushManyElements()
        {
            var stack = new Stack();

            for(var i = 0; i < 10; i++)
            {
                stack.Push(i+1);
            }

            Assert.Equal(10, stack.Pop());
        }
    }
}

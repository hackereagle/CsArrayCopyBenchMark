using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsArrayCopyMethodsBenchMark
{
    [MemoryDiagnoser]
    public class TestArrayCopyClass
    {
        private const int ARRAY_SIZE = 1000000;
        private int[] _sourceArray = new int[ARRAY_SIZE];
        public TestArrayCopyClass()
        {
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                _sourceArray[i] = random.Next(ARRAY_SIZE);
            }
        }

        [Benchmark]
        public void CopyArrayUsingForLoop()
        {
            int[] destinationArray = new int[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                destinationArray[i] = _sourceArray[i];
            }
        }

        [Benchmark]
        public void CopyArrayUsingArrayCopy()
        {
            int[] destinationArray = new int[ARRAY_SIZE];
            Array.Copy(_sourceArray, destinationArray, ARRAY_SIZE);
        }

        [Benchmark]
        public void CopyArrayUsingCopyTo()
        {
            int[] destinationArray = new int[ARRAY_SIZE];
            _sourceArray.CopyTo(destinationArray, 0);
        }

        [Benchmark]
        public void CopyArrayUsingLinq()
        {
            int[] destinationArray = _sourceArray.ToArray();
        }

        [Benchmark]
        public void CopyArrayUsingBuffer()
        {
            int[] destinationArray = new int[ARRAY_SIZE];
            Buffer.BlockCopy(_sourceArray, 0, destinationArray, 0, ARRAY_SIZE * sizeof(int));
        }
    }
}

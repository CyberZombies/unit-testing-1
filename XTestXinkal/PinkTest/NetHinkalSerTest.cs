using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XTestXinkal.PinkTest
{
    public class NetHinkalSerTest
    {
        [Fact]
        public void NetHinkalSerTest_Run()
        {
            KhinkaliWithCheeseAndMushrooms khinkali = new KhinkaliWithCheeseAndMushrooms(500, 250, 10, 200, 150, 50, 30, 5);
            string dough = khinkali.PrepareDough();
            string filling = khinkali.PrepareFilling();
            Console.WriteLine(dough);
            Console.WriteLine(filling);
        }
        [Fact]
        public void AdditionExample()
        {
            int result = AdditionOperations.Add(5, 3);
            Console.WriteLine(result);
        }
        [Fact]
        public void SubtractionExample()
        {
            int result = SubtractionOperations.Subtract(10, 4);
            Console.WriteLine(result);
        }
        [Fact]
        public void MultiplicationExample()
        {
            int result = MultiplicationOperations.Multiply(2, 7);
            Console.WriteLine(result);
        }
        [Fact]
        public void DivisionExample()
        {
            int result = DivisionOperations.Divide(15, 3);
            Console.WriteLine(result);

            result = DivisionOperations.Modulo(17, 5);
            Console.WriteLine(result);
        }
    }
}

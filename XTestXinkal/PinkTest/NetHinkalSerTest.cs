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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Stack
{
    internal class stackbasic
    {
        public static void Main(string[] args)
        {
            Stack<string> BrowserHistory = new Stack<string>();

            BrowserHistory.Push("base.com");
            BrowserHistory.Push("x.com");
            BrowserHistory.Push("instagram.com");

            string current = BrowserHistory.Peek();

            Console.WriteLine(current);

            string previous = BrowserHistory.Pop();


        }
    }
}

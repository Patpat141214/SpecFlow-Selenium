using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shouty
{
    public class Person
    {
        public IEnumerable<string> GetMessagesHeard()
        {
            return new List<string> { "free bagels at Sean's", "Free Coffee!", "Free keyboard" };
        }

        public void MoveTo(int distance)
        {
        }

        public void Shouts(string message)
        {
         
        }
    }
}

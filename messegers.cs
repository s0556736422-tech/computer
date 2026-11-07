using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    public class messegers
    {
        public event Action<string> messegersRecieved;
        public void addMesseger(string s)
        {
            messegersRecieved?.Invoke(s);
        }


    }
}

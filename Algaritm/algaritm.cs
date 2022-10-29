using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm
{
    internal class algaritm
    {
        private int _count;
        private string _line;

        public void Func(int count,string line)
        {
            _count =  count;
            _line =  line;
            for(int i = 0; i < count; i++)
            {
                Console.Write(line);
            }
        }
    }
}

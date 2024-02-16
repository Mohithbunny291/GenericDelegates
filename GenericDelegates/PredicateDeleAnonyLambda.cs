using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    internal class PredicateDeleAnonyLambda
    {
        public bool IsEvenNum(int num)
        {
            if(num%2 == 0) return true;
            return false;
        }
    }
}

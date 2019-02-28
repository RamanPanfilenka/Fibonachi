using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    public class Fibonachi20
    {
        public List<int> FirstTwenty()
        {
            List<int> ans = new List<int>();
            int value = 0;
            int previos = 1;
            for (int i = 0; i < 21; i++)
            {

                ans.Add(value);
                int temp = value;
                value += previos;
                previos = temp;
            }
            return ans;
        }
    }
}

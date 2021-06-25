using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class FactorialService
    {
        public int Calculate(int number) {
            if (number == 0)
            {
                return 1;
            }

            int result = 1;
            for (int index = 1; index <= number; index++) {
                result *= index;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class EvenOdd
    {
        int num;
        public EvenOdd(int num) {
            this.num = num;
        }

        public String GetEvenOdd() {
            if(this.num % 2 == 0 ){
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}

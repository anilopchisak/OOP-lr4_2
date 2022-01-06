using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_лаба_4_часть_2
{
    class Model
    {
        private int a;
        private int b;
        private int c;

        public System.EventHandler observers;
        public void setA(int _a)
        {
            if (_a >= 0 && _a <= 100)
            {
                this.a = _a;
                while (b < a)
                    b = b + 1;
                while (c < a)
                    c = c + 1;

            }
                
            observers.Invoke(this, null);
        }

        public void setB(int _b)
        {
            if (_b >= a && _b <= c)
                this.b = _b;

            observers.Invoke(this, null);
        }

        public void setC(int _c)
        {
            if (_c >= 0 && _c <= 100)
            {
                this.c = _c;
                while (b > c )
                    b = b - 1;
                while (a > c)
                    a = a - 1;
            }
                

            observers.Invoke(this, null);
        }

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }

        public int getC()
        {
            return c;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Calculator
{   public class Calculation
    {
        private int mauso;
        private int tuso;

        public Calculation(int a,int b)
        {
            this.tuso = a;
            this.mauso = b;
        }

        public int Execute (string CalSybol)
        {
            int result = 0;
            switch(CalSybol)
            {
                case "+": result = this.tuso + this.mauso; break;
                case "-": result = this.tuso - this.mauso; break;
                case "*": result = this.tuso * this.mauso;break;
                case "/": result = this.tuso / this.mauso;break;
            }
            return result;
        }
    }

   
}

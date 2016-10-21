﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public class Multicasting : IExample
    {
        delegate int NumberChanger(int n);

        private int num = 10;
        public int AddNum(int p)
        {
            num += p;
            return num;
        }

        public int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public int getNum()
        {
            return num;
        }
        
        public void Run()
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}

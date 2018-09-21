using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExercise
{
    public class MyOut
    {
        public void outPut(out int b)
        {
            int temp = 5;
            b = temp;
            b = b / 2;
        }
        //public void outPut(decimal a)
        //{
        //    a = a / 2;
        //}
        //public void outPut(out int a)
        //{
        //    a = a / 2;
        //}
    }
}

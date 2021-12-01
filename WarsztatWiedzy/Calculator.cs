using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1
{
    internal static class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subttract(float a, float b)
        {
            if(a > b)
                return a - b;

            return b - a;
        }

        public static float AddMore(params float[] numbers)
        {
            float result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_lesson
{
     static class Utilities
    {
        public static bool IsNumber(string text)
        {
            try
            {
                Convert.ToDecimal(text);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Please, enter only number!");
                return false;
            }
        }
    }
}

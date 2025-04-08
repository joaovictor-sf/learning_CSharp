using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FormatException
            //OverflowException
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (OverflowException o)
            {
                Console.WriteLine(o.Message);
            }
            catch (Exception e)//All exceptions
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}

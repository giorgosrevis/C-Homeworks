using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Customer cust = new Customer("giorgosrevis@hotmail.com", "6974113556");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }




        }
    }
}


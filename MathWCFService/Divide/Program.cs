using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no1");
            int no1;
            int.TryParse(Console.ReadLine(), out no1);

            Console.WriteLine("enter no2");
            int no2;
            int.TryParse(Console.ReadLine(), out no2);

            MathServiceReference.MathServiceClient client=new MathServiceReference.MathServiceClient();
            try
            {
                client.Divide(no1, no2);
            }
            catch(FaultException<MathServiceReference.DivideByZeroFault> e)
            {
                Console.WriteLine(e.Detail.Message+""+e.Detail.Description+""+e.Detail.Result);
            }
            catch (FaultException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
               
                client.Abort();
            
            }

            Console.ReadLine();

        }
    }
}

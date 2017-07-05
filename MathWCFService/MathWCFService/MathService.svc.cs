using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MathService.svc or MathService.svc.cs at the Solution Explorer and start debugging.
    public class MathService : IMathService
    {

        public int Add(int no1, int no2)
        {
            return no1 + no2;
        }

        public int Subtract(int no1, int no2)
        {
            return no1 - no2;
        }

        public int Multiple(int no1, int no2)
        {
            return no1 * no2;
        }

        public int Divide(int no1, int no2)
        {
            try
            {
                return no1 / no2;
            }
            catch (DivideByZeroException e)
            {
                DivideByZeroFault fault=new DivideByZeroFault();
                fault.Result = false;
                fault.Message = e.Message;
                fault.Description = "Cannot divide by zero";
                throw new FaultException<DivideByZeroFault>(fault);
            }
          
        }
    }
}

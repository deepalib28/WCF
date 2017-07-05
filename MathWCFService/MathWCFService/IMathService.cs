using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathService" in both code and config file together.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(int no1,int no2);

        [OperationContract]
        int Subtract(int no1, int no2);

        [OperationContract]
        int Multiple(int no1, int no2);

        [OperationContract]
        [FaultContract(typeof(DivideByZeroFault))]
        int Divide(int no1, int no2);

    
    }

    public class DivideByZeroFault
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}

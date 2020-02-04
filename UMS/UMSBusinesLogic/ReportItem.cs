using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLogic
{
     public class ReportItem
    {
        public string ID { get; private set; }
        public string Vadas { get; private set; }
        public string RightCode { get; private set; }

        public ReportItem(int id, string vardas, string rightCode)
        {
            ID = Convert.ToString(id);
            Vadas = vardas;
            RightCode = rightCode;
        }


        
                
        
    }
    
}

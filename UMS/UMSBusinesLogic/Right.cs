using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UMSBusinesLogic
{
    public class Right
    { 
        public int RightId { get; private set; }
        public string Code
        {
            get
            {
                if (RightId == 0)
                {
                    return "READONLY";
                }
                else if(RightId == 1)
                {
                    return "Approve_Reject";
                }
                else if(RightId == 2)
                {
                    return "FullAccess";
                }
                else
                {
                    return "Nezinoma Teise";
                }

            }
            
        }
        public Right(int rightId)
        {
            if ((rightId >= 0) && (rightId <= 2))
            {
                RightId = rightId;
            }
            else
            {
                RightId = 0;
            }
        }
        

    }
}

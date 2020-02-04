using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLogic
{
     public class ReportGenerator
    {
        private List<User> VartotojuSarasas;
       
        public ReportGenerator(List<User> vartotojuSarasas)
        {
            VartotojuSarasas = vartotojuSarasas;

        }
        public List<ReportItem> Generate()
        {
            List<ReportItem> ataskaitosEilutes = new List<ReportItem>();

            foreach (var item in VartotojuSarasas)
            {
                ReportItem eilute = new ReportItem(item.UserId, item.Name, item.GetRightCode());
                ataskaitosEilutes.Add(eilute);
            }
            return ataskaitosEilutes;
        }
        public List<ReportItem> Generate(int rightId)
        {
            List<ReportItem> ataskaitosEilutes = new List<ReportItem>();
            foreach (var vartotojas in VartotojuSarasas)

            {
               int userRightId = vartotojas.GetRightId();
                if (userRightId == rightId)
                {
                 ReportItem eilute = new ReportItem(vartotojas.UserId, vartotojas.Name, vartotojas.GetRightCode());
                 ataskaitosEilutes.Add(eilute);
                }

               
            }
            return ataskaitosEilutes;
        }
            


    }
}

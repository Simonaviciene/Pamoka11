using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLogic
{
    public class User
    {
        public int UserId { get; private set; }
        public string Name { get; private set; }
        private Right userRight;

        public User(int userId, string name, Right right)  //Konstruktorius
        {
            UserId = userId;
            Name = name;
            userRight = right;
        }
        public void ChangeRight(Right right)
        {
            userRight = right;
        }
        public string GetRightCode()
        {
            string rightCode = userRight.Code;
            return rightCode;
        }
        public int GetRightId()
        {
            return userRight.RightId;

        }




    
    }
}

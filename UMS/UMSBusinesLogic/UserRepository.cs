using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLogic
{
     public class UserRepository
    {
        private List<User> vartotojai;
        public UserRepository()
        {
            vartotojai = new List<User>();
            vartotojai.Add(new User(1, "Jonas", new Right(2)));
            vartotojai.Add(new User(2, "Antanas", new Right(1)));
            vartotojai.Add(new User(3, "Algis", new Right(0)));
            vartotojai.Add(new User(4, "Maria", new Right(6)));
            vartotojai.Add(new User(5, "Eva", new Right(5)));
            vartotojai.Add(new User(6, "Martynas", new Right(3)));
            vartotojai.Add(new User(7, "Asndrius", new Right(1)));
        }
        public User Retrieve(int userId)
        {
            foreach (var vartotojas in vartotojai)
            {
                if (vartotojas.UserId == userId)
                    return vartotojas;
            }
            return null;
            
        }
        public List<User> Retrieve()
        {
            return vartotojai;
        }
        public void AddUser(int id, string name, int rightId)
        {
            User vartotojas = Retrieve(id);
            if(vartotojas != null)
            {
                return;
            }
            vartotojai.Add(new User(id, name, new Right(rightId)));
        }
        public void DeleteId(int userId)
        {
            int pozicija = -1;
            for (int i = 0; i < vartotojai.Count; i++)
            {
                if (vartotojai[i].UserId == userId)
                {
                    pozicija = i;
                    break;
                }
            }
            if(pozicija == -1)
            {
                return;
            }
            vartotojai.RemoveAt(pozicija);
        }

    }
}

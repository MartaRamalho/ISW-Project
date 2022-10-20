using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public User(){ 
            MainAuthoredPapers = new List<Paper>();
        }

        public User(String id, String name,String surname, bool alerted, String areasOfInterest, 
            String email, String login, String password, 
            Area area, Magazine magazine):base(id,name,surname) {

            this.Alerted = alerted;
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login;
            this.Password = password;
            this.Area = area;
            this.Magazine = magazine;
            
        }
    }
}

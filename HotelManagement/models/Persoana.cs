using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.models
{
    [Serializable]
    public abstract class Persoana
    {
        protected string firstName;
        protected string lastName;
        protected string cnp;

        protected Persoana(string firstName, string lastName, string cnp)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
        }

        public string FirstName
        {
            get => firstName;
            set { if (value != null) firstName = value; }
        }
        public string LastName
        {
            get => lastName;
            set { if (value != null) lastName = value; }
        }
        public string Cnp
        {
            get => cnp;
            set { if (value.Length == 13) cnp = value; }
        }

        public abstract int getAge();
    }
}

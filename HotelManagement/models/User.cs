using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{

    [Serializable]
    public class User
    {
        private string firstName;
        private string lastName;
        private string cnp;
        private string email;
        private string phone;
        //Booking[] bookings;

        public User(string firstName, string lastName, string cnp, string email, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Cnp = cnp;
            this.Email = email;
            this.Phone = phone;
        }

        public string getFullName()
        {
            return lastName + " " + firstName;
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
        public string Email
        {
            get => email;
            set { if (value.Contains("@")) email = value; }
        }
        public string Phone
        {
            get => phone;
            set { if (value != null) phone = value; }
        }

        public override string ToString()
        {
            return String.Format("Client: {0}\n" +
                "CNP: {1}\n" +
                "Email: {2}\n" +
                "Telefon: {3}",
                firstName + " " + lastName, cnp, email, phone
            );
        }
    }
}

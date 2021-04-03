using HotelManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    [Serializable]
    public class User : Persoana, IComparable<User>
    {
        private string email;
        private string phone;

        public User(string firstName, string lastName, string cnp, string email, string phone): base(firstName, lastName, cnp)
        {
            this.Email = email;
            this.Phone = phone;
        }

        ~User() { }

        public string getFullName()
        {
            return lastName + " " + firstName;
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

        public override int getAge()
        {
            int year = DateTime.Now.Year;
            string birthdayYear = this.cnp.Substring(1, 2);
            birthdayYear = "19" + birthdayYear;

            return year - Int32.Parse(birthdayYear);
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

        public int CompareTo(User user)
        {
            return this.cnp.CompareTo(user.cnp);
        }
    }
}

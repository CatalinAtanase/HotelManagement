using HotelManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    [Serializable]
    public class User : Person, IComparable<User>, ICloneable
    {
        private string[] emails;
        private string phone;

        public User(string firstName, string lastName, string cnp,  string phone) : base(firstName, lastName, cnp)
        {
            this.emails = null;
            this.phone = phone;
        }

        //todo change email to array 

        ~User() { }

        public string getFullName()
        {
            return lastName + " " + firstName;
        }


        public int NrEmails
        {
            get
            {
                return emails != null ? emails.Length : 0;
            }
        }

        public string this[int index]
        {
            get
            {
                return emails != null && index >= 0 && index < emails.Length ? emails[index] : "";
            }
        }

        public object Clone()
        {
            return ((ICloneable)this).Clone();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }



        public static User operator +(User user, string email)
        {
            User u = (User)user.Clone();
            string[] newEmails = new string[u.NrEmails + 1];
            if(u.emails != null)
            {
                for (int i = 0; i < u.NrEmails; i++)
                {
                    newEmails[i] = u.emails[i];
                }

                newEmails[u.NrEmails - 1] = email;
            } else
            {
                newEmails[0] = email;
            }

            return u;
        }

        public static User operator +(string email, User u)
        {
            return u + email;
        }


        public string Phone
        {
            get => phone;
            set { if (value != null) phone = value; }
        }

        public string[] Emails { get => emails; set => emails = value; }

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
                firstName + " " + lastName, cnp, string.Join(", ", emails), phone
            );
        }

        public int CompareTo(User user)
        {
            return this.cnp.CompareTo(user.cnp);
        }
    }
}

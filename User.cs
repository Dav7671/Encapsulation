using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class User
    {
        public string _firstName { get; set; }
        public string _surname { get; set; }

        public int _age { get; set; }
        public Guid _id { get; } = Guid.NewGuid();

        public int _salary { get; set; }

        public string FullName { get => $"{_firstName} {_surname}";}

        public int Age
        {
            get
            {
                return _age;
            }


            set
            {
                if (value < 18)
                {
                    throw new Exception("Invalid year");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public User()
        {
           
        }
    }
}

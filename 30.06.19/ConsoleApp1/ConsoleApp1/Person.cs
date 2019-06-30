using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private static int ID;
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Age;
        public  int Payment { get; set; }

        private int _discount;

        public int Discount
        {
            get
            {
                return _discount;
            }


            set
            {
                if (value > 0 && value <= 100)
                {
                    _discount = value;
                }

            }
        }

        public GroupType Type { get; set; }

        public Person(string name, string surname, int payment, GroupType type, DateTime age)
        {
            ID++;
            Name = name;
            Surname = surname;
            Age = age;
            Payment = payment;
            Type = type;

        }

        public float GetPrice()
        {
            if (Discount == 0)
            {
                return Payment;
            }
            else
            {
                return (Payment * Discount / 100);

            }

        }
        public int GetAge()
        {
            return DateTime.Now.Year - Age.Year;
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Groups
    {
        private static int ID;
        public string Name { get; set; }
        private Person[] people;

        public Groups(string name)
        {
            ID++;
            Name = name;
            people = new Person[0];

        }
        
        public void AddPerson(Person person)
        {
            if (people.Length <= 2)
            {
                Array.Resize(ref people, people.Length + 1);
                people[people.Length - 1] = person;

            }
            else
            {
                Console.WriteLine($"{person.Name} {person.Surname},qebul olmadi,qrup dolub");
            }
            
            
            
        }

        public void GetAllPerson()
        {
            foreach (var item in people)
            {
               
                
                if (item.Payment < 3900)
                {
                    Console.WriteLine($"{item.Name} {item.Surname},qebul olmadi,odenis tam deyil");

                }
                else
                {
                    Console.WriteLine($"Adi:{item.Name},Soyadi:{item.Surname},Yasi:{item.GetAge()},Odenisi:{item.Payment} manat ");
                }
                
            }
        }

       
    }
}


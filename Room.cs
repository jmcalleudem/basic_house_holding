using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHolding
{
    internal class Room
    {
        public string name { get; set; }
        public List<Person> people_in_room = new List<Person>();
        public void get_person_in(Person person) { people_in_room.Add(person); }
        public void get_person_out(Person person) { people_in_room.Remove(person); }

        public List<Person> get_people_in_room() 
        {
            if (people_in_room.Count == 0) { Console.WriteLine(this.name + " is empty..."); }
            else 
            {
                Console.WriteLine("People at " + this.name + ":\n");
                foreach(Person person in people_in_room) 
                {
                    Console.WriteLine("--> " + person.name);
                }
            }
            return people_in_room;
        }
    }
}

using System;
using System.Collections.Generic;

namespace HouseHolding
{
    internal class Person
    {
        public string name { get; set; }
        public BedRoom main_room { get; set; }
        public Room current_room { get; set; }
        public Person(string name)
        {
            this.name = name;
        }
        public void move(Room room) 
        {
            if (current_room == room) { Console.WriteLine("You're already there... Choose another one..."); return; }

            Console.WriteLine(this.name + " moved to " + room.name);
            current_room.get_person_out(this);
            current_room = room;
            current_room.get_person_in(this);
        }
    }
}

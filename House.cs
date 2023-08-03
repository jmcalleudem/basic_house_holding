using System;
using System.Collections.Generic;

namespace HouseHolding
{
    internal class House
    {
        public List<Room> rooms= new List<Room>();
        public Person owner;
        public Dictionary<string, Room> rooms_dictionary = new Dictionary<string, Room>();
        public House(Person owner) 
        {
            this.owner = owner;

            BedRoom bedroom = new BedRoom();
            Kitchen kitchen = new Kitchen();
            LivingRoom livingroom = new LivingRoom();

            rooms_dictionary.Add("bedroom", bedroom);
            rooms_dictionary.Add("kitchen", kitchen);
            rooms_dictionary.Add("livingroom", livingroom);

            owner.main_room = bedroom;
            owner.current_room = bedroom;

            bedroom.get_person_in(owner);
        }
        public Room get_room(string room_name)
        {
            return rooms_dictionary[room_name];
        }
        public List<Person> get_people_in_room(string room_name) 
        {
            return rooms_dictionary[room_name].get_people_in_room();
        }
    }
}

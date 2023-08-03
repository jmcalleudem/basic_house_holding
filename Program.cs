using System;
using System.Collections.Generic;

namespace HouseHolding
{
    internal class Program
    {
        public static void Main() 
        {
            Person magola = new Person("Magola");
            House magolas_house = new House(magola);

            magola.move(magolas_house.get_room("bedroom"));
            magolas_house.get_people_in_room("bedroom");
            magolas_house.get_people_in_room("kitchen");
            magolas_house.get_people_in_room("livingroom");

            magola.move(magolas_house.get_room("kitchen"));
            magolas_house.get_people_in_room("bedroom");
            magolas_house.get_people_in_room("kitchen");
            magolas_house.get_people_in_room("livingroom");
        }
    }
}

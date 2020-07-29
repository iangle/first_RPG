using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine{
    public class Location{

        public int ID { get; set; } // the ID number of the location
        public string Name { get; set; }// the name of the location
        public string Description { get; set; } // a description of the location

        public Item ItemRequiredToEnter { get; set; } //an item that is required to enter the location
        public Quest QuestAvailableHere { get; set; } //whether or not there is a quest here
        public Monster MonsterLivingHere { get; set; } //whether or not a monster lives here
        public Location LocationToNorth { get; set; } //the northern exit
        public Location LocationToEast { get; set; } //the eastern exit
        public Location LocationToSouth { get; set; } //the southern exit
        public Location LocationToWest { get; set; } // the western exit



        public Location(int id, string name, string description, IRaiseItemChangedEvents itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null){

            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;

        }
    }
}

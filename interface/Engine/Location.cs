using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine{
    public class Location{

        public int ID { get; set; } // the ID number of the location
        public string Name { get; set; }// the name of the location
        public string Description { get; set; } // a description of the location


        public Location(int id, string name, string description){

            ID = id;
            Name = name;
            Description = description;

        }
    }
}

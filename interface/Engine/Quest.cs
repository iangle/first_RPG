﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine{
    public class Quest{

        public int Id { get; set; } // the identification number of the quest
        public string Name { get; set; } // the name of the quest
        public string Description { get; set; } // a description of the quest
        public int RewardExperiencePoints { get; set; } // give the player some xp
        public int RewardGold { get; set; } // give the player some gold

        public Item RewardItem { get; set; } //give the player an item from a quest

        public Quest(int id, string name, string description, int rewardExperiencePoints,
            int rewardGold, Item rewardItem = null)
        {
            Id = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
        }
    }
}

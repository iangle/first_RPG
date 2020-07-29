using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine{
    public class Monster : LivingCreature{

        public int ID { get; set; } //the indentification number of the monster
        public string Name { get; set; } // the name of the monster
        public int MaximumDamage { get; set; } // the maximum damage of the monster
        public int RewardExperiencePoints { get; set; } // give the monster xp
        public int RewardGold { get; set; } // give the monster money

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int maximumHitpoints, int currentHitpoints) : 
            base(currentHitpoints, maximumHitpoints){

            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}

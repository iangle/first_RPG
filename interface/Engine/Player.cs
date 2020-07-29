using System;
using System.Collections.Generic;
using System.Text;

namespace Engine{
    public class Player : LivingCreature{

        public int Gold { get; set; } //the amount of gold the player currently has
        public int ExperiencePoints { get; set; } //  the amount of xp the player currently has
        public int Level { get; set; } //the players current level

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : 
            base(currentHitPoints, maximumHitPoints) {

            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}

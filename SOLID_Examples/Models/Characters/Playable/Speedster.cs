﻿namespace SOLID_S.Models.Characters.Playable
{
    internal class Speedster : PlayableCharacter
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 0.80;
        public Speedster(string nickname, double strength, double speed) : base(nickname, strength, speed)
        {
        }

        public override double BattlePower
        {
            get
            {
                double battlePower = 0;
                battlePower += strength * BattlePowerStrengthMultiplier;
                battlePower += speed * BattlePowerSpeedMultiplier;
                return battlePower;
            }
        }
    }
}

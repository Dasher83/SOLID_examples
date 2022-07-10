﻿using SOLID_L.Models.Characters.Playable;
using SOLID_L.Shared.Interfaces;

namespace SOLID_L.Models
{
    internal class Player
    {
        private string id;
        private string username;
        private DateTime createdAt;
        private List<PlayableCharacter> characters;
        public Player(string username)
        {
            id = Guid.NewGuid().ToString();
            this.username = username;
            createdAt = DateTime.UtcNow;
            characters = new List<PlayableCharacter>();
        }

        public List<IFighter> Characters
        {
            get
            {
                List<IFighter> listOfCharacters = new List<IFighter>();
                foreach (PlayableCharacter character in characters)
                {
                    listOfCharacters.Add(character);
                }
                return listOfCharacters;
            }
        }

        public void AddCharacter(PlayableCharacter character)
        {
            characters.Add(character);
        }
    }
}

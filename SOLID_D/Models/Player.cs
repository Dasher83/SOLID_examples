using SOLID_D.Models.Characters.Playable;
using SOLID_D.Shared.Interfaces;

namespace SOLID_D.Models
{
    internal class Player: IPlayer
    {
        private string id;
        private string username;
        private DateTime createdAt;
        private List<IPlayableCharacter> characters;
        public Player(string username)
        {
            id = Guid.NewGuid().ToString();
            this.username = username;
            createdAt = DateTime.UtcNow;
            characters = new List<IPlayableCharacter>();
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

        public void AddCharacter(IPlayableCharacter character)
        {
            characters.Add(character);
        }
    }
}

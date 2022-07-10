namespace SOLID_D.Shared.Interfaces
{
    internal interface IPlayer
    {
        public List<IFighter> Characters { get; }

        public void AddCharacter(IPlayableCharacter character);
    }
}

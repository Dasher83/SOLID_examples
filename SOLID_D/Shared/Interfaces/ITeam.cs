namespace SOLID_D.Shared.Interfaces
{
    internal interface ITeam
    {
        public IPlayableCharacter Leader { get; }
        public List<IPlayableCharacter> Members { get; }
        public void AddMember(IPlayableCharacter member);
    }
}

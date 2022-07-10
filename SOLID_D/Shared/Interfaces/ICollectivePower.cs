namespace SOLID_D.Shared.Interfaces
{
    internal interface ICollectivePower
    {
        public abstract double OverallBattlePower { get; }

        public double AverageBattlePower { get; }
    }
}

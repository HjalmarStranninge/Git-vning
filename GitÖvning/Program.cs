namespace GitÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight Garen = new Knight();
            Garen.Age = 30;
            Garen.Strength = 250;
            Garen.HP = 4000;
            Garen.Name = "Garen";

            Garen.PrintInfo();
            Garen.BattleSound();
        }
    }
}

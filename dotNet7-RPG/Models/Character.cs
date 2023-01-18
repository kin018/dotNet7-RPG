namespace dotNet7_RPG.Models
{
   public class Character
   {
      public int Id { get; set; }
      public string Name { get; set; } = "Frodo"; //public string? Name { get; set; } is the null-able version instead of hard coding in a value
      public int HitPoints { get; set; } = 100;
      public int Strength { get; set; } = 10;
      public int Defense { get; set; } = 10;
      public int Intelligence { get; set; } = 10;
      public RpgClass Class { get; set; } = RpgClass.Knight;
   }
}
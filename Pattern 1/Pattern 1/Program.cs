using System;
namespace GuitarProcessor.Prototype
{
  public class Guitar_Scenec
  {
    public string Name { get; set; }
    public int Gain { get; set; }
    public int Level { get; set; }
    public int Delay { get; set; }

    public Guitar_Scenec(string name, int gain, int level, int delay)
    {
      Name = name;
      Gain = gain;
      Level = level;
      Delay = delay;
    }

    public Guitar_Scenec Clone()
    {
      return (Guitar_Scenec)MemberwiseClone();
    }

    public void Show()
    {
      Console.WriteLine($"{Name} | Gain:{Gain}, Level:{Level}, Delay:{Delay}");
    }
  }

  class Program
  {
    static void Main()
    {
      var Clean_Scenec = new Guitar_Scenec("Clean", gain: 2, level: 5, delay: 1);
      var Lead_Scenec = new Guitar_Scenec("Lead", gain: 7, level: 6, delay: 3);
      var Ambient_Scenec = new Guitar_Scenec("Ambient", gain: 3, level: 4, delay: 5);


      var song1Scen = Clean_Scenec.Clone();
      song1Scen.Name = "Clean - Song 1";
      song1Scen.Delay = 2;

      var song2Scen = Lead_Scenec.Clone();
      song2Scen.Name = "Praise";
      song2Scen.Gain = 10;

      var song3Scen = Ambient_Scenec.Clone();
      song3Scen.Name = "Testimony";
      song3Scen.Level = 3;


      Clean_Scenec.Show();
      Lead_Scenec.Show();
      song2Scen.Show();
      song1Scen.Show();
    }
  }
}

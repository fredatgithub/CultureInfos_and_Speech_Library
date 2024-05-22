using System.Globalization;
using System.Speech.Synthesis;

namespace CultureInfos
{
  internal class Program
  {
    static void Main()
    {
      var Builder = new PromptBuilder();
      SpeechSynthesizer synth = new();
      synth.SetOutputToDefaultAudioDevice();
      string voice = "Ceci est un test pour écouter comment une voix synthétique prononce du texte";
      Console.WriteLine(voice);

      Builder.StartVoice(new CultureInfo("fr-FR"));
      Builder.EndVoice();
      Builder.AppendText(voice);
      synth.Speak(Builder);

      DateTime dateTime = DateTime.Now;
      CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");
      string Time = dateTime.ToString("dddd,dd MMM yyyy", culture);
      Console.WriteLine(Time);
      Console.ReadKey();
    }
  }
}

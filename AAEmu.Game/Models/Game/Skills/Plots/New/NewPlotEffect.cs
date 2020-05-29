using AAEmu.Game.Models.Game.Skills.Effects;
using AAEmu.Game.Models.Game.Skills.Plots.Type;

namespace AAEmu.Game.Models.Game.Skills.Plots.New
{
    public class NewPlotEffect
    {
        public NewPlotEventTemplate Event { get; set; }
        public int Position { get; set; }
        public PlotEffectSource Source { get; set; }
        public PlotEffectSource Target { get; set; }
        public int EffectId { get; set; }
        public string EffectType { get; set; }

        public void Apply()
        {
            
        }
    }
}
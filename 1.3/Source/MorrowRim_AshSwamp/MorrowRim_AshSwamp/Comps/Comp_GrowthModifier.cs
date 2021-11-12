using RimWorld;
using Verse;

namespace MorrowRim_AshSwamp
{
    class Comp_GrowthModifier : ThingComp
    {
        public CompProperties_GrowthModifier Props
        {
            get
            {
                return (CompProperties_GrowthModifier)this.props;
            }
        }

        public override void CompTickLong()
        {
            base.CompTickLong();
            Plant plant = parent as Plant;
            if (!plant.Position.Roofed(plant.Map) && Props.weather.Contains(plant.Map.weatherManager.curWeather) && plant.Growth >= Props.minGrowth)
            {
                plant.Growth += Props.amount;
            }
        }
    }
}

using System;
using Verse;
using RimWorld;
using System.Collections.Generic;


namespace MorrowRim_AshSwamp
{
    class CompProperties_GrowthModifier : CompProperties
    {
		public CompProperties_GrowthModifier()
		{
			this.compClass = typeof(Comp_GrowthModifier);
		}
		public List<WeatherDef> weather;
		public float amount = 0.05f;
		public float minGrowth = 0.1f;
	}
}

using System;
using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	class CompProperties_PlantSpawner : CompProperties
	{
		public CompProperties_PlantSpawner()
		{
			this.compClass = typeof(Comp_PlantSpawner);
		}
		public ThingDef thing = null;
		public int amount = 1;
		public float growthDecrease = 0.5f;
		public float growthMin = 0.7f;
		public float radius = 0f;
		public SoundDef sound = null;
	}
}
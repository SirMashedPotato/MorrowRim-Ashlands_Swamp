using System;
using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
    class CompProperties_PlantDischargeOnMature : CompProperties
	{
		public CompProperties_PlantDischargeOnMature()
		{
			this.compClass = typeof(Comp_PlantDischargeOnMature);
		}
		public ThingDef thing = null;
		public float growthMin = 1f;
		public float growthDecrease = 0.5f;
		public DamageDef explosionDamage = null;
		public int explosionDamageNum = 3;
		public float explosionRadius = 2f;
		public SoundDef sound = null;
	}
}

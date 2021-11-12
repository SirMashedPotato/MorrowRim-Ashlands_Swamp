using System;
using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	class CompProperties_Discharge : CompProperties
	{
		public CompProperties_Discharge()
		{
			this.compClass = typeof(Comp_Discharge);
		}
		public HediffDef Hediff;
		public float Radius = 3;
		public int Damage = 20;
		public SoundDef Sound;
	}
}
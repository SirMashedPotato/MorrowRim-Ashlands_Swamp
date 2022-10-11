using System;
using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
    class Comp_Discharge : ThingComp
    {
		public CompProperties_Discharge Props
		{
			get
			{
				return (CompProperties_Discharge)this.props;
			}
		}

		public override void PostPostApplyDamage(DamageInfo dinfo, float totalDamageDealt)
		{
			base.PostPostApplyDamage(dinfo, totalDamageDealt);
			Pawn pawn = parent as Pawn;
			if (!pawn.health.hediffSet.HasHediff(Props.Hediff)){
				//gen explosion
				DoDischarge(pawn);
				pawn.health.AddHediff(Props.Hediff).Severity = 1;
			}
		}

		private void DoDischarge(Pawn pawn)
		{
			GenExplosion.DoExplosion(pawn.Position, pawn.Map, Props.Radius, DamageDefOf.EMP, pawn, Props.Damage, -1, Props.Sound);
		}
	}
}

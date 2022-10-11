using System;
using Verse;
using RimWorld;
using Verse.Sound;

namespace MorrowRim_AshSwamp
{
    class Comp_PlantDischargeOnMature : ThingComp
    {
		public CompProperties_PlantDischargeOnMature Props
		{
			get
			{
				return (CompProperties_PlantDischargeOnMature)this.props;
			}
		}

        public override void CompTickLong()
        {
            base.CompTickLong();
            /* settings check */
            if (parent.def == ThingDefOf.MorrowRim_FulgurSpore && !ModSettings_Utility.MorrowRim_enableFulgurSpores()) return;
            if (parent is Plant)
            {
                Plant p = parent as Plant;
                if(p.Growth == Props.growthMin)
                {
                    if(Props.explosionDamage != null)
                    {
						DoExplosion(p);
                    }
                    if (Props.growthDecrease != 0f)
                    {
						p.Growth -= Props.growthDecrease;
					}
                }
            }
        }

		private void DoExplosion(Plant p)
        {
			GenExplosion.DoExplosion(p.Position, p.Map, Props.explosionRadius, Props.explosionDamage, p, Props.explosionDamageNum, -1, Props.sound);
		}
	}
}

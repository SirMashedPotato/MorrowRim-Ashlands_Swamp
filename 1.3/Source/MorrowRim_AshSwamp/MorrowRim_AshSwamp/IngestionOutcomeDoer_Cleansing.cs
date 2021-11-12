using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	/* Based on  IngestionOutcomeDoer_GiveHediff */
	public class IngestionOutcomeDoer_Cleansing : IngestionOutcomeDoer
	{
		protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
		{
			float q;
			ingested.TryGetQuality(out QualityCategory qc);
			q = (float)qc;
			float actual = (q++) / 10;
			Hediff hediff = pawn.health.hediffSet.GetFirstHediffOfDef(hediffDef);
			if (hediff != null)
			{
				if (qc == QualityCategory.Legendary || hediff.Severity <= actual)
				{
					pawn.health.RemoveHediff(hediff);
				}
				else
				{
					pawn.health.hediffSet.GetFirstHediffOfDef(hediffDef).Severity = hediff.Severity - actual;
				}
			}
		}
		public HediffDef hediffDef;
	}
}
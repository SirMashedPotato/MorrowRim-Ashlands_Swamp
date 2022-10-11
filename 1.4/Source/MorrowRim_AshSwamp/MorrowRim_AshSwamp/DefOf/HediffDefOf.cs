using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	[DefOf]
	public static class HediffDefOf
	{
		static HediffDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
		}

		public static HediffDef MorrowRim_BionicFilter;
	}
}
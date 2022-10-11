using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	[DefOf]
	public static class ThingDefOf
	{
		static ThingDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
		}

		public static ThingDef MorrowRim_MiasmaSponge;
		public static ThingDef MorrowRim_FulgurSpore;
	}
}
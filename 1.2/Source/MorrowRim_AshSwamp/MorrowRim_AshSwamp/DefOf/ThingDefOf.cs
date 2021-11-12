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

		public static ThingDef MorrowRim_DraggleTails;
		public static ThingDef MorrowRim_SloughFern;
		public static ThingDef MorrowRim_FilterFern;
		public static ThingDef MorrowRim_WeepingParasol;
		public static ThingDef MorrowRim_FunnelCap;
		public static ThingDef MorrowRim_CorkBulb_Wild;
		public static ThingDef MorrowRim_HackleLo_Wild;
		public static ThingDef MorrowRim_LuminousRussula;
		public static ThingDef MorrowRim_VioletCoprinus;
		public static ThingDef MorrowRim_MiasmaSponge;
		public static ThingDef MorrowRim_FulgurSpore;
	}
}
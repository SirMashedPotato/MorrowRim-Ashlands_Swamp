using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
	[DefOf]
	public static class TerrainDefOf
	{
		static TerrainDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(TerrainDefOf));
		}

		// Token: 0x04003CFB RID: 15611
		public static TerrainDef MorrowRim_StonyAsh;
		public static TerrainDef MorrowRim_SandyAsh;

		public static TerrainDef Marsh;
		public static TerrainDef MorrowRim_WateryAsh;
		public static TerrainDef MarshyTerrain;
	}
}
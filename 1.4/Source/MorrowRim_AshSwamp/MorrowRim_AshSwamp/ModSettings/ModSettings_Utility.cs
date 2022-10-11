using Verse;

namespace MorrowRim_AshSwamp
{
    class ModSettings_Utility
    {
        public static bool MorrowRim_enableMiasmaClouds()
        {
            return LoadedModManager.GetMod<AshSwamp_Mod>().GetSettings<AshSwamp_ModSettings>().MorrowRim_enableMiasmaClouds;
        }

        public static bool MorrowRim_enableFulgurSpores()
        {
            return LoadedModManager.GetMod<AshSwamp_Mod>().GetSettings<AshSwamp_ModSettings>().MorrowRim_enableFulgurSpores;
        }
    }
}

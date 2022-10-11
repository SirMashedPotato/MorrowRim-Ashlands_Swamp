using Verse;

namespace MorrowRim_AshSwamp
{
    class AshSwamp_ModSettings : ModSettings
    {
        //settings
        public bool MorrowRim_enableMiasmaClouds = MorrowRim_enableMiasmaClouds_def;
        public bool MorrowRim_enableFulgurSpores = MorrowRim_enableFulgurSpores_def;

        //defaults
        public static readonly bool MorrowRim_enableMiasmaClouds_def = true;
        public static readonly bool MorrowRim_enableFulgurSpores_def = true;

        //save settings
        public override void ExposeData()
        {
            Scribe_Values.Look(ref MorrowRim_enableMiasmaClouds, "MorrowRim_enableMiasmaClouds", MorrowRim_enableMiasmaClouds_def);
            Scribe_Values.Look(ref MorrowRim_enableFulgurSpores, "MorrowRim_enableFulgurSpores", MorrowRim_enableFulgurSpores_def);
            base.ExposeData();
        }
    }
}

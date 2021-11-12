using UnityEngine;
using Verse;

namespace MorrowRim_AshSwamp
{
    class AshSwamp_Mod : Mod
    {
        AshSwamp_ModSettings settings;
        public AshSwamp_Mod(ModContentPack contentPack) : base(contentPack)
        {
            this.settings = GetSettings<AshSwamp_ModSettings>();
        }

        public override string SettingsCategory() => "MorrowRim - Ashlands Swamp";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);

            /* weather */

            listing_Standard.CheckboxLabeled("MorrowRim_enableMiasmaClouds".Translate(), ref settings.MorrowRim_enableMiasmaClouds);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("MorrowRim_enableFulgurSpores".Translate(), ref settings.MorrowRim_enableFulgurSpores);
            listing_Standard.Gap();

            listing_Standard.End();
            base.DoSettingsWindowContents(inRect);
        }
    }
}


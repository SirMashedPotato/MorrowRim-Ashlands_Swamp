using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection.Emit;
using System.Linq;

namespace MorrowRim_AshSwamp
{
    class WeatherEvent_ToxicMiasma : WeatherEvent
    {
        public WeatherEvent_ToxicMiasma(Map map) : base(map)
        {
        }

        public override bool Expired
        {
            get
            {
                return this.age > this.duration;
            }
        }

        public override void FireEvent()
        {
            /*if (map.weatherManager.curWeather == WeatherDefOf.MorrowRim_ToxicMiasma && map.weatherManager.curWeatherAge <= 1)
            {
                return;
            }*/
            List<Pawn> allPawnsSpawned = map.mapPawns.AllPawnsSpawned;
            for (int i = 0; i < allPawnsSpawned.Count; i++)
            {
                WeatherEvent_ToxicMiasma.doTheThingToPawns(allPawnsSpawned[i]);
            }
        }

        public static void doTheThingToPawns(Pawn p)
        {
            //check if roofed
            if (p.Spawned && p.Position.Roofed(p.Map))
            {
                return;
            }
            
            //check if flesh
            if (!p.RaceProps.IsFlesh)
            {
                return;
            }

            //check if human, then check if face is covered
            if (p.def.race.Humanlike)
            {
                string[] apparelList = new string[] {
                    /*Rimatomics*/ "Apparel_RadiationMask", "Apparel_MoppMaskDesert", "Apparel_MoppMaskWoodland", "Apparel_MoppMaskSnow"
                };
                if (p.apparel.WornApparel.Any(x => apparelList.Contains(x.def.defName.ToString())))
                {
                    return;
                }
            }

            //check if they can actually breathe
            if (p.RaceProps.body.GetPartsWithTag(BodyPartTagDefOf.BreathingSource) == null)
            {
                return;
            }

            //check for filter implant
            if (p.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.MorrowRim_BionicFilter) != null)
            {
                return;
            }

            //increase toxic buildup
            WeatherEvent_ToxicMiasma.DoPawnToxicDamage(p);
        }

        public static void DoPawnToxicDamage(Pawn p)
        {
            //float num = 0.028758334f;
            float num = 0.028758334f;
            num *= p.GetStatValue(StatDefOf.ToxicSensitivity, true);
            if (num != 0f)
            {
                float num2 = Mathf.Lerp(0.85f, 1.15f, Rand.ValueSeeded(p.thingIDNumber ^ 74374237));
                num *= num2;
                HealthUtility.AdjustSeverity(p, RimWorld.HediffDefOf.ToxicBuildup, num);
            }
        }

        public override void WeatherEventTick()
        {
            this.age++;
        }

        private int age;
        private int duration;
    }
}

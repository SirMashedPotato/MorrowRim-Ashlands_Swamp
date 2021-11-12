﻿using System;
using RimWorld.Planet;
using RimWorld;

namespace MorrowRim_AshSwamp
{
    class BiomeWorker_AshSwamp : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature <= 0 - 10f)
            {
                return 0f;
            }
            if ((tile.rainfall < 500f) || (tile.rainfall >= 3000f))
            {
                return 0f;
            }
            if (tile.swampiness < 0.5f)
            {
                return 0f;
            }
            return 22.5f + (tile.temperature - 20f) * 2.2f + (tile.rainfall - 600f) / 100f;
        }

    }
}
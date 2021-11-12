using System;
using Verse;
using RimWorld;
using Verse.Sound;

namespace MorrowRim_AshSwamp
{
    class Comp_PlantSpawner : ThingComp
    {
		public CompProperties_PlantSpawner Props
		{
			get
			{
				return (CompProperties_PlantSpawner)this.props;
			}
		}

		public override void CompTickLong()
		{
			base.CompTickLong();
			if (parent.def == ThingDefOf.MorrowRim_MiasmaSponge && !ModSettings_Utility.MorrowRim_enableMiasmaClouds()) return;
			if (Props.thing != null)
			{
				Plant plant = parent as Plant;
				if(plant.Growth >= Props.growthMin)
				{
					plant.Growth -= Props.growthDecrease;
					DoSpawn(plant);


				}
			}
		}

		private void DoSpawn(Plant plant)
		{
			if (Props.sound != null)
			{
				Props.sound.PlayOneShot(new TargetInfo(plant.Position, plant.Map, false));
			}
			if (Props.radius == 0)
			{
				GenSpawn.Spawn(Props.thing, plant.Position, plant.Map);
			}
			else
			{
				int radius = GenRadial.NumCellsInRadius(Props.radius);
				for (int i = 0; i != radius; i++)
				{
					IntVec3 tile = plant.Position + GenRadial.RadialPattern[i];
					if (tile.InBounds(plant.Map))
					{
						GenSpawn.Spawn(Props.thing, tile, plant.Map);
					}
				}
			}
		}

	}
}

using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace MorrowRim_AshSwamp
{
    [StaticConstructorOnStartup]
    class WeatherOverlay_ToxicMiasma : SkyOverlay
    {
		public WeatherOverlay_ToxicMiasma()
		{
			this.worldOverlayMat = WeatherOverlay_ToxicMiasma.FogOverlayWorld;
			base.OverlayColor = new Color(250f, 255f, 250f, 0.1f);
			this.worldOverlayPanSpeed1 = 0.0005f;
			this.worldOverlayPanSpeed2 = 0.0004f;
			this.worldPanDir1 = new Vector2(1f, 1f);
			this.worldPanDir2 = new Vector2(1f, -1f);
		}
		private static readonly Material FogOverlayWorld = MatLoader.LoadMat("Weather/FogOverlayWorld", -1);
	}
}

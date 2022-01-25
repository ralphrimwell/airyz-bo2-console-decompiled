using System;
using System.Collections.Generic;

namespace BO2_Console_V4.Info
{
	// Token: 0x02000053 RID: 83
	public static class DefaultFogs
	{
		// Token: 0x040002C3 RID: 707
		public static Dictionary<string, Structures.Fog> Defaults = new Dictionary<string, Structures.Fog>
		{
			{
				"map_name",
				new Structures.Fog
				{
					startDist = 100f,
					fogColor = new Structures.flColor
					{
						r = 10f,
						g = 50f,
						b = 10f
					}
				}
			},
			{
				"mp_la",
				new Structures.Fog
				{
					startDist = 471.25f,
					fadeDist = 4070.898f,
					startHeight = -81.25f,
					fadeHeight = 1650.967f,
					sunHazePitchAngle = -41.715f,
					sunHazeYawAngle = 92.20499f,
					hazeInnerRadius = 5.05125f,
					hazeOuterRadius = 54.945f,
					fogColor = new Structures.flColor
					{
						r = 1.866311f,
						g = 2.506295f,
						b = 2.794348f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 5.115763f,
						g = 4.077024f,
						b = 2.252481f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_dockside",
				new Structures.Fog
				{
					startDist = 202.5f,
					fadeDist = 2808.43f,
					startHeight = 0f,
					fadeHeight = 877.5449f,
					sunHazePitchAngle = -36.63f,
					sunHazeYawAngle = -99.78751f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 56.21062f,
					fogColor = new Structures.flColor
					{
						r = 1.327015f,
						g = 1.999683f,
						b = 2.397493f
					},
					fogOpacity = 0.936844f,
					sunHazeColor = new Structures.flColor
					{
						r = 6.490641f,
						g = 4.995249f,
						b = 3.367997f
					},
					sunHazeOpacity = 0.91225f
				}
			},
			{
				"mp_carrier",
				new Structures.Fog
				{
					startDist = 210.625f,
					fadeDist = 19790.51f,
					startHeight = 100f,
					fadeHeight = 6668.055f,
					sunHazePitchAngle = -26.5275f,
					sunHazeYawAngle = 64.41751f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 66.31313f,
					fogColor = new Structures.flColor
					{
						r = 2.283752f,
						g = 2.264661f,
						b = 2.582f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 5.502f,
						g = 4.948421f,
						b = 4.199631f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_drone",
				new Structures.Fog
				{
					startDist = 186.875f,
					fadeDist = 4210.895f,
					startHeight = 140.625f,
					fadeHeight = 390.0547f,
					sunHazePitchAngle = -59.3775f,
					sunHazeYawAngle = -105.9975f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 61.26188f,
					fogColor = new Structures.flColor
					{
						r = 2.636256f,
						g = 4.127571f,
						b = 4.828f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 9.207f,
						g = 8.629385f,
						b = 7.540909f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_express",
				new Structures.Fog
				{
					startDist = 280.625f,
					fadeDist = 6597.085f,
					startHeight = 18.75f,
					fadeHeight = 1404.097f,
					sunHazePitchAngle = -26.5275f,
					sunHazeYawAngle = 175.59f,
					hazeInnerRadius = 6.946875f,
					hazeOuterRadius = 40.42125f,
					fogColor = new Structures.flColor
					{
						r = 5.40872f,
						g = 6.181082f,
						b = 6.472667f
					},
					fogOpacity = 0.771875f,
					sunHazeColor = new Structures.flColor
					{
						r = 13.159f,
						g = 11.31654f,
						b = 8.109635f
					},
					sunHazeOpacity = 0.8105f
				}
			},
			{
				"mp_hijacked",
				new Structures.Fog
				{
					startDist = 200f,
					fadeDist = 36631.34f,
					startHeight = -100f,
					fadeHeight = 10702.35f,
					sunHazePitchAngle = 199.98f,
					sunHazeYawAngle = -145.0125f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 88.41937f,
					fogColor = new Structures.flColor
					{
						r = 1.946802f,
						g = 2.575428f,
						b = 3.256f
					},
					fogOpacity = 0.9f,
					sunHazeColor = new Structures.flColor
					{
						r = 15.158f,
						g = 6.308809f,
						b = 4.644844f
					},
					sunHazeOpacity = 0.9f
				}
			},
			{
				"mp_meltdown",
				new Structures.Fog
				{
					startDist = 421.25f,
					fadeDist = 3930.902f,
					startHeight = 56.25f,
					fadeHeight = 352.5555f,
					sunHazePitchAngle = -33.03f,
					sunHazeYawAngle = -67.4325f,
					hazeInnerRadius = 5.05125f,
					hazeOuterRadius = 46.73812f,
					fogColor = new Structures.flColor
					{
						r = 3.501075f,
						g = 3.309013f,
						b = 3.159896f
					},
					fogOpacity = 0.954375f,
					sunHazeColor = new Structures.flColor
					{
						r = 10.85963f,
						g = 5.241024f,
						b = 2.694884f
					},
					sunHazeOpacity = 0.522781f
				}
			},
			{
				"mp_overflow",
				new Structures.Fog
				{
					startDist = 300f,
					fadeDist = 3228.419f,
					startHeight = 50.00391f,
					fadeHeight = 1049.417f,
					sunHazePitchAngle = -21.465f,
					sunHazeYawAngle = 155.34f,
					hazeInnerRadius = 6.946875f,
					hazeOuterRadius = 34.73438f,
					fogColor = new Structures.flColor
					{
						r = 4.484316f,
						g = 5.844154f,
						b = 6.362255f
					},
					fogOpacity = 0.70525f,
					sunHazeColor = new Structures.flColor
					{
						r = 2.956371f,
						g = 2.827996f,
						b = 1.744385f
					},
					sunHazeOpacity = 0.856125f
				}
			},
			{
				"mp_nightclub",
				new Structures.Fog
				{
					startDist = 210.625f,
					fadeDist = 13334.42f,
					startHeight = -131.25f,
					fadeHeight = 3510.305f,
					sunHazePitchAngle = -41.715f,
					sunHazeYawAngle = 41.6925f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 75.79125f,
					fogColor = new Structures.flColor
					{
						r = 0.4907385f,
						g = 0.7384214f,
						b = 1.215147f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 2.506563f,
						g = 3.62461f,
						b = 5.370259f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_raid",
				new Structures.Fog
				{
					startDist = 200f,
					fadeDist = 40000f,
					startHeight = -100f,
					fadeHeight = 18070.95f,
					sunHazePitchAngle = -36.63f,
					sunHazeYawAngle = -233.01f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 37.26563f,
					fogColor = new Structures.flColor
					{
						r = 7.693051f,
						g = 9.247441f,
						b = 11.902f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 12.014f,
						g = 10.09732f,
						b = 8.294711f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_slums",
				new Structures.Fog
				{
					startDist = 350.625f,
					fadeDist = 5999.6f,
					startHeight = 653.125f,
					fadeHeight = 877.5449f,
					sunHazePitchAngle = -42.00748f,
					sunHazeYawAngle = 148.005f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 70.73438f,
					fogColor = new Structures.flColor
					{
						r = 6.92809f,
						g = 7.437491f,
						b = 8.760055f
					},
					fogOpacity = 0.736844f,
					sunHazeColor = new Structures.flColor
					{
						r = 11.902f,
						g = 9.329444f,
						b = 4.953652f
					},
					sunHazeOpacity = 0.778938f
				}
			},
			{
				"mp_village",
				new Structures.Fog
				{
					startDist = 196.875f,
					fadeDist = 15719.36f,
					startHeight = 62.5f,
					fadeHeight = 352.5555f,
					sunHazePitchAngle = 212.6025f,
					sunHazeYawAngle = -49.2525f,
					hazeInnerRadius = 6.946875f,
					hazeOuterRadius = 34.73438f,
					fogColor = new Structures.flColor
					{
						r = 3.178708f,
						g = 5.181635f,
						b = 7.298f
					},
					fogOpacity = 0.71925f,
					sunHazeColor = new Structures.flColor
					{
						r = 5.162079f,
						g = 4.793771f,
						b = 3.552519f
					},
					sunHazeOpacity = 0.856125f
				}
			},
			{
				"mp_turbine",
				new Structures.Fog
				{
					startDist = 220f,
					fadeDist = 6597.085f,
					startHeight = 315.625f,
					fadeHeight = 1046.292f,
					sunHazePitchAngle = -24.00751f,
					sunHazeYawAngle = 109.89f,
					hazeInnerRadius = 15.78937f,
					hazeOuterRadius = 37.89563f,
					fogColor = new Structures.flColor
					{
						r = 7.602443f,
						g = 7.066451f,
						b = 4.724855f
					},
					fogOpacity = 0.607f,
					sunHazeColor = new Structures.flColor
					{
						r = 15.495f,
						g = 11.41003f,
						b = 5.258323f
					},
					sunHazeOpacity = 0.775375f
				}
			},
			{
				"mp_socotra",
				new Structures.Fog
				{
					startDist = 131.875f,
					fadeDist = 1123.472f,
					startHeight = -6490.625f,
					fadeHeight = 2632.198f,
					sunHazePitchAngle = -36.63f,
					sunHazeYawAngle = -122.535f,
					hazeInnerRadius = 5.05125f,
					hazeOuterRadius = 39.79125f,
					fogColor = new Structures.flColor
					{
						r = 7.049898f,
						g = 7.113116f,
						b = 6.31512f
					},
					fogOpacity = 0.571938f,
					sunHazeColor = new Structures.flColor
					{
						r = 22.59463f,
						g = 21.4256f,
						b = 15.96284f
					},
					sunHazeOpacity = 0.954375f
				}
			},
			{
				"mp_nuketown_2020",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 12630.68f,
					startHeight = -200f,
					fadeHeight = 3333.746f,
					sunHazePitchAngle = -37.01251f,
					sunHazeYawAngle = 220.995f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 29.68312f,
					fogColor = new Structures.flColor
					{
						r = 4.225669f,
						g = 7.449696f,
						b = 10.891f
					},
					fogOpacity = 0.8035f,
					sunHazeColor = new Structures.flColor
					{
						r = 14.1642f,
						g = 20.60124f,
						b = 22.344f
					},
					sunHazeOpacity = 0.8f
				}
			},
			{
				"mp_downhill",
				new Structures.Fog
				{
					startDist = 350.625f,
					fadeDist = 4492.138f,
					startHeight = 1090.629f,
					fadeHeight = 1133.79f,
					sunHazePitchAngle = -147.78f,
					sunHazeYawAngle = 195.795f,
					hazeInnerRadius = 5.68125f,
					hazeOuterRadius = 42.31688f,
					fogColor = new Structures.flColor
					{
						r = 7.971484f,
						g = 8.844243f,
						b = 10.56107f
					},
					fogOpacity = 0.70525f,
					sunHazeColor = new Structures.flColor
					{
						r = 12.18874f,
						g = 9.858136f,
						b = 7.661362f
					},
					sunHazeOpacity = 0.72275f
				}
			},
			{
				"mp_mirage",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 3930.902f,
					startHeight = 75f,
					fadeHeight = 449.4285f,
					sunHazePitchAngle = -37.01251f,
					sunHazeYawAngle = 61.01999f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 37.89563f,
					fogColor = new Structures.flColor
					{
						r = 7.380338f,
						g = 4.496122f,
						b = 2.531552f
					},
					fogOpacity = 0.961375f,
					sunHazeColor = new Structures.flColor
					{
						r = 19.04858f,
						g = 15.76961f,
						b = 7.827929f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_hydro",
				new Structures.Fog
				{
					startDist = 200f,
					fadeDist = 34998.88f,
					startHeight = -1931.25f,
					fadeHeight = 4913.402f,
					sunHazePitchAngle = -61.91998f,
					sunHazeYawAngle = 142.74f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 73.89f,
					fogColor = new Structures.flColor
					{
						r = 4.183841f,
						g = 5.738887f,
						b = 6.6f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 23f,
						g = 17.09007f,
						b = 12.17625f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_skate",
				new Structures.Fog
				{
					startDist = 550f,
					fadeDist = 4199.645f,
					startHeight = 175f,
					fadeHeight = 877.5449f,
					sunHazePitchAngle = -120.015f,
					sunHazeYawAngle = -6.32251f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 82.73812f,
					fogColor = new Structures.flColor
					{
						r = 1.904238f,
						g = 3.191708f,
						b = 3.964241f
					},
					fogOpacity = 0.75f,
					sunHazeColor = new Structures.flColor
					{
						r = 2.153524f,
						g = 3.802355f,
						b = 4.607994f
					},
					sunHazeOpacity = 0.75f
				}
			},
			{
				"mp_concert",
				new Structures.Fog
				{
					startDist = 210.625f,
					fadeDist = 7299.568f,
					startHeight = -15.625f,
					fadeHeight = 1530.657f,
					sunHazePitchAngle = 360f,
					sunHazeYawAngle = -198.315f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 52.41938f,
					fogColor = new Structures.flColor
					{
						r = 2.264146f,
						g = 2.611578f,
						b = 3.136674f
					},
					fogOpacity = 0.933344f,
					sunHazeColor = new Structures.flColor
					{
						r = 4.92871f,
						g = 2.663701f,
						b = 1.961143f
					},
					sunHazeOpacity = 0.8f
				}
			},
			{
				"mp_magma",
				new Structures.Fog
				{
					startDist = 100f,
					fadeDist = 4773.381f,
					startHeight = -600f,
					fadeHeight = 1580.656f,
					sunHazePitchAngle = -34.01999f,
					sunHazeYawAngle = 245.9925f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 104.2087f,
					fogColor = new Structures.flColor
					{
						r = 0.8601839f,
						g = 1.387084f,
						b = 1.761049f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 5f,
						g = 4.347642f,
						b = 3.748798f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_vertigo",
				new Structures.Fog
				{
					startDist = 15f,
					fadeDist = 6999.575f,
					startHeight = -7118.75f,
					fadeHeight = 3510.305f,
					sunHazePitchAngle = -25.02002f,
					sunHazeYawAngle = -128.0025f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 80.8425f,
					fogColor = new Structures.flColor
					{
						r = 4f,
						g = 3.842604f,
						b = 3.478113f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 5f,
						g = 4.797701f,
						b = 4.344497f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_studio",
				new Structures.Fog
				{
					startDist = 1052.5f,
					fadeDist = 13755.66f,
					startHeight = -75f,
					fadeHeight = 611.9253f,
					sunHazePitchAngle = -46.73248f,
					sunHazeYawAngle = 74.52002f,
					hazeInnerRadius = 1.895625f,
					hazeOuterRadius = 54.945f,
					fogColor = new Structures.flColor
					{
						r = 12.5815f,
						g = 11.41003f,
						b = 13.93598f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 6.4f,
						g = 4.926209f,
						b = 6.4f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_uplink",
				new Structures.Fog
				{
					startDist = 0f,
					fadeDist = 899.7275f,
					startHeight = 0f,
					fadeHeight = 527.552f,
					sunHazePitchAngle = -11.36249f,
					sunHazeYawAngle = 228.6225f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 56.21062f,
					fogColor = new Structures.flColor
					{
						r = 0.6914986f,
						g = 0.9438397f,
						b = 1.114079f
					},
					fogOpacity = 0.51575f,
					sunHazeColor = new Structures.flColor
					{
						r = 1.431952f,
						g = 1.823552f,
						b = 1.999183f
					},
					sunHazeOpacity = 0.564875f
				}
			},
			{
				"mp_bridge",
				new Structures.Fog
				{
					startDist = 0f,
					fadeDist = 13614.41f,
					startHeight = -200f,
					fadeHeight = 2457.201f,
					sunHazePitchAngle = -59.3775f,
					sunHazeYawAngle = 326.295f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 94.73624f,
					fogColor = new Structures.flColor
					{
						r = 1.640995f,
						g = 1.848058f,
						b = 2.021f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 5.833008f,
						g = 3.245303f,
						b = 1.092128f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_castaway",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 7018.324f,
					startHeight = 100f,
					fadeHeight = 352.5555f,
					sunHazePitchAngle = -120.015f,
					sunHazeYawAngle = -6.32251f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 0f,
					fogColor = new Structures.flColor
					{
						r = 1.102963f,
						g = 2.311849f,
						b = 2.971079f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 2.36075f,
						g = 3.524108f,
						b = 4.00062f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"mp_paintball",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 7860.804f,
					startHeight = 65.625f,
					fadeHeight = 2105.646f,
					sunHazePitchAngle = -36.63f,
					sunHazeYawAngle = -329.715f,
					hazeInnerRadius = 5.05125f,
					hazeOuterRadius = 37.89563f,
					fogColor = new Structures.flColor
					{
						r = 5.817296f,
						g = 6.448908f,
						b = 6.687419f
					},
					fogOpacity = 0.50875f,
					sunHazeColor = new Structures.flColor
					{
						r = 12.76706f,
						g = 11.66955f,
						b = 9.37893f
					},
					sunHazeOpacity = 0.407f
				}
			},
			{
				"mp_dig",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 4499.638f,
					startHeight = -100f,
					fadeHeight = 1999.398f,
					sunHazePitchAngle = -29.02499f,
					sunHazeYawAngle = 253.9575f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 80.8425f,
					fogColor = new Structures.flColor
					{
						r = 2.357661f,
						g = 3.106892f,
						b = 3.847156f
					},
					fogOpacity = 0.52625f,
					sunHazeColor = new Structures.flColor
					{
						r = 5.27939f,
						g = 4.73051f,
						b = 3.880285f
					},
					sunHazeOpacity = 0.673688f
				}
			},
			{
				"mp_frostbite",
				new Structures.Fog
				{
					startDist = 25f,
					fadeDist = 2499.688f,
					startHeight = 0f,
					fadeHeight = 877.5449f,
					sunHazePitchAngle = -36.63f,
					sunHazeYawAngle = 54.315f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 56.21062f,
					fogColor = new Structures.flColor
					{
						r = 1.327015f,
						g = 1.999683f,
						b = 2.685402f
					},
					fogOpacity = 0.936844f,
					sunHazeColor = new Structures.flColor
					{
						r = 7.877372f,
						g = 6.799073f,
						b = 5.169451f
					},
					sunHazeOpacity = 0.91225f
				}
			},
			{
				"mp_pod",
				new Structures.Fog
				{
					startDist = 250f,
					fadeDist = 4070.898f,
					startHeight = 0f,
					fadeHeight = 1497.845f,
					sunHazePitchAngle = -11.36249f,
					sunHazeYawAngle = -195.795f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 85.26375f,
					fogColor = new Structures.flColor
					{
						r = 2.743493f,
						g = 3.280422f,
						b = 3.5f
					},
					fogOpacity = 0.8f,
					sunHazeColor = new Structures.flColor
					{
						r = 3.133842f,
						g = 3.749054f,
						b = 4f
					},
					sunHazeOpacity = 0.8f
				}
			},
			{
				"mp_takeoff",
				new Structures.Fog
				{
					startDist = 200f,
					fadeDist = 7439.564f,
					startHeight = -300f,
					fadeHeight = 1580.656f,
					sunHazePitchAngle = -57.14999f,
					sunHazeYawAngle = -296.28f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 80.8425f,
					fogColor = new Structures.flColor
					{
						r = 4.027995f,
						g = 4.914246f,
						b = 6f
					},
					fogOpacity = 0.859656f,
					sunHazeColor = new Structures.flColor
					{
						r = 4.704378f,
						g = 5.736122f,
						b = 7f
					},
					sunHazeOpacity = 0.86f
				}
			},
			{
				"zm_transit",
				new Structures.Fog
				{
					startDist = 40f,
					fadeDist = 330.3747f,
					startHeight = -500f,
					fadeHeight = 499.4276f,
					sunHazePitchAngle = -155.0025f,
					sunHazeYawAngle = 62.99997f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 83.99812f,
					fogColor = new Structures.flColor
					{
						r = 0.2984383f,
						g = 0.1242995f,
						b = 0.07659156f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 0.7814701f,
						g = 0.2564911f,
						b = 0.1469749f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"zm_prison",
				new Structures.Fog
				{
					startDist = 100f,
					fadeDist = 983.4755f,
					startHeight = 196.875f,
					fadeHeight = 702.5485f,
					sunHazePitchAngle = -46.73248f,
					sunHazeYawAngle = 145.26f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 53.685f,
					fogColor = new Structures.flColor
					{
						r = 0.2094091f,
						g = 0.356643f,
						b = 0.444023f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 1.673501f,
						g = 2.734721f,
						b = 3.368f
					},
					sunHazeOpacity = 0.336844f
				}
			},
			{
				"zm_nuked",
				new Structures.Fog
				{
					startDist = 250f,
					fadeDist = 1999.7f,
					startHeight = -21.875f,
					fadeHeight = 949.4185f,
					sunHazePitchAngle = -39.14999f,
					sunHazeYawAngle = -140.22f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 60.63188f,
					fogColor = new Structures.flColor
					{
						r = 3.014352f,
						g = 5.055804f,
						b = 5.540473f
					},
					fogOpacity = 0.733344f,
					sunHazeColor = new Structures.flColor
					{
						r = 11.89219f,
						g = 16.51516f,
						b = 16.51516f
					},
					sunHazeOpacity = 1f
				}
			},
			{
				"zm_tomb",
				new Structures.Fog
				{
					startDist = 150f,
					fadeDist = 999.725f,
					startHeight = 315.625f,
					fadeHeight = 999.4175f,
					sunHazePitchAngle = -90f,
					sunHazeYawAngle = 234f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 69.47437f,
					fogColor = new Structures.flColor
					{
						r = 0.690934f,
						g = 1.124639f,
						b = 1.477577f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 0f,
						g = 0f,
						b = 0f
					},
					sunHazeOpacity = 0f
				}
			},
			{
				"zm_buried",
				new Structures.Fog
				{
					startDist = 25f,
					fadeDist = 474.7382f,
					startHeight = 0f,
					fadeHeight = 249.4325f,
					sunHazePitchAngle = -45f,
					sunHazeYawAngle = 0f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 0f,
					fogColor = new Structures.flColor
					{
						r = 0.2924221f,
						g = 0.2034818f,
						b = 0.1206749f
					},
					fogOpacity = 0.536844f,
					sunHazeColor = new Structures.flColor
					{
						r = 1f,
						g = 1f,
						b = 1f
					},
					sunHazeOpacity = 0.5f
				}
			},
			{
				"zm_highrise",
				new Structures.Fog
				{
					startDist = 50f,
					fadeDist = 299.7425f,
					startHeight = 2499.996f,
					fadeHeight = 258.8073f,
					sunHazePitchAngle = -34.10999f,
					sunHazeYawAngle = 216f,
					hazeInnerRadius = 0f,
					hazeOuterRadius = 51.15938f,
					fogColor = new Structures.flColor
					{
						r = 1.491456f,
						g = 1.441789f,
						b = 1.523575f
					},
					fogOpacity = 1f,
					sunHazeColor = new Structures.flColor
					{
						r = 3.294395f,
						g = 2.31163f,
						b = 1.692076f
					},
					sunHazeOpacity = 0.90175f
				}
			}
		};
	}
}

using System;
using System.Collections.Generic;

namespace BO2_Console_V4
{
	// Token: 0x02000015 RID: 21
	internal static class DvarsWithDesc
	{
		// Token: 0x04000095 RID: 149
		public static List<DvarEntry> DvarsWithDescriptions = new List<DvarEntry>
		{
			new DvarEntry
			{
				Name = "aim_aimAssistRangeScale",
				Description = "Scales the weapon's aim assist range"
			},
			new DvarEntry
			{
				Name = "aim_autoAimRangeScale",
				Description = "Scales the weapon's auto aim range"
			},
			new DvarEntry
			{
				Name = "aim_target_closest_first",
				Description = "Target the closest AI based on 3d distance"
			},
			new DvarEntry
			{
				Name = "aim_input_graph_enabled",
				Description = "Use graph for adjusting view input"
			},
			new DvarEntry
			{
				Name = "aim_input_graph_debug",
				Description = "Debug the view input graphs"
			},
			new DvarEntry
			{
				Name = "aim_input_graph_index",
				Description = "Which input graph to use"
			},
			new DvarEntry
			{
				Name = "aim_turnrate_pitch",
				Description = "The vertical turn rate for aim assist when firing from the hip"
			},
			new DvarEntry
			{
				Name = "aim_turnrate_pitch_ads",
				Description = "The turn rate up and down for aim assist when aiming down the sight"
			},
			new DvarEntry
			{
				Name = "aim_turnrate_yaw",
				Description = "The horizontal turn rate for aim assist when firing from the hip"
			},
			new DvarEntry
			{
				Name = "aim_turnrate_yaw_ads",
				Description = "The horizontal turn rate for aim assist when aiming down the sight"
			},
			new DvarEntry
			{
				Name = "aim_linkto_autorecenter_rate",
				Description = "The auto recenter rate used when the player is linked"
			},
			new DvarEntry
			{
				Name = "aim_linkto_autorecenter_delay",
				Description = "The auto recenter delay used when the player is linked"
			},
			new DvarEntry
			{
				Name = "aim_accel_turnrate_enabled",
				Description = "Enable/disable acceleration of the turnrates"
			},
			new DvarEntry
			{
				Name = "aim_accel_turnrate_debug",
				Description = "Turn on debugging info for the acceleration"
			},
			new DvarEntry
			{
				Name = "aim_accel_turnrate_lerp",
				Description = "The acceleration of the turnrates"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_enabled",
				Description = "Slowdown the turn rate when the cross hair passes over a target"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_debug",
				Description = "Turn on debugging info for aim slowdown"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_region_width",
				Description = "The screen width of the aim slowdown region"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_region_height",
				Description = "The screen height of the aim assist slowdown region"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_region_extended_width",
				Description = "The screen width of the extended aim slowdown region"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_region_extended_height",
				Description = "The screen height of the extended aim assist slowdown region"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_pitch_scale",
				Description = "The vertical aim assist slowdown ratio from the hip"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_pitch_scale_ads",
				Description = "The vertical aim assist slowdown ratio when aiming down the sight"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_yaw_scale",
				Description = "The horizontal aim assist slowdown ratio from the hip"
			},
			new DvarEntry
			{
				Name = "aim_slowdown_yaw_scale_ads",
				Description = "The horizontal aim assist slowdown ratio when aiming down the sight"
			},
			new DvarEntry
			{
				Name = "aim_autoaim_lerp",
				Description = "The rate in degrees per second that the auto aim will converge to its target"
			},
			new DvarEntry
			{
				Name = "aim_autoaim_enabled",
				Description = "Turn on auto aim"
			},
			new DvarEntry
			{
				Name = "aim_autoaim_debug",
				Description = "Turn on auto aim debugging"
			},
			new DvarEntry
			{
				Name = "aim_autoaim_region_width",
				Description = "The width of the auto aim region in virtual screen coordinates (0 - 640)"
			},
			new DvarEntry
			{
				Name = "aim_autoaim_region_height",
				Description = "The height of the auto aim region in virtual screen coordinates (0 - 480)"
			},
			new DvarEntry
			{
				Name = "aim_automelee_enabled",
				Description = "Turn on auto melee"
			},
			new DvarEntry
			{
				Name = "aim_automelee_debug",
				Description = "Turn on auto melee debugging"
			},
			new DvarEntry
			{
				Name = "aim_automelee_lerp",
				Description = "The rate in degrees per second that the auto melee will converge to its target"
			},
			new DvarEntry
			{
				Name = "aim_automelee_region_width",
				Description = "The width of the auto melee region in virtual screen coordinates (0 - 640)"
			},
			new DvarEntry
			{
				Name = "aim_automelee_region_height",
				Description = "The height of the auto melee region in virtual screen coordinates (0 - 480)"
			},
			new DvarEntry
			{
				Name = "aim_automelee_range",
				Description = "The range of the auto melee"
			},
			new DvarEntry
			{
				Name = "aim_automelee_move_limit",
				Description = "Speed at which player needs to be moving forward to activate the charge"
			},
			new DvarEntry
			{
				Name = "aim_automelee_move_limit_range",
				Description = "The range above which the player needs to be moving forward above the limit value for the charge to work"
			},
			new DvarEntry
			{
				Name = "aim_automelee_move_limit_angle",
				Description = "The arccos of the angle which the player needs to be moving twords the target for the charge to happen"
			},
			new DvarEntry
			{
				Name = "aim_autobayonet_range",
				Description = "The range of the auto bayonet"
			},
			new DvarEntry
			{
				Name = "aim_view_sensitivity_override",
				Description = "override value for view sensitivity"
			},
			new DvarEntry
			{
				Name = "tu_aim_automelee_fix1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "aim_lockon_enabled",
				Description = "Aim lock on helps the player to stay on target"
			},
			new DvarEntry
			{
				Name = "aim_lockon_debug",
				Description = "Turn on debugging info for aim lock on"
			},
			new DvarEntry
			{
				Name = "aim_lockon_deflection",
				Description = "The amount of stick deflection for the lockon to activate"
			},
			new DvarEntry
			{
				Name = "aim_alternate_lockon_deflection",
				Description = "The amount of stick deflection for the lockon to activate"
			},
			new DvarEntry
			{
				Name = "aim_lockon_strength",
				Description = "The amount of aim assistance given by the target lock on (yaw)"
			},
			new DvarEntry
			{
				Name = "aim_alternate_lockon_strength",
				Description = "The amount of aim assistance given by the target lock on (yaw)"
			},
			new DvarEntry
			{
				Name = "aim_lockon_pitch_strength",
				Description = "The amount of aim assistance given by the target lock on (pitch)"
			},
			new DvarEntry
			{
				Name = "aim_alternate_lockon_pitch_strength",
				Description = "The amount of aim assistance given by the target lock on (pitch)"
			},
			new DvarEntry
			{
				Name = "aim_lockon_region_width",
				Description = "The width of the auto aim region in virtual screen coordinates(0-640)"
			},
			new DvarEntry
			{
				Name = "aim_lockon_region_height",
				Description = "The height of the auto aim region in virtual screen coordinates(0-480)"
			},
			new DvarEntry
			{
				Name = "aim_alternate_lockon_region_width",
				Description = "The width of the auto aim region in virtual screen coordinates(0-640)"
			},
			new DvarEntry
			{
				Name = "aim_alternate_lockon_region_height",
				Description = "The height of the auto aim region in virtual screen coordinates(0-480)"
			},
			new DvarEntry
			{
				Name = "aim_scale_view_axis",
				Description = "Scale the influence of each input axis so that the major axis has more influence on the control"
			},
			new DvarEntry
			{
				Name = "aim_assist_script_disable",
				Description = "Override aim assist from script: set to true to disable code aim assist (i.e. for meatshield)"
			},
			new DvarEntry
			{
				Name = "aim_assist_min_target_distance",
				Description = "Aim assist will not work on targets beyond this distance"
			},
			new DvarEntry
			{
				Name = "aim_target_player_enabled",
				Description = "Allows players to be considered for aim targetting (used in zombies only)"
			},
			new DvarEntry
			{
				Name = "aim_target_sentient_radius",
				Description = "The radius used to calculate target bounds for a sentient(actor or player)"
			},
			new DvarEntry
			{
				Name = "aim_target_sentient_half_height",
				Description = "The radius used to calculate frustum target center for a sentient(actor or player)"
			},
			new DvarEntry
			{
				Name = "aim_target_frustum_expand_fast_updates",
				Description = "The frustum expansion to determine if a target is in the fast interval tag update zone.Positive is inwards."
			},
			new DvarEntry
			{
				Name = "aim_target_frustum_min_distance",
				Description = "If target is inside this distance frustum culling is not applied."
			},
			new DvarEntry
			{
				Name = "aim_target_alternate_frustum_min_distance",
				Description = "If target is inside this distance frustum culling is not applied."
			},
			new DvarEntry
			{
				Name = "aim_target_aim_tag_fast_update_interval",
				Description = "How often the aim target tag is updated instead of pulled from cache inside of the fast zone."
			},
			new DvarEntry
			{
				Name = "aim_target_aim_tag_slow_update_interval",
				Description = "How often the aim target tag is updated instead of pulled from cache inside of the fast zone."
			},
			new DvarEntry
			{
				Name = "aim_target_ignore_team_checking",
				Description = "Disable team checking so that aim assist works on everybody"
			},
			new DvarEntry
			{
				Name = "aim_target_fixed_actor_size",
				Description = "Use a fixed box for actors so you don't have to calculate the skel on the main thread"
			},
			new DvarEntry
			{
				Name = "ammoCounterHide",
				Description = "Hide the Ammo Counter"
			},
			new DvarEntry
			{
				Name = "actionSlotsHide",
				Description = "Hide the actionslots."
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningColor1",
				Description = "Color 1 of 2 to oscilate between"
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningColor2",
				Description = "Color 2 of 2 to oscilate between"
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningNoReloadColor1",
				Description = "Like lowAmmoWarningColor1, but when no ammo to reload with."
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningNoReloadColor2",
				Description = "lowAmmoWarningColor2, but when no ammo to reload with."
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningNoAmmoColor1",
				Description = "Like lowAmmoWarningColor1, but when no ammo."
			},
			new DvarEntry
			{
				Name = "lowAmmoWarningNoAmmoColor2",
				Description = "lowAmmoWarningColor2, but when no ammo."
			},
			new DvarEntry
			{
				Name = "cg_fuelHudVersion",
				Description = "Determines what version of the hud to show"
			},
			new DvarEntry
			{
				Name = "ui_right_ammo_width",
				Description = "Width of the ammo shown on the right."
			},
			new DvarEntry
			{
				Name = "ui_ammo_stock_width",
				Description = "Width of the ammo stock shown on the right."
			},
			new DvarEntry
			{
				Name = "compass",
				Description = "Display Compass"
			},
			new DvarEntry
			{
				Name = "compassMaxRange",
				Description = "The maximum range from the player in world space that objects will be shown on the compass"
			},
			new DvarEntry
			{
				Name = "compassMinRange",
				Description = "The minimum range from the player in world space that objects will appear on the compass"
			},
			new DvarEntry
			{
				Name = "compassMinRadius",
				Description = "The minimum radius from the center of the compass that objects will appear."
			},
			new DvarEntry
			{
				Name = "compassSoundPingFadeTime",
				Description = "The time in seconds for the sound overlay on the compass to fade"
			},
			new DvarEntry
			{
				Name = "compassClampIcons",
				Description = "they disappear off the edge."
			},
			new DvarEntry
			{
				Name = "compassRadarPingFadeTime",
				Description = "How long an enemy is visible on the compass after it is detected by radar"
			},
			new DvarEntry
			{
				Name = "compassRadarUpdateTime",
				Description = "Time between radar updates"
			},
			new DvarEntry
			{
				Name = "compassRadarUpdateFastTime",
				Description = "Time between radar updates for fast update killstreak"
			},
			new DvarEntry
			{
				Name = "compassSatelliteStaticImageFadeTime",
				Description = "How long the static image is visible on the compass after it is detected by Satellite"
			},
			new DvarEntry
			{
				Name = "compassSatellitePingFadeTime",
				Description = "How long an enemy is visible on the compass after it is detected by Satellite"
			},
			new DvarEntry
			{
				Name = "compassStaticImageUpdateTime",
				Description = "Time between static image updates"
			},
			new DvarEntry
			{
				Name = "compassSatelliteScanTime",
				Description = "Time taken for Satellite t scans"
			},
			new DvarEntry
			{
				Name = "compassRadarLineThickness",
				Description = "Thickness, relative to the compass size, of the radar texture that sweeps across the map"
			},
			new DvarEntry
			{
				Name = "compassLocalRadarUpdateTime",
				Description = "Time between local radar updates"
			},
			new DvarEntry
			{
				Name = "compassLocalRadarRadius",
				Description = "Maximum radius of the local radar"
			},
			new DvarEntry
			{
				Name = "compassObjectiveWidth",
				Description = "The size of the objective on the compass"
			},
			new DvarEntry
			{
				Name = "compassObjectiveHeight",
				Description = "The size of the objective on the compass"
			},
			new DvarEntry
			{
				Name = "compassObjectiveNearbyDist",
				Description = "an Objective Nearby type of indicator is shown."
			},
			new DvarEntry
			{
				Name = "compassObjectiveMinDistRange",
				Description = "centered on compassObjectiveNearbyDist."
			},
			new DvarEntry
			{
				Name = "compassObjectiveDetailDist",
				Description = "the icon will not be drawn on the tickertape."
			},
			new DvarEntry
			{
				Name = "compassObjectiveMinHeight",
				Description = "The minimum height that an objective is considered to be on this level"
			},
			new DvarEntry
			{
				Name = "compassObjectiveMaxHeight",
				Description = "The maximum height that an objective is considered to be on this level"
			},
			new DvarEntry
			{
				Name = "compassEnemyFootstepMaxRange",
				Description = "The maximum distance at which an enemy may appear on the compass due to 'footsteps'"
			},
			new DvarEntry
			{
				Name = "compassEnemyFootstepMaxZ",
				Description = "The maximum vertical distance enemy may be from the player and appear on the compass due to 'footsteps'"
			},
			new DvarEntry
			{
				Name = "compassEnemyFootstepMinSpeed",
				Description = "The minimum speed an enemy must be moving to appear on the compass due to 'footsteps'"
			},
			new DvarEntry
			{
				Name = "compassEnemyFootstepEnabled",
				Description = "Enables enemies showing on the compass because of moving rapidly nearby."
			},
			new DvarEntry
			{
				Name = "compassShowEnemies",
				Description = "Enables enemies showing on the compass."
			},
			new DvarEntry
			{
				Name = "compassForcePlayerIcon",
				Description = "Forces the player to always show as compassping_player on the compass."
			},
			new DvarEntry
			{
				Name = "compassGridEnabled",
				Description = "Enables compass grid."
			},
			new DvarEntry
			{
				Name = "compassGridRows",
				Description = "Grid row count."
			},
			new DvarEntry
			{
				Name = "compassGridCols",
				Description = "Grid column count."
			},
			new DvarEntry
			{
				Name = "compassGridAlign",
				Description = "Position of letter and number in grid."
			},
			new DvarEntry
			{
				Name = "typeWriterCod7LetterFXTime",
				Description = "Time it takes for a letter to come in. "
			},
			new DvarEntry
			{
				Name = "popInLetterFXTime",
				Description = "Time it takes for a letter to pop in. "
			},
			new DvarEntry
			{
				Name = "redactionDisplayTime",
				Description = "Time that it should be displayed for. "
			},
			new DvarEntry
			{
				Name = "redactionFadeDuration",
				Description = "Fade duration time. "
			},
			new DvarEntry
			{
				Name = "redactionStartStrokeTime",
				Description = "Time before the stroke starts. "
			},
			new DvarEntry
			{
				Name = "redactionStrokeTime",
				Description = "Time it takes to complete the redaction stroke. "
			},
			new DvarEntry
			{
				Name = "shoutcastSelectedClient",
				Description = "Shoutcaster's currently selected clientNum."
			},
			new DvarEntry
			{
				Name = "shoutcastHighlightedClient",
				Description = "Shoutcaster's currently highlighted clientNum."
			},
			new DvarEntry
			{
				Name = "compassEnableColorBlindPlayerIcons",
				Description = "Checks if we should draw the player arrows in color blind colors."
			},
			new DvarEntry
			{
				Name = "compassDebug",
				Description = "Compass Debugging Mode"
			},
			new DvarEntry
			{
				Name = "forceFullScreenMap",
				Description = "Force the fullscreen map up"
			},
			new DvarEntry
			{
				Name = "cg_hudMapRadarLineThickness",
				Description = "of the radar texture that sweeps across the full screen map"
			},
			new DvarEntry
			{
				Name = "cg_hudMapFriendlyWidth",
				Description = "The size of the friendly icon on the full map"
			},
			new DvarEntry
			{
				Name = "cg_hudMapFriendlyHeight",
				Description = "The size of the friendly icon on the full map"
			},
			new DvarEntry
			{
				Name = "cg_hudMapPlayerWidth",
				Description = "The size of the player's icon on the full map"
			},
			new DvarEntry
			{
				Name = "cg_hudMapPlayerHeight",
				Description = "The size of the player's icon on the full map"
			},
			new DvarEntry
			{
				Name = "cg_hudMapBorderWidth",
				Description = "filled by the CG_PLAYER_FULLMAP_BORDER ownerdraw"
			},
			new DvarEntry
			{
				Name = "cg_showZombieControls",
				Description = "Show the zombie controller layout"
			},
			new DvarEntry
			{
				Name = "waypointIconWidth",
				Description = "Width of the offscreen pointer."
			},
			new DvarEntry
			{
				Name = "waypointIconHeight",
				Description = "Height of the offscreen pointer."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPointerWidth",
				Description = "Width of the offscreen pointer."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPointerHeight",
				Description = "Height of the offscreen pointer."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPointerDistance",
				Description = "Distance from the center of the offscreen objective icon to the center its arrow."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenDistanceThresholdAlpha",
				Description = "Distance from the threshold over which offscreen objective icons lerp their alpha."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPadLeft",
				Description = "Offset from the edge."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPadRight",
				Description = "Offset from the edge."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPadTop",
				Description = "Offset from the edge."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenPadBottom",
				Description = "Offset from the edge."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenRoundedCorners",
				Description = "Off-screen icons take rounded corners when true.90-degree corners when false."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenCornerRadius",
				Description = "Size of the rounded corners."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenScaleLength",
				Description = "How far the offscreen icon scale travels from full to smallest scale."
			},
			new DvarEntry
			{
				Name = "waypointOffscreenScaleSmallest",
				Description = "Smallest scale that the offscreen effect uses."
			},
			new DvarEntry
			{
				Name = "waypointDistScaleRangeMin",
				Description = "Distance from player that icon distance scaling starts."
			},
			new DvarEntry
			{
				Name = "waypointDistScaleRangeMax",
				Description = "Distance from player that icon distance scaling ends."
			},
			new DvarEntry
			{
				Name = "waypointDistScaleSmallest",
				Description = "Smallest scale that the distance effect uses."
			},
			new DvarEntry
			{
				Name = "waypointDistFade",
				Description = "Distance to start fading waypoints when the player is ADS"
			},
			new DvarEntry
			{
				Name = "waypointTimeFade",
				Description = "Time in ms to fade waypoints the player is ADS"
			},
			new DvarEntry
			{
				Name = "waypointSplitscreenScale",
				Description = "Scale applied to waypoint icons in splitscreen views."
			},
			new DvarEntry
			{
				Name = "waypointTweakY",
				Description = ""
			},
			new DvarEntry
			{
				Name = "hudElemPausedBrightness",
				Description = "Brightness of the hudelems when the game is paused."
			},
			new DvarEntry
			{
				Name = "waypointPlayerOffsetProne",
				Description = "how high to offset off of their origin when they are prone."
			},
			new DvarEntry
			{
				Name = "waypointPlayerOffsetCrouch",
				Description = "how high to offset off of their origin when they are crouching."
			},
			new DvarEntry
			{
				Name = "waypointPlayerOffsetStand",
				Description = "how high to offset off of their origin when they are standing."
			},
			new DvarEntry
			{
				Name = "waypointPlayerOffsetRevive",
				Description = "how high to offset off of their origin when they are in last stand."
			},
			new DvarEntry
			{
				Name = "laserForceOn",
				Description = "Force laser sights on in all possible places (for debug purposes)."
			},
			new DvarEntry
			{
				Name = "laserRange",
				Description = "The maximum range of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserRangePlayer",
				Description = "The maximum range of the player's laser beam"
			},
			new DvarEntry
			{
				Name = "laserLightRangePlayer",
				Description = "The maximum range of the player's laser light (is less than laserRangePlayer then not used)"
			},
			new DvarEntry
			{
				Name = "laserRadius",
				Description = "The size (radius) of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserFadeADS",
				Description = "Whether to draw the light emitted from a laser (not the laser itself)"
			},
			new DvarEntry
			{
				Name = "laserLightWithoutNightvision",
				Description = "Whether to draw the light emitted from a laser (not the laser itself) when nightvision is off. Player always gets light."
			},
			new DvarEntry
			{
				Name = "laserLightBodyTweak",
				Description = "Amount to add to length of beam for light when laser hits a body (for hitboxes)."
			},
			new DvarEntry
			{
				Name = "laserLightRadius",
				Description = "The radius of the light at the far end of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserLightBeginOffset",
				Description = "How far from the true beginning of the beam the light at the beginning is."
			},
			new DvarEntry
			{
				Name = "laserLightEndOffset",
				Description = "How far from the true end of the beam the light at the end is."
			},
			new DvarEntry
			{
				Name = "laserEndOffset",
				Description = "How far from the point of collision the end of the beam is."
			},
			new DvarEntry
			{
				Name = "laserFlarePct",
				Description = "Percentage laser widens over distance from viewer."
			},
			new DvarEntry
			{
				Name = "laserDebug",
				Description = "Enables the display of various debug info."
			},
			new DvarEntry
			{
				Name = "laserRange_alt",
				Description = "The maximum range of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserRadius_alt",
				Description = "The size (radius) of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserLightRadius_alt",
				Description = "The radius of the light at the far end of a laser beam"
			},
			new DvarEntry
			{
				Name = "laserFlarePct_alt",
				Description = "Percentage laser widens over distance from viewer."
			},
			new DvarEntry
			{
				Name = "laserAlpha",
				Description = "Laser Beam Alpha."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderDefaultColor",
				Description = "Default color for the reticle and display digits on the range finder attachment."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderActiveColor",
				Description = "when an enemy is spotted."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderMinEnemySpottingDist",
				Description = "The distance in feet(world units/12)beyond which the rangeFinder would not change color when an enemy is spotted. -1 means there is no distance limit."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderPlayerTargetSize",
				Description = "Size of player target highlights for the rangefinder."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderActiveWidth",
				Description = "Width of the center area of the screen for which the rangefinder will display diamonds around enemies."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderActiveHeight",
				Description = "Height of the center area of the screen for which the rangefinder will display diamonds around enemies."
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderDiamondIndicator",
				Description = "Draw diamond shaped indicators in the rangefinder (otherwise draw brackets around the player's bounding box)"
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderDiamondSize",
				Description = "Size of the diamond indicator in the rangefinder."
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentBlur",
				Description = "Blur amount on the characters in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentMaxDist",
				Description = "Maximum distance that players are visible in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentSpeedDelay",
				Description = "Amount of time the players movement distance is accumulated while using the sonar attachment (MM Wave) - smaller values will shorten the transition times"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentFadeFriendlies",
				Description = "Fade out the friendlies when they move in the sonar attachment (MM Wave)."
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentHideFriendlies",
				Description = "Hide friendlies in the sonar attachment (MM Wave)."
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentEmpFade",
				Description = "Time it takes the sonar attachment (MM Wave) when player is hit by EMP"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentPulseInterval",
				Description = "Time between the pulses in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentPulseTime",
				Description = "Amount of time it takes the pulse to travel to max distance in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentMaxSpeed",
				Description = "Minimum speed [units/frame] that will make the player disappear in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentDistanceFactor",
				Description = "A factor that makes closer players disappear in higher speeds than farther ones in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentSpeedTimeRatio",
				Description = "Amount of fade out a player will get when moving at max speed in the sonar attachment (MM Wave)"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentCounterColorMultiplier",
				Description = "Multiplier to 'Player_Color_Multiplier' to reduce player visibility when having immunemms perk"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentCounterMaxSpeed",
				Description = "but for players with immunemms perk"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentZmTurnedGraceTime",
				Description = "Amount of time a turned human isn't visible to other zombies"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentZmTurnedFadeTime",
				Description = "Amount of time a turned human is faded in after the grace period"
			},
			new DvarEntry
			{
				Name = "cg_sonarAttachmentZmTurnedMinFade",
				Description = "The lowest amount of fade a player can have after the grace period"
			},
			new DvarEntry
			{
				Name = "cg_useNewEventQueueScheme",
				Description = "if true - otherwise just sets lastEvent to currentEvent."
			},
			new DvarEntry
			{
				Name = "cg_infraredBlur",
				Description = "Blur amount on the infrared"
			},
			new DvarEntry
			{
				Name = "cg_infraredBlurTime",
				Description = "Time [in millisecs] that the infrared blur lasts."
			},
			new DvarEntry
			{
				Name = "cg_forceInfrared",
				Description = "Force using infrared"
			},
			new DvarEntry
			{
				Name = "cg_infraredFriendlies",
				Description = "Friendlies in infrared: 0:off 1:heartbeat 2:thermal+heartbeat"
			},
			new DvarEntry
			{
				Name = "cg_InfraredFadeoutTime",
				Description = "Time [in millisecs] it takes to corpses to fadeout."
			},
			new DvarEntry
			{
				Name = "cg_weaponHeat",
				Description = "Force the heat of all weapon (for infrared)"
			},
			new DvarEntry
			{
				Name = "cg_infraredUseDefaultMaterial",
				Description = "Use the default white material when no thermal material is available in infrared"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_Debug",
				Description = "enable to tweak the ballistic arc system"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_BeginWidth",
				Description = "Starting width of the arrow"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_EndWidth",
				Description = "Ending width of the arrow"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_Offset",
				Description = "Distance to offset the start of the arc from the true launch position"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_MinBounces",
				Description = "Start rendering bounces at this item"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_MaxBounces",
				Description = "Start rendering bounces at this item"
			},
			new DvarEntry
			{
				Name = "cg_VelocityArrow_RateOfChange",
				Description = "The minimum rate of change required to force a segment split"
			},
			new DvarEntry
			{
				Name = "cg_VelocityArrow_MaxSegmentLength",
				Description = "The maximum length of a segment"
			},
			new DvarEntry
			{
				Name = "cg_VelocityArrow_MinSegmentLength",
				Description = "The minimum length of a segment"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_DrawDelay",
				Description = "Amount of time in ms before the arc starts to render"
			},
			new DvarEntry
			{
				Name = "cg_BallisticArc_ForceHitIndicator",
				Description = "force the grenade arc indicator to indicate a hit condition"
			},
			new DvarEntry
			{
				Name = "cg_debugLocHit",
				Description = "Display locational damage info for an entity when the entity is hit"
			},
			new DvarEntry
			{
				Name = "cg_debugLocHitTime",
				Description = "Time duration of g_debugLocHit lines"
			},
			new DvarEntry
			{
				Name = "cg_useColorControl",
				Description = "Enable global color control"
			},
			new DvarEntry
			{
				Name = "cg_colorSaturation",
				Description = "Color saturation"
			},
			new DvarEntry
			{
				Name = "cg_colorTemp",
				Description = "color temp"
			},
			new DvarEntry
			{
				Name = "cg_colorHue",
				Description = "Color hue"
			},
			new DvarEntry
			{
				Name = "cg_colorScale",
				Description = "color scale"
			},
			new DvarEntry
			{
				Name = "cg_vehNPCThrottleMultiplier",
				Description = "Speed of vehicle mul this = throttle percentage."
			},
			new DvarEntry
			{
				Name = "cg_streamLowDetailCamos",
				Description = "Force the low mips of camo material to always be loaded."
			},
			new DvarEntry
			{
				Name = "tracer_debugDraw",
				Description = "Draw debug lines where the tracers should be visible."
			},
			new DvarEntry
			{
				Name = "cg_opticAttachmentViewmodelSwitch",
				Description = "Zoom factor to switch Optic 1 ADS viewmodel"
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamFov",
				Description = "Helicopter kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamNearBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamFarBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamFarBlurStart",
				Description = "Helicopter kill camera distance above the helicopter."
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamFarBlurDist",
				Description = "Helicopter kill camera distance above the helicopter."
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamNearBlurStart",
				Description = "Helicopter kill camera distance above the helicopter."
			},
			new DvarEntry
			{
				Name = "cg_heliKillCamNearBlurEnd",
				Description = "Helicopter kill camera distance above the helicopter."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamFov",
				Description = "Scripted kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamCloseXYDist",
				Description = "Scripted kill camera closest distance in front of the bomb."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamCloseZDist",
				Description = "Scripted kill camera closest distance above the target."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamNearBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamFarBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamFarBlurStart",
				Description = "Scripted kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamFarBlurDist",
				Description = "Scripted kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamNearBlurStart",
				Description = "Scripted kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_scriptedKillCamNearBlurEnd",
				Description = "Scripted kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamFov",
				Description = "Destructible kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamCloseXYDist",
				Description = "Destructible kill camera closest distance in front of the bomb."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamCloseZDist",
				Description = "Destructible kill camera closest distance above the target."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamNearBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamFarBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamFarBlurStart",
				Description = "Destructible kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamFarBlurDist",
				Description = "Destructible kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamNearBlurStart",
				Description = "Destructible kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamNearBlurEnd",
				Description = "Destructible kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamZIncrease",
				Description = "Height above origin for the destructibles"
			},
			new DvarEntry
			{
				Name = "cg_destructibleKillCamRegularHeight",
				Description = "then just move the camera to above it"
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamUpDist",
				Description = "Explosive kill camera: distance of camera vertically from explosive."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamBackDist",
				Description = "Explosive kill camera: distance of camera backwards from explosive."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamWallOutDist",
				Description = "Explosive kill camera when stuck to wall: distance of camera out from wall."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamWallSideDist",
				Description = "Explosive kill camera when stuck to wall: distance of camera along wall from explosive."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamGroundUpDist",
				Description = "Explosive kill camera when stuck to ground: distance of camera vertically from explosive."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamGroundBackDist",
				Description = "Explosive kill camera when stuck to ground: distance of camera backwards from explosive."
			},
			new DvarEntry
			{
				Name = "cg_rocketKillCamUpDist",
				Description = "Rocket kill camera: distance of camera vertically from rocket."
			},
			new DvarEntry
			{
				Name = "cg_rocketKillCamBackDist",
				Description = "Rocket kill camera: distance of camera backwards from rocket."
			},
			new DvarEntry
			{
				Name = "cg_droneKillCamUpDist",
				Description = "Drone kill camera: distance of camera vertically from drone."
			},
			new DvarEntry
			{
				Name = "cg_droneKillCamBackDist",
				Description = "Drone kill camera: distance of camera backwards from drone."
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamStopDist",
				Description = "Rocket and Grenade Launcher kill camera: distance from player to begin coming to rest"
			},
			new DvarEntry
			{
				Name = "cg_explosiveKillCamStopDecelDist",
				Description = "Rocket and Grenade Launcher kill camera: distance over which to decelerate when coming to rest"
			},
			new DvarEntry
			{
				Name = "cg_dogKillCamFov",
				Description = "Dog kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_dogKillCamForwardDist",
				Description = "Dog kill camera: distance of target camera vertically from dog."
			},
			new DvarEntry
			{
				Name = "cg_dogKillCamUpDist",
				Description = "Dog kill camera: distance of camera target vertically from dog."
			},
			new DvarEntry
			{
				Name = "cg_dogKillCamSideDist",
				Description = "Dog kill camera: distance of camera target vertically from dog."
			},
			new DvarEntry
			{
				Name = "cg_dogKillCamDistFromEyes",
				Description = "Dog kill camera: distance of camera past the delta from player target to dog eye"
			},
			new DvarEntry
			{
				Name = "cg_dogKillMinDistFromTarget",
				Description = "Dog kill camera: minimum distance that the camera will approach the target"
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamFov",
				Description = "Artillery kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamUpDist",
				Description = "artillery kill camera: distance of camera vertically from artillery."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamBackDist",
				Description = "artillery kill camera: distance of camera backwards from artillery."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamWallOutDist",
				Description = "artillery kill camera when stuck to wall: distance of camera out from wall."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamWallSideDist",
				Description = "artillery kill camera when stuck to wall: distance of camera along wall from artillery."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamGroundUpDist",
				Description = "artillery kill camera when stuck to ground: distance of camera vertically from artillery."
			},
			new DvarEntry
			{
				Name = "cg_artilleryKillCamGroundBackDist",
				Description = "artillery kill camera when stuck to ground: distance of camera backwards from artillery."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamFov",
				Description = "Airstrike kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamCloseXYDist",
				Description = "Airstrike kill camera closest distance in front of the bomb."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamCloseZDist",
				Description = "Airstrike kill camera closest distance above the target."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamNearBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamFarBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamFarBlurStart",
				Description = "Airstrike kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamFarBlurDist",
				Description = "Airstrike kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamNearBlurStart",
				Description = "Airstrike kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamNearBlurEnd",
				Description = "Airstrike kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamHeightIncrease",
				Description = "Airstrike kill camera distance above the airplane."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamBackOffset",
				Description = "Move the camera to the Back of the turret by this much."
			},
			new DvarEntry
			{
				Name = "cg_turretKillCamSideOffset",
				Description = "Move the camera to the side of the turret by this much."
			},
			new DvarEntry
			{
				Name = "cg_microwaveTurretKillCamFov",
				Description = "Airstrike kill camera field of view."
			},
			new DvarEntry
			{
				Name = "cg_microwaveTurretKillCamHeightIncrease",
				Description = "Killcam distance above the microwave turret."
			},
			new DvarEntry
			{
				Name = "cg_microwaveTurretKillCamBackOffset",
				Description = "Move the killcam to the back of the microwave turret by this much."
			},
			new DvarEntry
			{
				Name = "cg_killcamdebug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_loadScripts",
				Description = "Disable scripts from loading"
			},
			new DvarEntry
			{
				Name = "cg_usingClientScripts",
				Description = "if client scripts are enabled."
			},
			new DvarEntry
			{
				Name = "cg_drawGun",
				Description = "Draw the view model"
			},
			new DvarEntry
			{
				Name = "cg_cursorHints",
				Description = "Draw cursor hints where: 0: no hints    1:    sin size pulse    2:    one way size pulse    3:    alpha pulse    4:    static image"
			},
			new DvarEntry
			{
				Name = "cg_retrieveHintTime",
				Description = "Time in milliseconds between the landing of a retrievable object and the start of the pulse shader to hint that the object is retrievable"
			},
			new DvarEntry
			{
				Name = "cg_retrieveHintTimeStuck",
				Description = "Time in milliseconds between the retrievable object being stuck in an entity and the start of the pulse shader to hint that the object is retrievable"
			},
			new DvarEntry
			{
				Name = "cg_weaponHintsCoD1Style",
				Description = "and with the icon below"
			},
			new DvarEntry
			{
				Name = "cg_fov",
				Description = "The field of view angle in degrees"
			},
			new DvarEntry
			{
				Name = "cg_fovScale",
				Description = "Scale applied to the field of view"
			},
			new DvarEntry
			{
				Name = "cg_fovMin",
				Description = "The minimum possible field of view"
			},
			new DvarEntry
			{
				Name = "cg_fovExtraCam",
				Description = "The field of view angle in degrees for the extra cam"
			},
			new DvarEntry
			{
				Name = "cg_useWeaponBasedVariableZoom",
				Description = "Use weapon based variable zoom instead of player based."
			},
			new DvarEntry
			{
				Name = "cg_viewVehicleInfluenceGunner",
				Description = "The influence on the view from being a vehicle gunner"
			},
			new DvarEntry
			{
				Name = "cg_viewVehicleInfluenceGunnerFiring",
				Description = "The influence on the view from being a vehicle gunner while firing"
			},
			new DvarEntry
			{
				Name = "cg_draw2D",
				Description = "Draw 2D screen elements"
			},
			new DvarEntry
			{
				Name = "cg_disableplayernames",
				Description = "Disable player names"
			},
			new DvarEntry
			{
				Name = "cg_drawHealth",
				Description = "Draw health bar"
			},
			new DvarEntry
			{
				Name = "cg_drawBreathHint",
				Description = "Draw a 'hold breath to steady' hint"
			},
			new DvarEntry
			{
				Name = "cg_drawBigFPS",
				Description = "Draws frames per second in large font and FPS curtains."
			},
			new DvarEntry
			{
				Name = "cg_drawLagometer",
				Description = "Draw lagometer"
			},
			new DvarEntry
			{
				Name = "cg_drawFPS",
				Description = "Draw frames per second"
			},
			new DvarEntry
			{
				Name = "cg_drawBudgets",
				Description = "Draw asset type budgets"
			},
			new DvarEntry
			{
				Name = "cg_development",
				Description = "Indicates if we are in DEVELOPMENT (non-release ship builds)"
			},
			new DvarEntry
			{
				Name = "cg_drawAnimAttachTags",
				Description = "Display anim attach tags debug data"
			},
			new DvarEntry
			{
				Name = "cg_drawLightingDebugText",
				Description = "Toggles 'Preview Lighting' debug text display"
			},
			new DvarEntry
			{
				Name = "cg_drawFPSOnly",
				Description = "Draw only the FPS stats in the upper right"
			},
			new DvarEntry
			{
				Name = "snd_drawInfo",
				Description = "Draw debugging information for sounds"
			},
			new DvarEntry
			{
				Name = "snd_drawSort",
				Description = "Sort debugging information for sounds"
			},
			new DvarEntry
			{
				Name = "cg_drawMaterial",
				Description = "Draw debugging information for materials"
			},
			new DvarEntry
			{
				Name = "cg_drawMaterialImageNum",
				Description = "Use up/down on the dpad to select an image when cg_drawMaterial is enabled.Press right for more info on that image."
			},
			new DvarEntry
			{
				Name = "cg_drawMaterialImageName",
				Description = "Do not use (set by cg_drawMaterialImageNum code)"
			},
			new DvarEntry
			{
				Name = "cg_drawModelAxis",
				Description = "Draw debugging axis for a bone of the model under the crosshair"
			},
			new DvarEntry
			{
				Name = "cg_drawBonesEntNum",
				Description = "entnum of dobj bone info display"
			},
			new DvarEntry
			{
				Name = "cg_drawCrosshair",
				Description = "Turn on weapon crosshair"
			},
			new DvarEntry
			{
				Name = "cg_drawHoldBreathHint",
				Description = "Turn on hold breath hint string for the sniper rifles"
			},
			new DvarEntry
			{
				Name = "cg_drawCrosshairNames",
				Description = "Draw the name of an enemy under the crosshair"
			},
			new DvarEntry
			{
				Name = "cg_drawCrosshairNamesPosX",
				Description = "Virtual screen space position of the crosshair name"
			},
			new DvarEntry
			{
				Name = "cg_drawCrosshairNamesPosY",
				Description = "Virtual screen space position of the crosshair name"
			},
			new DvarEntry
			{
				Name = "cg_drawShellshock",
				Description = "Draw shellshock & flashbang screen effects."
			},
			new DvarEntry
			{
				Name = "cg_lastSpectatorSelectedThirdPerson",
				Description = "Saves last spectator view selected"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadeIconMaxRangeFrag",
				Description = "The minimum distance that a grenade has to be from a player in order to be shown on the grenade indicator"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadeIconMaxRangeFlash",
				Description = "The minimum distance that a flashbang has to be from a player in order to be shown on the grenade indicator"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadeIconOffset",
				Description = "The offset from the center of the screen for a grenade icon"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadeIconHeight",
				Description = "The height of the grenade indicator icon"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadeIconWidth",
				Description = "The width of the grenade indicator icon"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadePointerHeight",
				Description = "The height of the grenade indicator pointer"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadePointerWidth",
				Description = "The width of the grenade indicator pointer"
			},
			new DvarEntry
			{
				Name = "cg_hudGrenadePointerPivot",
				Description = "The pivot point of th grenade indicator pointer"
			},
			new DvarEntry
			{
				Name = "cg_lagometer_pos",
				Description = "lagometer position"
			},
			new DvarEntry
			{
				Name = "cg_centertime",
				Description = "The time for a center printed message to fade"
			},
			new DvarEntry
			{
				Name = "cg_crosshairAlpha",
				Description = "The alpha value of the crosshair"
			},
			new DvarEntry
			{
				Name = "cg_crosshairAlphaMin",
				Description = "The minimum alpha value of the crosshair when it fades in"
			},
			new DvarEntry
			{
				Name = "cg_crosshairDynamic",
				Description = "Crosshair is Dynamic"
			},
			new DvarEntry
			{
				Name = "cg_crosshairEnemyColor",
				Description = "The crosshair color when over an enemy"
			},
			new DvarEntry
			{
				Name = "cg_debugPosition",
				Description = "Output position debugging information"
			},
			new DvarEntry
			{
				Name = "cg_debugEvents",
				Description = "Output event debug information"
			},
			new DvarEntry
			{
				Name = "cg_footsteps",
				Description = "Play footstep sounds"
			},
			new DvarEntry
			{
				Name = "cg_footprints",
				Description = "Draw footprint decals and effects"
			},
			new DvarEntry
			{
				Name = "cg_footprintsDistortWater",
				Description = "Distort water on footprint (0 means no distortion)"
			},
			new DvarEntry
			{
				Name = "cg_footprintsDebug",
				Description = "Debug footprint drawing code (0 means no debugging)"
			},
			new DvarEntry
			{
				Name = "cg_treadmarks",
				Description = "Draw treadmark decals and effects"
			},
			new DvarEntry
			{
				Name = "cg_firstPersonTracerChance",
				Description = "The probability that a bullet is a tracer round for your bullets"
			},
			new DvarEntry
			{
				Name = "cg_airburstLaseTime",
				Description = "Time required to lase a distance in seconds."
			},
			new DvarEntry
			{
				Name = "cg_airburstStrafeRestriction",
				Description = "Amount of movement of strafe movement allowed before reseting laze."
			},
			new DvarEntry
			{
				Name = "cg_airburstCameraRestriction",
				Description = "Amount of movement of camera movement allowed before reseting laze."
			},
			new DvarEntry
			{
				Name = "cg_airburstLaseFlashTime",
				Description = "Time that the distance numbers in the menus will flash green after lase is complete."
			},
			new DvarEntry
			{
				Name = "cg_thirdPersonRange",
				Description = "The range of the camera from the player in third person view"
			},
			new DvarEntry
			{
				Name = "cg_thirdPersonAngle",
				Description = "The angle of the camera from the player in third person view"
			},
			new DvarEntry
			{
				Name = "cg_thirdPersonFocusDist",
				Description = "The distance infront of the player to aim the 3rd person camera at"
			},
			new DvarEntry
			{
				Name = "cg_thirdPerson",
				Description = "Use third person view"
			},
			new DvarEntry
			{
				Name = "cg_thirdPersonMode",
				Description = "How the camera behaves in third person"
			},
			new DvarEntry
			{
				Name = "cg_use_colored_smoke",
				Description = "Allow the use of colored smoke grenades"
			},
			new DvarEntry
			{
				Name = "cg_fakefireWizbyChance",
				Description = "The probability that a fake fire shot plays a wizby to local players round"
			},
			new DvarEntry
			{
				Name = "cg_useWeaponSwitchReloadCancel",
				Description = "Allow weapon switch to cancel reload"
			},
			new DvarEntry
			{
				Name = "cg_enableHelicopterNoCullLodOut",
				Description = "When true objects do not get LOD'ed out when in the helicopter"
			},
			new DvarEntry
			{
				Name = "cg_forceNoCullLodOut",
				Description = "Force drawing all models"
			},
			new DvarEntry
			{
				Name = "cg_paused",
				Description = "Pause the game"
			},
			new DvarEntry
			{
				Name = "cg_drawpaused",
				Description = "Draw paused screen"
			},
			new DvarEntry
			{
				Name = "cg_synchronousClients",
				Description = "Client is synchronized to the server - allows smooth demos"
			},
			new DvarEntry
			{
				Name = "cg_debug_overlay_viewport",
				Description = "Remove the sniper overlay so you can check that the scissor window is correct."
			},
			new DvarEntry
			{
				Name = "cg_fs_debug",
				Description = "Output debugging information for the file system"
			},
			new DvarEntry
			{
				Name = "cg_debugFace",
				Description = "Turn on debug information for face"
			},
			new DvarEntry
			{
				Name = "cg_dumpAnims",
				Description = "Output animation info for the given entity id"
			},
			new DvarEntry
			{
				Name = "cg_developer",
				Description = "Turn on Development systems"
			},
			new DvarEntry
			{
				Name = "cg_subtitleWidthStandard",
				Description = "The width of the subtitles in non wide-screen"
			},
			new DvarEntry
			{
				Name = "cg_subtitleWidthWidescreen",
				Description = "The width of the subtitles in wide-screen "
			},
			new DvarEntry
			{
				Name = "cg_constantSizeHeadIcons",
				Description = "Head icons are the same size regardless of distance from the player"
			},
			new DvarEntry
			{
				Name = "cg_headIconMinScreenRadius",
				Description = "The minumum radius of a head icon on the screen"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesMaxDist",
				Description = "The maximum distance for showing friendly player names"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesNearDist",
				Description = "The near distance at which names are full size"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesFarDist",
				Description = "The far distance at which name sizes are scaled by cg_overheadNamesFarScale"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesFarScale",
				Description = "The amount to scale overhead name sizes at cg_overheadNamesFarDist"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesSize",
				Description = "The maximum size to show overhead names"
			},
			new DvarEntry
			{
				Name = "cg_overheadIconSize",
				Description = "The maximum size to show overhead icons like 'rank'"
			},
			new DvarEntry
			{
				Name = "cg_overheadRankSize",
				Description = "The size to show rank text"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesGlow",
				Description = "Glow color for overhead names"
			},
			new DvarEntry
			{
				Name = "cg_drawFriendlyNames",
				Description = "Whether to show friendly names in game"
			},
			new DvarEntry
			{
				Name = "cg_enemyNameFadeIn",
				Description = "Time in milliseconds to fade in enemy names"
			},
			new DvarEntry
			{
				Name = "cg_friendlyNameFadeIn",
				Description = "Time in milliseconds to fade in friendly names"
			},
			new DvarEntry
			{
				Name = "cg_enemyNameFadeOut",
				Description = "Time in milliseconds to fade out enemy names"
			},
			new DvarEntry
			{
				Name = "cg_friendlyNameFadeOut",
				Description = "Time in milliseconds to fade out friendly names"
			},
			new DvarEntry
			{
				Name = "cg_drawThroughWalls",
				Description = "Whether to draw friendly names through walls or not"
			},
			new DvarEntry
			{
				Name = "cg_playerHighlightTargetSize",
				Description = "Size of player target highlights."
			},
			new DvarEntry
			{
				Name = "cg_maxPlayerHighlightTargetSize",
				Description = "Max size of player target highlights."
			},
			new DvarEntry
			{
				Name = "cg_playerHighlightEnemyColor",
				Description = "Color of enemy player highlights."
			},
			new DvarEntry
			{
				Name = "cg_playerHighlightBrightness",
				Description = "Brightness of highlights."
			},
			new DvarEntry
			{
				Name = "cg_playerHighlightMinFade",
				Description = "The minimum fade for player highlight blinking."
			},
			new DvarEntry
			{
				Name = "cg_playerHighlightBlinkTime",
				Description = "The speed (in ms) at which the player highlights blink."
			},
			new DvarEntry
			{
				Name = "cg_corpseHighlightFadeTime",
				Description = "Time (in seconds) that corpse highlights fade out"
			},
			new DvarEntry
			{
				Name = "cg_cameraSpikeHighlightBrightness",
				Description = "Brightness of player highlights in the camera spike view"
			},
			new DvarEntry
			{
				Name = "cg_cameraSpikeEnemyColor",
				Description = "Color of enemies in the camera spike view"
			},
			new DvarEntry
			{
				Name = "cg_adsZScaleMax",
				Description = "The scale factor for shrinky dinks"
			},
			new DvarEntry
			{
				Name = "cg_allow_mature",
				Description = "Controls Mature Content selectability"
			},
			new DvarEntry
			{
				Name = "ui_email_address",
				Description = "Email address"
			},
			new DvarEntry
			{
				Name = "cg_viewZSmoothingMin",
				Description = "Threshhold for the minimum smoothing distance it must move to smooth"
			},
			new DvarEntry
			{
				Name = "cg_viewZSmoothingMax",
				Description = "Threshhold for the maximum smoothing distance we'll do"
			},
			new DvarEntry
			{
				Name = "cg_viewZSmoothingTime",
				Description = "Amount of time to spread the smoothing over"
			},
			new DvarEntry
			{
				Name = "overrideNVGModelWithKnife",
				Description = "nightvision animations will attach the weapDef's knife model instead of the night vision goggles."
			},
			new DvarEntry
			{
				Name = "cg_visionSetLerpMaxIncreasePerFrame",
				Description = "used for smoothing for flare visionset"
			},
			new DvarEntry
			{
				Name = "cg_visionSetLerpMaxDecreasePerFrame",
				Description = "used for smoothing for flare visionset"
			},
			new DvarEntry
			{
				Name = "cg_flareVisionSetFadeDuration",
				Description = "Duration of fade back to normal vision set when you look away from the flare"
			},
			new DvarEntry
			{
				Name = "cg_turretBipodOffset",
				Description = "Offset bipod mount position on gun by this distance"
			},
			new DvarEntry
			{
				Name = "cg_AllPlayerNamesVisible",
				Description = "When true all names are visible within visibility range."
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_MyTeam",
				Description = "Player team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_EnemyTeam",
				Description = "Enemy team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Spectator",
				Description = "Spectator team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Free",
				Description = "Free Team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Allies",
				Description = "Allies team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Axis",
				Description = "Axis team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_TeamName_Allies",
				Description = "Allied team name"
			},
			new DvarEntry
			{
				Name = "cg_TeamName_Axis",
				Description = "Axis team name"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_Allies",
				Description = "Allies team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_Axis",
				Description = "Axis team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_MyTeam",
				Description = "Player team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_EnemyTeam",
				Description = "Enemy team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_MyTeamAlt",
				Description = "Player team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_MyTeamAlt_Party",
				Description = "Player team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_EnemyTeamAlt",
				Description = "Enemy team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_Party",
				Description = "Party color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_Spectator",
				Description = "Spectator team color"
			},
			new DvarEntry
			{
				Name = "cg_TeamColor_Free",
				Description = "Free Team color"
			},
			new DvarEntry
			{
				Name = "cg_proneFeetCollisionHull",
				Description = "Enables the use of the extra physics collision hulls on the feet while prone."
			},
			new DvarEntry
			{
				Name = "g_compassShowEnemies",
				Description = "Whether enemies are visible on the compass at all times"
			},
			new DvarEntry
			{
				Name = "cg_drawRumbleDebug",
				Description = "Display rumble debug information"
			},
			new DvarEntry
			{
				Name = "cg_drawWVisDebug",
				Description = "Display weapon visibility debug info"
			},
			new DvarEntry
			{
				Name = "debugOverlay",
				Description = "Toggles the display of various debug info."
			},
			new DvarEntry
			{
				Name = "cg_timedDamageDuration",
				Description = "Sets the time to display a damage friendly indicator"
			},
			new DvarEntry
			{
				Name = "cg_playerFrustumHalfHeight",
				Description = "The radius used to calculate frustum target center for a player. Used for fast is on screen tests"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesTagUpdateInterval",
				Description = "How often the friendly visibility head tag is updated for the on screen frustum check"
			},
			new DvarEntry
			{
				Name = "cg_canSeeFriendlyFrustumUpdateInterval",
				Description = "How often the head tag is updated for the overhead names"
			},
			new DvarEntry
			{
				Name = "cg_canSeeFriendlyFrustumExpand",
				Description = "The frustum expansion to determine if a friendly is on screen.Positive is inwards."
			},
			new DvarEntry
			{
				Name = "cg_canSeeFriendlyFrustumMinDistance",
				Description = "If target is inside this distance frustum culling is not applied."
			},
			new DvarEntry
			{
				Name = "cg_watersheeting",
				Description = "Enables/disables the watersheeting fullscreen effect"
			},
			new DvarEntry
			{
				Name = "cg_cameraWaterClip",
				Description = "Min distance between camera and water surface. To prevent camera seeing water edge-on. Set to -1 to disable"
			},
			new DvarEntry
			{
				Name = "cg_cameraVehicleExitTweenTime",
				Description = "Time(secs) to tween from gunner/vehicle camera to normal player camera"
			},
			new DvarEntry
			{
				Name = "cg_vehicle_piece_damagesfx_threshold",
				Description = "Minimum amount of damage for which a destructible piece damageSound SFX will be played."
			},
			new DvarEntry
			{
				Name = "tu6_cg_destructible_radius_damage_enabled",
				Description = "allow the client destructible system to modify server authoritative piece health when dealing radius damage."
			},
			new DvarEntry
			{
				Name = "cg_captureCameraEnable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_captureCameraPositionOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_captureCameraRotationOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_useSafeSpectatorCam",
				Description = "instead of following the player entity."
			},
			new DvarEntry
			{
				Name = "cg_fixupSmodelCullDists",
				Description = "Fixup the static models' cull distance - the calculation in the Linker doesn't treat the smodel scale the same as in runtime"
			},
			new DvarEntry
			{
				Name = "cg_alt_mode_killstreak_fix_tu6",
				Description = "When switching back from a killstreak without the killstreak finishing fully the alt mode was reset to default. "
			},
			new DvarEntry
			{
				Name = "tu7_cg_deathCamAboveWater",
				Description = "Number of units above the water plane to clamp the death camera. Set to 0 to disable."
			},
			new DvarEntry
			{
				Name = "hud_enable",
				Description = "Enable hud elements"
			},
			new DvarEntry
			{
				Name = "hud_fade_stance",
				Description = "The time for the stance to fade in seconds"
			},
			new DvarEntry
			{
				Name = "hud_health_startpulse_injured",
				Description = "The health level at which to start the 'injured' pulse effect"
			},
			new DvarEntry
			{
				Name = "hud_health_startpulse_critical",
				Description = "The health level at which to start the 'critical' pulse effect"
			},
			new DvarEntry
			{
				Name = "hud_health_pulserate_injured",
				Description = "The pulse rate of the 'injured' pulse effect"
			},
			new DvarEntry
			{
				Name = "hud_health_pulserate_critical",
				Description = "The pulse rate of the 'critical' pulse effect"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_regenPauseTime",
				Description = "The time in milliseconds before the health regeneration kicks in"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_pulseStart",
				Description = "The percentage of full health at which the low-health warning overlay begins flashing"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_pulseStop",
				Description = "The percentage of full health above which the health overlay fades out"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseOne_toAlphaAdd",
				Description = "Alpha value to add to the first health overlay phase"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseOne_pulseDuration",
				Description = "Pulse duration of the first health overlay phase"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseTwo_toAlphaMultiplier",
				Description = "Alpha multiplier for the second health overlay phase (percentage of the pulse peak)"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseTwo_pulseDuration",
				Description = "Time in milliseconds to fade the alpha to hud_healthOverlay_phaseTwo_toAlphaMultiplier"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseThree_toAlphaMultiplier",
				Description = "Alpha multiplier for the third health overlay phase (percentage of the pulse peak)"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseThree_pulseDuration",
				Description = "Time in milliseconds to fade the alpha to hud_healthOverlay_phaseThree_toAlphaMultiplier"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseEnd_fromAlpha",
				Description = "Starting alpha of the final health overlay phase"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseEnd_toAlpha",
				Description = "Alpha multiplier to fade to before turning off the overlay (percentage of the pulse peak)"
			},
			new DvarEntry
			{
				Name = "hud_healthOverlay_phaseEnd_pulseDuration",
				Description = "Time in milliseconds to fade out the health overlay after it is done flashing"
			},
			new DvarEntry
			{
				Name = "cg_drawTalk",
				Description = "Controls which icons CG_TALKER ownerdraw draws"
			},
			new DvarEntry
			{
				Name = "cg_rumble_devgui_duration",
				Description = "Duration of rumble"
			},
			new DvarEntry
			{
				Name = "cg_rumble_devgui_loop",
				Description = "Enable a looping rumble"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_HighColor",
				Description = "Color for high ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_MedColor",
				Description = "Color for medium ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_LowColor",
				Description = "Color for low ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_BgColor",
				Description = "Background color of ping"
			},
			new DvarEntry
			{
				Name = "cg_scoreboardMyColor",
				Description = "The local player's font color when shown in scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_HighColor",
				Description = "Color for high ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_MedColor",
				Description = "Color for medium ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_LowColor",
				Description = "Color for low ping"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_BgColor",
				Description = "Background color of ping"
			},
			new DvarEntry
			{
				Name = "cg_scoreboardMyColor",
				Description = "The local player's font color when shown in scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Player",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Player_0",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Player_1",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Player_2",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Player_3",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Transparency",
				Description = "Transparency of scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Zombie",
				Description = "player color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_TransparencyZombie",
				Description = "Transparency of scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Gamertag_0",
				Description = "player gamertag color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Gamertag_1",
				Description = "player gamertag color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Gamertag_2",
				Description = "player gamertag color on scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_ScoresColor_Gamertag_3",
				Description = "player gamertag color on scoreboard"
			},
			new DvarEntry
			{
				Name = "snd_boat_current_rpm",
				Description = "scalar value for boat engine"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_scalar",
				Description = "scalar value for boat rpm"
			},
			new DvarEntry
			{
				Name = "snd_boat_using_lerp_rpm",
				Description = "scalar value for boat rpm"
			},
			new DvarEntry
			{
				Name = "snd_boat_lerp_rpm",
				Description = "scalar value for boat rpm"
			},
			new DvarEntry
			{
				Name = "snd_boat_engine_off",
				Description = "value for boat engine low/idle"
			},
			new DvarEntry
			{
				Name = "snd_throttle_time_held_check",
				Description = "how long (ms) throttle is held before engine vol begins to decrease"
			},
			new DvarEntry
			{
				Name = "snd_throttle_reduce_vol",
				Description = "ammount to reduce engine vol"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_idle_fout_start",
				Description = "rpm point where engine_idle begins to fade out"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_idle_end",
				Description = "rpm point where engine_idle ends"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_low_start",
				Description = "rpm point where engine_low start"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_low_fin_end",
				Description = "rpm point where engine_low fade in ends"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_low_fout_start",
				Description = "rpm point where engine_low fade out begins"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_low_end",
				Description = "rpm point where engine_low ends"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_med_start",
				Description = "rpm point where engine_medium start"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_med_fin_end",
				Description = "rpm point where engine_med fade in ends"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_med_fout_start",
				Description = "rpm point where engine_med fade out begins"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_med_end",
				Description = "rpm point where engine_medium ends"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_high_start",
				Description = "rpm point where engine_high start"
			},
			new DvarEntry
			{
				Name = "snd_boat_rpm_high_fin_end",
				Description = "rpm point where engine_high fade in begins"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_idle_min",
				Description = "boat pitch low min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_idle_max",
				Description = "boat pitch low min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_low_min",
				Description = "boat pitch low min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_low_max",
				Description = "boat pitch low min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_med_min",
				Description = "boat pitch med min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_med_max",
				Description = "boat pitch med max"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_high_min",
				Description = "boat pitch high min"
			},
			new DvarEntry
			{
				Name = "snd_boat_pitch_high_max",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_boat_water_slow_min",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_boat_water_idle_max",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_boat_water_fast_min",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_boat_water_slow_max",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_boat_water_pitch_max",
				Description = "boat pitch high max"
			},
			new DvarEntry
			{
				Name = "snd_minigun_loop_start",
				Description = "spin time elapse until loop sound starts playing"
			},
			new DvarEntry
			{
				Name = "snd_minigun_pitch_start",
				Description = "pitch where the loop starts"
			},
			new DvarEntry
			{
				Name = "snd_minigun_pitch_end",
				Description = "pitch where the loop ends"
			},
			new DvarEntry
			{
				Name = "snd_jetgun_loop_start",
				Description = "spin time elapse until loop sound starts playing"
			},
			new DvarEntry
			{
				Name = "snd_jetgun_pitch_start",
				Description = "pitch where the loop starts"
			},
			new DvarEntry
			{
				Name = "snd_jetgun_pitch_end",
				Description = "pitch where the loop ends"
			},
			new DvarEntry
			{
				Name = "cg_altDofTrace",
				Description = "Use more precise trace for finding the DOF center of interest"
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteMissile_Angles",
				Description = "range to shake the view."
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteMissile_Freqs",
				Description = "how fast to shake."
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteMissile_SpeedRange",
				Description = "range of missile speed to scale the shaking."
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteHelo_Angles",
				Description = "range to shake the view."
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteHelo_Freqs",
				Description = "how fast to shake."
			},
			new DvarEntry
			{
				Name = "cameraShakeRemoteHelo_SpeedRange",
				Description = "range of missile speed to scale the shaking."
			},
			new DvarEntry
			{
				Name = "cg_laserSightMaxDistance",
				Description = "Maximum distance a laser sight dot is drawn."
			},
			new DvarEntry
			{
				Name = "cg_missile_FOV",
				Description = "DEFAULT MISSILE FOV"
			},
			new DvarEntry
			{
				Name = "cg_EnableAdaptiveSkinLodScale",
				Description = "Dynamically change the LOD scale for skinned models when the skinned vertex cache is close to being full"
			},
			new DvarEntry
			{
				Name = "nightVisionFadeInOutTime",
				Description = "How long the fade to/from black lasts when putting on or removing night vision goggles."
			},
			new DvarEntry
			{
				Name = "nightVisionPowerOnTime",
				Description = "How long the black-to-nightvision fade lasts when turning on the goggles."
			},
			new DvarEntry
			{
				Name = "nightVisionDisableEffects",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flareDisableEffects",
				Description = ""
			},
			new DvarEntry
			{
				Name = "showVisionSetDebugInfo",
				Description = "Enables visionset debug info"
			},
			new DvarEntry
			{
				Name = "cg_clanNameDebug",
				Description = "debug clan tag"
			},
			new DvarEntry
			{
				Name = "cg_gun_x",
				Description = "x position of the viewmodel"
			},
			new DvarEntry
			{
				Name = "cg_gun_y",
				Description = "y position of the viewmodel"
			},
			new DvarEntry
			{
				Name = "cg_gun_z",
				Description = "z position of the viewmodel"
			},
			new DvarEntry
			{
				Name = "cg_gun_move_f",
				Description = "Weapon movement forward due to player movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_move_r",
				Description = "Weapon movement right due to player movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_move_u",
				Description = "Weapon movement up due to player movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_ofs_f",
				Description = "Forward weapon offset when prone/ducked"
			},
			new DvarEntry
			{
				Name = "cg_gun_ofs_r",
				Description = "Right weapon offset when prone/ducked"
			},
			new DvarEntry
			{
				Name = "cg_gun_ofs_u",
				Description = "Up weapon offset when prone/ducked"
			},
			new DvarEntry
			{
				Name = "cg_gun_rot_p",
				Description = "Pitch gun rotation with movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_rot_y",
				Description = "Yaw gun rotation with movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_rot_r",
				Description = "Gun roll rotation with movement"
			},
			new DvarEntry
			{
				Name = "cg_gun_move_rate",
				Description = "The base weapon movement rate"
			},
			new DvarEntry
			{
				Name = "cg_gun_move_minspeed",
				Description = "The minimum weapon movement rate"
			},
			new DvarEntry
			{
				Name = "cg_gun_rot_rate",
				Description = "The base weapon rotation rate"
			},
			new DvarEntry
			{
				Name = "cg_gun_rot_minspeed",
				Description = "The minimum weapon rotation speed"
			},
			new DvarEntry
			{
				Name = "cg_cullBullets",
				Description = "Whether to cull bullet fire prediction if trajectory doesn't pass your view or anywhere near you"
			},
			new DvarEntry
			{
				Name = "cg_minCullBulletDist",
				Description = "Don't cull bullet trajectories that are within this distance to you."
			},
			new DvarEntry
			{
				Name = "cg_cullBulletAngle",
				Description = "Cull bullet trajectories that don't fall within this fov"
			},
			new DvarEntry
			{
				Name = "cg_weaponSimulateFireAnims",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehicleMouseExtraTurnSpeed",
				Description = "Increase assist for turn angle for nitrous vehicles when not using a gamepad."
			},
			new DvarEntry
			{
				Name = "snd_autoSim",
				Description = "turn on client side simulation of automatic gun sounds"
			},
			new DvarEntry
			{
				Name = "cl_nodelta",
				Description = "The server does not send snapshot deltas"
			},
			new DvarEntry
			{
				Name = "tu7_3rdPersonSpecateFix",
				Description = "Make sure we do not allow 3rd person spectating if the server has it disabled"
			},
			new DvarEntry
			{
				Name = "cl_leanCountMin",
				Description = "Keep stats of lean use"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNMsgTime[v0]",
				Description = "&con_gameMsgWindowNMsgTime_Descs[69 * v0]"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNLineCount[v0]",
				Description = "&con_gameMsgWindowNLineCount_Descs[73 * v0]"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNScrollTime[v0]",
				Description = "(const char *)&con_gameMsgWindowNScrollTime_Descs + 84 * v0"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNFadeInTime[v0]",
				Description = "&con_gameMsgWindowNFadeInTime_Descs[54 * v0]"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNFadeOutTime[v0]",
				Description = "&con_gameMsgWindowNFadeOutTime_Descs[55 * v0]"
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNSplitscreenScale[v0]",
				Description = "&con_gameMsgWindowNSplitscreenScale_Descs[48 * v0]"
			},
			new DvarEntry
			{
				Name = "con_typewriterColorBase",
				Description = "Base color of typewritten objective text."
			},
			new DvarEntry
			{
				Name = "cl_deathMessageWidth",
				Description = "Pixel width of the obituary area"
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[0]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[1]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[2]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[3]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[4]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[5]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clGuiGlob.mapEnumDvar[6]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "result",
				Description = ""
			},
			new DvarEntry
			{
				Name = "m_pitch",
				Description = "Default pitch"
			},
			new DvarEntry
			{
				Name = "m_yaw",
				Description = "Default yaw"
			},
			new DvarEntry
			{
				Name = "m_forward",
				Description = "Forward speed in units per second"
			},
			new DvarEntry
			{
				Name = "m_side",
				Description = "Sideways motion in units per second"
			},
			new DvarEntry
			{
				Name = "m_filter",
				Description = "Allow mouse movement smoothing"
			},
			new DvarEntry
			{
				Name = "cl_mouseAccel",
				Description = "Mouse acceleration"
			},
			new DvarEntry
			{
				Name = "cl_freelook",
				Description = "Enable looking with mouse"
			},
			new DvarEntry
			{
				Name = "cl_motdString",
				Description = "Message of the day"
			},
			new DvarEntry
			{
				Name = "cl_ingame",
				Description = "True if the game is active"
			},
			new DvarEntry
			{
				Name = "password",
				Description = "password"
			},
			new DvarEntry
			{
				Name = "mortarStrikesLeft",
				Description = "Mortar locations not positioned yet"
			},
			new DvarEntry
			{
				Name = "player_name",
				Description = "Player name"
			},
			new DvarEntry
			{
				Name = "baud_rate",
				Description = "Player's preferred baud rate"
			},
			new DvarEntry
			{
				Name = "systemlink",
				Description = "Current game is a system link game"
			},
			new DvarEntry
			{
				Name = "cl_debugMessageKey",
				Description = "Enable message key debugging information"
			},
			new DvarEntry
			{
				Name = "cl_profileTextHeight",
				Description = "Text size to draw the network profile data"
			},
			new DvarEntry
			{
				Name = "cl_profileTextY",
				Description = "Y position to draw the profile data"
			},
			new DvarEntry
			{
				Name = "cl_playerRank",
				Description = "To toggle the rank of the player which is displayed in his overhead name"
			},
			new DvarEntry
			{
				Name = "cl_playerPrestige",
				Description = "To toggle the prestige of the player which is displayed in his overhead name"
			},
			new DvarEntry
			{
				Name = "cl_voice",
				Description = "Use voice communications"
			},
			new DvarEntry
			{
				Name = "cl_timeout",
				Description = "Seconds with no received packets until a timeout occurs"
			},
			new DvarEntry
			{
				Name = "cl_connectTimeout",
				Description = "Timeout time in seconds while connecting to a server"
			},
			new DvarEntry
			{
				Name = "cl_connectionAttempts",
				Description = "Maximum number of connection attempts before aborting"
			},
			new DvarEntry
			{
				Name = "doublescreen",
				Description = "Command line option to enable double screen"
			},
			new DvarEntry
			{
				Name = "splitscreen",
				Description = "Current game is a splitscreen game"
			},
			new DvarEntry
			{
				Name = "splitscreen_playerCount",
				Description = "The number of players in a splitscreen game"
			},
			new DvarEntry
			{
				Name = "killOnlyTrailFX",
				Description = "Kill only trail FX on host migration"
			},
			new DvarEntry
			{
				Name = "customGameMode",
				Description = "2 if user created custom game mode."
			},
			new DvarEntry
			{
				Name = "cl_maxppf",
				Description = "Maximum servers to ping per frame in server browser"
			},
			new DvarEntry
			{
				Name = "ui_custom_name",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cl_splitscreenGamestateHack",
				Description = "If true non-primary local clients wait until the primary local client has parsed the gamestate. See DT#93624"
			},
			new DvarEntry
			{
				Name = "cl_bspmismatchFatal",
				Description = "If true client will ERR_DROP if its BSP doesn't match the server's"
			},
			new DvarEntry
			{
				Name = "cl_migrationPingTime",
				Description = "how many seconds between client pings.used to determine hosting suitability."
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindowNFilter[v8]",
				Description = "v9"
			},
			new DvarEntry
			{
				Name = "con_debug_console_filter",
				Description = "Display channel adding/hiding text in the output"
			},
			new DvarEntry
			{
				Name = "qosPreferredPing",
				Description = "QoS preferred ping"
			},
			new DvarEntry
			{
				Name = "qosMaxAllowedPing",
				Description = "QoS max allowed ping"
			},
			new DvarEntry
			{
				Name = "excellentPing",
				Description = "Anything less than this is consider excellent"
			},
			new DvarEntry
			{
				Name = "goodPing",
				Description = "Anything less thant this is considered decent"
			},
			new DvarEntry
			{
				Name = "terriblePing",
				Description = "limit of playability"
			},
			new DvarEntry
			{
				Name = "party_challengeResponseGraceTime",
				Description = "ms to give clients to respond to challenge instant message"
			},
			new DvarEntry
			{
				Name = "league_kickForBadHash",
				Description = "If true partyhost will kick clients with a hash that doesn't match"
			},
			new DvarEntry
			{
				Name = "party_clientChangelist",
				Description = "If non-zero server will reject clients that have a different changelist than the one specified"
			},
			new DvarEntry
			{
				Name = "party_challengeResponseInterval",
				Description = "ms between sending challenge responses to the server"
			},
			new DvarEntry
			{
				Name = "live_ignoreserverchallenge",
				Description = "If true client won't respond to server challenges"
			},
			new DvarEntry
			{
				Name = "league_forceHashFailure",
				Description = "If true adds 100 to rankpoints so the league hash won't match"
			},
			new DvarEntry
			{
				Name = "party_maxChangeListDiff",
				Description = "Max diff in changelists between client and host before showing warning in UI"
			},
			new DvarEntry
			{
				Name = "party_reconnectToClientOnTimeout",
				Description = "Whether to attempt reconnection to clients after timeout"
			},
			new DvarEntry
			{
				Name = "party_reconnectToHostOnTimeout",
				Description = "Whether to attempt reconnection to host after timeout"
			},
			new DvarEntry
			{
				Name = "party_forceMemberUpdateOnVoiceConnectivityBits",
				Description = "Whether to force a party member update on receiving voice connectivity bits (even if they are unchanged)"
			},
			new DvarEntry
			{
				Name = "party_disconnectPlayerOnRemoval",
				Description = "Whether to disconnect players upon removal by the host"
			},
			new DvarEntry
			{
				Name = "party_disconnectPlayerOnJoinFailed",
				Description = "Whether to disconnect players when the fail to join"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_allowguests",
				Description = "Whether or not guests are allowed in the playlist"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_mainlobby",
				Description = "Maximum number of local players in the main lobby."
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_playermatch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_privatematch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "live_startmatchDeadline",
				Description = "Deadline in seconds before we kick everyone to find a better session"
			},
			new DvarEntry
			{
				Name = "party_maxplayers",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_wagerpartylobby",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_playermatch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_privatematch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_wagermatch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_theater",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_wagermatch",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_theater",
				Description = "Maximum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_leaguematch",
				Description = "Maximum number of players in a league lobby"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_leaguematch",
				Description = "Maximum number of local players in a league lobby"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_systemlink",
				Description = "Maximum number of players in a systemlink lobby"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_systemlink",
				Description = "Maximum number of local players in a systemlink lobby"
			},
			new DvarEntry
			{
				Name = "party_maxplayers_local_splitscreen",
				Description = "Maximum number of players in a local splitscreen lobby"
			},
			new DvarEntry
			{
				Name = "party_maxlocalplayers_local_splitscreen",
				Description = "Maximum number of local players in a local splitscreen lobby"
			},
			new DvarEntry
			{
				Name = "party_disableLockin",
				Description = "disable the league UI lockin"
			},
			new DvarEntry
			{
				Name = "party_connect_dedicated",
				Description = "connect to dedicated servers"
			},
			new DvarEntry
			{
				Name = "party_dedicatedOnly",
				Description = "only allow dedicated servers to host"
			},
			new DvarEntry
			{
				Name = "party_minplayers",
				Description = "Minimum number of players in a party"
			},
			new DvarEntry
			{
				Name = "party_gameStartTimerLengthPrivate",
				Description = "Time in seconds before a game start once enough party members are ready"
			},
			new DvarEntry
			{
				Name = "party_pregameStartTimerLengthPrivate",
				Description = "Time in seconds before showing and starting the game start timer"
			},
			new DvarEntry
			{
				Name = "party_gameStartTimerLength",
				Description = "Time in seconds before a game start once enough party members are ready"
			},
			new DvarEntry
			{
				Name = "party_pregameStartTimerLength",
				Description = "Time in seconds before showing and starting the game start timer"
			},
			new DvarEntry
			{
				Name = "party_vetoButtonVisible",
				Description = "The party veto button is visible in the UI"
			},
			new DvarEntry
			{
				Name = "party_isPreviousMapVoted",
				Description = "If previous map won the voting"
			},
			new DvarEntry
			{
				Name = "party_sequentialPreviousMapVotingAllowed",
				Description = "If sequential previous map voting is allowed"
			},
			new DvarEntry
			{
				Name = "party_vetoPassed",
				Description = "Did the veto pass?"
			},
			new DvarEntry
			{
				Name = "party_vetoPercentRequired",
				Description = "The fraction of the waiting players who need to veto for a map to be skipped"
			},
			new DvarEntry
			{
				Name = "party_vetoDelayTime",
				Description = "Delay time in seconds for a successful map vote to execute"
			},
			new DvarEntry
			{
				Name = "party_readyButtonVisible",
				Description = "The party ready button is visible in the UI"
			},
			new DvarEntry
			{
				Name = "party_readyPercentRequired",
				Description = "The fraction of the waiting players who need to be ready for a party to start"
			},
			new DvarEntry
			{
				Name = "party_readyAllowOnlyLocalPlayers",
				Description = "Allow the player to start a party match with only local players."
			},
			new DvarEntry
			{
				Name = "party_linearMapCycle",
				Description = "We will cycle through the maps linearly if this is true."
			},
			new DvarEntry
			{
				Name = "party_linearMapCycleRandom",
				Description = "We will cycle through the maps linearly if this is true but picks a random start map."
			},
			new DvarEntry
			{
				Name = "party_connectToOthers",
				Description = "even if others exist"
			},
			new DvarEntry
			{
				Name = "party_debugShowSkill",
				Description = "Show players skill rating instead of clan tag in lobby lists"
			},
			new DvarEntry
			{
				Name = "party_editingsettings",
				Description = "True if the host is editing game settings"
			},
			new DvarEntry
			{
				Name = "party_gametype",
				Description = "Current gametype"
			},
			new DvarEntry
			{
				Name = "party_gamesize",
				Description = "Current maximum game size"
			},
			new DvarEntry
			{
				Name = "party_mapname",
				Description = "Current map name"
			},
			new DvarEntry
			{
				Name = "party_kickplayerquestion",
				Description = "String to store the question about kicking the selected player"
			},
			new DvarEntry
			{
				Name = "party_playerCount",
				Description = "Number of players currently in that party/lobby."
			},
			new DvarEntry
			{
				Name = "party_hostname",
				Description = "The name of the host player"
			},
			new DvarEntry
			{
				Name = "party_mappacks",
				Description = "The string for the current combination of map packs in use"
			},
			new DvarEntry
			{
				Name = "party_matchedPlayerCount",
				Description = "Number of matched players before revealing their true names"
			},
			new DvarEntry
			{
				Name = "party_autoteams",
				Description = "Enables/Disables auto team functionality"
			},
			new DvarEntry
			{
				Name = "party_minlobbytime",
				Description = "Minimum time (in seconds) for a lobby to be open before auto starting a match"
			},
			new DvarEntry
			{
				Name = "party_skillBaseDifferenceAllowance",
				Description = "The minimum skill difference we will allow when joining a league lobby"
			},
			new DvarEntry
			{
				Name = "party_skillAllowancePerSecond",
				Description = "The amount we increase the allowed skill difference by each second that we are searching"
			},
			new DvarEntry
			{
				Name = "party_restartMatchmakingTimer",
				Description = "Minimum time (in seconds) for a lobby to be open before auto matchmaking"
			},
			new DvarEntry
			{
				Name = "party_connectTimeout",
				Description = "Connect timeout"
			},
			new DvarEntry
			{
				Name = "party_playerVisible",
				Description = "Whether selected player in party is showing true info or not.Only valid when used with party feeders."
			},
			new DvarEntry
			{
				Name = "party_IAmHostSelected",
				Description = "True if selected player is you and if you are the host.Only valid when used with party feeders."
			},
			new DvarEntry
			{
				Name = "party_firstSubpartyIndex",
				Description = "Determines sort order and coloring of parties in lobbies.Randomly set by code.Dvar provided for debugging."
			},
			new DvarEntry
			{
				Name = "party_membersMissingMapPack",
				Description = "Whether any party member is missing one of the enabled map packs. Only valid after running partyUpdateMissingMapPackDvar"
			},
			new DvarEntry
			{
				Name = "party_mergingEnabled",
				Description = "Whether the lobby host for look for sessions to merge with"
			},
			new DvarEntry
			{
				Name = "party_forceMerge",
				Description = "Force a lobby to attempt a merge"
			},
			new DvarEntry
			{
				Name = "party_forceJoinFailureReason",
				Description = "Force all joins to fail with this reason string"
			},
			new DvarEntry
			{
				Name = "party_mergingJitter",
				Description = "Upper bound on jitter to apply to merging sessinon search in milliseconds"
			},
			new DvarEntry
			{
				Name = "party_searchInterval",
				Description = "Interval in milliseconds between session searches for lobby merging"
			},
			new DvarEntry
			{
				Name = "party_subSearchInterval",
				Description = "Interval in milliseconds between session searches for subparty lobby merging"
			},
			new DvarEntry
			{
				Name = "party_dedicatedMergeMinPlayers",
				Description = "Minimum number of players before we attempt a dedicated server merge"
			},
			new DvarEntry
			{
				Name = "party_joinInProgressAllowed",
				Description = "The party can be joined in the middle of a game"
			},
			new DvarEntry
			{
				Name = "party_minResumeMs",
				Description = "Time in ms before accepting another 'go' message after quitting a game"
			},
			new DvarEntry
			{
				Name = "party_localTeamTest",
				Description = "so real xuids will be absent."
			},
			new DvarEntry
			{
				Name = "party_clientTimeout",
				Description = "After not hearing from the host for this amount of time the client will timeout of the party"
			},
			new DvarEntry
			{
				Name = "party_teamSwitchDelay",
				Description = "The time in seconds that team switchs are delayed until applied."
			},
			new DvarEntry
			{
				Name = "party_theaterTimeout",
				Description = "After not hearing from the host for this amount of time the client will timeout of the theater"
			},
			new DvarEntry
			{
				Name = "party_theaterTimeoutWhenLoading",
				Description = "After not hearing from the host for this amount of time the client will timeout of the theater when the film is loading"
			},
			new DvarEntry
			{
				Name = "party_lobbyExtensionTime",
				Description = "Extension time (in seconds) for the lobby min time during streaming."
			},
			new DvarEntry
			{
				Name = "party_forceMigrateAfterRound",
				Description = "we trigger a request for host migration after every game."
			},
			new DvarEntry
			{
				Name = "party_forceMigrateOnMatchStartRegression",
				Description = "we request a host migration when the match starting conditions regress (usually when a player leaves)."
			},
			new DvarEntry
			{
				Name = "party_requestMigrateDuringAutoStartIfStreaming",
				Description = "when nominating for host migration"
			},
			new DvarEntry
			{
				Name = "party_considerStreamingForHostMigration",
				Description = "when nominating for host migration"
			},
			new DvarEntry
			{
				Name = "party_keepPartyAliveWhileMatchmaking",
				Description = "party lobby will be sent heartbeat packets while matchmaking"
			},
			new DvarEntry
			{
				Name = "party_chooseLowestPingSlot",
				Description = "matchmaking will prioritize slots with the lowest ping"
			},
			new DvarEntry
			{
				Name = "using_original",
				Description = "Whether user has only original maps."
			},
			new DvarEntry
			{
				Name = "partyend_reason",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_maxMigrationTime",
				Description = "Maximum time before a host migration has failed"
			},
			new DvarEntry
			{
				Name = "party_maxDesperateMigrationTime",
				Description = "Maximum time before a host migration has failed due to lack of consensus"
			},
			new DvarEntry
			{
				Name = "party_neverJoinRecent",
				Description = "If true recent games are never joined during session searches"
			},
			new DvarEntry
			{
				Name = "party_leagueValidityGrace",
				Description = "Grace period before kicking members for being in invalid teams"
			},
			new DvarEntry
			{
				Name = "partyprober_chanceToFailAssociation",
				Description = "Probability that the party prober will simulate a failure to associate."
			},
			new DvarEntry
			{
				Name = "partyprober_chanceToFailConnection",
				Description = "Probability that the party prober will simulate a failure to connect."
			},
			new DvarEntry
			{
				Name = "partyprober_chanceToFailSend",
				Description = "Probability that the party prober will simulate the server dropping a packet we sent."
			},
			new DvarEntry
			{
				Name = "tu2_delayComErrorForPlaylistRules",
				Description = "Use a delayed com_error when erroring for playlist rules"
			},
			new DvarEntry
			{
				Name = "tu2_stopPartyForPlaylistRules",
				Description = "Stop the party when erroring for playlist rules"
			},
			new DvarEntry
			{
				Name = "tu6_ignoreSeasonPass",
				Description = "Ignore Season Pass when checking for missing DLC."
			},
			new DvarEntry
			{
				Name = "tu6_ignoreOtherModesDLC",
				Description = "Ignore ZM<->MP DLC when checking for missing DLC."
			},
			new DvarEntry
			{
				Name = "tu7_partyDoublePartyCloseFix",
				Description = "Awake the party lobby before shutting it down so it communicates correctly to clients."
			},
			new DvarEntry
			{
				Name = "tu8_cancelMatchStartReturnValue",
				Description = "Have the LUI function PartyHostCancelStartMatch return true for cancelling the start matach (success) and false for fail."
			},
			new DvarEntry
			{
				Name = "tu8_partyDisconnectExtraPacket",
				Description = "When disconnecting from a party send an extra disconnect package in case we have not parsed the party members yet."
			},
			new DvarEntry
			{
				Name = "tu4_removeClientsFromInactivePartyToNotify",
				Description = "Remove clients from partyToNotify when they are removed from the current active party or lobby."
			},
			new DvarEntry
			{
				Name = "tu4_removeUsingXuidClientFromPartyToNotify",
				Description = "Remove correct clients from partyToNotify when they are removed from the current active party or lobby."
			},
			new DvarEntry
			{
				Name = "party_memberUpdateBackoffRate",
				Description = "Rate at which we backoff member updates"
			},
			new DvarEntry
			{
				Name = "party_minMemberUpdateInterval",
				Description = "Minimum interval between member update messages"
			},
			new DvarEntry
			{
				Name = "party_maxMemberUpdateInterval",
				Description = "Maximum interval between member update messages"
			},
			new DvarEntry
			{
				Name = "party_migrateRestTime",
				Description = "Time to wait for the party state to relax before trying to migrate"
			},
			new DvarEntry
			{
				Name = "partymigrate_debugEnabled",
				Description = "Print debug info on reliable migrate on screen"
			},
			new DvarEntry
			{
				Name = "partymigrate_disabled",
				Description = "Set to true to disable party migration"
			},
			new DvarEntry
			{
				Name = "partymigrate_MaxBWPackets",
				Description = "number of bw test packets to send when we have the token"
			},
			new DvarEntry
			{
				Name = "partymigrate_MaxPacketWaitTime",
				Description = "ms to wait for test packet responses after last packet is sent"
			},
			new DvarEntry
			{
				Name = "partymigrate_NomineeWaitMS",
				Description = "ms to wait for each nominee to send us a partystate"
			},
			new DvarEntry
			{
				Name = "partymigrate_HostWaitMS",
				Description = "ms to send hostannounce packets before sending partystates"
			},
			new DvarEntry
			{
				Name = "partymigrate_NomineeRecalcInterval",
				Description = "ms to wait between recalculating migration nominees"
			},
			new DvarEntry
			{
				Name = "partymigrate_TestInterval",
				Description = "see partymigrate_TestIntervalJitter"
			},
			new DvarEntry
			{
				Name = "partymigrate_TestIntervalJitter",
				Description = "ms jitter between test rounds"
			},
			new DvarEntry
			{
				Name = "partymigrate_MinScoreDiff",
				Description = "minimum score nominee must differ by before rank will change"
			},
			new DvarEntry
			{
				Name = "db_xassetdebug",
				Description = "debug assets loading"
			},
			new DvarEntry
			{
				Name = "db_xassetdebugtype",
				Description = "debug assets loading type: -1 all; indexes start at 0"
			},
			new DvarEntry
			{
				Name = "db_xassetdebugname",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gump_name[v0]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restore_gump_name",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zone_reorder",
				Description = "Set to the name of the fast file you want to reorder"
			},
			new DvarEntry
			{
				Name = "devgui_colorBgnd",
				Description = "Color background for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorText",
				Description = "Text color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorBgndSel",
				Description = "Selection background color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorTextSel",
				Description = "Selection text color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorBgndGray",
				Description = "Grayed out background color for the devgui"
			},
			new DvarEntry
			{
				Name = "*(_DWORD *)devgui_colorTextGray.label",
				Description = "Greyed out text color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorBgndGraySel",
				Description = "selected background color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorTextGraySel",
				Description = "selected text color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorSliderBgnd",
				Description = "Color slider background for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorSliderKnob",
				Description = "Knob color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorSliderKnobSel",
				Description = "Selected knob color for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_bevelShade",
				Description = "Bevel shade for the devgui"
			},
			new DvarEntry
			{
				Name = "devgui_colorGraphKnotNormal",
				Description = "Devgiu Color graph knot normal color"
			},
			new DvarEntry
			{
				Name = "devgui_colorGraphKnotSelected",
				Description = "Devgui color graph knot selected color"
			},
			new DvarEntry
			{
				Name = "devgui_colorGraphKnotEditing",
				Description = "Devgui color graph knot editing color"
			},
			new DvarEntry
			{
				Name = "result",
				Description = "Enlarges the currently selected Devgui cell."
			},
			new DvarEntry
			{
				Name = "dynEnt_bulletForce",
				Description = "Force applied from bullet hit"
			},
			new DvarEntry
			{
				Name = "dynEnt_explodeForce",
				Description = "Force applied from explosion hit"
			},
			new DvarEntry
			{
				Name = "dynEnt_explodeUpbias",
				Description = "Upward bias applied to force directions from explosion hits"
			},
			new DvarEntry
			{
				Name = "dynEnt_explodeSpinScale",
				Description = "Scale of the random offset from the center of mass for explosion forces."
			},
			new DvarEntry
			{
				Name = "dynEnt_explodeMinForce",
				Description = "Force below which dynents won't even bother waking up"
			},
			new DvarEntry
			{
				Name = "dynEnt_explodeMaxEnts",
				Description = "The maximum number of dynents that can be awakened by one explosion"
			},
			new DvarEntry
			{
				Name = "dynEnt_spawnedLimit",
				Description = "or destructibles)"
			},
			new DvarEntry
			{
				Name = "tu6_dynEnt_disable_rb_collision",
				Description = "Disable rigid body collision for dyn ents with point or hinge constraints."
			},
			new DvarEntry
			{
				Name = "tu6_dynEnt_small_cylinder_dimension",
				Description = "Treats dyn ents with small cylinders less than this number in the X or Y as small for the purposes of angular velocity. Applies to dyn ents with point or hinge constraints. Set to 0 to disable."
			},
			new DvarEntry
			{
				Name = "tu6_dynEnt_small_cylinder_max_avel",
				Description = "Dyn ents with small cylinders will have their maximum angular velocity set to this value. Applies to dyn ents with point or hinge constraints."
			},
			new DvarEntry
			{
				Name = "dynEntPieces_velocity",
				Description = "Initial breakable pieces velocity"
			},
			new DvarEntry
			{
				Name = "dynEntPieces_angularVelocity",
				Description = "Initial breakable pieces angular velocity"
			},
			new DvarEntry
			{
				Name = "dynEntPieces_impactForce",
				Description = "Force applied when breakable is destroyed"
			},
			new DvarEntry
			{
				Name = "dynEnt_damageRadiusScale",
				Description = "Scale applied to radius for radius damage"
			},
			new DvarEntry
			{
				Name = "dynEnt_shouldCullEntitiesForSplitscreen",
				Description = "Cull alternating entities in splitscreen"
			},
			new DvarEntry
			{
				Name = "fx_enable",
				Description = "Toggles all effects processing"
			},
			new DvarEntry
			{
				Name = "fx_draw_dvar",
				Description = "Toggles drawing of effects after processing"
			},
			new DvarEntry
			{
				Name = "fx_marks_draw",
				Description = "Toggles whether decals are rendered"
			},
			new DvarEntry
			{
				Name = "fx_freeze",
				Description = "Freeze effects"
			},
			new DvarEntry
			{
				Name = "fx_debugBolt",
				Description = "Debug effects bolt"
			},
			new DvarEntry
			{
				Name = "fx_count",
				Description = "Debug effects count"
			},
			new DvarEntry
			{
				Name = "fx_visMinTraceDist",
				Description = "Minimum visibility trace size"
			},
			new DvarEntry
			{
				Name = "fx_profile",
				Description = "with '1' being the first.)"
			},
			new DvarEntry
			{
				Name = "fx_mark_profile",
				Description = "with '1' being the first.)"
			},
			new DvarEntry
			{
				Name = "fx_drawClouds",
				Description = "Toggles the drawing of particle clouds"
			},
			new DvarEntry
			{
				Name = "fx_priority_debug",
				Description = "with '1' being the first.)"
			},
			new DvarEntry
			{
				Name = "fx_priority_enable",
				Description = "Turn on priority"
			},
			new DvarEntry
			{
				Name = "fx_occlusion_query_profile",
				Description = "with '1' being the first.)"
			},
			new DvarEntry
			{
				Name = "fx_occlusion_max_player_count",
				Description = "Maximium number of local clients that FX is drawing sprite with occlusion test.)"
			},
			new DvarEntry
			{
				Name = "fx_draw_weapon_tags",
				Description = "Render weapon tag axis"
			},
			new DvarEntry
			{
				Name = "fx_use_ground_entity",
				Description = "entity ground entity is used to modify frameAtSpawn"
			},
			new DvarEntry
			{
				Name = "fx_marks_draw_impact_axis",
				Description = "Render impact mark axis for debugging"
			},
			new DvarEntry
			{
				Name = "fx_marks_debug_text",
				Description = "Show addition marks related debugging text"
			},
			new DvarEntry
			{
				Name = "fx_marks_range",
				Description = "marks will be made only within this range to camera"
			},
			new DvarEntry
			{
				Name = "fx_show_names_range",
				Description = "shows names of effects within this range"
			},
			new DvarEntry
			{
				Name = "fx_hide_superflare",
				Description = "Hide all superflare particles"
			},
			new DvarEntry
			{
				Name = "fx_enable_bounding_boxes",
				Description = "Enable effect bounding boxes"
			},
			new DvarEntry
			{
				Name = "fx_show_bounding_boxes",
				Description = "Show effect bounding boxes"
			},
			new DvarEntry
			{
				Name = "fx_force_bounding_boxes",
				Description = "Force all effects to use bounding boxes"
			},
			new DvarEntry
			{
				Name = "fx_enable_portal_culling",
				Description = "Enable effect portal culling"
			},
			new DvarEntry
			{
				Name = "fx_force_portal_culling",
				Description = "Force all effects (with bounding boxes) to be portal culled"
			},
			new DvarEntry
			{
				Name = "fx_alphacull_enable",
				Description = "toggles particle alpha-culling"
			},
			new DvarEntry
			{
				Name = "fx_marks_grid_debug",
				Description = "toggles marks grid debug display"
			},
			new DvarEntry
			{
				Name = "fx_marks_grid_enable",
				Description = "toggles marks grid-based culling"
			},
			new DvarEntry
			{
				Name = "fx_logging",
				Description = "toggles fx logging printf's"
			},
			new DvarEntry
			{
				Name = "bot_AllowMovement",
				Description = "Allow testclients to pathfind and move"
			},
			new DvarEntry
			{
				Name = "bot_ForceStand",
				Description = "Make testclients always stand"
			},
			new DvarEntry
			{
				Name = "bot_ForceCrouch",
				Description = "Make testclients always crouch"
			},
			new DvarEntry
			{
				Name = "bot_ForceProne",
				Description = "Make testclients always prone"
			},
			new DvarEntry
			{
				Name = "bot_ForceFire",
				Description = "Make testclients always fire"
			},
			new DvarEntry
			{
				Name = "bot_PressAttackBtn",
				Description = "Allow testclients to press attack button"
			},
			new DvarEntry
			{
				Name = "bot_PressMeleeBtn",
				Description = "Allow testclients to press melee button"
			},
			new DvarEntry
			{
				Name = "bot_ForceFragOnly",
				Description = "Force testclients to Frag grenades only"
			},
			new DvarEntry
			{
				Name = "bot_ForceSpecialOnly",
				Description = "Force testclients special frag grenades only"
			},
			new DvarEntry
			{
				Name = "bot_IgnoreHumans",
				Description = "Testclients will ignore human players"
			},
			new DvarEntry
			{
				Name = "bot_ForceYaw",
				Description = "Debug yaw used by bot when movement is disabled"
			},
			new DvarEntry
			{
				Name = "bot_Debug",
				Description = "Clientnum of bot to debug"
			},
			new DvarEntry
			{
				Name = "bot_DebugX",
				Description = "X-position of debug overlay"
			},
			new DvarEntry
			{
				Name = "bot_DebugY",
				Description = "Y-position of debug overlay"
			},
			new DvarEntry
			{
				Name = "bot_DebugThreat",
				Description = "Clientnum of bot to debug threat"
			},
			new DvarEntry
			{
				Name = "bot_DebugPaths",
				Description = "Clientnum of bot to debug path"
			},
			new DvarEntry
			{
				Name = "bot_DebugDanger",
				Description = "Team index to show dangerous areas"
			},
			new DvarEntry
			{
				Name = "bot_SnapshotDebug",
				Description = "Simulate writing/sending snapshots to bots. Used for snapshot debugging."
			},
			new DvarEntry
			{
				Name = "bot_friends",
				Description = "Number of friends allowed in basic training"
			},
			new DvarEntry
			{
				Name = "bot_enemies",
				Description = "Number of enemies allowed in basic training"
			},
			new DvarEntry
			{
				Name = "bot_difficulty",
				Description = "Difficulty level of the basic training bots"
			},
			new DvarEntry
			{
				Name = "bot_Fov",
				Description = "Bot field of view angle in degrees"
			},
			new DvarEntry
			{
				Name = "bot_GoalRadius",
				Description = "Bot goal radius"
			},
			new DvarEntry
			{
				Name = "bot_CloseDistance",
				Description = "Bot enemy close distance. Used for threat selection"
			},
			new DvarEntry
			{
				Name = "bot_SprintDistance",
				Description = "the bot will sprint"
			},
			new DvarEntry
			{
				Name = "bot_CrouchDistance",
				Description = "the bot will crouch"
			},
			new DvarEntry
			{
				Name = "bot_TargetLeadBias",
				Description = "The number of server frames used to predict an entity's position. Used for bot aiming when firing."
			},
			new DvarEntry
			{
				Name = "bot_UseFriendNames",
				Description = "Testclients will use names from the players' friends list"
			},
			new DvarEntry
			{
				Name = "bot_AllowGrenades",
				Description = "Allow the bots to throw grenades"
			},
			new DvarEntry
			{
				Name = "bot_MeleeDist",
				Description = "The range from the target from which the bot will press the melee button"
			},
			new DvarEntry
			{
				Name = "bot_MinGrenadeTime",
				Description = "The minimum amount of time in ms the bot must lose sight of his enemy before throwing a grenade."
			},
			new DvarEntry
			{
				Name = "bot_MaxGrenadeTime",
				Description = "The maximum amount of time in ms the bot must lose sight of his enemy before throwing a grenade."
			},
			new DvarEntry
			{
				Name = "bot_MinAdsTime",
				Description = "The minimum amount of time in ms the bot will remain in ADS. Used to prevent repeatedly popping in and out of ads."
			},
			new DvarEntry
			{
				Name = "bot_MaxAdsTime",
				Description = "The maximum amount of time in ms the bot will remain in ADS. Used to prevent repeatedly popping in and out of ads."
			},
			new DvarEntry
			{
				Name = "bot_MinPitchTime",
				Description = "The minimum amount of time in ms the bot will hold his current pitch on the target when engaged"
			},
			new DvarEntry
			{
				Name = "bot_MaxPitchTime",
				Description = "The maximum amount of time in ms the bot will hold his current pitch on the target when engaged"
			},
			new DvarEntry
			{
				Name = "bot_MinCrouchTime",
				Description = "The minimum amount of time in ms the bot will hold his crouch stance"
			},
			new DvarEntry
			{
				Name = "bot_MaxCrouchTime",
				Description = "The maximum amount of time in ms the bot will hold his crouch stance"
			},
			new DvarEntry
			{
				Name = "bot_MinDeathTime",
				Description = "The minimum amount of time in ms the bot will hold his position while his target is dead"
			},
			new DvarEntry
			{
				Name = "bot_MaxDeathTime",
				Description = "The maximum amount of time in ms the bot will hold his position while his target is dead"
			},
			new DvarEntry
			{
				Name = "bot_MinFireTime",
				Description = "the minimum amount of time the bot will delay before firing again. Used to simulate the time to depress and press the controller attack trigger."
			},
			new DvarEntry
			{
				Name = "bot_MaxFireTime",
				Description = "the maximum amount of time the bot will delay before firing again. Used to simulate the time to depress and press the controller attack trigger."
			},
			new DvarEntry
			{
				Name = "bot_MinReactionTime",
				Description = "Bot minimum time to react when first seeing a target"
			},
			new DvarEntry
			{
				Name = "bot_MaxReactionTime",
				Description = "Bot maximum time to react when first seeing a target"
			},
			new DvarEntry
			{
				Name = "bot_YawSpeed",
				Description = "Bot yaw rate for normal turning"
			},
			new DvarEntry
			{
				Name = "bot_YawSpeedAds",
				Description = "Bot yaw rate for slower (fine tuning) turning"
			},
			new DvarEntry
			{
				Name = "bot_PitchUp",
				Description = "Bot pitch maximum (looking upward)"
			},
			new DvarEntry
			{
				Name = "bot_PitchDown",
				Description = "Bot pitch minimum (looking downward)"
			},
			new DvarEntry
			{
				Name = "bot_PitchSpeed",
				Description = "Bot pitch lerp speed"
			},
			new DvarEntry
			{
				Name = "bot_PitchSpeedAds",
				Description = "Bot pitch lerp speed used when engaging"
			},
			new DvarEntry
			{
				Name = "bot_StrafeChance",
				Description = "The percentage chance that the bot will strafe when engaged"
			},
			new DvarEntry
			{
				Name = "bot_MinStrafeTime",
				Description = "Bot minimum time to strafe when engaged"
			},
			new DvarEntry
			{
				Name = "bot_MaxStrafeTime",
				Description = "Bot maximum time to strafe when engaged"
			},
			new DvarEntry
			{
				Name = "tu7_botsCountAsPartyMembers",
				Description = "allow the party host to count the bot count as party members in order to transmit an accurate player count to clients"
			},
			new DvarEntry
			{
				Name = "vehHelicopterHoverSpeedThreshold",
				Description = "for hovering"
			},
			new DvarEntry
			{
				Name = "vehHelicopterRightStickDeadzone",
				Description = "Dead-zone for the axes of the right thumbstick.This helps to better control the two axes separately."
			},
			new DvarEntry
			{
				Name = "vehHelicopterStrafeDeadzone",
				Description = "Dead-zone so that you can fly straight forward easily without accidentally strafing (and thus rolling)."
			},
			new DvarEntry
			{
				Name = "vehHelicopterScaleMovement",
				Description = "Scales down the smaller of the left stick axes."
			},
			new DvarEntry
			{
				Name = "vehHelicopterYawAltitudeControls",
				Description = "Determines how to control yaw and altitude"
			},
			new DvarEntry
			{
				Name = "vehHelicopterSoftCollisions",
				Description = "Player helicopters have soft collisions (slow down before they collide)."
			},
			new DvarEntry
			{
				Name = "vehHelicopterInvertUpDown",
				Description = "Invert the altitude control on the player helicopter."
			},
			new DvarEntry
			{
				Name = "vehHelicopterYawOnLeftStick",
				Description = "moving forward and strafing slightly)."
			},
			new DvarEntry
			{
				Name = "vehHelicopterTiltFromViewangles",
				Description = "The amount of tilt caused by the current velocity"
			},
			new DvarEntry
			{
				Name = "vehHelicopterPathTransitionTime",
				Description = "How quickly the helicopter transitions from driving path to locked path."
			},
			new DvarEntry
			{
				Name = "vehHelicopterFreeLook",
				Description = "Allow free look with left trigger."
			},
			new DvarEntry
			{
				Name = "vehHelicopterDefaultPitch",
				Description = "Set the default pitch of the helicopter."
			},
			new DvarEntry
			{
				Name = "vehHelicopterRotDecel",
				Description = "Set the rotational deceleration or dampening for the helicopter."
			},
			new DvarEntry
			{
				Name = "vehHelicopterMinHeightLockOffset",
				Description = "The maximum the helicopter can move below the height mesh."
			},
			new DvarEntry
			{
				Name = "vehHelicopterMaxHeightLockOffset",
				Description = "The maximum the helicopter can move above the height mesh."
			},
			new DvarEntry
			{
				Name = "vehHelicopterRotDecel",
				Description = "Set the rotational deceleration or dampening for the helicopter."
			},
			new DvarEntry
			{
				Name = "vehHelicopterLookaheadTime",
				Description = "you should keep 2 seconds distance between you and the vehicle in front of you)"
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundsOn",
				Description = "Heli bounds on/off."
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundMapUpperLeftX",
				Description = "Helicopter Bounding box."
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundMapUpperLeftY",
				Description = "Helicopter Bounding box."
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundMapLowerRightX",
				Description = "Helicopter Bounding box."
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundMapLowerRightY",
				Description = "Helicopter Bounding box."
			},
			new DvarEntry
			{
				Name = "vehHelicopterboundMapHeight",
				Description = "Helicopter Bounding height."
			},
			new DvarEntry
			{
				Name = "vehPlaneAssistedFlying",
				Description = "This is set when the plane is using assisted flying."
			},
			new DvarEntry
			{
				Name = "vehPlaneConventionalFlight",
				Description = "Setting this will make the plane fly ctol only. Default is ctol/vtol combo."
			},
			new DvarEntry
			{
				Name = "vehPlaneSpeedControl",
				Description = "Setting this will give the player speed control."
			},
			new DvarEntry
			{
				Name = "vehPlanePlayerAvoidance",
				Description = "Enable/Disable player building avoidance."
			},
			new DvarEntry
			{
				Name = "vehPlaneTurnAssistDecayRate",
				Description = "The rate at which the yaw and pitch input from the mouse are kept between frames. Used when the flying assisted."
			},
			new DvarEntry
			{
				Name = "v2",
				Description = "Show the script source for all hud alloc / free calls"
			},
			new DvarEntry
			{
				Name = "g_connectpaths",
				Description = "Connect paths"
			},
			new DvarEntry
			{
				Name = "g_removeRedundantLinks",
				Description = "Remove redundant links from path graph"
			},
			new DvarEntry
			{
				Name = "g_ignoreVisData",
				Description = "Do not generate or save the vis data on the nodes"
			},
			new DvarEntry
			{
				Name = "g_loadScripts",
				Description = "Disable scripts from loading"
			},
			new DvarEntry
			{
				Name = "g_erroronpathsnotconnected",
				Description = "Errors out during load if paths are not connected."
			},
			new DvarEntry
			{
				Name = "gamename",
				Description = "The name of the game"
			},
			new DvarEntry
			{
				Name = "gamedate",
				Description = "The date compiled"
			},
			new DvarEntry
			{
				Name = "g_gametype",
				Description = "The current campaign"
			},
			new DvarEntry
			{
				Name = "g_disableDemonwareSubscriptionRefresh",
				Description = "disables refreshing of Demonware's first party subscription values."
			},
			new DvarEntry
			{
				Name = "g_disableEliteButton",
				Description = "disables main lobby elite button"
			},
			new DvarEntry
			{
				Name = "g_disableEliteEmblemUploads",
				Description = "disables Elite emblem uploads"
			},
			new DvarEntry
			{
				Name = "g_disableEliteRegistrationPopup",
				Description = "disables Elite registration popup"
			},
			new DvarEntry
			{
				Name = "g_disablePlatformAutofill",
				Description = "disables platform autofill functionality"
			},
			new DvarEntry
			{
				Name = "g_minNumLogins_Before_ERegPopup",
				Description = "num logins before ERegPopup"
			},
			new DvarEntry
			{
				Name = "g_minElapsedTime_Before_ERegPopup",
				Description = "min elapsed time before ERegPopup"
			},
			new DvarEntry
			{
				Name = "g_maxElapsedTime_Before_ERegPopup",
				Description = "max elapsed time before ERegPopup"
			},
			new DvarEntry
			{
				Name = "g_maxERegPopupsShown",
				Description = "max # of ERegPopups possible"
			},
			new DvarEntry
			{
				Name = "g_minElapsedTime_Before_RefreshUCDAccountStatus",
				Description = "min elapsed time before refreshing UCDAccountStatus"
			},
			new DvarEntry
			{
				Name = "ui_scrollSpeed",
				Description = "controls scrolling speed for custom scrolling renderer foudn in lui custom element"
			},
			new DvarEntry
			{
				Name = "ui_scrollFontScale",
				Description = "controls font scale for scrolling custom element"
			},
			new DvarEntry
			{
				Name = "ui_scrollMinUpdateInterval",
				Description = "controls scrolling custom element min update time interval (ms)"
			},
			new DvarEntry
			{
				Name = "ui_scrollEmptySpaceHeightPercentage",
				Description = "controls empty space height percentage for scroll bar used by scrolling custom element"
			},
			new DvarEntry
			{
				Name = "ui_scrollBarWidth",
				Description = "controls scroll bar width used by scrolling custom element"
			},
			new DvarEntry
			{
				Name = "ui_scrollByRow",
				Description = "scroll the custom element by a number of rows"
			},
			new DvarEntry
			{
				Name = "ui_scrollOverrideLanguage",
				Description = "overrides the TOS language shown in the scrolling custom element."
			},
			new DvarEntry
			{
				Name = "g_synchronousClients",
				Description = "Call 'client think' exactly once for each server frame to make smooth demos"
			},
			new DvarEntry
			{
				Name = "g_log",
				Description = "Log file name"
			},
			new DvarEntry
			{
				Name = "g_logTimeStampInSeconds",
				Description = "Enable logging with time stamps in seconds since UTC 1/1/1970"
			},
			new DvarEntry
			{
				Name = "g_logSync",
				Description = "Enable synchronous logging"
			},
			new DvarEntry
			{
				Name = "g_password",
				Description = "Password"
			},
			new DvarEntry
			{
				Name = "g_banIPs",
				Description = "IP addresses to ban from playing"
			},
			new DvarEntry
			{
				Name = "g_speed",
				Description = "Player speed"
			},
			new DvarEntry
			{
				Name = "g_knockback",
				Description = "Maximum knockback"
			},
			new DvarEntry
			{
				Name = "g_maxDroppedWeapons",
				Description = "Maximum number of dropped weapons"
			},
			new DvarEntry
			{
				Name = "g_debugDamage",
				Description = "Show debug information for damage"
			},
			new DvarEntry
			{
				Name = "g_debugBullets",
				Description = "Show debug information for bullets"
			},
			new DvarEntry
			{
				Name = "g_vehicleDrawPath",
				Description = "Turn on debug information for vehicle paths"
			},
			new DvarEntry
			{
				Name = "g_vehicleDrawSplines",
				Description = "Draws the vehicles splines"
			},
			new DvarEntry
			{
				Name = "g_ai",
				Description = "Enable AI"
			},
			new DvarEntry
			{
				Name = "g_spawnai",
				Description = "Enable AI spawning"
			},
			new DvarEntry
			{
				Name = "g_dumpAIEvents",
				Description = "Print AI events happening for this entity"
			},
			new DvarEntry
			{
				Name = "ai_turnRate",
				Description = "turn rate for AI"
			},
			new DvarEntry
			{
				Name = "ai_useFacingTranslation",
				Description = "whether to use facing to determine direction of translation"
			},
			new DvarEntry
			{
				Name = "ai_useLeanRunAnimations",
				Description = "whether to use lean run animations instead of strafes"
			},
			new DvarEntry
			{
				Name = "ai_useBetterLookahead",
				Description = "t5 lookahead improvements (not for MP - PETER)"
			},
			new DvarEntry
			{
				Name = "ai_slowdownMinYawDiff",
				Description = "min yaw diff before slowdown kicks in"
			},
			new DvarEntry
			{
				Name = "ai_slowdownMaxYawDiff",
				Description = "max yaw diff used for slowdown cal"
			},
			new DvarEntry
			{
				Name = "ai_slowdownMinRate",
				Description = "anim rate at ai_slowdownMaxYawDiff"
			},
			new DvarEntry
			{
				Name = "ai_slowdownRateBlendFactor",
				Description = "percent of desired rate that goes into final rate"
			},
			new DvarEntry
			{
				Name = "ai_angularYawEnabled",
				Description = "turn on velocity based body rotation"
			},
			new DvarEntry
			{
				Name = "ai_angularYawAccelRate",
				Description = "yaw acceleration rate"
			},
			new DvarEntry
			{
				Name = "ai_angularYawDecelFactor",
				Description = "yaw deceleration factor (decel rate = factor * accel rate)"
			},
			new DvarEntry
			{
				Name = "ai_trim_path_zigzags",
				Description = "enables/disables the goal nodes pickup logic"
			},
			new DvarEntry
			{
				Name = "ai_corpseCount",
				Description = "Maximum number of AI corpses"
			},
			new DvarEntry
			{
				Name = "ai_showNodes",
				Description = "Show AI navigation node debug information"
			},
			new DvarEntry
			{
				Name = "ai_showNodesDist",
				Description = "Maximum distance from the camera at which AI nodes are shown"
			},
			new DvarEntry
			{
				Name = "ai_showNearestNode",
				Description = "Show nodes closest to AI"
			},
			new DvarEntry
			{
				Name = "ai_showNodeDrawType",
				Description = "Change ai_showNodes to render double wide or flying nodes"
			},
			new DvarEntry
			{
				Name = "ai_showVisData",
				Description = "Display debug information for visibility data"
			},
			new DvarEntry
			{
				Name = "ai_showVisDataDist",
				Description = "Maximum distance for visibility data debugging information to be shown"
			},
			new DvarEntry
			{
				Name = "ai_showPaths",
				Description = "Show AI navigation paths"
			},
			new DvarEntry
			{
				Name = "ai_showPathFindNodes",
				Description = "Show nodes consider in latest path find"
			},
			new DvarEntry
			{
				Name = "ai_showFailedPaths",
				Description = "Shows failed AStar searches that take longer than the dvar value in milliseconds."
			},
			new DvarEntry
			{
				Name = "ai_debugFindPath",
				Description = "Display AI 'find path' debugging information"
			},
			new DvarEntry
			{
				Name = "ai_debugFindPathDirect",
				Description = "Display AI 'find direct path' debugging information"
			},
			new DvarEntry
			{
				Name = "ai_debugFindPathWidth",
				Description = "Display paths with the given width"
			},
			new DvarEntry
			{
				Name = "ai_debugFindPathLock",
				Description = "Find path lock"
			},
			new DvarEntry
			{
				Name = "ai_debugClaimedNodes",
				Description = "Enable debugging information claimed status of nodes"
			},
			new DvarEntry
			{
				Name = "ai_disableSpawn",
				Description = "Do not spawn AI"
			},
			new DvarEntry
			{
				Name = "ai_moveOrientMode",
				Description = "Debug AI Orient Mode"
			},
			new DvarEntry
			{
				Name = "ai_ShowCanshootChecks",
				Description = "Display debugging information for 'can shoot' checks"
			},
			new DvarEntry
			{
				Name = "ai_pathNegotiationOverlapCost",
				Description = "The distance AI would travel around to avoid going to a negotiation being used. Multiplied by number of users of the negotiation"
			},
			new DvarEntry
			{
				Name = "ai_pathChokePointCost",
				Description = "The distance AI would travel around to randomly avoid going through a choke point."
			},
			new DvarEntry
			{
				Name = "ai_pathRandomPercent",
				Description = "Amount of random cost percent to add to each path node so AI always take slightly different routes"
			},
			new DvarEntry
			{
				Name = "ai_showPotentialThreatDir",
				Description = "Display AI potential threat direction"
			},
			new DvarEntry
			{
				Name = "ai_debugCoverEntityNum",
				Description = "Display debug info for cover"
			},
			new DvarEntry
			{
				Name = "ai_showBadPlaces",
				Description = "Display debug information for 'bad places'"
			},
			new DvarEntry
			{
				Name = "ai_showDodge",
				Description = "Display debug information for AI dodging"
			},
			new DvarEntry
			{
				Name = "ai_noDodge",
				Description = "AI won't dodge to the side"
			},
			new DvarEntry
			{
				Name = "ai_pathMomentum",
				Description = "Momentum factor for continuing motion in previous direction. 0 for no momentum carry over"
			},
			new DvarEntry
			{
				Name = "ai_debugMayMove",
				Description = "Display debug information for AI 'may move' calculations"
			},
			new DvarEntry
			{
				Name = "ai_showVolume",
				Description = "Draw the goal volume and fixed node safe volume for an AI"
			},
			new DvarEntry
			{
				Name = "ai_debugAnimDeltas",
				Description = "Display animation delta debug information"
			},
			new DvarEntry
			{
				Name = "ai_debugThreatSelection",
				Description = "Enable debugging information for threat selection"
			},
			new DvarEntry
			{
				Name = "ai_debugMeleeAttackSpots",
				Description = "Enable debugging information for melee attack spots"
			},
			new DvarEntry
			{
				Name = "ai_debugEntIndex",
				Description = "Entity index of an entity to debug"
			},
			new DvarEntry
			{
				Name = "ai_eventDistFootstep",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistFootstepLite",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistNewEnemy",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistReact",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistPain",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistDeath",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistExplosion",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistGrenadePing",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistProjPing",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistGunShot",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistSilencedShot",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistBullet",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistBulletRunning",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistProjImpact",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_eventDistBadPlace",
				Description = "Distance used for AI event"
			},
			new DvarEntry
			{
				Name = "ai_playerNearAccuracy",
				Description = "Accuracy for an AI near to a player"
			},
			new DvarEntry
			{
				Name = "ai_playerNearRange",
				Description = "Maximum range for AI to use 'near' accuracy"
			},
			new DvarEntry
			{
				Name = "ai_playerFarAccuracy",
				Description = "Accuracy for AI far away from the player"
			},
			new DvarEntry
			{
				Name = "ai_playerFarRange",
				Description = "Minimum range for AI to use 'far' accuracy"
			},
			new DvarEntry
			{
				Name = "ai_threatUpdateInterval",
				Description = "AI target threat update interval in milliseconds"
			},
			new DvarEntry
			{
				Name = "ai_foliageIngoreDist",
				Description = "Maximum distance AI ignore foliage for sight trace to targets"
			},
			new DvarEntry
			{
				Name = "ai_friendlySuppression",
				Description = "Whether AI fire will suppression teammates or not."
			},
			new DvarEntry
			{
				Name = "ai_friendlySuppressionDist",
				Description = "Max distance at which AI suppress teammates"
			},
			new DvarEntry
			{
				Name = "ai_meleeRange",
				Description = "The maximum range of the AI's melee attack"
			},
			new DvarEntry
			{
				Name = "ai_meleeWidth",
				Description = "The width of the AI's melee attack"
			},
			new DvarEntry
			{
				Name = "ai_meleeHeight",
				Description = "The height of the AI's melee attack"
			},
			new DvarEntry
			{
				Name = "ai_meleeDamage",
				Description = "The amount of damage dealt by AI's melee attack"
			},
			new DvarEntry
			{
				Name = "ai_maxAttackerCount",
				Description = "Max number of AI's that will attack one player"
			},
			new DvarEntry
			{
				Name = "bullet_penetrationEnabled",
				Description = "Enable/Disable bullet penetration."
			},
			new DvarEntry
			{
				Name = "g_entinfo",
				Description = "Display entity information"
			},
			new DvarEntry
			{
				Name = "g_entinfo_type",
				Description = "Type of entities to display information"
			},
			new DvarEntry
			{
				Name = "g_entinfo_AItext",
				Description = "Type of text information for AI entinfo"
			},
			new DvarEntry
			{
				Name = "g_entinfo_maxdist",
				Description = "Maximum distance of an entity from the camera at which to show entity information"
			},
			new DvarEntry
			{
				Name = "g_entinfo_scale",
				Description = "Scale of the entity information text"
			},
			new DvarEntry
			{
				Name = "g_debugPlayerAnimScript",
				Description = "Show debug information for playeranim.script"
			},
			new DvarEntry
			{
				Name = "g_motd",
				Description = "The message of the day"
			},
			new DvarEntry
			{
				Name = "g_allowVote",
				Description = "Enable voting on this server"
			},
			new DvarEntry
			{
				Name = "g_listEntity",
				Description = "List the entities"
			},
			new DvarEntry
			{
				Name = "g_listEntityCounts",
				Description = "list all of the current entities counts"
			},
			new DvarEntry
			{
				Name = "g_entsInSnapshot",
				Description = "the number of ents in the snapshot (read only)"
			},
			new DvarEntry
			{
				Name = "g_maxEntsInSnapshot",
				Description = "the high water mark number of ents in all snapshots (read only)"
			},
			new DvarEntry
			{
				Name = "g_TeamIcon_Allies",
				Description = "Shader name for the allied scores banner"
			},
			new DvarEntry
			{
				Name = "g_TeamIcon_Axis",
				Description = "Shader name for the axis scores banner"
			},
			new DvarEntry
			{
				Name = "g_TeamIcon_Free",
				Description = "Shader name for the scores of players with no team"
			},
			new DvarEntry
			{
				Name = "g_TeamIcon_Spectator",
				Description = "Shader name for the scores of players who are spectators"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_MyTeam",
				Description = "Player team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_EnemyTeam",
				Description = "Enemy team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_Spectator",
				Description = "Spectator team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_Free",
				Description = "Free Team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_Allies",
				Description = "Allies team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_ScoresColor_Axis",
				Description = "Axis team color on scoreboard"
			},
			new DvarEntry
			{
				Name = "g_customTeamName_Allies",
				Description = "User assigned allied team name"
			},
			new DvarEntry
			{
				Name = "g_customTeamName_Axis",
				Description = "User assigned axis team name"
			},
			new DvarEntry
			{
				Name = "g_customTeamName_Three",
				Description = "User assigned three team name"
			},
			new DvarEntry
			{
				Name = "g_TeamName_Allies",
				Description = "Allied team name"
			},
			new DvarEntry
			{
				Name = "g_TeamName_Axis",
				Description = "Axis team name"
			},
			new DvarEntry
			{
				Name = "g_TeamName_Three",
				Description = "Three team name"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_Allies",
				Description = "Allies team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_Axis",
				Description = "Axis team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_MyTeam",
				Description = "Player team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_EnemyTeam",
				Description = "Enemy team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_MyTeamAlt",
				Description = "Player team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_EnemyTeamAlt",
				Description = "Enemy team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_Party",
				Description = "Party color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_Spectator",
				Description = "Spectator team color"
			},
			new DvarEntry
			{
				Name = "g_TeamColor_Free",
				Description = "Free Team color"
			},
			new DvarEntry
			{
				Name = "g_debugLocDamage",
				Description = "Turn on debugging information for locational damage (2 = show results of bullet trace pose only)"
			},
			new DvarEntry
			{
				Name = "g_debugLocDamageEntity",
				Description = "Write animation commands debug info for this entity"
			},
			new DvarEntry
			{
				Name = "g_debugLocHit",
				Description = "Display locational damage info for an entity when the entity is hit"
			},
			new DvarEntry
			{
				Name = "g_debugLocHitTime",
				Description = "Time duration of g_debugLocHit lines"
			},
			new DvarEntry
			{
				Name = "g_NoScriptSpam",
				Description = "Turn off script debugging info"
			},
			new DvarEntry
			{
				Name = "g_friendlyfireDist",
				Description = "Maximum range for disabling fire at a friendly"
			},
			new DvarEntry
			{
				Name = "g_friendlyNameDist",
				Description = "Maximum range for seeing a friendly's name"
			},
			new DvarEntry
			{
				Name = "melee_debug",
				Description = "Turn on debug lines for melee traces"
			},
			new DvarEntry
			{
				Name = "radius_damage_debug",
				Description = "Turn on debug lines for radius damage traces"
			},
			new DvarEntry
			{
				Name = "player_throwbackInnerRadius",
				Description = "The radius to a live grenade player must be within initially to do a throwback"
			},
			new DvarEntry
			{
				Name = "player_throwbackOuterRadius",
				Description = "The radius player is allow to throwback a grenade once the player has been in the inner radius"
			},
			new DvarEntry
			{
				Name = "player_throwbackOuterRadius_zm",
				Description = "The radius player is allow to throwback a grenade once the player has been in the inner radius zm"
			},
			new DvarEntry
			{
				Name = "player_useRadius",
				Description = "The radius within which a player can use things"
			},
			new DvarEntry
			{
				Name = "player_useRadius_zm",
				Description = "The radius within which a player can use things in zombiemode"
			},
			new DvarEntry
			{
				Name = "player_MGUseRadius",
				Description = "The radius within which a player can mount a machine gun"
			},
			new DvarEntry
			{
				Name = "vehicle_useRadius",
				Description = "The radius within which a player can enter a vehicle"
			},
			new DvarEntry
			{
				Name = "g_minGrenadeDamageSpeed",
				Description = "Minimum speed at which getting hit be a grenade will do damage (not the grenade explosion damage)"
			},
			new DvarEntry
			{
				Name = "g_compassShowEnemies",
				Description = "Whether enemies are visible on the compass at all times"
			},
			new DvarEntry
			{
				Name = "pickupPrints",
				Description = "etc."
			},
			new DvarEntry
			{
				Name = "g_dumpAnims",
				Description = "Animation debugging info for the given character number"
			},
			new DvarEntry
			{
				Name = "g_dumpAnimsCommands",
				Description = "Write animation commands debug info for this entity"
			},
			new DvarEntry
			{
				Name = "g_useholdspawndelay",
				Description = "Time in milliseconds that the player is unable to 'use' after spawning"
			},
			new DvarEntry
			{
				Name = "g_redCrosshairs",
				Description = "Whether red crosshairs are enabled"
			},
			new DvarEntry
			{
				Name = "g_mantleBlockTimeBuffer",
				Description = "Time that the client think is delayed after mantling"
			},
			new DvarEntry
			{
				Name = "g_vehicleDebug",
				Description = "Turn on debug information for vehicles"
			},
			new DvarEntry
			{
				Name = "vehGunnerSplashDamage",
				Description = "Percentage of projectile and grenade splash damage that vehicle gunners take."
			},
			new DvarEntry
			{
				Name = "g_quadrotorFlyHeight",
				Description = "Default fly height of the quadrotors"
			},
			new DvarEntry
			{
				Name = "g_avoidEnabled",
				Description = "Disable the vehicle avoidance"
			},
			new DvarEntry
			{
				Name = "turretPlayerAvoidScale",
				Description = "the farther the player is from the turret.Use this dvar to scale the cone size."
			},
			new DvarEntry
			{
				Name = "g_vehiclePlaneCurveTime",
				Description = "Time between start and end nodes for curves [used in AI planes on curves]"
			},
			new DvarEntry
			{
				Name = "anim_deltas_debug",
				Description = "Enable animation debug data"
			},
			new DvarEntry
			{
				Name = "g_destructibleDraw",
				Description = "Render destructible debug info"
			},
			new DvarEntry
			{
				Name = "g_debugServerAiming",
				Description = "Render where the server thinks the client is aiming"
			},
			new DvarEntry
			{
				Name = "g_actorAndVehicleAntilag",
				Description = "Enable singleplayer/co-op antilag"
			},
			new DvarEntry
			{
				Name = "g_actorAndVehicleAntilagDebug",
				Description = "Render singleplayer/co-op antilag debugging info"
			},
			new DvarEntry
			{
				Name = "g_broadcastLocalSound",
				Description = "Broadcast local sound commands to spectators"
			},
			new DvarEntry
			{
				Name = "g_connectpaths",
				Description = "Connect paths"
			},
			new DvarEntry
			{
				Name = "g_removeRedundantLinks",
				Description = "Remove redundant links from path graph"
			},
			new DvarEntry
			{
				Name = "g_ignoreVisData",
				Description = "Do not generate or save the vis data on the nodes"
			},
			new DvarEntry
			{
				Name = "g_fogColorReadOnly",
				Description = "Fog color that was set in the most recent call to setexpfog"
			},
			new DvarEntry
			{
				Name = "g_fogStartDistReadOnly",
				Description = "Fog start distance that was set in the most recent call to setexpfog"
			},
			new DvarEntry
			{
				Name = "g_fogHalfDistReadOnly",
				Description = "Fog start distance that was set in the most recent call to setexpfog"
			},
			new DvarEntry
			{
				Name = "vehPlaneRollDeadZone",
				Description = "Roll input dead zone. Percentage of stick movement to ignore for roll."
			},
			new DvarEntry
			{
				Name = "vehPlaneRollAccel",
				Description = "Adjustable rotation scaler."
			},
			new DvarEntry
			{
				Name = "vehPlanePitchAccel",
				Description = "Adjustable rotation scaler."
			},
			new DvarEntry
			{
				Name = "vehPlaneYawSpeed",
				Description = "Adjustable rotation scaler."
			},
			new DvarEntry
			{
				Name = "vehPlaneYawFromRollScale",
				Description = "Adjustable rotation scaler."
			},
			new DvarEntry
			{
				Name = "vehPlaneLiftForce",
				Description = "Lift force on aircraft."
			},
			new DvarEntry
			{
				Name = "vehPlaneFakeLiftForce",
				Description = "Fake lift force on aircraft.Adds extra pitch when non-horizontal."
			},
			new DvarEntry
			{
				Name = "vehPlaneLowSpeed",
				Description = "Min speed."
			},
			new DvarEntry
			{
				Name = "vehPlaneGravityForce",
				Description = "Gravity force on aircraft."
			},
			new DvarEntry
			{
				Name = "vehicle_switch_seat_delay",
				Description = "Delay before player can switch seats again."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_max_shielding",
				Description = "Percent of core damage that armor can shield."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_zone_front",
				Description = "Front zone damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_zone_side",
				Description = "Side zone damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_zone_rear",
				Description = "Rear zone damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_zone_under",
				Description = "Bottom zone damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_bullet",
				Description = "Bullet damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_grenade",
				Description = "Grenade damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_projectile",
				Description = "Projectile damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_bouncing_betty",
				Description = "Bouncing betty damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_satchel_charge",
				Description = "Satchel charge damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_damage_sticky_grenade",
				Description = "Sticky grenade damage for vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_piece_damagesfx_threshold",
				Description = "Minimum amount of damage for which a destructible piece damageSound SFX will be played."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_grenade",
				Description = "Grenade damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_bouncing_betty",
				Description = "Bouncing betty damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_satchel_charge",
				Description = "Satchel charge damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_sticky_grenade",
				Description = "Sticky grenade damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_grenade_radius",
				Description = "Radius for grenade damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_bouncing_betty_radius",
				Description = "Radius for bouncing betty damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_satchel_charge_radius",
				Description = "Radius for satchel charge damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_sticky_grenade_radius",
				Description = "Radius for sticky grenade damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "vehicle_destructible_damage_projectile_radius",
				Description = "Radius for projectile damage for destructible armor on vehicles."
			},
			new DvarEntry
			{
				Name = "tu_dontDropKillstreakOnDeath",
				Description = ""
			},
			new DvarEntry
			{
				Name = "g_lagged_damage_threshold",
				Description = "Threshold (ms) beyond which we will report a damaged lagged client to the tracker leaderboards."
			},
			new DvarEntry
			{
				Name = "vehicle_infinite_boost",
				Description = "used in the devgui."
			},
			new DvarEntry
			{
				Name = "g_turretServerPitchMin",
				Description = "Limit turret pitch range on server (visual only)"
			},
			new DvarEntry
			{
				Name = "g_turretServerPitchMax",
				Description = "Limit turret pitch range on server (visual only)"
			},
			new DvarEntry
			{
				Name = "g_turretBipodOffset",
				Description = "Offset bipod mount position on gun by this distance"
			},
			new DvarEntry
			{
				Name = "missileHellfireMaxSlope",
				Description = "This limits how steeply the hellfire missile can turn upward when climbing"
			},
			new DvarEntry
			{
				Name = "missileHellfireUpAccel",
				Description = "The rate at which the hellfire missile curves upward"
			},
			new DvarEntry
			{
				Name = "missileJavClimbHeightDirect",
				Description = "how far above the target the rocket will aim for when climbing."
			},
			new DvarEntry
			{
				Name = "missileJavClimbHeightTop",
				Description = "how far above the target the rocket will aim for when climbing."
			},
			new DvarEntry
			{
				Name = "missileJavClimbAngleDirect",
				Description = "the minimum angle between the rocket and target until the rocket stops climbing.Smaller angles make for higher climbs."
			},
			new DvarEntry
			{
				Name = "missileJavClimbAngleTop",
				Description = "the minimum angle between the rocket and target until the rocket stops climbing.Smaller angles make for higher climbs."
			},
			new DvarEntry
			{
				Name = "missileJavClimbCeilingDirect",
				Description = "how high the missile needs to reach before it descends."
			},
			new DvarEntry
			{
				Name = "missileJavClimbCeilingTop",
				Description = "how high the missile needs to reach before it descends."
			},
			new DvarEntry
			{
				Name = "missileJavTurnRateDirect",
				Description = "in angles/sec."
			},
			new DvarEntry
			{
				Name = "missileJavTurnRateTop",
				Description = "in angles/sec."
			},
			new DvarEntry
			{
				Name = "missileJavAccelClimb",
				Description = "Rocket acceleration when climbing."
			},
			new DvarEntry
			{
				Name = "missileJavAccelDescend",
				Description = "Rocket acceleration when descending towards target."
			},
			new DvarEntry
			{
				Name = "missileJavSpeedLimitClimb",
				Description = "Rocket's speed limit when climbing."
			},
			new DvarEntry
			{
				Name = "missileJavSpeedLimitDescend",
				Description = "Rocket's speed limit when descending towards target."
			},
			new DvarEntry
			{
				Name = "missileJavTurnDecel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileJavClimbToOwner",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileDroneClimbHeightDirect",
				Description = "how far above the target the rocket will aim for when climbing."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbHeightTop",
				Description = "how far above the target the rocket will aim for when climbing."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbAngleDirect",
				Description = "the minimum angle between the rocket and target until the rocket stops climbing.Smaller angles make for higher climbs."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbAngleTop",
				Description = "the minimum angle between the rocket and target until the rocket stops climbing.Smaller angles make for higher climbs."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbCeilingDirect",
				Description = "how high the missile needs to reach before it descends."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbCeilingTop",
				Description = "how high the missile needs to reach before it descends."
			},
			new DvarEntry
			{
				Name = "missileDroneTurnRateDecent",
				Description = "in angles/sec."
			},
			new DvarEntry
			{
				Name = "missileDroneTurnRateAscent",
				Description = "in angles/sec."
			},
			new DvarEntry
			{
				Name = "missileDroneTurnRateAvoidance",
				Description = "in angles/sec."
			},
			new DvarEntry
			{
				Name = "missileDroneTurnRateSmallAdjustments",
				Description = "angles/sec"
			},
			new DvarEntry
			{
				Name = "missileDroneflattenRollRatio",
				Description = "reduce the roll angle by this ratio every server frame"
			},
			new DvarEntry
			{
				Name = "missileDroneDistanceAvoidance",
				Description = "how far to check for impacts"
			},
			new DvarEntry
			{
				Name = "missileDroneDistanceAvoidanceSec",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileDroneDistSqTargetAvoidanceDisabled",
				Description = "is for when the missile is traveling at low speeds"
			},
			new DvarEntry
			{
				Name = "missileDroneTurnMaxRoll",
				Description = "When turning the maximum roll to be applied to the projectile"
			},
			new DvarEntry
			{
				Name = "missileDroneTurnMaxRollChange",
				Description = "When turning the maximum roll to be applied to the projectile per server frame"
			},
			new DvarEntry
			{
				Name = "missileDroneTurnMaxRate",
				Description = "When turning at this DPS the maximum roll to be applied to the projectile"
			},
			new DvarEntry
			{
				Name = "missileDroneAccelClimb",
				Description = "Rocket acceleration when climbing."
			},
			new DvarEntry
			{
				Name = "missileDroneAccelDescend",
				Description = "Rocket acceleration when descending towards target."
			},
			new DvarEntry
			{
				Name = "missileDroneSpeedLimitClimb",
				Description = "Rocket's speed limit when climbing."
			},
			new DvarEntry
			{
				Name = "missileDroneSpeedLimitDescend",
				Description = "Rocket's speed limit when descending towards target."
			},
			new DvarEntry
			{
				Name = "missileDroneClimbMaxDist",
				Description = "If the Rocket exceeds this distance it will change from ascend mode to descend mode."
			},
			new DvarEntry
			{
				Name = "missileDroneTurnDecel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileDroneClimbToOwner",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileWaterMaxDepth",
				Description = "they explosion effect/sound will not play."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedStickDeadzone",
				Description = "defines the dead zone for stick movement (stick values range from -128..127"
			},
			new DvarEntry
			{
				Name = "missileTVGuidedTurnRate",
				Description = "max turn rate of a tv guided missile (multiplied by the stick deflection [0-1])"
			},
			new DvarEntry
			{
				Name = "missilePlantableSize",
				Description = "Size of the bounding box used for plantable equipment collision."
			},
			new DvarEntry
			{
				Name = "missileMolotovBlobNum",
				Description = "these count against the server entities."
			},
			new DvarEntry
			{
				Name = "missileMolotovBlobTime",
				Description = "The life time of a molotov fire blob in seconds."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedBoost",
				Description = "The multiplier that the TV guided missile recieves while boosting."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedBoostSpeedUp",
				Description = "Speed increase factor to get to full boost."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedBoostSpeedDown",
				Description = "Speed decrease factor to return from full boost."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedMaxRollAngle",
				Description = "Max roll the missile will have when turning."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedTurningRollAccel",
				Description = "Roll acceleration when the missile is turning."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedFlatteningRollAccel",
				Description = "Roll acceleration when the missile is flattening out after a turn."
			},
			new DvarEntry
			{
				Name = "missileTVGuidedMPSpecific",
				Description = "MP specific Guided Missile functionality"
			},
			new DvarEntry
			{
				Name = "grenadeRestThreshold",
				Description = "The speed threshold below which grenades will come to rest"
			},
			new DvarEntry
			{
				Name = "grenadeRollingEnabled",
				Description = "Enables the new rolling grenade behavior"
			},
			new DvarEntry
			{
				Name = "grenadeFrictionLow",
				Description = "The amount of friction (0 to 1) for slower/rolling grenades"
			},
			new DvarEntry
			{
				Name = "grenadeFrictionHigh",
				Description = "The amount of friction (0 to 1) for fast-moving grenades"
			},
			new DvarEntry
			{
				Name = "grenadeFrictionThresh",
				Description = "The speed threshold that determines whether to use grenadeFrictionLow/High"
			},
			new DvarEntry
			{
				Name = "grenadeBumpFreq",
				Description = "How likely (per server frame) a bump will occur"
			},
			new DvarEntry
			{
				Name = "grenadeBumpMag",
				Description = "Size of bumps (as a fraction of the grenade's current speed)"
			},
			new DvarEntry
			{
				Name = "grenadeBumpMax",
				Description = "Maximum upward speed of a bump (inches/sec)"
			},
			new DvarEntry
			{
				Name = "grenadeWobbleFreq",
				Description = "Wobble cycles per inch of rolling distance (approx)"
			},
			new DvarEntry
			{
				Name = "grenadeWobbleFwdMag",
				Description = "The forward rolling speed will oscillate +/- this amount"
			},
			new DvarEntry
			{
				Name = "grenadeWobbleSideMag",
				Description = "The distance to wobble left and right"
			},
			new DvarEntry
			{
				Name = "grenadeWobbleSideDamp",
				Description = "The rate at which the amount of side-to-side wobbling decreases as overall grenade speed increases"
			},
			new DvarEntry
			{
				Name = "grenadeCurveMax",
				Description = "Largest rolling curvature (will be random between +/- this value)"
			},
			new DvarEntry
			{
				Name = "grenadeBounceRestitutionMax",
				Description = "Cap to keep code from increasing bounce restitution too high."
			},
			new DvarEntry
			{
				Name = "airburstAdjustDistance",
				Description = "Distance to append to airburst locked in distance."
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug",
				Description = "Debug and rendering for the spawn system"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_best_points",
				Description = "Render best spawn point information"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_points",
				Description = "Render spawn point boxes. 2 = no depth test"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_point_weights",
				Description = "Render spawn point information"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_influencers",
				Description = "Use colors to differentiate influencer types"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_influencer_types",
				Description = "Render spawn influencer information"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_influencer_pulse",
				Description = "Influencers pulsate when enabled"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_player",
				Description = "Name of player to show debug info for"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_team",
				Description = "Team to show debug info for"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_sideswitched",
				Description = "Switch to sideswitched mode"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_visibility",
				Description = "Render spawn point visibility checking"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_visibility_time",
				Description = "Length of time to render the visibility check"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_archive",
				Description = "Sets the spawn system archive mode"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_showclients",
				Description = "Render archived clients"
			},
			new DvarEntry
			{
				Name = "spawnsystem_debug_liveedit",
				Description = "live edit now!"
			},
			new DvarEntry
			{
				Name = "spawnsystem_weapon_influencer_sight_check",
				Description = "Do a line of sight check on the weapon influencer"
			},
			new DvarEntry
			{
				Name = "spawnsystem_weapon_influencer_push_through",
				Description = "Extend the line of sight distance this much after check"
			},
			new DvarEntry
			{
				Name = "spawnsystem_weapon_influencer_min_length",
				Description = "Minimum lenght the line of sight check will drop the distance to"
			},
			new DvarEntry
			{
				Name = "spawnsystem_weapon_influencer_update_interval",
				Description = "How often to update the sight check in milliseconds"
			},
			new DvarEntry
			{
				Name = "spawnsystem_friend_influencer_stacking",
				Description = "Combine all friendly player influencers"
			},
			new DvarEntry
			{
				Name = "spawnsystem_enemy_influencer_stacking",
				Description = "Combine all enemy player influencers"
			},
			new DvarEntry
			{
				Name = "spawnsystem_enemy_spawned_influencer_stacking",
				Description = "Combine all enemy spawned influencers"
			},
			new DvarEntry
			{
				Name = "spawnsystem_sight_check_max_distance",
				Description = "Max distance for the line of sight check"
			},
			new DvarEntry
			{
				Name = "spawnsystem_sight_height_offset",
				Description = "Adjust Z for LOS test by this value"
			},
			new DvarEntry
			{
				Name = "spawnsystem_badspawn_damage_delay",
				Description = "Report damage that occurs to a player within this MS of spawning in"
			},
			new DvarEntry
			{
				Name = "spawnsystem_badspawn_aggression_delay",
				Description = "Report aggression to others that a player deals within this MS of spawning in"
			},
			new DvarEntry
			{
				Name = "spawnsystem_badspawn_force_record",
				Description = "submit a corresponding badspawn report"
			},
			new DvarEntry
			{
				Name = "spawnsystem_allow_culling",
				Description = "Enables the culling of dangerous and low scoring points"
			},
			new DvarEntry
			{
				Name = "spawnsystem_danger_time",
				Description = "When found to be dangerous (enemy LOS or telefrag) disable the point for this duration"
			},
			new DvarEntry
			{
				Name = "spawnsystem_score_cull_time_max",
				Description = "Max time that any particular point can stay disabled due to low score"
			},
			new DvarEntry
			{
				Name = "spawnsystem_score_cull_time_min",
				Description = "Min time that any particular point can stay disabled due to low score"
			},
			new DvarEntry
			{
				Name = "spawnsystem_score_cull_percent",
				Description = "Percentage of total spawn points that can be disabled due to low score at any time"
			},
			new DvarEntry
			{
				Name = "spawnsystem_score_cull_min_points",
				Description = "Make sure we always have at least this many points left after score culling"
			},
			new DvarEntry
			{
				Name = "spawnsystem_allow_non_team_spawns",
				Description = "Enables the usage of non-team spawns when all team spawns are blocked"
			},
			new DvarEntry
			{
				Name = "spawnsystem_demo_max_written",
				Description = "Limit for how many bytes we are allowed to write to the demo file"
			},
			new DvarEntry
			{
				Name = "spawnsystem_demo_enable_parsing",
				Description = "Enables the usage of spawn debugging information embedded in the demo recordings"
			},
			new DvarEntry
			{
				Name = "spawnsystem_old_vis_mask",
				Description = "Switches back to old spawn vis mask without nosight"
			},
			new DvarEntry
			{
				Name = "vehicle_collision_prediction_time",
				Description = "How far ahead of the vehicle it should predict to do collision damage."
			},
			new DvarEntry
			{
				Name = "turret_KillstreakTargetTime",
				Description = "Time in milliseconds that a TOW turret will stay locked on a target before verifying line of sight"
			},
			new DvarEntry
			{
				Name = "turret_SentryTargetTime",
				Description = "Time in milliseconds that a sentry turret will stay locked on a target before verifying line of sight"
			},
			new DvarEntry
			{
				Name = "turret_TargetLeadBias",
				Description = "The number of server frames used to predict an entity's position. Used for turret aiming when firing."
			},
			new DvarEntry
			{
				Name = "live_serverLSPID",
				Description = "LSPID the server should advertise"
			},
			new DvarEntry
			{
				Name = "live_serverLSPPort",
				Description = "LSPPort the server should advertise"
			},
			new DvarEntry
			{
				Name = "live_FFOTDCheckInterval",
				Description = "Interval server will check for new FFOTD"
			},
			new DvarEntry
			{
				Name = "hopper_enabled",
				Description = "True if server should move to parking playlist when empty"
			},
			new DvarEntry
			{
				Name = "hopper_playlist",
				Description = "overrides parkingplaylist associated with sv_playlist"
			},
			new DvarEntry
			{
				Name = "xPGroups",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gunXPGroups",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_statsCheckSeasonPass",
				Description = "Check for stats before setting them while writing the season pass stat"
			},
			new DvarEntry
			{
				Name = "tu7_statsCheckGroupMask",
				Description = "Check for stats before reading them for the group mask"
			},
			new DvarEntry
			{
				Name = "sv_leaderboardwriteInterval",
				Description = "ms to wait between leaderboard writes"
			},
			new DvarEntry
			{
				Name = "lbTaskDelay",
				Description = "LB task throttle delay"
			},
			new DvarEntry
			{
				Name = "ui_hideLeaderboards",
				Description = "Hide leaderboard buttons in the UI"
			},
			new DvarEntry
			{
				Name = "ui_hideMiniLeaderboards",
				Description = "(const char *)&stru_C1C634.bspCellIndex"
			},
			new DvarEntry
			{
				Name = "league_leaderboardRefetchTime",
				Description = "Time in milliseconds before refetching league leaderboard data for a given team and a subdivision."
			},
			new DvarEntry
			{
				Name = "league_teamLeagueInfoRefetchTime",
				Description = "Time in milliseconds before refetching team league and subdivision info."
			},
			new DvarEntry
			{
				Name = "league_historyInfoRefetchTime",
				Description = "Time in milliseconds before refetching league history info."
			},
			new DvarEntry
			{
				Name = "league_friendsRefetchTime",
				Description = "Time in minutes before refetching league friends data."
			},
			new DvarEntry
			{
				Name = "league_defaultPlaylistID",
				Description = "The default playlist to select if the player has never played leagues before"
			},
			new DvarEntry
			{
				Name = "league_forcePreSeason",
				Description = "Force all leagues to preseason mode."
			},
			new DvarEntry
			{
				Name = "metPlayerListUpdateInterval",
				Description = "Time in milliseconds since update recent met player list."
			},
			new DvarEntry
			{
				Name = "metPlayerListUploadInterval",
				Description = "This dvar is used to make sure that recent met player list get updates only when it changes."
			},
			new DvarEntry
			{
				Name = "maxMetPlayerListCount",
				Description = "This dvar is used to changes the size of the met player list."
			},
			new DvarEntry
			{
				Name = "unsubscriptionCooloffTimer",
				Description = "This dvar is used to set the cool of time for unsubscribing the xuids of the recent met playerlist."
			},
			new DvarEntry
			{
				Name = "metPlayerListCleanupInterval",
				Description = "This dvar is used to make sure that recent met player list does not contain friends in it."
			},
			new DvarEntry
			{
				Name = "hostdelegate_sendwaitms",
				Description = "ms to wait between hostdelegate sends"
			},
			new DvarEntry
			{
				Name = "hostdelegate_skipcleanup",
				Description = "If true client skips cleaning up delegated session. CAUSES BAD THINGS"
			},
			new DvarEntry
			{
				Name = "hostdelegate_rejectwhenwaiting",
				Description = "If true we reject incoming clients when waiting for delegation to complete"
			},
			new DvarEntry
			{
				Name = "tu8_ignoredelegateduringmodify",
				Description = "If true ignore host delegation requests if we have a modify in progress"
			},
			new DvarEntry
			{
				Name = "hostdelegate_delegatequiettime",
				Description = "ms to wait after a successful delegation before we let other clients in"
			},
			new DvarEntry
			{
				Name = "twitchEnabled",
				Description = "Twitch Enabled"
			},
			new DvarEntry
			{
				Name = "liveVoteTaskDelay",
				Description = "Delay between consequent vote history page tasks"
			},
			new DvarEntry
			{
				Name = "liveVoteErrorBackoff",
				Description = "Backoff time if a vote history page task fails"
			},
			new DvarEntry
			{
				Name = "ytForcePrivate",
				Description = "Force youtube clip uploads to be private"
			},
			new DvarEntry
			{
				Name = "ytAuthCooloff",
				Description = "Wait for a while after receiving auth and before trying to get token info"
			},
			new DvarEntry
			{
				Name = "ytAuthCooloffTime",
				Description = "Time to wait after receiving auth and before getting token info"
			},
			new DvarEntry
			{
				Name = "com_profileLoading",
				Description = "Show map load profiler"
			},
			new DvarEntry
			{
				Name = "com_maxclients",
				Description = "Maximum amount of clients on the server"
			},
			new DvarEntry
			{
				Name = "com_freemoveScale",
				Description = "Scale how fast you move in com_freemove mode"
			},
			new DvarEntry
			{
				Name = "disconnected_ctrls",
				Description = "String representing the disconnected controllers"
			},
			new DvarEntry
			{
				Name = "com_maxfps",
				Description = "Cap frames per second"
			},
			new DvarEntry
			{
				Name = "grenade_indicators_enabled",
				Description = "Enables grenade indicators"
			},
			new DvarEntry
			{
				Name = "throwback_enabled",
				Description = "Enables throwbacks"
			},
			new DvarEntry
			{
				Name = "disable_vcs",
				Description = "Disables VCS"
			},
			new DvarEntry
			{
				Name = "disable_vcs_viewmodel",
				Description = "Disables VCS viewmodel in the VCS UI menu"
			},
			new DvarEntry
			{
				Name = "vcs_timelimit",
				Description = "Sets the timelimit for the VCS easter egg"
			},
			new DvarEntry
			{
				Name = "com_report_syserrors",
				Description = "Enable syserror reporting"
			},
			new DvarEntry
			{
				Name = "gts_validation_enabled",
				Description = "Enables gametype settings validation in online modes"
			},
			new DvarEntry
			{
				Name = "lui_checksum_enabled",
				Description = "Enables LUI checksums"
			},
			new DvarEntry
			{
				Name = "lui_error_report",
				Description = "Enable LUI error reporting"
			},
			new DvarEntry
			{
				Name = "lui_error_report_delay",
				Description = "Number of ms to wait for error report to send before restarting the EXE"
			},
			new DvarEntry
			{
				Name = "lui_timescale",
				Description = "Scale time of each frame of LUI animation"
			},
			new DvarEntry
			{
				Name = "lui_disable_blur",
				Description = "Disable LUI blur"
			},
			new DvarEntry
			{
				Name = "tu7_restoreBlur",
				Description = "Restore blur on com_error"
			},
			new DvarEntry
			{
				Name = "zombiemode_path_minz_bias",
				Description = "Bias to prevent missing valid cells below the origin"
			},
			new DvarEntry
			{
				Name = "zombie_devgui",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zombie_useOldPathFallback",
				Description = "Whether to use the old method of finding closest node when pathfind fails"
			},
			new DvarEntry
			{
				Name = "zombie_double_wide_checks",
				Description = "Whether to do double wide checks when finding a start node for a pathfinding check"
			},
			new DvarEntry
			{
				Name = "spmode",
				Description = "Current game is a sp game"
			},
			new DvarEntry
			{
				Name = "onlinegame",
				Description = "unlocks"
			},
			new DvarEntry
			{
				Name = "xblive_rankedmatch",
				Description = "Current game is a ranked match"
			},
			new DvarEntry
			{
				Name = "xblive_privatematch",
				Description = "Current game is a private match"
			},
			new DvarEntry
			{
				Name = "sv_fakeServerLoad",
				Description = "Artificially load the server by this time in MS"
			},
			new DvarEntry
			{
				Name = "sv_fakeServerLoadRand",
				Description = "Additional server load to add randomly each frame"
			},
			new DvarEntry
			{
				Name = "sv_forceunranked",
				Description = ""
			},
			new DvarEntry
			{
				Name = "consoleGame",
				Description = "True if running on a console"
			},
			new DvarEntry
			{
				Name = "xenonGame",
				Description = "True if running on XBox 360"
			},
			new DvarEntry
			{
				Name = "ps3Game",
				Description = "True if running on PS3"
			},
			new DvarEntry
			{
				Name = "wiiuGame",
				Description = "True if running on WiiU"
			},
			new DvarEntry
			{
				Name = "com_masterServerName",
				Description = "Master server name for listing public inet games"
			},
			new DvarEntry
			{
				Name = "com_authServerName",
				Description = "Authentication server name for listing public inet games"
			},
			new DvarEntry
			{
				Name = "com_masterPort",
				Description = "Master server port"
			},
			new DvarEntry
			{
				Name = "com_authPort",
				Description = "Auth server port"
			},
			new DvarEntry
			{
				Name = "com_developer",
				Description = "Enable development options"
			},
			new DvarEntry
			{
				Name = "com_developer_script",
				Description = "Enable developer script comments"
			},
			new DvarEntry
			{
				Name = "v0",
				Description = "2 = Sync every write"
			},
			new DvarEntry
			{
				Name = "com_statmon",
				Description = "Draw stats monitor"
			},
			new DvarEntry
			{
				Name = "com_timescale",
				Description = "Scale time of each frame"
			},
			new DvarEntry
			{
				Name = "dev_timescale",
				Description = "Scale time of each frame"
			},
			new DvarEntry
			{
				Name = "com_fixedtime",
				Description = "Use a fixed time rate for each frame"
			},
			new DvarEntry
			{
				Name = "com_fixedtime_float",
				Description = "Use a fixed time rate for each frame"
			},
			new DvarEntry
			{
				Name = "long_blocking_call",
				Description = "Enable SCR_DrawPleaseWait dialog"
			},
			new DvarEntry
			{
				Name = "sv_paused",
				Description = "Pause the server"
			},
			new DvarEntry
			{
				Name = "cl_paused",
				Description = "Pause the client"
			},
			new DvarEntry
			{
				Name = "cl_paused_simple",
				Description = "Toggling pause won't do any additional special processing if true."
			},
			new DvarEntry
			{
				Name = "com_sv_running",
				Description = "Server is running"
			},
			new DvarEntry
			{
				Name = "com_voip_resume_time",
				Description = "Time at which voip can resume"
			},
			new DvarEntry
			{
				Name = "com_introPlayed",
				Description = "Intro movie has been played"
			},
			new DvarEntry
			{
				Name = "com_desiredMenu",
				Description = "Target menu to navigate to when possible"
			},
			new DvarEntry
			{
				Name = "com_skipMovies",
				Description = "Skip intro movies"
			},
			new DvarEntry
			{
				Name = "com_hiDef",
				Description = "True if the game video is running in high-def."
			},
			new DvarEntry
			{
				Name = "com_wideScreen",
				Description = "false if 4x3."
			},
			new DvarEntry
			{
				Name = "doublesided_raycasts",
				Description = "turn on double sided ray casts"
			},
			new DvarEntry
			{
				Name = "log_append",
				Description = "Open log file in append mode"
			},
			new DvarEntry
			{
				Name = "ui_mapname",
				Description = "Current map name"
			},
			new DvarEntry
			{
				Name = "ui_gametype",
				Description = "Current game type"
			},
			new DvarEntry
			{
				Name = "ui_levelEra",
				Description = "Int for the year/era of the current level. Default is 2020."
			},
			new DvarEntry
			{
				Name = "ui_zm_mapstartlocation",
				Description = "Current zombie map start location"
			},
			new DvarEntry
			{
				Name = "tu6_startMovieEarly",
				Description = "start zm_highrise load movie earlier"
			},
			new DvarEntry
			{
				Name = "ui_combatCurrScrollBarPos",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_deadquote",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mapCount",
				Description = "Number of maps the player has"
			},
			new DvarEntry
			{
				Name = "ui_errorTitle",
				Description = "Title of the most recent error message"
			},
			new DvarEntry
			{
				Name = "ui_errorMessage",
				Description = "Most recent error message"
			},
			new DvarEntry
			{
				Name = "ui_errorMessageDebug",
				Description = "Most recent debug error message"
			},
			new DvarEntry
			{
				Name = "ui_autoContinue",
				Description = "Automatically 'click to continue' after loading a level"
			},
			new DvarEntry
			{
				Name = "ui_creditsScrollScale",
				Description = "credits scroll speed"
			},
			new DvarEntry
			{
				Name = "ui_drawSpinnerAfterMovie",
				Description = "True"
			},
			new DvarEntry
			{
				Name = "all_players_are_connected",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hostmigrationtest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "quit_on_error",
				Description = ""
			},
			new DvarEntry
			{
				Name = "debug_show_viewpos",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wagerTier",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_killcam",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_numLives",
				Description = ""
			},
			new DvarEntry
			{
				Name = "debug_protocol",
				Description = ""
			},
			new DvarEntry
			{
				Name = "nextarena",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ClickToContinue",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demoname",
				Description = ""
			},
			new DvarEntry
			{
				Name = "createfx",
				Description = ""
			},
			new DvarEntry
			{
				Name = "saved_gameskill",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_sb",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_allies",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_axis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wagerBet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "miniscoreboardhide",
				Description = ""
			},
			new DvarEntry
			{
				Name = "band_demosystem",
				Description = "demo system bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_2players",
				Description = "2 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_4players",
				Description = "4 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_6players",
				Description = "8 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_8players",
				Description = "8 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_12players",
				Description = "12 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_18players",
				Description = "18 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "band_dedicated",
				Description = ">18 player bandwidth req'd"
			},
			new DvarEntry
			{
				Name = "result",
				Description = "When true a missing command or config file will cause an ERR_DROP."
			},
			new DvarEntry
			{
				Name = "scr_xpscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_xpscale",
				Description = "Used by pc clients to show scr_xpscale in the UI"
			},
			new DvarEntry
			{
				Name = "scr_gunxpscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_rankXpCap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_codpointsxpscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_codpointsmatchscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_codpointsperchallenge",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_scorestreaks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_scorestreaks_maxstacking",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_rampagebonusscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disableChallenges",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disableStatTracking",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disableSetDStat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "version",
				Description = "Game version"
			},
			new DvarEntry
			{
				Name = "shortversion",
				Description = "Short game version"
			},
			new DvarEntry
			{
				Name = "v1",
				Description = "Whether the player has this map downloaded."
			},
			new DvarEntry
			{
				Name = "v0[1]",
				Description = "Whether this map is available to be bought and downloaded"
			},
			new DvarEntry
			{
				Name = "devdlc",
				Description = "Set to true to fake the presence of all dlc"
			},
			new DvarEntry
			{
				Name = "xblive_anymappacks",
				Description = "Set to true if the player has any content packs"
			},
			new DvarEntry
			{
				Name = "xblive_allmappacks",
				Description = "Set to true if the player has all the content packs available"
			},
			new DvarEntry
			{
				Name = "msg_logPredictionPositionErrors",
				Description = "Logs player position prediction errors less than the set distance"
			},
			new DvarEntry
			{
				Name = "net_emu_latency",
				Description = "Emulated network latency in ms"
			},
			new DvarEntry
			{
				Name = "net_emu_jitter",
				Description = "Emulated network latency jitter in ms"
			},
			new DvarEntry
			{
				Name = "net_emu_packet_loss",
				Description = "Emulated network %% packet loss"
			},
			new DvarEntry
			{
				Name = "net_emu_server",
				Description = "Server network emulation info string"
			},
			new DvarEntry
			{
				Name = "net_emu_client",
				Description = "Client network emulation info string"
			},
			new DvarEntry
			{
				Name = "sv_connectionLogProbability",
				Description = "Probability of uploading connection log data."
			},
			new DvarEntry
			{
				Name = "sv_connectionLogSamplesPerSecond",
				Description = "Number of samples per second per client."
			},
			new DvarEntry
			{
				Name = "sv_maxclients",
				Description = "The maximum number of clients that can connect to a server"
			},
			new DvarEntry
			{
				Name = "sv_maxclients",
				Description = "The maximum number of clients that can connect to a server"
			},
			new DvarEntry
			{
				Name = "sv_gametype",
				Description = "Current game type"
			},
			new DvarEntry
			{
				Name = "protocol",
				Description = "Protocol version"
			},
			new DvarEntry
			{
				Name = "sv_mapname",
				Description = "Current map name"
			},
			new DvarEntry
			{
				Name = "sv_mapcrc",
				Description = "crc of the map file"
			},
			new DvarEntry
			{
				Name = "sv_privateClients",
				Description = "Maximum number of private clients allowed on the server"
			},
			new DvarEntry
			{
				Name = "sv_privateClientsForClients",
				Description = "The # of private clients (we send this to clients)"
			},
			new DvarEntry
			{
				Name = "sv_endGameIfISuck",
				Description = "End the match if most of the players are lagged out"
			},
			new DvarEntry
			{
				Name = "sv_hostname",
				Description = "Host name of the server"
			},
			new DvarEntry
			{
				Name = "sv_noname",
				Description = "Player name assigned to players that fail name validation"
			},
			new DvarEntry
			{
				Name = "sv_syslog_address",
				Description = "Address to send syslog messages to"
			},
			new DvarEntry
			{
				Name = "sv_syslog_enabled",
				Description = "Enable sending syslog messages"
			},
			new DvarEntry
			{
				Name = "sv_syslog_port",
				Description = "Port to send syslog messages to"
			},
			new DvarEntry
			{
				Name = "sv_playlist",
				Description = "Playlist ID server should run"
			},
			new DvarEntry
			{
				Name = "sv_botsoak",
				Description = "True if running the dedicated boat soak changelist"
			},
			new DvarEntry
			{
				Name = "query_address",
				Description = "Address to listen on for udp query packets"
			},
			new DvarEntry
			{
				Name = "query_port",
				Description = "Port to list on for udp query packets"
			},
			new DvarEntry
			{
				Name = "sv_perf_interval",
				Description = "ms to record server perf for before reset"
			},
			new DvarEntry
			{
				Name = "sv_perf_pingThrottle",
				Description = "ms to wait between logging client pings"
			},
			new DvarEntry
			{
				Name = "sv_badLoadoutAction",
				Description = "Action to take when a client has a loadout invalid for their rank"
			},
			new DvarEntry
			{
				Name = "sv_badRankAction",
				Description = "Action to take when a client has rank / plevel that doesn't match the hash"
			},
			new DvarEntry
			{
				Name = "sv_geolocation",
				Description = "geolocation"
			},
			new DvarEntry
			{
				Name = "sv_clientFpsLimit",
				Description = "Limit clients FPS"
			},
			new DvarEntry
			{
				Name = "sv_numreservedslots",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sv_clientSideBullets",
				Description = "clients will synthesize tracers and bullet impacts"
			},
			new DvarEntry
			{
				Name = "sv_clientSideVehicles",
				Description = "vehicles will be predicted on the client reducing response time"
			},
			new DvarEntry
			{
				Name = "sv_penetrationCount",
				Description = "Maximum number of private clients allowed on the server"
			},
			new DvarEntry
			{
				Name = "sv_axis_penetrationCount",
				Description = "Maximum number for TEAM_AXIS"
			},
			new DvarEntry
			{
				Name = "sv_allies_penetrationCount",
				Description = "Maximum number for TEAM_ALLIES"
			},
			new DvarEntry
			{
				Name = "sv_bullet_range",
				Description = "Defines the how far the bulllets will go."
			},
			new DvarEntry
			{
				Name = "sv_expensive_bullet_time",
				Description = "MS threshold for reporting expensive bullet fire events to blackbox."
			},
			new DvarEntry
			{
				Name = "sv_hitFXFrustumCutoff",
				Description = "Hit effects that are more than <this value> outside of the frustum will be culled."
			},
			new DvarEntry
			{
				Name = "sv_FakeRemoteClient",
				Description = "If true script func numremoteclients() always returns at least 1."
			},
			new DvarEntry
			{
				Name = "sv_minPing",
				Description = "Minimum ping allowed on the server"
			},
			new DvarEntry
			{
				Name = "sv_maxPing",
				Description = "Maximum ping allowed on the server"
			},
			new DvarEntry
			{
				Name = "sv_timeout",
				Description = "seconds without any message"
			},
			new DvarEntry
			{
				Name = "sv_connectTimeout",
				Description = "seconds without any message when a client is loading"
			},
			new DvarEntry
			{
				Name = "sv_floodProtect",
				Description = "Prevent malicious lagging by flooding the server with commands.Is the number of client commands the server will process per 800ms.0 means no flood protection."
			},
			new DvarEntry
			{
				Name = "sv_showCommands",
				Description = "Print client commands in the log file"
			},
			new DvarEntry
			{
				Name = "sv_writeConfigStrings",
				Description = "Write out the config string file"
			},
			new DvarEntry
			{
				Name = "scr_writeConfigStrings",
				Description = "Special script mode for writing config string files"
			},
			new DvarEntry
			{
				Name = "sv_keywords",
				Description = "Server keywords"
			},
			new DvarEntry
			{
				Name = "sv_dwlsgerror",
				Description = "Demonware LSG error"
			},
			new DvarEntry
			{
				Name = "sv_allowAnonymous",
				Description = "Allow anonymous access"
			},
			new DvarEntry
			{
				Name = "sv_disableClientConsole",
				Description = "Disallow remote clients from accessing the console"
			},
			new DvarEntry
			{
				Name = "sv_privatePassword",
				Description = "password for the privateClient slots"
			},
			new DvarEntry
			{
				Name = "sv_iwds",
				Description = "IWD server checksums"
			},
			new DvarEntry
			{
				Name = "sv_iwdNames",
				Description = "Names of IWD files used by the server"
			},
			new DvarEntry
			{
				Name = "sv_referencedIwds",
				Description = "Checksum of all referenced IWD files"
			},
			new DvarEntry
			{
				Name = "sv_referencedIwdNames",
				Description = "Names of all referenced IWD files"
			},
			new DvarEntry
			{
				Name = "sv_FFCheckSums",
				Description = "Fast File server checksums"
			},
			new DvarEntry
			{
				Name = "sv_FFNames",
				Description = "Names of Fast Files used by the server"
			},
			new DvarEntry
			{
				Name = "sv_referencedFFCheckSums",
				Description = "Checksum of all referenced Fast Files"
			},
			new DvarEntry
			{
				Name = "sv_referencedFFNames",
				Description = "Names of all referenced Fast Files"
			},
			new DvarEntry
			{
				Name = "sv_authenticating",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sv_voice",
				Description = "Use server side voice communications"
			},
			new DvarEntry
			{
				Name = "sv_voiceQuality",
				Description = "Voice quality"
			},
			new DvarEntry
			{
				Name = "sv_cheats",
				Description = "Enable cheats on the server"
			},
			new DvarEntry
			{
				Name = "sv_pure",
				Description = "Cannot use modified IWD files"
			},
			new DvarEntry
			{
				Name = "rcon_password",
				Description = "Password for the rcon command"
			},
			new DvarEntry
			{
				Name = "sv_zombietime",
				Description = "seconds to sync messages after disconnect"
			},
			new DvarEntry
			{
				Name = "sv_debugMessageKey",
				Description = "net message key generation debugging"
			},
			new DvarEntry
			{
				Name = "sv_debugPacketContents",
				Description = "print out the contents of every snapshot (VERY SLOW)"
			},
			new DvarEntry
			{
				Name = "sv_debugPacketContentsForClientThisFrame",
				Description = "set to true to get the next snapshot for this client"
			},
			new DvarEntry
			{
				Name = "sv_showHuffmanData",
				Description = "To enable or disable the printing of the huffman data byte count"
			},
			new DvarEntry
			{
				Name = "sv_debugConstantConfigStrings",
				Description = "const config strings debugging"
			},
			new DvarEntry
			{
				Name = "sv_loadMyChanges",
				Description = "Load my changes fast file on devmap."
			},
			new DvarEntry
			{
				Name = "sv_debugPlayerstate",
				Description = "Print out what fields are changing in the playerstate"
			},
			new DvarEntry
			{
				Name = "sv_debugMomentumPercent",
				Description = "Sets the first players momentum to this percent of max momentum allowable"
			},
			new DvarEntry
			{
				Name = "sv_debugPacketContentsQuick",
				Description = "print out snapshot entity changed fields"
			},
			new DvarEntry
			{
				Name = "sv_bitfieldTracking",
				Description = "send blackbox notifies when bitfields data exceeeds thresholds"
			},
			new DvarEntry
			{
				Name = "sv_mapRotation",
				Description = "List of maps for the server to play"
			},
			new DvarEntry
			{
				Name = "sv_mapRotationCurrent",
				Description = "Current map in the map rotation"
			},
			new DvarEntry
			{
				Name = "nextmap",
				Description = "Next map to play"
			},
			new DvarEntry
			{
				Name = "sv_network_fps",
				Description = "Number of times per second the server checks for net messages"
			},
			new DvarEntry
			{
				Name = "sv_externalEventLoop",
				Description = "Allow the event loop to run outside of the server frame"
			},
			new DvarEntry
			{
				Name = "sv_assistWorkers",
				Description = "Enable server worker thread assist when idle"
			},
			new DvarEntry
			{
				Name = "sv_networkRateSolution",
				Description = "Select different types of solutions for network rate / client movement issues."
			},
			new DvarEntry
			{
				Name = "sv_restrictedTempEnts",
				Description = "certain temp ents are not sent - used in DOA."
			},
			new DvarEntry
			{
				Name = "sv_maxPhysExplosionSpheres",
				Description = "otherwise max number of concurrent explosion sphere temp ents."
			},
			new DvarEntry
			{
				Name = "sv_onlineHostSnapshotRateThrottled",
				Description = "Enables sending snapshot to the host client during online matches according to standard policy."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingEnabled",
				Description = "Determines whether we should allow rate boosting."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingMinUploadScale",
				Description = "Scale of the required bandwidth for current player limit needed to be able to send snapshots at a higher rate."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingMaxUploadUsage",
				Description = "Portion of the available bandwidth that we can use before we switch back to regular updates."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingSuspendedMaxUploadUsage",
				Description = "Portion of the available bandwidth that we can use before we switch back to faster updates."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingRecoverTime",
				Description = "Time spent below upload usage limits before we can switch back to faster updates."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingSuspendBadFramesCPU",
				Description = "Number of bad CPU frames before we drop to a lower rate."
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingSuspendBadFramesCPUThreshold",
				Description = "Duration at which a frame is considered bad (MS)"
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingSuspendBadFramesCPUTimeout",
				Description = "Reset bad CPU frames count if we don't get any for this duration (MS)"
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingDebugForceSuspend",
				Description = "Force rate boosting on/off in regular intervals"
			},
			new DvarEntry
			{
				Name = "sv_rateBoostingAllowUnackDeltas",
				Description = "Use smallest possible deltas on alternate frames when in 20hz mode"
			},
			new DvarEntry
			{
				Name = "sv_serverLogClientPings",
				Description = "Enable logging of client pings at intervals (ms)"
			},
			new DvarEntry
			{
				Name = "sv_autoshutdowncheckInterval",
				Description = "Ms between checking for existence of autoshutdown file"
			},
			new DvarEntry
			{
				Name = "sv_autoshutdownFilename",
				Description = "the server will automagically exit if it's not running a map"
			},
			new DvarEntry
			{
				Name = "sv_max_sys_milliseconds",
				Description = "Max value for sys_milliseconds before server shutdown to prevent it wrapping"
			},
			new DvarEntry
			{
				Name = "query_challenge",
				Description = "Challenge to expect from query packets"
			},
			new DvarEntry
			{
				Name = "migration_minclientcount",
				Description = "below which the host will not migrate."
			},
			new DvarEntry
			{
				Name = "migration_blocksperframe",
				Description = "Number of blocks to send out each server frame.A value of 0 means base it off our tested bandwidth."
			},
			new DvarEntry
			{
				Name = "migration_msgtimeout",
				Description = "timeout time in ms of migration messages"
			},
			new DvarEntry
			{
				Name = "migration_limit",
				Description = "maximum number of migrations within migration_timeBetween dvar's value in milliseconds."
			},
			new DvarEntry
			{
				Name = "migration_timeBetween",
				Description = "milliseconds between migration_limit dvar's value of migrations."
			},
			new DvarEntry
			{
				Name = "migration_forceHost",
				Description = "force a particular client index to be host."
			},
			new DvarEntry
			{
				Name = "migration_soak",
				Description = "Soak test the migration. Migrate every migrationTimeBetween milliseconds"
			},
			new DvarEntry
			{
				Name = "language",
				Description = ""
			},
			new DvarEntry
			{
				Name = "loc_language",
				Description = "Language"
			},
			new DvarEntry
			{
				Name = "loc_forceEnglish",
				Description = "Force english localized strings"
			},
			new DvarEntry
			{
				Name = "loc_warnings",
				Description = "Enable localization warnings"
			},
			new DvarEntry
			{
				Name = "loc_warningsAsErrors",
				Description = "Throw an error for any unlocalized string"
			},
			new DvarEntry
			{
				Name = "emblemImageUpload",
				Description = "Toggles emblemImage upload"
			},
			new DvarEntry
			{
				Name = "tu6_emblemVoting",
				Description = "Allow emblem voting from the playercard"
			},
			new DvarEntry
			{
				Name = "ui_friendsListOpen",
				Description = "True when viewing Friends List."
			},
			new DvarEntry
			{
				Name = "ui_playerListOpen",
				Description = "True when viewing recent met player List."
			},
			new DvarEntry
			{
				Name = "ui_playercardOpen",
				Description = "True when in game gamercard is open."
			},
			new DvarEntry
			{
				Name = "ui_animSpeedScale",
				Description = "Scales the UI animation speed."
			},
			new DvarEntry
			{
				Name = "ui_customModeName",
				Description = "Custom game mode name"
			},
			new DvarEntry
			{
				Name = "ui_customModeEditName",
				Description = "Name to give the currently edited custom game mode when editing is complete"
			},
			new DvarEntry
			{
				Name = "ui_customModeDesc",
				Description = "Description for the custom game mode."
			},
			new DvarEntry
			{
				Name = "ui_customModeEditDesc",
				Description = "Description for the custom game mode while editing."
			},
			new DvarEntry
			{
				Name = "ui_playlistPopulationRefreshTime",
				Description = "The number of seconds before the playlist population heatmap is refreshed."
			},
			new DvarEntry
			{
				Name = "ui_netSource",
				Description = "The network source where:0:Local1:Internet2:Favourites"
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh[v0]",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_smallFont",
				Description = "Small font scale"
			},
			new DvarEntry
			{
				Name = "ui_bigFont",
				Description = "Big font scale"
			},
			new DvarEntry
			{
				Name = "ui_language",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_languagechanged",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_currentMap",
				Description = "Current map index"
			},
			new DvarEntry
			{
				Name = "ui_preview",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_preview_map",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mapPackChanged",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_load_index",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_prevTextEntryBox",
				Description = "Index of the previous text entry box."
			},
			new DvarEntry
			{
				Name = "ui_ignoreMousePos",
				Description = "Whether there are multiple text entries in the menu."
			},
			new DvarEntry
			{
				Name = "ui_favoriteAddress",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_favoriteName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_gametype_text",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_demoname",
				Description = "Current selected demo name"
			},
			new DvarEntry
			{
				Name = "ui_serverStatusTimeOut",
				Description = "Time in milliseconds before a server status request times out"
			},
			new DvarEntry
			{
				Name = "ui_showSessionMode",
				Description = "Show onscreen list of current session and game mode state"
			},
			new DvarEntry
			{
				Name = "ui_sessionModeLocation",
				Description = "Where to draw session and game mode info"
			},
			new DvarEntry
			{
				Name = "ui_showGameModeHistory",
				Description = "Show onscreen match history and probation information"
			},
			new DvarEntry
			{
				Name = "ui_menuLvlNotify",
				Description = "send code notification to script; default off"
			},
			new DvarEntry
			{
				Name = "selectedFriendName",
				Description = "The name of the currently selected friend."
			},
			new DvarEntry
			{
				Name = "selectedFriendIndex",
				Description = "Currently selected friend index."
			},
			new DvarEntry
			{
				Name = "selectedGroupIndex",
				Description = "Currently selected group index"
			},
			new DvarEntry
			{
				Name = "selectedPlayerXuid",
				Description = "Currently selected player xuid."
			},
			new DvarEntry
			{
				Name = "selectedMenuItemIndex",
				Description = "Current selected event index."
			},
			new DvarEntry
			{
				Name = "highlightedPlayerName",
				Description = "Currently highlighted player name."
			},
			new DvarEntry
			{
				Name = "splitscreen_lobbyPlayerCount",
				Description = "Splitscreen lobby player count string."
			},
			new DvarEntry
			{
				Name = "splitscreen_partyPlayerCount",
				Description = "Splitscreen lobby party player count string."
			},
			new DvarEntry
			{
				Name = "tickerHeaderWidth",
				Description = "The width of the ticker header text used to align the the ticker message."
			},
			new DvarEntry
			{
				Name = "ui_showDLCMaps",
				Description = "Whether to display the DLC maps."
			},
			new DvarEntry
			{
				Name = "ui_showBryceMagic",
				Description = "Whether to display the COD Elite button in the MP main menu."
			},
			new DvarEntry
			{
				Name = "ui_scrollTextYOffset",
				Description = "The y offset of the text scrolled using the UI_SCROLLING_LONG_MESSAGE ownerdraw."
			},
			new DvarEntry
			{
				Name = "ui_scrollTextScrollRate",
				Description = "The rate at which UI_SCROLLING_LONG_MESSAGE ownerdraw scrolls the text."
			},
			new DvarEntry
			{
				Name = "ui_scrollTextYOffsetResetDelay",
				Description = "The delay after the UI_SCROLLING_LONG_MESSAGE ownerdraw finishes scrolling the text"
			},
			new DvarEntry
			{
				Name = "ui_scrollTextDelay",
				Description = "The delay before the UI_SCROLLING_LONG_MESSAGE ownerdraw begins scrolling the text."
			},
			new DvarEntry
			{
				Name = "ui_scrollMOTDYOffset",
				Description = "The y offset of the text scrolled using the UI_SCROLLING_MOTD_MESSAGE ownerdraw."
			},
			new DvarEntry
			{
				Name = "ui_MOTDScrollRate",
				Description = "The rate at which UI_SCROLLING_MOTD_MESSAGE ownerdraw scrolls the text."
			},
			new DvarEntry
			{
				Name = "ui_scrollMOTDDelay",
				Description = "The delay before the UI_SCROLLING_MOTD_MESSAGE ownerdraw begins scrolling the text."
			},
			new DvarEntry
			{
				Name = "ui_scrollMOTDYOffsetResetDelay",
				Description = "The delay after the UI_SCROLLING_MOTD_MESSAGE ownerdraw finishes scrolling the text"
			},
			new DvarEntry
			{
				Name = "ui_partyFull",
				Description = "True if the current party is full."
			},
			new DvarEntry
			{
				Name = "ui_borderLowLightScale",
				Description = "Scales the border color for the lowlight color on certain UI borders"
			},
			new DvarEntry
			{
				Name = "ui_ethernetLinkActive",
				Description = "true if a network connection is available(and active)"
			},
			new DvarEntry
			{
				Name = "ui_lobbypopup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_listboxIndex",
				Description = "Current position in a listbox. Used to position associated drop down menu."
			},
			new DvarEntry
			{
				Name = "ls_status",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_favorite_message",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboardtitle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_dvar_edit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ls_demoauthor",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardcore",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_splitscreen",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_choice_noaction",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_hud_showobjicons",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_hud_obituaries",
				Description = ""
			},
			new DvarEntry
			{
				Name = "g_FactionName_Axis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "g_FactionName_Allies",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_dvar_new",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_ui_multiteam_compass_fix",
				Description = "Allow multiteam to use BIT_RADAR_CLIENT so that it can be set on a per client basis. "
			},
			new DvarEntry
			{
				Name = "ui_display_aar",
				Description = "true if returning from a level and need to display aar"
			},
			new DvarEntry
			{
				Name = "ui_specops",
				Description = "whether or not to use special specops only hud elements"
			},
			new DvarEntry
			{
				Name = "ui_hideminimap",
				Description = "map toggle"
			},
			new DvarEntry
			{
				Name = "ui_readingSaveDevice",
				Description = "Whether or not the reading save device menu is open."
			},
			new DvarEntry
			{
				Name = "ui_fxFontColor",
				Description = "Color of font face"
			},
			new DvarEntry
			{
				Name = "ui_fxFontGlowColor",
				Description = "Color of the font glow"
			},
			new DvarEntry
			{
				Name = "ui_fxFontShadowColor",
				Description = "Color of the shadow"
			},
			new DvarEntry
			{
				Name = "ui_fxFontOutlineColor",
				Description = "Color of the outline"
			},
			new DvarEntry
			{
				Name = "ui_drawOldUI",
				Description = "Draw the old UI"
			},
			new DvarEntry
			{
				Name = "tu_allowDLCWeaponsByOwnership",
				Description = "Whether to use owned or mounted as the precondition for enabling DLC items"
			},
			new DvarEntry
			{
				Name = "ui_loadscreenTimeout",
				Description = "Times out the loading screen stall if we cant load the texture because the content is missing."
			},
			new DvarEntry
			{
				Name = "ui_zm_useloadingmovie",
				Description = "Play and render a loading movie instead of static screen (mapname_load)"
			},
			new DvarEntry
			{
				Name = "ui_zm_gamemodegroup",
				Description = "zsurvival or zencounter"
			},
			new DvarEntry
			{
				Name = "ui_zm_playtest",
				Description = "indicate if it is for play test"
			},
			new DvarEntry
			{
				Name = "ui_hud_hardcore",
				Description = "Whether the HUD should be suppressed for hardcore mode"
			},
			new DvarEntry
			{
				Name = "ui_allow_classchange",
				Description = "Whether the UI should allow changing class"
			},
			new DvarEntry
			{
				Name = "ui_hud_visible",
				Description = "Whether the 2D HUD should be displayed or not."
			},
			new DvarEntry
			{
				Name = "ui_party_download_bar_height",
				Description = "Height of each download progress bar."
			},
			new DvarEntry
			{
				Name = "ui_party_download_bar_color",
				Description = "Color of the party download progress bar."
			},
			new DvarEntry
			{
				Name = "ls_gametype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ls_mapname",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ls_maplocation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ls_demotitle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ls_demoduration",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_favoriteAddress",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_favoriteName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_busyBlockIngameMenu",
				Description = "1 if ingame menu should be blocked for pending action"
			},
			new DvarEntry
			{
				Name = "ui_heatMapColor",
				Description = "Heat Map Blob Color"
			},
			new DvarEntry
			{
				Name = "ui_heatMapColorForPlayer",
				Description = "Heat Map Blob Color for player deaths only"
			},
			new DvarEntry
			{
				Name = "ui_multiplayer",
				Description = "True if the game is multiplayer"
			},
			new DvarEntry
			{
				Name = "party_linearMapCycle",
				Description = "We will cycle through the maps linearly if this is true."
			},
			new DvarEntry
			{
				Name = "party_linearMapCycleRandom",
				Description = "We will cycle through the maps linearly if this is true but picks a random start map."
			},
			new DvarEntry
			{
				Name = "playlist_enabled",
				Description = "The server is using playlist"
			},
			new DvarEntry
			{
				Name = "playlist_next",
				Description = "The server playlist for next map rotation"
			},
			new DvarEntry
			{
				Name = "playlist_entry",
				Description = "The current server playlist entry."
			},
			new DvarEntry
			{
				Name = "playlist_excludeMap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "playlist_excludeGametype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "playlist_excludeGametypeMap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "playlist_allowdevmaps",
				Description = "Allow maps that aren't in the map/presence table to be selected"
			},
			new DvarEntry
			{
				Name = "tu2_partyCheckRulesAlways",
				Description = "Check party eligibility every time we run playlist rules"
			},
			new DvarEntry
			{
				Name = "result",
				Description = "Check party eligibility every time we setup the playlist"
			},
			new DvarEntry
			{
				Name = "blackboxBandwidthLimited",
				Description = "limits blackbox sending so that it only occurs when not in game"
			},
			new DvarEntry
			{
				Name = "blackboxHighVolumeProbability",
				Description = "Probability of sending high volume blackbox data"
			},
			new DvarEntry
			{
				Name = "fs_debug",
				Description = "Enable file system debugging information"
			},
			new DvarEntry
			{
				Name = "fs_copyfiles",
				Description = "Copy all used files to another location"
			},
			new DvarEntry
			{
				Name = "fs_cdpath",
				Description = "CD path"
			},
			new DvarEntry
			{
				Name = "fs_basepath",
				Description = "Base game path"
			},
			new DvarEntry
			{
				Name = "fs_basegame",
				Description = "Base game name"
			},
			new DvarEntry
			{
				Name = "fs_gameDirVar",
				Description = "Game data directory. Must be  or a sub directory of 'mods/'."
			},
			new DvarEntry
			{
				Name = "fs_usermapDir",
				Description = "Usermap data directory."
			},
			new DvarEntry
			{
				Name = "fs_ignoreLocalized",
				Description = "Ignore localized files"
			},
			new DvarEntry
			{
				Name = "fs_homepath",
				Description = "Game home path"
			},
			new DvarEntry
			{
				Name = "fs_userDocuments",
				Description = "user documents path(screenshots)."
			},
			new DvarEntry
			{
				Name = "fs_restrict",
				Description = "Restrict file access for demos etc."
			},
			new DvarEntry
			{
				Name = "result",
				Description = "Use development directories."
			},
			new DvarEntry
			{
				Name = "ui_playerNemesisColor",
				Description = "Nemesis background colour in lobbies"
			},
			new DvarEntry
			{
				Name = "v560",
				Description = "Squad Member background colour in lobbies"
			},
			new DvarEntry
			{
				Name = "cg_sensorGrenadePulsePeriodMs",
				Description = "How often (ms) sensor grenade pulses to trigger its targeting lasers (LASERS!)"
			},
			new DvarEntry
			{
				Name = "v715",
				Description = "Duration (ms) for lasers to draw after a pulse"
			},
			new DvarEntry
			{
				Name = "v732",
				Description = "Time to satellite track the players tagged by a sensor grenade explosion."
			},
			new DvarEntry
			{
				Name = "riotshield_carry_model",
				Description = "Riotshield carry model name"
			},
			new DvarEntry
			{
				Name = "v1005",
				Description = "Riotshield stowed model name"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_Interval",
				Description = "Number of milliseconds each bar represents"
			},
			new DvarEntry
			{
				Name = "cg_ScoresPing_MaxBars",
				Description = "Number of bars to show in ping graph"
			},
			new DvarEntry
			{
				Name = "cg_adsZoomToggleStyle",
				Description = "1=rotate"
			},
			new DvarEntry
			{
				Name = "cg_bloodLimitMsec",
				Description = "number of milliseconds between effects."
			},
			new DvarEntry
			{
				Name = "cg_chatHeight",
				Description = "The font height of a chat message"
			},
			new DvarEntry
			{
				Name = "cg_chatTime",
				Description = "The amount of time that a chat message is visible"
			},
			new DvarEntry
			{
				Name = "cg_gameBoldMessageWidth",
				Description = "The maximum character width of the bold game messages"
			},
			new DvarEntry
			{
				Name = "cg_gameMessageWidth",
				Description = "The maximum character width of the game messages"
			},
			new DvarEntry
			{
				Name = "cg_hintFadeTime",
				Description = "Time in milliseconds for the cursor hint to fade"
			},
			new DvarEntry
			{
				Name = "cg_hudDamageDirectionalIconTime",
				Description = "The amount of time for the damage icon to stay on screen after damage is taken"
			},
			new DvarEntry
			{
				Name = "cg_hudDamageIconTime",
				Description = "The amount of time for the damage icon to stay on screen after damage is taken"
			},
			new DvarEntry
			{
				Name = "cg_invalidCmdHintBlinkInterval",
				Description = "Blink rate of an invalid command hint"
			},
			new DvarEntry
			{
				Name = "cg_invalidCmdHintDuration",
				Description = "Duration of an invalid command hint"
			},
			new DvarEntry
			{
				Name = "cg_mapLocationSelectionRotationSpeed",
				Description = "Rotation speed of the cursor when selecting a location on the map"
			},
			new DvarEntry
			{
				Name = "cg_marqueeTimeScale",
				Description = "Time in milliseconds to show the full name in the marquee"
			},
			new DvarEntry
			{
				Name = "cg_objectiveListWrapCountWidescreen",
				Description = "The amount of on-screen length to wrap an objective in wide-screen mode"
			},
			new DvarEntry
			{
				Name = "cg_overheadNamesFont",
				Description = "Font for overhead names ( see menudefinition.h )"
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderColorChangeDelay",
				Description = "Time in milliseconds for the range finder to change reticle color after an enemy is spotted."
			},
			new DvarEntry
			{
				Name = "cg_scoreboardBannerHeight",
				Description = "Banner height of the scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_scoreboardFont",
				Description = "Scoreboard font enum ( see menudefinition.h )"
			},
			new DvarEntry
			{
				Name = "cg_scoreboardItemHeight",
				Description = "Item height of each item"
			},
			new DvarEntry
			{
				Name = "cg_scoreboardScrollStep",
				Description = "Scroll step amount for the scoreboard"
			},
			new DvarEntry
			{
				Name = "cg_seatHintFadeTime",
				Description = "Time in milliseconds for the seat hint to fade"
			},
			new DvarEntry
			{
				Name = "cg_showmiss",
				Description = "Show prediction errors"
			},
			new DvarEntry
			{
				Name = "cg_weaponCycleDelay",
				Description = "The delay after cycling to a new weapon to prevent holding down the cycle weapon button from cycling too fast"
			},
			new DvarEntry
			{
				Name = "cl_dblTapMaxDelayTime",
				Description = "The maximum amount of time (ms) between button presses to be considered a double tap"
			},
			new DvarEntry
			{
				Name = "cl_dblTapMaxHoldTime",
				Description = "The maximum amount of time (ms) the player can hold the button to be considered a double tap"
			},
			new DvarEntry
			{
				Name = "cl_dtpHoldTime",
				Description = "The time to hold the stance button while sprinting before the player dives to prone"
			},
			new DvarEntry
			{
				Name = "cl_maxpackets",
				Description = "Maximum number of packets sent per frame"
			},
			new DvarEntry
			{
				Name = "cl_packetdup",
				Description = "Enable packet duplication"
			},
			new DvarEntry
			{
				Name = "cl_serverStatusResendTime",
				Description = "Time in milliseconds to resend a server status message"
			},
			new DvarEntry
			{
				Name = "cl_shownet",
				Description = "Display network debugging information"
			},
			new DvarEntry
			{
				Name = "cl_socketpool_size",
				Description = "Number of sockets to use for server browser socket pool"
			},
			new DvarEntry
			{
				Name = "cl_stanceHoldTime",
				Description = "The time to hold the stance button before the player goes prone"
			},
			new DvarEntry
			{
				Name = "cl_weapNextHoldTime",
				Description = "The time to hold the weapon next button before the player switches to the inventory weapon"
			},
			new DvarEntry
			{
				Name = "com_attractmodeduration",
				Description = "Time when controller is unused before attract mode is enabled"
			},
			new DvarEntry
			{
				Name = "com_maxFrameTime",
				Description = "Time slows down if a frame takes longer than this many milliseconds"
			},
			new DvarEntry
			{
				Name = "com_voip_disable_threshold",
				Description = "Message size at which voip becomes disabled"
			},
			new DvarEntry
			{
				Name = "compassObjectiveNumRings",
				Description = "The number of rings when a new objective appears"
			},
			new DvarEntry
			{
				Name = "compassObjectiveRingTime",
				Description = "The amount of time between each ring when an objective appears"
			},
			new DvarEntry
			{
				Name = "compassPartialType",
				Description = "The style of compass to use 2d or 3d"
			},
			new DvarEntry
			{
				Name = "con_miniconlines",
				Description = "Number of lines in the minicon message window"
			},
			new DvarEntry
			{
				Name = "con_typewriterDecayDuration",
				Description = "Time (in milliseconds) to spend disolving the line away."
			},
			new DvarEntry
			{
				Name = "con_typewriterDecayStartTime",
				Description = "Time (in milliseconds) to spend between the build and disolve phases."
			},
			new DvarEntry
			{
				Name = "con_typewriterPrintSpeed",
				Description = "Time (in milliseconds) to print each letter in the line."
			},
			new DvarEntry
			{
				Name = "debug_audio",
				Description = "Enables debug rendering for audio."
			},
			new DvarEntry
			{
				Name = "debug_mover",
				Description = "Turns on mover debug mode"
			},
			new DvarEntry
			{
				Name = "demo_drawdebuginformation",
				Description = "Used to draw debug information."
			},
			new DvarEntry
			{
				Name = "drawEntityCountSize",
				Description = "How big to draw the entity count graph"
			},
			new DvarEntry
			{
				Name = "dvar_maxCallbackTimeMS",
				Description = "Max ms to spend doing dvar modified callbacks"
			},
			new DvarEntry
			{
				Name = "cl_avidemo",
				Description = "AVI demo frames per second"
			},
			new DvarEntry
			{
				Name = "emblem_scroll_delay_first",
				Description = "First repeat delay for emblem editor"
			},
			new DvarEntry
			{
				Name = "emblem_scroll_delay_rest",
				Description = "Repeat delay for emblem editor"
			},
			new DvarEntry
			{
				Name = "freeBuffersDelay",
				Description = "Frames delay until vertex & index buffers are freed"
			},
			new DvarEntry
			{
				Name = "g_deathDelay",
				Description = "Delay a level restart on death"
			},
			new DvarEntry
			{
				Name = "g_inactivity",
				Description = "Time delay before player is kicked for inactivity"
			},
			new DvarEntry
			{
				Name = "g_playerRespawnTime",
				Description = "Time for player to respawn in milliseconds"
			},
			new DvarEntry
			{
				Name = "g_useholdtime",
				Description = "The time to hold down the 'use' button to activate a 'use' command"
			},
			new DvarEntry
			{
				Name = "g_voiceChatTalkingDuration",
				Description = "Time after the last talk packet was received that the player is considered by theserver to still be talking in milliseconds"
			},
			new DvarEntry
			{
				Name = "gpad_menu_scroll_delay_first",
				Description = "in milliseconds"
			},
			new DvarEntry
			{
				Name = "gpad_menu_scroll_delay_rest",
				Description = "in milliseconds"
			},
			new DvarEntry
			{
				Name = "hud_deathQuoteFadeTime",
				Description = "The time for the death quote to fade"
			},
			new DvarEntry
			{
				Name = "lua_systemTest",
				Description = "Debug UI running."
			},
			new DvarEntry
			{
				Name = "maxAttachmentsPerWeapon",
				Description = "Max attachments allowed for a weapon"
			},
			new DvarEntry
			{
				Name = "maxGlassShatters",
				Description = "Max number of glass shatters that can happen in a single frame"
			},
			new DvarEntry
			{
				Name = "modPrvAnimDumpInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "modPrvAnimDumpOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "net_profile",
				Description = "Profile network performance"
			},
			new DvarEntry
			{
				Name = "net_showprofile",
				Description = "Show network profiling display"
			},
			new DvarEntry
			{
				Name = "party_debug",
				Description = "Debug party functionality"
			},
			new DvarEntry
			{
				Name = "party_debugMembers",
				Description = "3 - both"
			},
			new DvarEntry
			{
				Name = "phys_ai_collision_mode",
				Description = "phys ai collision mode"
			},
			new DvarEntry
			{
				Name = "phys_buoyancyRippleFrequency",
				Description = "How often (in ms) floating objects will play the ripple fx"
			},
			new DvarEntry
			{
				Name = "phys_buoyancyRippleVariance",
				Description = "How late (in ms) the ripple fx can be played"
			},
			new DvarEntry
			{
				Name = "phys_floatTimeVariance",
				Description = "Variance in time (in ms) objects will float for"
			},
			new DvarEntry
			{
				Name = "phys_msecStep",
				Description = "Physics simulation update increment in milliseconds"
			},
			new DvarEntry
			{
				Name = "phys_player_collision_mode",
				Description = "phys player collision mode"
			},
			new DvarEntry
			{
				Name = "r_clear",
				Description = "Controls how the color buffer is cleared"
			},
			new DvarEntry
			{
				Name = "r_framelock",
				Description = "etc "
			},
			new DvarEntry
			{
				Name = "r_framesyncThreshold",
				Description = "100 = flip anytime"
			},
			new DvarEntry
			{
				Name = "r_fullHDRrendering",
				Description = "enable full HDR rendering"
			},
			new DvarEntry
			{
				Name = "r_hideShadowingSmodels",
				Description = "Hide static models that cast shadows (1:flash 2:hide)."
			},
			new DvarEntry
			{
				Name = "r_hideShadowingSurfaces",
				Description = "Hide BSP surfaces that cast shadows (1:flash 2:hide)."
			},
			new DvarEntry
			{
				Name = "r_pixelShaderGPRReallocation",
				Description = "Number of general purpose registers to the pixel shader"
			},
			new DvarEntry
			{
				Name = "r_polygonOffsetBiasInt",
				Description = "Offset bias for decal polygons; bigger values z-fight less but poke through walls more"
			},
			new DvarEntry
			{
				Name = "ragdoll_max_simulating",
				Description = "Max number of simultaneous active ragdolls"
			},
			new DvarEntry
			{
				Name = "render_bpi_env_collision",
				Description = "render bpi_env collision"
			},
			new DvarEntry
			{
				Name = "showpackets",
				Description = "Show packets"
			},
			new DvarEntry
			{
				Name = "snd_levelFadeTime",
				Description = "The amount of time in milliseconds for all audio to fade in at the start of a level"
			},
			new DvarEntry
			{
				Name = "sv_forcelicensetype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sv_maxHappyPingTime",
				Description = "Max ping that a player can have that we consider acceptable when calculating if the server is swamped"
			},
			new DvarEntry
			{
				Name = "sv_padPackets",
				Description = "add nop bytes to messages"
			},
			new DvarEntry
			{
				Name = "test_levels_choices",
				Description = "Number of Levels"
			},
			new DvarEntry
			{
				Name = "tickerStandardWidth",
				Description = "Ticker message text standard width."
			},
			new DvarEntry
			{
				Name = "tickerWidescreenWidth",
				Description = "Ticker message text widescreen width."
			},
			new DvarEntry
			{
				Name = "ui_dropdownListMax",
				Description = "Number of elements in list that opened dropdown."
			},
			new DvarEntry
			{
				Name = "ui_dropdownMax",
				Description = "Number of elements in the dropdown."
			},
			new DvarEntry
			{
				Name = "uiscript_debug",
				Description = "spam debug info for the ui script"
			},
			new DvarEntry
			{
				Name = "vehRecenterDelay",
				Description = "before triggering the camera auto-centering functionality in idle mode"
			},
			new DvarEntry
			{
				Name = "xanim_monitorEnt",
				Description = "this defines the entity number to send"
			},
			new DvarEntry
			{
				Name = "xanim_monitorFilter",
				Description = "Determines what filter will be applied to data sent to the anim monitor"
			},
			new DvarEntry
			{
				Name = "bg_weaponleftbone",
				Description = "Left hand weapon bone name"
			},
			new DvarEntry
			{
				Name = "bg_weaponrightbone",
				Description = "Right handed weapon bone name"
			},
			new DvarEntry
			{
				Name = "cg_rangeFinderDefaultDisplayStr",
				Description = "Default string to display on the range finder attachment when it is not active."
			},
			new DvarEntry
			{
				Name = "con_default_console_filter",
				Description = "Default channel filter for the console destination."
			},
			new DvarEntry
			{
				Name = "flameVar_editingFlameTable",
				Description = "mostly included to help artists"
			},
			new DvarEntry
			{
				Name = "flameVar_lastFlameTable",
				Description = "mostly included to help artists"
			},
			new DvarEntry
			{
				Name = "modPrvCurrAndMaxFrameIndexes",
				Description = ""
			},
			new DvarEntry
			{
				Name = "snd_assert_on_duck_stop",
				Description = "assert when duck stopped which matches this name"
			},
			new DvarEntry
			{
				Name = "snd_assert_on_enqueue",
				Description = "assert if played alias is put into q"
			},
			new DvarEntry
			{
				Name = "snd_assert_on_play",
				Description = "assert if played alias"
			},
			new DvarEntry
			{
				Name = "snd_assert_on_stop",
				Description = "assert if stopped alias"
			},
			new DvarEntry
			{
				Name = "snd_assert_on_animation_prime",
				Description = "assert if animation primes this alias"
			},
			new DvarEntry
			{
				Name = "snd_debug_alias_filter",
				Description = "only allow aliases containing this string to trigger"
			},
			new DvarEntry
			{
				Name = "snd_debug_context_type",
				Description = "enable debug context type"
			},
			new DvarEntry
			{
				Name = "snd_debug_context_value",
				Description = "enable debug context value"
			},
			new DvarEntry
			{
				Name = "snd_debug_duck",
				Description = "enable debug duck"
			},
			new DvarEntry
			{
				Name = "snd_gfutz_override",
				Description = "override gfutz"
			},
			new DvarEntry
			{
				Name = "snd_master_override",
				Description = "overide current master"
			},
			new DvarEntry
			{
				Name = "snd_mute_alias_substring",
				Description = "mute alias with not matching substring"
			},
			new DvarEntry
			{
				Name = "snd_reverb_override",
				Description = "overide current verb"
			},
			new DvarEntry
			{
				Name = "snd_start_alias",
				Description = "start sound"
			},
			new DvarEntry
			{
				Name = "snd_stop_alias",
				Description = "stop sound"
			},
			new DvarEntry
			{
				Name = "snd_solo_alias_substring",
				Description = "mute alias with matching substring"
			},
			new DvarEntry
			{
				Name = "snd_voice_duck_override",
				Description = "overide current voice duck patch"
			},
			new DvarEntry
			{
				Name = "test_levels_bsps",
				Description = "Test Level Bsps"
			},
			new DvarEntry
			{
				Name = "test_levels_names",
				Description = "Test Level Names"
			},
			new DvarEntry
			{
				Name = "v1203",
				Description = "Current Selection"
			},
			new DvarEntry
			{
				Name = "dvar_cheats",
				Description = "External Dvar"
			},
			new DvarEntry
			{
				Name = "allClientDvarsEnabled",
				Description = "Allow host to set all client dvars"
			},
			new DvarEntry
			{
				Name = "reliableResendTime",
				Description = "Amount of time (in ms) to wait before resending an unack'd reliable message"
			},
			new DvarEntry
			{
				Name = "reliableTimeoutTime",
				Description = "Amount of time (in ms) to wait before timing out a client for not ack'ing a message"
			},
			new DvarEntry
			{
				Name = "vcs_WindowState",
				Description = "2=fullscreen"
			},
			new DvarEntry
			{
				Name = "port",
				Description = "Network port"
			},
			new DvarEntry
			{
				Name = "broadcastport",
				Description = "Broadcast Network port"
			},
			new DvarEntry
			{
				Name = "shim_addr",
				Description = "Address to expect packets from. Should be the internal addr in the shim config"
			},
			new DvarEntry
			{
				Name = "shim_port",
				Description = "Port to expect packets from. Should be the internal port in the shim config"
			},
			new DvarEntry
			{
				Name = "net_noudp",
				Description = "Disable UDP"
			},
			new DvarEntry
			{
				Name = "net_socksEnabled",
				Description = "Enable network sockets"
			},
			new DvarEntry
			{
				Name = "net_socksServer",
				Description = "Network socket server"
			},
			new DvarEntry
			{
				Name = "net_socksPort",
				Description = "Network socket port"
			},
			new DvarEntry
			{
				Name = "net_socksUsername",
				Description = "Network socket username"
			},
			new DvarEntry
			{
				Name = "net_socksPassword",
				Description = "Network socket password"
			},
			new DvarEntry
			{
				Name = "ip",
				Description = "Network IP Address"
			},
			new DvarEntry
			{
				Name = "winvoice_mic_mute",
				Description = "Mute the microphone"
			},
			new DvarEntry
			{
				Name = "winvoice_mic_reclevel",
				Description = "Microphone recording level"
			},
			new DvarEntry
			{
				Name = "winvoice_save_voice",
				Description = "Write voice data to a file"
			},
			new DvarEntry
			{
				Name = "winvoice_mic_scaler",
				Description = "Microphone scaler value"
			},
			new DvarEntry
			{
				Name = "winvoice_loopback",
				Description = "Echo microphone input locally"
			},
			new DvarEntry
			{
				Name = "winvoice_voice_level",
				Description = "Voice scaler value"
			},
			new DvarEntry
			{
				Name = "phys_impact_intensity_limit",
				Description = "Lower limit for the intensity of the impact sounds that the engine triggers."
			},
			new DvarEntry
			{
				Name = "phys_impact_distance_cutoff",
				Description = "Disable effects that are further than distance_cutoff value. Uses the distance /in inches/ to the closes active player."
			},
			new DvarEntry
			{
				Name = "phys_impact_fx",
				Description = "Enable/Disable the physics impact effects."
			},
			new DvarEntry
			{
				Name = "phys_gravity",
				Description = "Physics gravity in units/sec^2."
			},
			new DvarEntry
			{
				Name = "phys_gravity_dir",
				Description = "Sets the gravity direction."
			},
			new DvarEntry
			{
				Name = "phys_vehicleGravityMultiplier",
				Description = "Physics gravity multiplier for vehicles."
			},
			new DvarEntry
			{
				Name = "phys_vehicleDamageFroceScale",
				Description = "Physics vehicle damamge force scale."
			},
			new DvarEntry
			{
				Name = "phys_vehicleWheelEntityCollision",
				Description = "Enable to turn on vehicle wheel entity collision."
			},
			new DvarEntry
			{
				Name = "phys_maxFloatTime",
				Description = "Maximum time objects can float (in ms)"
			},
			new DvarEntry
			{
				Name = "phys_buoyancyDistanceCutoff",
				Description = "Objects that are too far will sink."
			},
			new DvarEntry
			{
				Name = "phys_piecesSpawnDistanceCutoff",
				Description = "Determine how far we can spawn destructible pieces."
			},
			new DvarEntry
			{
				Name = "phys_buoyancyFloatHeightOffset",
				Description = "Adjust the height that buoyant physics objects float"
			},
			new DvarEntry
			{
				Name = "phys_buoyancy",
				Description = "Used to turn on/off buoyancy"
			},
			new DvarEntry
			{
				Name = "phys_ragdoll_buoyancy",
				Description = "Used to turn on/off the buoyancy for he ragdolls"
			},
			new DvarEntry
			{
				Name = "phys_disableEntsAndDynEntsCollision",
				Description = "Disable rigid body collision with dyn ents and regular entities as an optimization.Vehicles do not apply."
			},
			new DvarEntry
			{
				Name = "debug_trace",
				Description = "Does a trace and draws the hit point"
			},
			new DvarEntry
			{
				Name = "debug_litBrushes",
				Description = "Use fake lighting when drawing the collision brushes"
			},
			new DvarEntry
			{
				Name = "g_debugRenderMask",
				Description = "Mask for collision rendering"
			},
			new DvarEntry
			{
				Name = "g_debugRenderCollisionDistance",
				Description = "Distance to render debug brushes and patches"
			},
			new DvarEntry
			{
				Name = "enable_moving_paths",
				Description = "enable moving paths"
			},
			new DvarEntry
			{
				Name = "enable_new_prone_check",
				Description = "enable new prone check"
			},
			new DvarEntry
			{
				Name = "tu8_script_mover_workaround",
				Description = "don't allow non-moving platform entities to have their origin/angles reset"
			},
			new DvarEntry
			{
				Name = "ragdoll_debug",
				Description = "Draw ragdoll debug info (bitflags)"
			},
			new DvarEntry
			{
				Name = "ragdoll_fps",
				Description = "Ragdoll update frames per second"
			},
			new DvarEntry
			{
				Name = "ragdoll_max_life",
				Description = "Max lifetime of a ragdoll system in msec"
			},
			new DvarEntry
			{
				Name = "ragdoll_explode_force",
				Description = "Explosive force applied to ragdolls"
			},
			new DvarEntry
			{
				Name = "ragdoll_explode_upbias",
				Description = "Upwards bias applied to ragdoll explosion effects"
			},
			new DvarEntry
			{
				Name = "ragdoll_bullet_force",
				Description = "Bullet force applied to ragdolls"
			},
			new DvarEntry
			{
				Name = "ragdoll_bullet_upbias",
				Description = "Upward bias applied to ragdoll bullet effects"
			},
			new DvarEntry
			{
				Name = "ragdoll_baselerp_time",
				Description = "Default time ragdoll baselerp bones take to reach the base pose"
			},
			new DvarEntry
			{
				Name = "ragdoll_jointlerp_time",
				Description = "Default time taken to lerp down ragdoll joint friction"
			},
			new DvarEntry
			{
				Name = "ragdoll_rotvel_scale",
				Description = "Ragdoll rotational velocity estimate scale"
			},
			new DvarEntry
			{
				Name = "ragdoll_jitter_scale",
				Description = "Scale up or down the effect of physics jitter on ragdolls"
			},
			new DvarEntry
			{
				Name = "ragdoll_self_collision_scale",
				Description = "Scale the size of the collision capsules used to prevent ragdoll limbs from interpenetrating"
			},
			new DvarEntry
			{
				Name = "ragdoll_reactivation_cutoff",
				Description = "Ragdoll reactivation distance cutoff"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[0]",
				Description = "Turn on/off IK"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[1]",
				Description = "Set to one of the IK debug values in ik_types.h"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[2]",
				Description = "Turn on/off IK pelvis test"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[3]",
				Description = "Turn on/off IK foot test"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[4]",
				Description = "Turn on/off IK hand test"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[5]",
				Description = "Turn on/off left-hand lerp test"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[6]",
				Description = "Turn on/off right-hand lerp test"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[7]",
				Description = "Turn on/off player hand IK"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[8]",
				Description = "Turn on/off player terrain IK"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[9]",
				Description = "Turn on/off AI hand IK"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[10]",
				Description = "2 = ALL)"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[11]",
				Description = "Turn on/off AI hand IK tuning. 1 = Use anim flag. 2 = Force on for all anims. 3 = Force on and apply devgui offsets."
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[12]",
				Description = "Offset vector for hand tuning"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[13]",
				Description = "Rotation vector for hand tuning"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[14]",
				Description = "Turn this on to print current hand bone data to the consol"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[15]",
				Description = "Turn on/off THOROUGH matrix validity checks"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[16]",
				Description = "Pitch angle at which headtracking starts to be constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[17]",
				Description = "Pitch angle at which headtracking is entirely constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[18]",
				Description = "Roll angle at which headtracking starts to be constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[19]",
				Description = "Roll angle at which headtracking is entirely constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[20]",
				Description = "Yaw angle at which headtracking starts to be constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[21]",
				Description = "Yaw angle at which headtracking is entirely constrained"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[22]",
				Description = "Adjust the amount of rotation that is applied during head/eye tracking"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[23]",
				Description = "No torso deformation in lookatentity transforms"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[24]",
				Description = "Determines the speed at which the head tracks the looking angle (lower is faster)"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[25]",
				Description = "Values less than 1.0 will reduce the amount that the eyes lock onto their target"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[26]",
				Description = "Adjust the amount of rotation that is applied during head/eye tracking"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[27]",
				Description = "No torso deformation in lookatpos transforms"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[28]",
				Description = "Determines the speed at which the head tracks the looking angle (lower is faster)"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[29]",
				Description = "Values less than 1.0 will reduce the amount that the eyes lock onto their target"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[30]",
				Description = "Determines the speed at which the AI tracks the aim target (lower is faster)"
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[31]",
				Description = "Determines how many AI are allowed to use IK systems at once."
			},
			new DvarEntry
			{
				Name = "ikSystem->dvars[32]",
				Description = "Determines the range within which the AI are allowed to use IK systems"
			},
			new DvarEntry
			{
				Name = "wiiuIkEnabled",
				Description = "Turn on/off WiiU IK"
			},
			new DvarEntry
			{
				Name = "sv_clientside",
				Description = "Used to toggle systems in script on and off on the server."
			},
			new DvarEntry
			{
				Name = "scrVmEnableScripts",
				Description = "Enables script execution"
			},
			new DvarEntry
			{
				Name = "scrShowVarUseage",
				Description = "Displays var useage at compile time."
			},
			new DvarEntry
			{
				Name = "scrShowStrUsage",
				Description = "Displays script string usage at compile time."
			},
			new DvarEntry
			{
				Name = "scrVmErrorHitcount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "v11",
				Description = "prefered audio device"
			},
			new DvarEntry
			{
				Name = "sd_xa2_device_name",
				Description = "Available Sound devices"
			},
			new DvarEntry
			{
				Name = "sd_xa2_num_devices",
				Description = "Number of xaudio2 devices"
			},
			new DvarEntry
			{
				Name = "sd_xa2_can_switch_device",
				Description = "Allow Switching sound device"
			},
			new DvarEntry
			{
				Name = "snd_draw3D",
				Description = "Draw the position and info of world sounds"
			},
			new DvarEntry
			{
				Name = "snd_autosim_window",
				Description = "autosim window masking"
			},
			new DvarEntry
			{
				Name = "snd_max_ram_voice",
				Description = "max ram voice count"
			},
			new DvarEntry
			{
				Name = "snd_max_stream_voice",
				Description = "max stream voice count"
			},
			new DvarEntry
			{
				Name = "snd_trace_master",
				Description = "trace master dsp"
			},
			new DvarEntry
			{
				Name = "snd_trace_reverb",
				Description = "trace reverb dsp"
			},
			new DvarEntry
			{
				Name = "snd_trace_voice",
				Description = "trace voice dsp"
			},
			new DvarEntry
			{
				Name = "snd_futz_blend",
				Description = "futz"
			},
			new DvarEntry
			{
				Name = "snd_ps3_vol_occlusion_attenuation_dry",
				Description = "maximum dry volume occlusion attenuation for PS3"
			},
			new DvarEntry
			{
				Name = "snd_ps3_vol_occlusion_attenuation_wet",
				Description = "maximum wet volume occlusion attenuation for PS3"
			},
			new DvarEntry
			{
				Name = "snd_speakerConfiguration",
				Description = "Speaker configuration"
			},
			new DvarEntry
			{
				Name = "disableAllTheEliteThings",
				Description = "Disable all the things related to Elite"
			},
			new DvarEntry
			{
				Name = "enableUCDErrorRecording",
				Description = "Record all UCD errors to recordEvent"
			},
			new DvarEntry
			{
				Name = "enableERegErrorRecording",
				Description = "Record all Elite Reg errors to recordEvent"
			},
			new DvarEntry
			{
				Name = "enableJapaneseElite",
				Description = "Enable Elite for Japanese"
			},
			new DvarEntry
			{
				Name = "tu6_marketingOptIn",
				Description = "Enable Elite Marketing Opt In code"
			},
			new DvarEntry
			{
				Name = "fshElite",
				Description = "Premium fileshare experience for all users when set."
			},
			new DvarEntry
			{
				Name = "fshRecentsXUID",
				Description = "Override recent games to come from this player instead"
			},
			new DvarEntry
			{
				Name = "fshStaffXuid",
				Description = "XUID for staff picks"
			},
			new DvarEntry
			{
				Name = "fshCustomGameName",
				Description = "Name of the game downloaded into the custom game lobby"
			},
			new DvarEntry
			{
				Name = "fshSummaryDelay",
				Description = "Delay between summary tasks. Tweak to ensure no BD_TOO_MANY_TASKS."
			},
			new DvarEntry
			{
				Name = "fshFileDebug",
				Description = "Show file IDs instead of file names in CODTV"
			},
			new DvarEntry
			{
				Name = "fshRetryDelay",
				Description = "Delay after which a failed fileshare fetch will be retried"
			},
			new DvarEntry
			{
				Name = "fshMtxName",
				Description = "MTX name for premium fileshare"
			},
			new DvarEntry
			{
				Name = "fshSkipFileStats",
				Description = "Skip fetching file votes and views"
			},
			new DvarEntry
			{
				Name = "fshEnableRender",
				Description = "Turn on or off the ability to render clips."
			},
			new DvarEntry
			{
				Name = "fshRenderWriteTimeout",
				Description = "DW http upload thread timeout to prevent an upload freeze"
			},
			new DvarEntry
			{
				Name = "fshRenderSuccessURL",
				Description = "The URL to display after successfully rendering a clip."
			},
			new DvarEntry
			{
				Name = "tu7_fileshareRetry",
				Description = "Retry fetching fileshare data on failure."
			},
			new DvarEntry
			{
				Name = "tu7_fileshareShowFailure",
				Description = "Show an error on screen on fileshare data failure"
			},
			new DvarEntry
			{
				Name = "groupUploadInterval",
				Description = "Minimum interval to wait before setting new group counts"
			},
			new DvarEntry
			{
				Name = "groupDownloadInterval",
				Description = "Minimum interval to wait before getting new group counts"
			},
			new DvarEntry
			{
				Name = "matchmaking_debug",
				Description = "Enable matchmaking debugging information"
			},
			new DvarEntry
			{
				Name = "sessionSearchMaxAttempts",
				Description = "Number of search retries before giving up."
			},
			new DvarEntry
			{
				Name = "forceHost",
				Description = "If true will always be host"
			},
			new DvarEntry
			{
				Name = "geographicalMatchmakingOverride",
				Description = "All Preferred or Foreign Preferred"
			},
			new DvarEntry
			{
				Name = "searchSessionNextTaskDelay",
				Description = "The delay after the task succeeds that we excute the next find sessions"
			},
			new DvarEntry
			{
				Name = "searchSessionIsEmpty",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionMapPackFlags",
				Description = "DLC flags to include in matchmaking query."
			},
			new DvarEntry
			{
				Name = "searchSessionSkillWeight",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionGeo1Weight",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionGeo2Weight",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionGeo3Weight",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionGeo4Weight",
				Description = "Geographical loc latitude weight for weighted distance matchmaking queries"
			},
			new DvarEntry
			{
				Name = "searchSessionGeoMin",
				Description = "Minimum number of geo tiers that must match."
			},
			new DvarEntry
			{
				Name = "skill_scoreBeta",
				Description = "Beta value for score based skill calculation"
			},
			new DvarEntry
			{
				Name = "skill_teamBeta",
				Description = "Beta value for team based skill calculation"
			},
			new DvarEntry
			{
				Name = "skill_scoreRange",
				Description = "Absolute maximum value for (score) skill rating"
			},
			new DvarEntry
			{
				Name = "skill_teamRange",
				Description = "Absolute maximum value for (team) skill rating"
			},
			new DvarEntry
			{
				Name = "recordPointsSpent",
				Description = "Record spending through eventRecordBin"
			},
			new DvarEntry
			{
				Name = "allowHost_matchesHostedRatio",
				Description = "Required match completion/hosted ratio. 0 is off."
			},
			new DvarEntry
			{
				Name = "allowHost_matchesPlayedRatio",
				Description = "Required match completion/played ratio. 0 is off."
			},
			new DvarEntry
			{
				Name = "allowHost_matchesHostedStreak",
				Description = "Required number of hosted completions in a row. 0 is off."
			},
			new DvarEntry
			{
				Name = "allowHost_matchesPlayedStreak",
				Description = "Required number of played completions in a row. 0 is off."
			},
			new DvarEntry
			{
				Name = "disableHost_matchesHostedRatio",
				Description = "Required match hosted completion/failure ratio. 0 is off."
			},
			new DvarEntry
			{
				Name = "disableHost_matchesPlayedRatio",
				Description = "Required match played completion/failure ratio. 0 is off."
			},
			new DvarEntry
			{
				Name = "disableHost_matchesHostedStreak",
				Description = "Required number of hosted completions in a row. 0 is off."
			},
			new DvarEntry
			{
				Name = "disableHost_matchesPlayedStreak",
				Description = "Required number of played completions in a row. 0 is off."
			},
			new DvarEntry
			{
				Name = "classVersionNumber",
				Description = "Version number for the class loadouts"
			},
			new DvarEntry
			{
				Name = "probation_version",
				Description = ""
			},
			new DvarEntry
			{
				Name = "probation_public_enabled",
				Description = "Probation enabled"
			},
			new DvarEntry
			{
				Name = "probation_public_quitScalar",
				Description = "How much each quit is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_public_timeoutScalar",
				Description = "How much each timeout is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_public_kickScalar",
				Description = "How much each kick is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_public_matchHistoryWindow",
				Description = "How many games are evaluated to determin probation."
			},
			new DvarEntry
			{
				Name = "probation_public_probationThreshold",
				Description = "How many violations puts the player over the limit."
			},
			new DvarEntry
			{
				Name = "probation_public_warningThreshold",
				Description = "How many violations causes the player to get warned."
			},
			new DvarEntry
			{
				Name = "probation_public_probationTime",
				Description = "Time the player gets punished in minutes."
			},
			new DvarEntry
			{
				Name = "probation_public_forgiveCount",
				Description = "How many violations to forgive when probation is given"
			},
			new DvarEntry
			{
				Name = "probation_league_enabled",
				Description = "Probation enabled"
			},
			new DvarEntry
			{
				Name = "probation_league_quitScalar",
				Description = "How much each quit is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_league_timeoutScalar",
				Description = "How much each timeout is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_league_kickScalar",
				Description = "How much each kick is factored into the probation"
			},
			new DvarEntry
			{
				Name = "probation_league_matchHistoryWindow",
				Description = "How many games are evaluated to determin probation."
			},
			new DvarEntry
			{
				Name = "probation_league_probationThreshold",
				Description = "How many violations puts the player over the limit."
			},
			new DvarEntry
			{
				Name = "probation_league_warningThreshold",
				Description = "How many violations causes the player to get warned."
			},
			new DvarEntry
			{
				Name = "probation_league_probationTime",
				Description = "Time the player gets punished in minutes."
			},
			new DvarEntry
			{
				Name = "probation_league_forgiveCount",
				Description = "How many violations to forgive when probation is given"
			},
			new DvarEntry
			{
				Name = "fixNegativeLosses",
				Description = "Fix negative losses in combat record"
			},
			new DvarEntry
			{
				Name = "maxLossesValue",
				Description = "Max value for losses in combat record"
			},
			new DvarEntry
			{
				Name = "leagueWinnerBonus",
				Description = "League Winner Bonus XP"
			},
			new DvarEntry
			{
				Name = "leagueLoserBonus",
				Description = "League Loser Bonus XP"
			},
			new DvarEntry
			{
				Name = "tu4_checkStatsCheckSum",
				Description = "Check the stats Checksum vs the backup stats"
			},
			new DvarEntry
			{
				Name = "tu4_statsParity",
				Description = "Check the stats Checksum vs the backup stats"
			},
			new DvarEntry
			{
				Name = "tu4_useRealXUIDForStats",
				Description = "Use the XUID from Xbox Live not the cached on"
			},
			new DvarEntry
			{
				Name = "tu6_checkNonPrimaryXUIDPS3",
				Description = "Check the XUID of the primary player vs the XUID in the stats"
			},
			new DvarEntry
			{
				Name = "tu6_writeStatsXUIDOnGameStart",
				Description = "Check and reset the XUID in the stats when creating the stable buffer"
			},
			new DvarEntry
			{
				Name = "tu7_skipStableStats",
				Description = "Skip creating and comparing with stable stats for non public/league game modes."
			},
			new DvarEntry
			{
				Name = "tu7_setGuestStatsFetched",
				Description = "set their stats status to fetched."
			},
			new DvarEntry
			{
				Name = "tu7_verifyStableStats",
				Description = "Verify that the stable stats buffer was populated before trying to run the comparison"
			},
			new DvarEntry
			{
				Name = "tu8_storeContentInfoInStats",
				Description = "Store players content ownership in the stats blob"
			},
			new DvarEntry
			{
				Name = "live_steam_country_override",
				Description = "Override the Steam country code which is determined by Steam client from the IP"
			},
			new DvarEntry
			{
				Name = "live_steam_override_isvacbanned",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu8_autoRestartSteamServerFailed",
				Description = "Auto restart dedicated server if SteamServer interface is not available or failed to initialize"
			},
			new DvarEntry
			{
				Name = "tu8_comerrorSteamServerFailed",
				Description = "ERROR_DROP game client if SteamServer interface is not available or failed to initialize"
			},
			new DvarEntry
			{
				Name = "storeMapPackMaskToStats",
				Description = "Store the installed Map-Pack Masks in the persistent stats"
			},
			new DvarEntry
			{
				Name = "live_readPublisherStorageLocally",
				Description = "instead of from the Xbox Live server"
			},
			new DvarEntry
			{
				Name = "WADTimestampUpdateInterval",
				Description = "Time in milliseconds since the last WAD timestamp is retrieved"
			},
			new DvarEntry
			{
				Name = "stat_version",
				Description = "Stats version number"
			},
			new DvarEntry
			{
				Name = "stats_version_check",
				Description = "Reset stats if version numbers do not match"
			},
			new DvarEntry
			{
				Name = "maxStatsBackupInterval",
				Description = "Maximum number of days before performing stats backup to Demonware User Storage"
			},
			new DvarEntry
			{
				Name = "zero_stats_check",
				Description = "Check for zeroed out stats from Demonware"
			},
			new DvarEntry
			{
				Name = "dwFileFetchTryIntervalBase",
				Description = "Delay in seconds after file fetch fails to the next retry.Exponential growth each retry."
			},
			new DvarEntry
			{
				Name = "dwFileFetchTryIntervalMax",
				Description = "Max delay in seconds between file fetch tries."
			},
			new DvarEntry
			{
				Name = "dwFileFetchTryMaxAttempts",
				Description = "Max retry attempts before stopping altogether."
			},
			new DvarEntry
			{
				Name = "dwStreamingSendSocketBuffSize",
				Description = "The maximum socket streaming packet for the HTTP transactions. Used in dwFileShareWriteFile()"
			},
			new DvarEntry
			{
				Name = "waitOnStatsTimeout",
				Description = "Time in seconds to wait for stats to be fetched while dev mapping."
			},
			new DvarEntry
			{
				Name = "minDelayForOtherPlayerStatsFetch",
				Description = "Delay in milliseconds to refetch the stats of a player."
			},
			new DvarEntry
			{
				Name = "fshSearchTaskDelay",
				Description = "Gap in milliseconds between file share search tasks."
			},
			new DvarEntry
			{
				Name = "fshThrottleEnabled",
				Description = "Whether the dcache upload throttling is enabled."
			},
			new DvarEntry
			{
				Name = "fshThrottleKBytesPerSec",
				Description = "Dcache upload throttle limit in K Bytes per second."
			},
			new DvarEntry
			{
				Name = "statsLocationFatal",
				Description = "if false a warning is printed to the console and the game continues"
			},
			new DvarEntry
			{
				Name = "tu3_resetStatsOnFailedValidate",
				Description = "stats will be completely reset on a failed validation"
			},
			new DvarEntry
			{
				Name = "tu4_copyGamertagOnStatsDownload",
				Description = "Copies the gamertag from live when stats are downloaded"
			},
			new DvarEntry
			{
				Name = "tu4_checkXUIDBeforeStatsUpload",
				Description = "Checks the XUID of the stats before uploading"
			},
			new DvarEntry
			{
				Name = "tu6_execffotdlua",
				Description = "Exec the FFOTD lua files after the ffotd_settings.cfg"
			},
			new DvarEntry
			{
				Name = "tu7_statsErrorNormal",
				Description = "Error if an invalid stats access is requested on NORMAL stats."
			},
			new DvarEntry
			{
				Name = "tu7_statsErrorBackup",
				Description = "Error if an invalid stats access is requested on BACKUP stats."
			},
			new DvarEntry
			{
				Name = "tu7_statsErrorStable",
				Description = "Error if an invalid stats access is requested on STABLE stats."
			},
			new DvarEntry
			{
				Name = "tu7_statsErrorOtherPlayer",
				Description = "Error if an invalid stats access is requested on OTHERPLAYER stats."
			},
			new DvarEntry
			{
				Name = "tu8_nullStatsBuffer",
				Description = "Return a null stats buffer if a stats access error occurs"
			},
			new DvarEntry
			{
				Name = "tu8_trackStatsAccessError",
				Description = "Track stats access errors in event records."
			},
			new DvarEntry
			{
				Name = "tu8_useClassSets",
				Description = "Enable class sets"
			},
			new DvarEntry
			{
				Name = "tu8_purchasedClassSetCount",
				Description = "Number of class sets available when purchased"
			},
			new DvarEntry
			{
				Name = "tu8_defaultClassSetCount",
				Description = "Number of class sets available when not purchased"
			},
			new DvarEntry
			{
				Name = "sv_playlistFetchInterval",
				Description = "Interval in seconds between playlist fetches"
			},
			new DvarEntry
			{
				Name = "reportUserInterval",
				Description = "The interval in minutes you wait before getting another vote on this console as long as the console is turned on."
			},
			new DvarEntry
			{
				Name = "dw_active",
				Description = "Pumps Live_Frame() (and hence DW) if true"
			},
			new DvarEntry
			{
				Name = "pc_newversionavailable",
				Description = "True if new version available for download"
			},
			new DvarEntry
			{
				Name = "dw_party_active",
				Description = "Pumps Party_Frame (and hence DW lobby) if true"
			},
			new DvarEntry
			{
				Name = "dw_dupe_key",
				Description = "True if key-in-use message from Demonware"
			},
			new DvarEntry
			{
				Name = "dw_popup",
				Description = "Online services popup"
			},
			new DvarEntry
			{
				Name = "dw_connectafterlogin",
				Description = "Whether to connect the user after login."
			},
			new DvarEntry
			{
				Name = "dw_defaultDTLSAssociationTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "xblive_loggedin",
				Description = "User is logged into online service"
			},
			new DvarEntry
			{
				Name = "xenon_maxVoicePacketsPerSec",
				Description = "Max voice packets per second a client will send"
			},
			new DvarEntry
			{
				Name = "xenon_maxVoicePacketsPerSecForServer",
				Description = "Max voice packets per second the server will send"
			},
			new DvarEntry
			{
				Name = "session_nonblocking",
				Description = "Non-blocking Session code"
			},
			new DvarEntry
			{
				Name = "inviteText",
				Description = "Text to display for the game invite"
			},
			new DvarEntry
			{
				Name = "bandwidth_retry_interval",
				Description = "Interval at which Bandwidth test will be retried"
			},
			new DvarEntry
			{
				Name = "xblive_showmarketplace",
				Description = "true if the player doesn't have all the map packs"
			},
			new DvarEntry
			{
				Name = "xblive_clanmatch",
				Description = "Current game is a clan match"
			},
			new DvarEntry
			{
				Name = "xblive_theater",
				Description = "Current game is a theater mode"
			},
			new DvarEntry
			{
				Name = "xblive_mappacks",
				Description = "2 = both original and new"
			},
			new DvarEntry
			{
				Name = "xblive_wagermatch",
				Description = "Current game is a wager match"
			},
			new DvarEntry
			{
				Name = "xblive_ec_minprobes",
				Description = "Minimum probe results required before early outing qos"
			},
			new DvarEntry
			{
				Name = "xblive_ec_minpercent",
				Description = "Minimum percentage of probe results required before early outing qos"
			},
			new DvarEntry
			{
				Name = "xblive_ec_firstupdatems",
				Description = "MS to wait before deciding to early out qos"
			},
			new DvarEntry
			{
				Name = "xblive_ec_lastupdatems",
				Description = "MS since last update required to early out qos"
			},
			new DvarEntry
			{
				Name = "xblive_ec_maxprobewait",
				Description = "Max MS for matchmaking QoS. Used only for percentage estimation."
			},
			new DvarEntry
			{
				Name = "party_simulateLongQoS",
				Description = "simulate a real QoS which takes around 30 seconds"
			},
			new DvarEntry
			{
				Name = "invite_waitPeriod",
				Description = "time in msec you have to wait between sending invites to the same friend"
			},
			new DvarEntry
			{
				Name = "xblive_clanListChanged",
				Description = "Clan list gets updated"
			},
			new DvarEntry
			{
				Name = "teamsplitter_verbose",
				Description = "Verbose debug output while splitting teams if true."
			},
			new DvarEntry
			{
				Name = "xblive_matchEndingSoon",
				Description = "True if the match is ending soon"
			},
			new DvarEntry
			{
				Name = "clancard_clanid",
				Description = "Clan id for the clancard to be displayed."
			},
			new DvarEntry
			{
				Name = "ui_isClanMember",
				Description = "True when member belongs to clan"
			},
			new DvarEntry
			{
				Name = "ui_inGameStoreVisible",
				Description = "Dvar to on/off ingamestore button on the main menu."
			},
			new DvarEntry
			{
				Name = "pclive_updateFriends",
				Description = "Determine whether to send PC friends to content server."
			},
			new DvarEntry
			{
				Name = "v2->drawBBox",
				Description = "Draw glass bounding box"
			},
			new DvarEntry
			{
				Name = "v2->drawDebug",
				Description = "Draw glass client debug"
			},
			new DvarEntry
			{
				Name = "v2->cullShards",
				Description = "Enable glass shards culling (draw all if false)"
			},
			new DvarEntry
			{
				Name = "v2->drawShardOutline",
				Description = "2-w/text)"
			},
			new DvarEntry
			{
				Name = "v2->pickShards",
				Description = "pick a shard"
			},
			new DvarEntry
			{
				Name = "v2->debugSplit",
				Description = "print shard split debug info"
			},
			new DvarEntry
			{
				Name = "v2->freezeShards",
				Description = "Freeze the shards after the shatter"
			},
			new DvarEntry
			{
				Name = "v2->broom",
				Description = "Enable the 'broom'"
			},
			new DvarEntry
			{
				Name = "v2->maxShardSplit",
				Description = "Max number of shards that a glass can be split into"
			},
			new DvarEntry
			{
				Name = "v2->maxSplitSizeRatio",
				Description = "Minimum size of the smallest accepted shard relative to the current largest shard"
			},
			new DvarEntry
			{
				Name = "v2->defragMemory",
				Description = "Enable glass memory defragmentation"
			},
			new DvarEntry
			{
				Name = "v2->defragIndices",
				Description = "Enable glass memory defragmentation"
			},
			new DvarEntry
			{
				Name = "v2->smpGlass",
				Description = "Update & generate glass verts in a worker thread"
			},
			new DvarEntry
			{
				Name = "v2->doMaintenance",
				Description = "Do cleanup of the glass"
			},
			new DvarEntry
			{
				Name = "v1->damageMultiplier",
				Description = "Multiplier the damage applied to the glass (server)."
			},
			new DvarEntry
			{
				Name = "demo_enabled",
				Description = "Used to turn the system on/off."
			},
			new DvarEntry
			{
				Name = "demo_recordPrivateMatch",
				Description = "Used to turn the private match recording on/off."
			},
			new DvarEntry
			{
				Name = "demo_filesizeLimit",
				Description = "The maximum filesize (in MB) of the demos which we support."
			},
			new DvarEntry
			{
				Name = "demo_recordStaticEntityPositions",
				Description = "as opposed to letting the client to evaluate."
			},
			new DvarEntry
			{
				Name = "demo_debug",
				Description = "Debug info for the Server Snapshot Demo system"
			},
			new DvarEntry
			{
				Name = "demo_errortitle",
				Description = "Most recent demo error's title."
			},
			new DvarEntry
			{
				Name = "demo_errormessage",
				Description = "Most recent demo error's message."
			},
			new DvarEntry
			{
				Name = "demo_client",
				Description = "Current viewing player"
			},
			new DvarEntry
			{
				Name = "demo_recordingrate",
				Description = "Used to tweak the rate(in msec) at which we write a super snapshot"
			},
			new DvarEntry
			{
				Name = "demo_keyframerate",
				Description = "Used to specify the rate(in sec) at which we generate a keyframe during playback."
			},
			new DvarEntry
			{
				Name = "demo_pause",
				Description = "Used to pause a demo playback."
			},
			new DvarEntry
			{
				Name = "demo_pauseOnNextSnapshot",
				Description = "Used to jump to the next snapshot during network analysis."
			},
			new DvarEntry
			{
				Name = "demo_maxTimeScale",
				Description = "The maximum timescale rate we will support."
			},
			new DvarEntry
			{
				Name = "demo_useCinematicsBuffer",
				Description = "Used cinematics buffer for downloading demo files on the PS3"
			},
			new DvarEntry
			{
				Name = "demo_save_smp",
				Description = "Used to toggle threaded save for the demo system."
			},
			new DvarEntry
			{
				Name = "demo_bookmarkEventThresholdTime",
				Description = "The time duration for which we want to show the bookmark event image in the demo timeline."
			},
			new DvarEntry
			{
				Name = "demo_selectedSegmentIndex",
				Description = "Used in the Manage Segments UI. This will be used to know which segment index we have selected."
			},
			new DvarEntry
			{
				Name = "demo_enableDollyCam",
				Description = "Used to turn the dollycam on/off."
			},
			new DvarEntry
			{
				Name = "demo_refreshDollyCamFxEveryFrame",
				Description = "Used to toggle the refreshing of the dollycam marker every frame."
			},
			new DvarEntry
			{
				Name = "demo_dollycamHighlightThreshholdDistance",
				Description = "Maximum distance between the marker point and the current camera for it to be treated as highlighted."
			},
			new DvarEntry
			{
				Name = "demo_dollycamTrackWidth",
				Description = "The width of the dollycam track."
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerInformationThreshholdDistance",
				Description = "Maximum distance between the marker point and the current camera for its information to be drawn."
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerInformationNearDist",
				Description = "The near distance at which dolly cam marker text is full size"
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerInformationFarDist",
				Description = "The far distance at which dolly cam marker text sizes stop scaling down"
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerInformationFarScale",
				Description = "The amount to scale overhead dolly cam marker text sizes at demo_dollycamMarkerInformationFarDist"
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerTimeScaleMode",
				Description = "The timescale mode of the selected marker. Used by the menus for tweaking."
			},
			new DvarEntry
			{
				Name = "demo_dollycamMarkerTimeScaleValue",
				Description = "The timescale value of the selected marker. Used by the menus for tweaking."
			},
			new DvarEntry
			{
				Name = "demo_desiredTime",
				Description = "Used to force demo to a certain time"
			},
			new DvarEntry
			{
				Name = "demo_desiredClient",
				Description = "Used to force demo to a certain client"
			},
			new DvarEntry
			{
				Name = "demo_playbackClientXUID",
				Description = "Overrides current player's xuid for the demo system."
			},
			new DvarEntry
			{
				Name = "demo_freeCameraShowLockableObjectsAlways",
				Description = "Used to decide whether we want to display a highlight for a lockable object."
			},
			new DvarEntry
			{
				Name = "demo_freeCameraLockOnHighlightThreshholdDistance",
				Description = "Maximum distance between the entity and the current camera for it to be treated as highlighted."
			},
			new DvarEntry
			{
				Name = "demo_freeCameraLockOnOrbitRadius",
				Description = "Radius of the lockon orbit."
			},
			new DvarEntry
			{
				Name = "demo_highlightReelPlayerFilter",
				Description = "Demo Highlight Reel player filter control"
			},
			new DvarEntry
			{
				Name = "demo_highlightReelTransitionFilter",
				Description = "Demo Highlight Reel transition filter control"
			},
			new DvarEntry
			{
				Name = "demo_highlightReelStylesFilter",
				Description = "Demo Highlight Reel styles filter control"
			},
			new DvarEntry
			{
				Name = "demo_highlightReelNumberOfSegments",
				Description = "Demo Highlight Reel number of segments"
			},
			new DvarEntry
			{
				Name = "demo_highlightReelMinimumStarsFilter",
				Description = "Minimum stars used for the filtering of events in the highlight."
			},
			new DvarEntry
			{
				Name = "demo_highlightReelGameResultFilter",
				Description = "Demo highlight reel round outcome filter."
			},
			new DvarEntry
			{
				Name = "demo_packetsPerSecondMin",
				Description = "Min amount of packets to send per second before throttling."
			},
			new DvarEntry
			{
				Name = "demo_bytesPerSecondMin",
				Description = "Min amount of bytes to send per second before throttling."
			},
			new DvarEntry
			{
				Name = "demo_packetsPerSecondMax",
				Description = "Max amount of packets to send per second before throttling."
			},
			new DvarEntry
			{
				Name = "demo_bytesPerSecondMax",
				Description = "Max amount of bytes to send per second before throttling."
			},
			new DvarEntry
			{
				Name = "demo_inLobbyThrottleBandwitdhPercent",
				Description = "Bandwidth percent to be released when we are not going to throttle in the lobby."
			},
			new DvarEntry
			{
				Name = "demo_inGameThrottleBandwitdhPercent",
				Description = "Bandwidth percent to be released when we are not going to throttle inside the game."
			},
			new DvarEntry
			{
				Name = "demo_streamingAdjustmentFactor",
				Description = "The adjustment factor for howScrewedAreWe in the streaming."
			},
			new DvarEntry
			{
				Name = "demo_enableSvBandwidthLimitThrottle",
				Description = "Used to enable the server bandwidth based throttling system."
			},
			new DvarEntry
			{
				Name = "demo_svBandwidthLimitThrottleMaxBytesPercent",
				Description = "The percentage of the max. bandwidth per frame within which we want to apply the throttle."
			},
			new DvarEntry
			{
				Name = "demo_svBandwidthLimitThrottleTimeout",
				Description = "due to the server hitting the maximum bandwidth limit per frame."
			},
			new DvarEntry
			{
				Name = "demo_streamUploadKeepAliveFrequency",
				Description = "used mainly to account for zombiemode pause."
			},
			new DvarEntry
			{
				Name = "demo_streamingSendSocketBuffSizeForRecording",
				Description = "The send socket buffer size which will be used for recording"
			},
			new DvarEntry
			{
				Name = "demo_streamingSendSocketBuffSizeForOtherUploads",
				Description = "The send socket buffer size which will be used for other uploads"
			},
			new DvarEntry
			{
				Name = "demo_downloadStreamThrottleTime",
				Description = "The maximum amount of time (in msec) we can starve the download stream callback."
			},
			new DvarEntry
			{
				Name = "demo_downloadStreamRetryWaitTime",
				Description = "The maximum amount of time (in msec) we will have to wait before we retry the download."
			},
			new DvarEntry
			{
				Name = "demo_downloadStreamMaxRetryAttemps",
				Description = "The maximum number of retry attempts before we mark the downloadstream as failed.."
			},
			new DvarEntry
			{
				Name = "demo_downloadStreamDataBlockThrottleTime",
				Description = "The maximum amount of time (in msec) we can wait before triggering the download of the next data block."
			},
			new DvarEntry
			{
				Name = "demo_downloadStreamDataBlockRequestSize",
				Description = "The maximum amount of time (in msec) we can wait before triggering the download of the next data block."
			},
			new DvarEntry
			{
				Name = "demoRenderDuration",
				Description = "Max duration in seconds of a clip that can be rendered."
			},
			new DvarEntry
			{
				Name = "demoRenderSizeX",
				Description = "Width of the demo render."
			},
			new DvarEntry
			{
				Name = "demoRenderSizeY",
				Description = "Height of the demo render."
			},
			new DvarEntry
			{
				Name = "demo_matchRecordEventOnPlaylists",
				Description = "Bit Mask of playlist IDs on which to do a recordEvent upon match completion."
			},
			new DvarEntry
			{
				Name = "demo_extraNetworkProfileData",
				Description = "Enables recording extra profile data into demo snapshots."
			},
			new DvarEntry
			{
				Name = "demo_enableClipRecordEvent",
				Description = "Enables recording of events for clips."
			},
			new DvarEntry
			{
				Name = "dtp",
				Description = "Turn on/off the dive to prone functionality"
			},
			new DvarEntry
			{
				Name = "dtp_debug",
				Description = "Turn on/off dive to prone debug draw path"
			},
			new DvarEntry
			{
				Name = "dtp_max_slide_duration",
				Description = "Determines the max time the slide portion of the dtp move will take"
			},
			new DvarEntry
			{
				Name = "dtp_max_slide_addition",
				Description = "Additional slide time should the player land on a mantle-able surface"
			},
			new DvarEntry
			{
				Name = "dtp_startup_delay",
				Description = "Determines how long the player has to sprint before the dtp move can trigger"
			},
			new DvarEntry
			{
				Name = "dtp_post_move_pause",
				Description = "Duration of the post move pause"
			},
			new DvarEntry
			{
				Name = "dtp_fall_damage_min_height",
				Description = "he will not receive any kill damage"
			},
			new DvarEntry
			{
				Name = "dtp_fall_damage_max_height",
				Description = "he will receive kill damage"
			},
			new DvarEntry
			{
				Name = "dtp_exhaustion_window",
				Description = "Determines how long the player has to sprint before the dtp move can trigger"
			},
			new DvarEntry
			{
				Name = "dtp_min_speed",
				Description = "Minimum player speed required to start a DTP or sustain a DTP"
			},
			new DvarEntry
			{
				Name = "door_breach_weapondrop",
				Description = "Turn on/off the waepon drop/rise for during door breach"
			},
			new DvarEntry
			{
				Name = "dtp_new_trajectory",
				Description = "Use new dive to prone trajectory"
			},
			new DvarEntry
			{
				Name = "dtp_new_trajectory_multiplier",
				Description = "New dive to prone trajectory modifier"
			},
			new DvarEntry
			{
				Name = "dtp_max_apex_duration",
				Description = "Determines the max time in milliseconds the dtp will spend at the apex of the jump"
			},
			new DvarEntry
			{
				Name = "jump_height",
				Description = "The maximum height of a player's jump"
			},
			new DvarEntry
			{
				Name = "jump_stepSize",
				Description = "The maximum step up to the top of a jump arc"
			},
			new DvarEntry
			{
				Name = "jump_slowdownEnable",
				Description = "Slow player movement after jumping"
			},
			new DvarEntry
			{
				Name = "jump_ladderPushVel",
				Description = "The velocity of a jump off of a ladder"
			},
			new DvarEntry
			{
				Name = "jump_spreadAdd",
				Description = "The amount of spread scale to add as a side effect of jumping"
			},
			new DvarEntry
			{
				Name = "mantle_enable",
				Description = "Enable player mantling"
			},
			new DvarEntry
			{
				Name = "mantle_debug",
				Description = "Show debug information for mantling"
			},
			new DvarEntry
			{
				Name = "mantle_check_range",
				Description = "The minimum distance from a player to a mantle surface to allow a mantle"
			},
			new DvarEntry
			{
				Name = "mantle_adjustment_tu",
				Description = "Enable the mantle adjustments for the cylindrical player collision"
			},
			new DvarEntry
			{
				Name = "mantle_check_range_tu",
				Description = "The minimum distance from a player to a mantle surface to allow a mantle"
			},
			new DvarEntry
			{
				Name = "mantle_check_radius",
				Description = "The player radius to test against while mantling"
			},
			new DvarEntry
			{
				Name = "mantle_check_angle",
				Description = "The minimum angle from the player to a mantle surface to allow a mantle"
			},
			new DvarEntry
			{
				Name = "mantle_check_glass_extra_range",
				Description = "The extra distance to test if glass is "
			},
			new DvarEntry
			{
				Name = "mantle_view_yawcap",
				Description = "The angle at which to restrict a sideways turn while mantling"
			},
			new DvarEntry
			{
				Name = "mantle_weapon_height",
				Description = "his weapon will remain equipped."
			},
			new DvarEntry
			{
				Name = "mantle_weapon_anim_height",
				Description = "the mantle animation will play."
			},
			new DvarEntry
			{
				Name = "vehicle_push_during_mantle",
				Description = "Enable player mantling"
			},
			new DvarEntry
			{
				Name = "prone_bipod_enable",
				Description = "Enable bipods whilst prone"
			},
			new DvarEntry
			{
				Name = "hatch_mantle_up",
				Description = "hatch_mantle_up"
			},
			new DvarEntry
			{
				Name = "hatch_mantle_fwd",
				Description = "hatch_mantle_fwd"
			},
			new DvarEntry
			{
				Name = "perk_weapSwitchMultiplier",
				Description = "Percentage of weapon switching rate to use"
			},
			new DvarEntry
			{
				Name = "perk_weapSpreadMultiplier",
				Description = "Percentage of weapon spread to use"
			},
			new DvarEntry
			{
				Name = "perk_weapReloadMultiplier",
				Description = "Percentage of weapon reload time to use"
			},
			new DvarEntry
			{
				Name = "perk_weapRateMultiplier",
				Description = "Percentage of weapon firing rate to use"
			},
			new DvarEntry
			{
				Name = "perk_weapAdsMultiplier",
				Description = "Percentage of weapon ADS rate to use"
			},
			new DvarEntry
			{
				Name = "perk_weapMeleeMultiplier",
				Description = "Percentage of weapon melee recovery rate to use"
			},
			new DvarEntry
			{
				Name = "perk_weapTossMultiplier",
				Description = "Percentage of grenade toss rate to use"
			},
			new DvarEntry
			{
				Name = "perk_weapEquipmentUseMultiplier",
				Description = "Percentage of equipment use rate to use"
			},
			new DvarEntry
			{
				Name = "perk_extraBreath",
				Description = "Number of extra seconds a player can hold his breath"
			},
			new DvarEntry
			{
				Name = "perk_bulletPenetrationMultiplier",
				Description = "Multiplier for extra bullet penetration"
			},
			new DvarEntry
			{
				Name = "perk_grenadeDeath",
				Description = "Name of the grenade weapon to drop"
			},
			new DvarEntry
			{
				Name = "perk_sprintMultiplier",
				Description = "Multiplier for player_sprinttime"
			},
			new DvarEntry
			{
				Name = "perk_grenadeTossBackTimer",
				Description = "Minimum timer for a grenade.If the time left is less than this it will be bumped up.Tossback Perk"
			},
			new DvarEntry
			{
				Name = "perk_killstreakReduction",
				Description = "Reduced number of kills required to obtain a killstreak."
			},
			new DvarEntry
			{
				Name = "perk_killstreakMomentumMultiplier",
				Description = "Multiplies the amount of momentum received by the player"
			},
			new DvarEntry
			{
				Name = "perk_killstreakDeathPenaltyMultiplier",
				Description = "Multiplies the amount of death penalty received by the player"
			},
			new DvarEntry
			{
				Name = "perk_delayExplosiveTime",
				Description = "Time in seconds to delay a proximity explosive"
			},
			new DvarEntry
			{
				Name = "perk_disarmExplosiveTime",
				Description = "Time in seconds to disarm a proximity explosive"
			},
			new DvarEntry
			{
				Name = "perk_speedMultiplier",
				Description = "Player speed multiplier"
			},
			new DvarEntry
			{
				Name = "perk_deathStreakCountRequired",
				Description = "Number of deaths required to obtain a deathstreak."
			},
			new DvarEntry
			{
				Name = "perk_sprintRecoveryMultiplier",
				Description = "Percent of sprint recovery time to use."
			},
			new DvarEntry
			{
				Name = "perk_healthRegenMultiplier",
				Description = "Multiplier to the time which the player starts to regenerate health after damage"
			},
			new DvarEntry
			{
				Name = "perk_damageKickReduction",
				Description = "The percentage decrease of view kick flinch when the player takes damage"
			},
			new DvarEntry
			{
				Name = "perk_shellShockReduction",
				Description = "The percentage decrease of shellshock time"
			},
			new DvarEntry
			{
				Name = "perk_mantleReduction",
				Description = "The percentage decrease of mantle up time"
			},
			new DvarEntry
			{
				Name = "perk_interactSpeedMultiplier",
				Description = "Multiplier for increasing use timers."
			},
			new DvarEntry
			{
				Name = "perk_throwbackInnerRadius",
				Description = "The radius to a live grenade player must be within initially to do a throwback with the toss back perk on"
			},
			new DvarEntry
			{
				Name = "perk_flakJacket",
				Description = "Percent of explosive damage done that will apply to player."
			},
			new DvarEntry
			{
				Name = "perk_flakJacket_hardcore",
				Description = "Percent of explosive damage done that will apply to player in hardcore."
			},
			new DvarEntry
			{
				Name = "perk_fireproof",
				Description = "Percent to reduce flame damage done to the player."
			},
			new DvarEntry
			{
				Name = "perk_armorPiercing",
				Description = "and turrets."
			},
			new DvarEntry
			{
				Name = "perk_dogsAttackGhost",
				Description = "Set to true if the dogs should attack players with 'specialty_nottargetedbyai'"
			},
			new DvarEntry
			{
				Name = "perk_blackbirdShowsGpsJammer",
				Description = "Set to true if the blackbird should show players with 'specialty_gpsjammer'"
			},
			new DvarEntry
			{
				Name = "perk_fastLadderClimbMultiplier",
				Description = "Multiplier for ladder climbing speed."
			},
			new DvarEntry
			{
				Name = "perk_marksmanEnemyNameFadeIn",
				Description = "Time in milliseconds to fade in enemy names for the marksman perk."
			},
			new DvarEntry
			{
				Name = "perk_marksmanEnemyNameFadeOut",
				Description = "Time in milliseconds to fade out enemy names for the marksman perk."
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_min_speed",
				Description = "player will always be protected from UAV sweeps with this specialty."
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_min_distance",
				Description = "player will always be protected from UAV sweeps with this specialty."
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_time_period",
				Description = "in MSec. Please use multiples of 50 msec as that is the period of server script "
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_graceperiods",
				Description = "Number of time period a player can be below the required velocity before removing protection."
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_alpha",
				Description = "The alpha of the player material on the minimap when being protected"
			},
			new DvarEntry
			{
				Name = "perk_gpsjammer_fade_time",
				Description = "The time ( in MSec ) for the player indicator to fade when being protected"
			},
			new DvarEntry
			{
				Name = "perk_nottargetedbyai_min_speed",
				Description = "player will always be protected from AI controlled killstreaks with this specialty."
			},
			new DvarEntry
			{
				Name = "perk_nottargetedbyai_graceperiod",
				Description = "0 default. "
			},
			new DvarEntry
			{
				Name = "perk_scavenger_clip_multiplier",
				Description = "2 default. Support rounding to an integer bullet count when a float is used."
			},
			new DvarEntry
			{
				Name = "perk_scavenger_lethal_proc",
				Description = "the player would need to pick up 3 scavenger bags to refill 1 frag grenade."
			},
			new DvarEntry
			{
				Name = "perk_scavenger_tactical_proc",
				Description = "2 default."
			},
			new DvarEntry
			{
				Name = "allItemsUnlocked",
				Description = "Allows all items to be purchased in the Black Market"
			},
			new DvarEntry
			{
				Name = "allItemsPurchased",
				Description = "Allows all items to be equiped in Create-a-Class"
			},
			new DvarEntry
			{
				Name = "printCACValidationSuccesses",
				Description = "displays validation successes"
			},
			new DvarEntry
			{
				Name = "printCACValidationErrors",
				Description = "displays validation errors"
			},
			new DvarEntry
			{
				Name = "tu6_perkBonusCardCheck",
				Description = "Switch for checking bonus card perks"
			},
			new DvarEntry
			{
				Name = "tu6_conflictingAttachmentCheck",
				Description = "Switch for checking for conflicting attachments"
			},
			new DvarEntry
			{
				Name = "tu6_verifyUnusedAttachmentSlotsCheck",
				Description = "Switch for checking unused attachment slots are empty"
			},
			new DvarEntry
			{
				Name = "tu6_enableDLCWeapons",
				Description = "Enable DLC weapons in CAC"
			},
			new DvarEntry
			{
				Name = "tu6_CaCImportVerifyDLCWeapons",
				Description = "Verify DLC weapons on CAC import"
			},
			new DvarEntry
			{
				Name = "tu7_additionalGrenadeChecks",
				Description = "additional grenade checks for valid itemindex and dangerclose bonuscard."
			},
			new DvarEntry
			{
				Name = "tu7_itemOptionLockedByChallengeCheck",
				Description = "perform stats check for itemOptionLockedByChallenge"
			},
			new DvarEntry
			{
				Name = "tu7_itemOptionLockedByChallengeResult",
				Description = "result when the above stats check failes"
			},
			new DvarEntry
			{
				Name = "tu7_itemOptionLockedCheck",
				Description = "perform stats check for unlockablesItemOptionLocked"
			},
			new DvarEntry
			{
				Name = "tu7_itemOptionLockedResult",
				Description = "result when the above stats check failes"
			},
			new DvarEntry
			{
				Name = "vehanim_enable",
				Description = "Enable player vehicle anims"
			},
			new DvarEntry
			{
				Name = "vehanim_debug",
				Description = "Show debug information for vehicle anims"
			},
			new DvarEntry
			{
				Name = "g_EnableGlobalWind",
				Description = "enable wind effect"
			},
			new DvarEntry
			{
				Name = "g_EnableGrassWind",
				Description = "enable grass wind effect"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindVector",
				Description = "global wind force in units/sec. This is also the hi-level wind"
			},
			new DvarEntry
			{
				Name = "g_GlobalLowWindAltitude",
				Description = "altitude of global low-level wind"
			},
			new DvarEntry
			{
				Name = "g_GlobalHiWindAltitude",
				Description = "altitude of global hi-level wind"
			},
			new DvarEntry
			{
				Name = "g_GlobalLowWindStrengthPercentage",
				Description = "expressed as a percentage of wind_global_vector"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindLeafScale",
				Description = "global wind grass tension (stiffness)"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGrassGustInterval",
				Description = "global wind force gust interval"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGrassScale",
				Description = "global wind force scaler"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGrassTension",
				Description = "global wind grass tension (stiffness)"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGustSpeedMultiplier",
				Description = "speed multiplier for gusts"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGustRadius",
				Description = "size of global wind gust effector"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGustStrength",
				Description = "percentage to bump the wind in a gust"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindGustDistance",
				Description = "max distance at which to place gusts"
			},
			new DvarEntry
			{
				Name = "g_GlobalWindDebugDisplay",
				Description = "shows wind debug display"
			},
			new DvarEntry
			{
				Name = "g_GlobalTreeBend",
				Description = "bend amount of tree trunk"
			},
			new DvarEntry
			{
				Name = "g_GlobalTreeRandom",
				Description = "random addition to bend amount of tree trunk"
			},
			new DvarEntry
			{
				Name = "g_GlobalTreeFrequency",
				Description = "frequency of tree bend oscillation"
			},
			new DvarEntry
			{
				Name = "shieldImpactBulletShakeScale",
				Description = "Viewmodel shake scale for bullet impacts."
			},
			new DvarEntry
			{
				Name = "shieldImpactBulletShakeDuration",
				Description = "Viewmodel shake duration for bullet impacts."
			},
			new DvarEntry
			{
				Name = "shieldImpactMissileShakeScale",
				Description = "Viewmodel shake scale for direct missile impacts."
			},
			new DvarEntry
			{
				Name = "shieldImpactMissileShakeDuration",
				Description = "Viewmodel shake duration for direct missile impacts."
			},
			new DvarEntry
			{
				Name = "shieldImpactExplosionLowShakeScale",
				Description = "Viewmodel shake scale for weak splash damage."
			},
			new DvarEntry
			{
				Name = "shieldImpactExplosionLowShakeDuration",
				Description = "Viewmodel shake duration for weak splash damage."
			},
			new DvarEntry
			{
				Name = "shieldImpactExplosionHighShakeScale",
				Description = "Viewmodel shake scale for strong splash damage."
			},
			new DvarEntry
			{
				Name = "shieldImpactExplosionHighShakeDuration",
				Description = "Viewmodel shake duration for strong splash damage."
			},
			new DvarEntry
			{
				Name = "shieldImpactExplosionThreshold",
				Description = "Pre-shield splash damage that is above this will be 'strong'."
			},
			new DvarEntry
			{
				Name = "shieldDeployShakeScale",
				Description = "Viewmodel shake scale for riotshield deploy."
			},
			new DvarEntry
			{
				Name = "shieldDeployShakeDuration",
				Description = "Viewmodel shake duration for riotshield deploy."
			},
			new DvarEntry
			{
				Name = "riotshield_deploy_limit_radius",
				Description = "Min distance deployed riotshields must be from each other."
			},
			new DvarEntry
			{
				Name = "riotshield_bullet_damage_scale",
				Description = "Value to scale bullet damage to deployed riotshield."
			},
			new DvarEntry
			{
				Name = "riotshield_explosive_damage_scale",
				Description = "Value to scale explosive damage to deployed riotshield.."
			},
			new DvarEntry
			{
				Name = "riotshield_melee_damage_scale",
				Description = "Value to scale melee damage to deployed riotshield."
			},
			new DvarEntry
			{
				Name = "riotshield_projectile_damage_scale",
				Description = "Value to scale projectile damage to deployed riotshield."
			},
			new DvarEntry
			{
				Name = "riotshield_deployed_health",
				Description = "Deployed riotshield health."
			},
			new DvarEntry
			{
				Name = "riotshield_destroyed_cleanup_time",
				Description = "Time (in seconds) destroyed riotshield model persists before disappearing"
			},
			new DvarEntry
			{
				Name = "riotshield_deploy_pitch_max",
				Description = "Max surface pitch angle to allow riotshield deployment"
			},
			new DvarEntry
			{
				Name = "riotshield_deploy_roll_max",
				Description = "Max surface roll angle to allow riotshield deployment"
			},
			new DvarEntry
			{
				Name = "riotshield_deploy_zdiff_max",
				Description = "Max height difference allowed between plant surface and player origin"
			},
			new DvarEntry
			{
				Name = "riotshield_assist_time",
				Description = "Time in seconds to receive assist points from the death of a player who's damage has been blocked by a riotshield"
			},
			new DvarEntry
			{
				Name = "riotshield_damage_score_threshold",
				Description = "The amount of damage blocked with the riotshield to receive a score bonus."
			},
			new DvarEntry
			{
				Name = "riotshield_damage_score_max",
				Description = "The amount of damage blocked before score awarded is nerfed."
			},
			new DvarEntry
			{
				Name = "shieldBlastDamageProtection_30",
				Description = "1.0 is full.For explosions within a 30-degree arc of the shield."
			},
			new DvarEntry
			{
				Name = "shieldBlastDamageProtection_60",
				Description = "1.0 is full.For explosions within a 60-degree arc of the shield."
			},
			new DvarEntry
			{
				Name = "shieldBlastDamageProtection_120",
				Description = "1.0 is full.  For explosions within a 120-degree arc of the shield."
			},
			new DvarEntry
			{
				Name = "shieldBlastDamageProtection_180",
				Description = "1.0 is full.  For explosions within a 180-degree arc of the shield."
			},
			new DvarEntry
			{
				Name = "shieldPlayerBulletProtectionDegrees",
				Description = "Bullets fired at a riotshield-bearing player will be blocked if they are within this many degrees of the player's forward direction.Higher value means wider protection."
			},
			new DvarEntry
			{
				Name = "r_fontResolution",
				Description = "Console font resolution setting. The value is 720 or 1080."
			},
			new DvarEntry
			{
				Name = "r_resolution",
				Description = "Console Resolution setting."
			},
			new DvarEntry
			{
				Name = "r_ssao",
				Description = "Enable SSAO."
			},
			new DvarEntry
			{
				Name = "r_ssaoScale",
				Description = "SSAO scale."
			},
			new DvarEntry
			{
				Name = "r_ssaoRadius",
				Description = "SSAO radius."
			},
			new DvarEntry
			{
				Name = "r_ssaoBias",
				Description = "SSAO bias."
			},
			new DvarEntry
			{
				Name = "r_ssaoIntensity",
				Description = "SSAO intensity."
			},
			new DvarEntry
			{
				Name = "r_ssaoDebug",
				Description = "SSAO debug."
			},
			new DvarEntry
			{
				Name = "r_txaa",
				Description = "Enable TXAA."
			},
			new DvarEntry
			{
				Name = "r_txaaSupported",
				Description = "True if TXAA is supported."
			},
			new DvarEntry
			{
				Name = "r_txaaMode",
				Description = "TXAA mode."
			},
			new DvarEntry
			{
				Name = "r_txaaDepth1",
				Description = "TXAA depth1"
			},
			new DvarEntry
			{
				Name = "r_txaaDepth2",
				Description = "TXAA depth2"
			},
			new DvarEntry
			{
				Name = "r_txaaMotion1",
				Description = "TXAA motion1"
			},
			new DvarEntry
			{
				Name = "r_txaaMotion2",
				Description = "TXAA motion2"
			},
			new DvarEntry
			{
				Name = "r_clipCodec",
				Description = "Codec used when rendering clips."
			},
			new DvarEntry
			{
				Name = "r_clipSize",
				Description = "Render clip size."
			},
			new DvarEntry
			{
				Name = "r_clipFPS",
				Description = "Render clip FPS."
			},
			new DvarEntry
			{
				Name = "vid_xpos",
				Description = "Game window horizontal position"
			},
			new DvarEntry
			{
				Name = "vid_ypos",
				Description = "game window vertical position"
			},
			new DvarEntry
			{
				Name = "r_autopriority",
				Description = "Automatically set the priority of the windows process when the game is minimized"
			},
			new DvarEntry
			{
				Name = "r_fullscreen",
				Description = "fullscreen window)"
			},
			new DvarEntry
			{
				Name = "r_previousFullscreen",
				Description = "fullscreen window)"
			},
			new DvarEntry
			{
				Name = "r_convergence",
				Description = "Change 3D convergence"
			},
			new DvarEntry
			{
				Name = "r_ignoreHwGamma",
				Description = "Ignore hardware gamma"
			},
			new DvarEntry
			{
				Name = "r_texFilterAnisoMax",
				Description = "Maximum anisotropy to use for texture filtering"
			},
			new DvarEntry
			{
				Name = "r_texFilterDisable",
				Description = "Disables all texture filtering (uses nearest only.)"
			},
			new DvarEntry
			{
				Name = "r_texFilterAnisoMin",
				Description = "Minimum anisotropy to use for texture filtering (overridden by max)"
			},
			new DvarEntry
			{
				Name = "r_texFilterMipMode",
				Description = "Forces all mipmaps to use a particular blend between levels (or disables mipping.)"
			},
			new DvarEntry
			{
				Name = "r_texFilterMipBias",
				Description = "Change the mipmap bias"
			},
			new DvarEntry
			{
				Name = "r_fullbright",
				Description = "Toggles rendering without lighting"
			},
			new DvarEntry
			{
				Name = "r_debugShader",
				Description = "Enable normal map debug shader"
			},
			new DvarEntry
			{
				Name = "r_debugPerformance",
				Description = "Enable performance debug shader"
			},
			new DvarEntry
			{
				Name = "r_lightConflicts",
				Description = "Shows conflicts between primary lights"
			},
			new DvarEntry
			{
				Name = "r_zebrastripe",
				Description = "3 = 18% Average Grey"
			},
			new DvarEntry
			{
				Name = "r_loadingScreen",
				Description = "True if the game is playing a loading movie"
			},
			new DvarEntry
			{
				Name = "r_multiGpu",
				Description = "Optimize for multiple GPUs (if present)"
			},
			new DvarEntry
			{
				Name = "r_texFilterQuality",
				Description = "Texture filtering quality."
			},
			new DvarEntry
			{
				Name = "r_lodScaleRigid",
				Description = "Scale the level of detail distance for rigid models (larger reduces detail)"
			},
			new DvarEntry
			{
				Name = "r_lodBiasRigid",
				Description = "Bias the level of detail distance for rigid models (negative increases detail)"
			},
			new DvarEntry
			{
				Name = "r_lodScaleSkinned",
				Description = "Scale the level of detail distance for skinned models (larger reduces detail)"
			},
			new DvarEntry
			{
				Name = "r_lodBiasSkinned",
				Description = "Bias the level of detail distance for skinned models (negative increases detail)"
			},
			new DvarEntry
			{
				Name = "r_skinnedCacheOverflowLodMaxScale",
				Description = "Maximum LOD scale when skinned vertex cache is overflowed"
			},
			new DvarEntry
			{
				Name = "r_skinnedCacheOverflowLodScaleDecay",
				Description = "Amount of time it takes the LOD scale to settle back to 1.0f after it overflowed"
			},
			new DvarEntry
			{
				Name = "r_autoLodScale",
				Description = "Enable FPS-based auto LOD scale"
			},
			new DvarEntry
			{
				Name = "r_znear",
				Description = "Things closer than this aren't drawn.Reducing this increases z-fighting in the distance."
			},
			new DvarEntry
			{
				Name = "r_znear_depthhack",
				Description = "Viewmodel near clip plane"
			},
			new DvarEntry
			{
				Name = "r_zfar",
				Description = "Change the distance at which culling fog reaches 100% opacity; 0 is off"
			},
			new DvarEntry
			{
				Name = "r_fog",
				Description = "Set to 0 to disable fog"
			},
			new DvarEntry
			{
				Name = "r_picmip_manual",
				Description = "picmip is set based on the other r_picmip dvars."
			},
			new DvarEntry
			{
				Name = "r_picmip",
				Description = "this is read-only."
			},
			new DvarEntry
			{
				Name = "r_picmip_bump",
				Description = "this is read-only."
			},
			new DvarEntry
			{
				Name = "r_picmip_spec",
				Description = "this is read-only."
			},
			new DvarEntry
			{
				Name = "r_lightMapSecondary",
				Description = "Replace secondary lightmaps with varying intensities"
			},
			new DvarEntry
			{
				Name = "r_lightMapFilterDisable",
				Description = "Disable filtering on lightmaps"
			},
			new DvarEntry
			{
				Name = "r_colorMap",
				Description = "Override all color maps"
			},
			new DvarEntry
			{
				Name = "r_normalMap",
				Description = "Lerp all normal maps to a flat normal map"
			},
			new DvarEntry
			{
				Name = "r_drawLitDrawlists",
				Description = "disable drawing of the LIT drawlists"
			},
			new DvarEntry
			{
				Name = "r_drawLightmapDrawlists",
				Description = "disable drawing of the LIGHTMAP drawlists"
			},
			new DvarEntry
			{
				Name = "r_alphaMap",
				Description = "Override all alpha maps"
			},
			new DvarEntry
			{
				Name = "r_specularMap",
				Description = "Replace all specular maps"
			},
			new DvarEntry
			{
				Name = "r_glossMap",
				Description = "Replace all gloss maps"
			},
			new DvarEntry
			{
				Name = "r_occlusionMap",
				Description = "Replace all occlusion maps"
			},
			new DvarEntry
			{
				Name = "r_warmShaders",
				Description = "Set to true to warm pixel shaders next frame"
			},
			new DvarEntry
			{
				Name = "r_loadForRenderer",
				Description = "Set to false to disable dx allocations (for dedicated server mode)"
			},
			new DvarEntry
			{
				Name = "r_shaderWarmingPerFrame",
				Description = "Incremental number of shaders to warm per frame"
			},
			new DvarEntry
			{
				Name = "r_showLodInfo",
				Description = "Show LOD info"
			},
			new DvarEntry
			{
				Name = "r_showTris",
				Description = "Show triangle outlines"
			},
			new DvarEntry
			{
				Name = "r_showTriCounts",
				Description = "Triangle count for each rendered entity"
			},
			new DvarEntry
			{
				Name = "r_showSurfCounts",
				Description = "Surface count for each rendered entity"
			},
			new DvarEntry
			{
				Name = "r_showVertCounts",
				Description = "Vertex count for each entity"
			},
			new DvarEntry
			{
				Name = "r_resampleScene",
				Description = "Upscale the frame buffer with sharpen filter and color correction."
			},
			new DvarEntry
			{
				Name = "r_showPenetration",
				Description = "Shows materials tagged with 'nopenetrate'"
			},
			new DvarEntry
			{
				Name = "r_xdebug",
				Description = "xmodel/xanim debug rendering"
			},
			new DvarEntry
			{
				Name = "r_showForceNoCull",
				Description = "Show ents with force no cull set"
			},
			new DvarEntry
			{
				Name = "r_showSkinned",
				Description = "Show skinned ents"
			},
			new DvarEntry
			{
				Name = "r_showBounds",
				Description = "Show entity bounds"
			},
			new DvarEntry
			{
				Name = "r_showLightGrid",
				Description = "Show light grid debugging information"
			},
			new DvarEntry
			{
				Name = "r_showLightingOrigins",
				Description = "Show lighting origins for models"
			},
			new DvarEntry
			{
				Name = "r_showMissingLightGrid",
				Description = "Use rainbow colors for entities that are outside the light grid"
			},
			new DvarEntry
			{
				Name = "r_showReflectionProbeSelection",
				Description = "Show reflection probe selection"
			},
			new DvarEntry
			{
				Name = "r_hidePartTestOn",
				Description = "enable viewmodel hide bone test"
			},
			new DvarEntry
			{
				Name = "r_lightTweakAmbient",
				Description = "Ambient light strength"
			},
			new DvarEntry
			{
				Name = "r_lightTweakSunLight",
				Description = "Sunlight strength"
			},
			new DvarEntry
			{
				Name = "r_lightTweakAmbientColor",
				Description = "Light ambient color"
			},
			new DvarEntry
			{
				Name = "r_lightTweakSunColor",
				Description = "Sun color"
			},
			new DvarEntry
			{
				Name = "r_lightTweakSunDiffuseColor",
				Description = "Sun diffuse color"
			},
			new DvarEntry
			{
				Name = "r_lightTweakSunDirection",
				Description = "Sun direction in degrees"
			},
			new DvarEntry
			{
				Name = "r_showSunDirectionDebug",
				Description = "Toggles the display of sun direction debug"
			},
			new DvarEntry
			{
				Name = "r_showOutdoorVolumeDebug",
				Description = "Toggles the display of particle outdoor volume debug"
			},
			new DvarEntry
			{
				Name = "r_materialXYZ",
				Description = "material color checker XYZ d65 coords"
			},
			new DvarEntry
			{
				Name = "r_drawInfo",
				Description = "rendering debug info"
			},
			new DvarEntry
			{
				Name = "r_drawPrimHistogram",
				Description = "Draws a histogram of the sizes of each primitive batch"
			},
			new DvarEntry
			{
				Name = "r_norefresh",
				Description = "Skips all rendering.Useful for benchmarking."
			},
			new DvarEntry
			{
				Name = "r_scaleViewport",
				Description = "Scale 3D viewports by this fraction.Use this to see if framerate is pixel shader bound."
			},
			new DvarEntry
			{
				Name = "r_smp_worker",
				Description = "Process renderer front end in a separate thread"
			},
			new DvarEntry
			{
				Name = "r_smp_worker_threads",
				Description = "Number of worker threads"
			},
			new DvarEntry
			{
				Name = "r_showCullDistDebug",
				Description = "Toggles corner culldist debug display"
			},
			new DvarEntry
			{
				Name = "r_showShadowMapDebugText",
				Description = "Toggles corner shadowmap debug display"
			},
			new DvarEntry
			{
				Name = "r_aaSamples",
				Description = "Anti-aliasing sample count; 1 disables anti-aliasing"
			},
			new DvarEntry
			{
				Name = "r_aaSamplesMax",
				Description = "Maximum number of samples supported for anti-aliasing."
			},
			new DvarEntry
			{
				Name = "r_vsync",
				Description = "Enable v-sync before drawing the next frame to avoid 'tearing' artifacts."
			},
			new DvarEntry
			{
				Name = "r_vsyncThreshold",
				Description = "Specify threshold percentage for allowed vsync 'tearing'."
			},
			new DvarEntry
			{
				Name = "r_clearColor",
				Description = "Color to clear the screen to when clearing the frame buffer"
			},
			new DvarEntry
			{
				Name = "r_clearColor2",
				Description = "Color to clear every second frame to (for use during development)"
			},
			new DvarEntry
			{
				Name = "r_viewportBackingColor",
				Description = "Color to clear the frame buffer with before compositing viewports"
			},
			new DvarEntry
			{
				Name = "r_drawSun",
				Description = "Enable sun effects"
			},
			new DvarEntry
			{
				Name = "r_drawWorld",
				Description = "Enable world rendering"
			},
			new DvarEntry
			{
				Name = "r_drawSceneEnts",
				Description = "Enable scene entity rendering"
			},
			new DvarEntry
			{
				Name = "r_drawSceneModels",
				Description = "Enable scene model rendering"
			},
			new DvarEntry
			{
				Name = "r_drawPoly",
				Description = "Enable poly rendering"
			},
			new DvarEntry
			{
				Name = "r_drawDynEnts",
				Description = "Enable dynamic entity rendering"
			},
			new DvarEntry
			{
				Name = "r_drawBModels",
				Description = "Enable brush model rendering"
			},
			new DvarEntry
			{
				Name = "r_drawSModels",
				Description = "Enable static model rendering"
			},
			new DvarEntry
			{
				Name = "r_drawSModelsLV",
				Description = "Enable vertex baked static model rendering"
			},
			new DvarEntry
			{
				Name = "r_drawModelsGobo",
				Description = "Enable model gobo rendering"
			},
			new DvarEntry
			{
				Name = "r_drawXModels",
				Description = "Enable xmodel rendering"
			},
			new DvarEntry
			{
				Name = "r_drawSkinnedModels",
				Description = "Enable skinned rendering"
			},
			new DvarEntry
			{
				Name = "r_dlightLimit",
				Description = "Maximum number of dynamic lights drawn simultaneously"
			},
			new DvarEntry
			{
				Name = "r_dobjLimit",
				Description = "Maximum number of DObjs drawn simultaneously"
			},
			new DvarEntry
			{
				Name = "r_modelLimit",
				Description = "Maximum number of models drawn simultaneously"
			},
			new DvarEntry
			{
				Name = "r_brushLimit",
				Description = "Maximum number of brushes drawn simultaneously"
			},
			new DvarEntry
			{
				Name = "r_spotLightShadows",
				Description = "Enable shadows for spot lights."
			},
			new DvarEntry
			{
				Name = "r_spotLightSModelShadows",
				Description = "Enable static model shadows for spot lights."
			},
			new DvarEntry
			{
				Name = "r_spotLightEntityShadows",
				Description = "Enable entity shadows for spot lights."
			},
			new DvarEntry
			{
				Name = "r_flashLightFovInnerFraction",
				Description = "Relative Inner FOV angle for the dynamic flash light. 0 is full fade 0.99 is almost no fade."
			},
			new DvarEntry
			{
				Name = "r_flashLightStartRadius",
				Description = "Radius of the circle at the start of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightEndRadius",
				Description = "Radius of the circle at the end of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightShadows",
				Description = "Enable shadows for flash light."
			},
			new DvarEntry
			{
				Name = "r_flashLightBrightness",
				Description = "Brightness scale for flash light."
			},
			new DvarEntry
			{
				Name = "r_flashLightOffset",
				Description = "Relative position of the Flashlight."
			},
			new DvarEntry
			{
				Name = "r_flashLightRange",
				Description = "Distance of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightColor",
				Description = "Flashlight Color."
			},
			new DvarEntry
			{
				Name = "r_flashLightBobAmount",
				Description = "Flashlight Movement Amount."
			},
			new DvarEntry
			{
				Name = "r_flashLightBobRate",
				Description = "Flashlight Movement Rate."
			},
			new DvarEntry
			{
				Name = "r_flashLightSpecularScale",
				Description = "Flashlight Specular Scale."
			},
			new DvarEntry
			{
				Name = "v6",
				Description = "Flashlight Flicker Amount."
			},
			new DvarEntry
			{
				Name = "r_flashLightFovInnerFraction",
				Description = "Relative Inner FOV angle for the dynamic flash light. 0 is full fade 0.99 is almost no fade."
			},
			new DvarEntry
			{
				Name = "r_flashLightStartRadius",
				Description = "Radius of the circle at the start of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightEndRadius",
				Description = "Radius of the circle at the end of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightShadows",
				Description = "Enable shadows for flash light."
			},
			new DvarEntry
			{
				Name = "r_flashLightBrightness",
				Description = "Brightness scale for flash light."
			},
			new DvarEntry
			{
				Name = "r_flashLightOffset",
				Description = "Relative position of the Flashlight."
			},
			new DvarEntry
			{
				Name = "r_flashLightRange",
				Description = "Distance of the flash light in inches."
			},
			new DvarEntry
			{
				Name = "r_flashLightColor",
				Description = "Flashlight Color."
			},
			new DvarEntry
			{
				Name = "r_flashLightBobAmount",
				Description = "Flashlight Movement Amount."
			},
			new DvarEntry
			{
				Name = "r_flashLightBobRate",
				Description = "Flashlight Movement Rate."
			},
			new DvarEntry
			{
				Name = "r_flashLightSpecularScale",
				Description = "Flashlight Specular Scale."
			},
			new DvarEntry
			{
				Name = "v6",
				Description = "Flashlight Flicker Amount."
			},
			new DvarEntry
			{
				Name = "r_flashLightFlickerRate",
				Description = "Flashlight Flicker Rate (Times per second)."
			},
			new DvarEntry
			{
				Name = "r_drawPrimCap",
				Description = "Only draw primitive batches with less than this many triangles"
			},
			new DvarEntry
			{
				Name = "r_drawPrimFloor",
				Description = "Only draw primitive batches with more than this many triangles"
			},
			new DvarEntry
			{
				Name = "r_skipDrawTris",
				Description = "Skip drawing primitive tris."
			},
			new DvarEntry
			{
				Name = "r_drawWater",
				Description = "Enable water rendering"
			},
			new DvarEntry
			{
				Name = "r_lockPvs",
				Description = "Request to lock the viewpoint used for determining what is visible to the current position and direction"
			},
			new DvarEntry
			{
				Name = "r_lockPvsInCode",
				Description = "in code. Only code should modified this dvar"
			},
			new DvarEntry
			{
				Name = "r_skipPvs",
				Description = "Skipt the determination of what is in the potentially visible set (disables most drawing)"
			},
			new DvarEntry
			{
				Name = "r_singleCell",
				Description = "Only draw things in the same cell as the camera.Most useful for seeing how big the current cell is."
			},
			new DvarEntry
			{
				Name = "r_showForcedInvisibleCells",
				Description = "Only draw cells that are forced to be off."
			},
			new DvarEntry
			{
				Name = "r_portalWalkLimit",
				Description = "Stop portal recursion after this many iterations.Useful for debugging portal errors."
			},
			new DvarEntry
			{
				Name = "r_portalMinRecurseDepth",
				Description = "Ignore r_portalMinClipArea for portals with fewer than this many parent portals."
			},
			new DvarEntry
			{
				Name = "r_enableOccluders",
				Description = "Enable occluders"
			},
			new DvarEntry
			{
				Name = "r_enableGlassDpvs",
				Description = "Enable DPVS for glass"
			},
			new DvarEntry
			{
				Name = "r_portalOccluderTest",
				Description = "Test portals against occluders"
			},
			new DvarEntry
			{
				Name = "r_showPortals",
				Description = "Show portals for debugging"
			},
			new DvarEntry
			{
				Name = "r_showOccluders",
				Description = "Show occluders for debugging"
			},
			new DvarEntry
			{
				Name = "r_showAabbTrees",
				Description = "Show axis-aligned bounding box trees used in potentially visibility set determination"
			},
			new DvarEntry
			{
				Name = "r_showSModelNames",
				Description = "Show static model names within range"
			},
			new DvarEntry
			{
				Name = "r_showDynEntModelNames",
				Description = "Show dynamic entity model names"
			},
			new DvarEntry
			{
				Name = "r_showDObjModelNamesDist",
				Description = "Show dobj model names within range"
			},
			new DvarEntry
			{
				Name = "r_showEntModelNamesDist",
				Description = "Show entity model names within range"
			},
			new DvarEntry
			{
				Name = "r_showTess",
				Description = "Show details for each surface"
			},
			new DvarEntry
			{
				Name = "r_showCullBModels",
				Description = "Show culled brush models"
			},
			new DvarEntry
			{
				Name = "r_showCullSModels",
				Description = "Show culled static models"
			},
			new DvarEntry
			{
				Name = "r_showCullXModels",
				Description = "Show culled xmodels"
			},
			new DvarEntry
			{
				Name = "r_showCullXmodelsEntNum",
				Description = "Target r_showCullXModels to a specific entity"
			},
			new DvarEntry
			{
				Name = "r_showCollision",
				Description = "Show the collision surfaces for the selected mask types"
			},
			new DvarEntry
			{
				Name = "r_showCollisionGroups",
				Description = "brush or all collision surface groups"
			},
			new DvarEntry
			{
				Name = "r_showCollisionPolyType",
				Description = "or both"
			},
			new DvarEntry
			{
				Name = "r_showCollisionDepthTest",
				Description = "Select whether to use depth test in collision surfaces display"
			},
			new DvarEntry
			{
				Name = "r_showCollisionDist",
				Description = "Maximum distance to show collision surfaces"
			},
			new DvarEntry
			{
				Name = "r_highLodDist",
				Description = "Distance for high level of detail"
			},
			new DvarEntry
			{
				Name = "r_mediumLodDist",
				Description = "Distance for medium level of detail"
			},
			new DvarEntry
			{
				Name = "r_lowLodDist",
				Description = "Distance for low level of detail"
			},
			new DvarEntry
			{
				Name = "r_lowestLodDist",
				Description = "Distance for lowest level of detail"
			},
			new DvarEntry
			{
				Name = "r_forceLod",
				Description = "Force all level of detail to this level"
			},
			new DvarEntry
			{
				Name = "r_modelVertColor",
				Description = "Set to 0 to replace all model vertex colors with white when loaded"
			},
			new DvarEntry
			{
				Name = "sm_sunEnable",
				Description = "Enable sun shadow mapping from script"
			},
			new DvarEntry
			{
				Name = "sm_sunQuality",
				Description = "Sun shadow quality"
			},
			new DvarEntry
			{
				Name = "sm_spotQuality",
				Description = "Spot shadow quality"
			},
			new DvarEntry
			{
				Name = "sm_spotEnable",
				Description = "Enable spot shadow mapping from script"
			},
			new DvarEntry
			{
				Name = "sm_maxLights",
				Description = "Limits how many primary lights can have shadow maps"
			},
			new DvarEntry
			{
				Name = "sm_spotShadowFadeTime",
				Description = "How many seconds it takes for a primary light shadow map to fade in or out"
			},
			new DvarEntry
			{
				Name = "sm_showOverlay",
				Description = "Show shadow map overlay"
			},
			new DvarEntry
			{
				Name = "sm_showOverlayDepthBounds",
				Description = "Near and far depth values for the shadow map overlay"
			},
			new DvarEntry
			{
				Name = "sm_showSpotAxis",
				Description = "Show spot shadow origin and orientation"
			},
			new DvarEntry
			{
				Name = "sm_sunAlwaysCastsShadow",
				Description = "from script"
			},
			new DvarEntry
			{
				Name = "sm_polygonOffsetBias",
				Description = "Shadow map offset bias"
			},
			new DvarEntry
			{
				Name = "sm_sunSampleSizeNear",
				Description = "Shadow sample size"
			},
			new DvarEntry
			{
				Name = "sm_sunShadowCenter",
				Description = "0 0 0 means don't override"
			},
			new DvarEntry
			{
				Name = "sm_sunShadowScale",
				Description = "Sun shadow scale optimization"
			},
			new DvarEntry
			{
				Name = "sm_sunShadowSmall",
				Description = "force quarter resolution sun shadow map"
			},
			new DvarEntry
			{
				Name = "sm_sunShadowSmallEnable",
				Description = "use quarter resolution sun shadow map"
			},
			new DvarEntry
			{
				Name = "r_flameScaler",
				Description = "Flame Scaler"
			},
			new DvarEntry
			{
				Name = "r_zombieDisableSlideEffect",
				Description = "Disable Slide Effect"
			},
			new DvarEntry
			{
				Name = "r_zombieDisableEarthEffect",
				Description = "Disable Earth Effect"
			},
			new DvarEntry
			{
				Name = "r_zombieNameAllowFriendsList",
				Description = "Allow zombie name to be from friends list"
			},
			new DvarEntry
			{
				Name = "r_zombieNameAllowDevList",
				Description = "Allow zombie name to be from dev list"
			},
			new DvarEntry
			{
				Name = "sm_spotShadowLargeRadiusScale",
				Description = "Radius scaler for large spot shadow switch over"
			},
			new DvarEntry
			{
				Name = "sm_strictCull",
				Description = "Strict shadow map cull"
			},
			new DvarEntry
			{
				Name = "sm_fastSunShadow",
				Description = "Fast sun shadow"
			},
			new DvarEntry
			{
				Name = "r_noipak",
				Description = "do not load/stream images from ipak(pc only)"
			},
			new DvarEntry
			{
				Name = "r_stereo3DAvailable",
				Description = "3D Mode available"
			},
			new DvarEntry
			{
				Name = "r_stereo3DOn",
				Description = "3D on off toggle"
			},
			new DvarEntry
			{
				Name = "r_stereo3DMode",
				Description = "3D Rendering mode"
			},
			new DvarEntry
			{
				Name = "r_stereo3DEyeSeparation",
				Description = "3D eye separation"
			},
			new DvarEntry
			{
				Name = "r_stereo3DEyeSeparationScaler",
				Description = "3D eye separation scaler (adjustment to separation used from scripts)"
			},
			new DvarEntry
			{
				Name = "r_stereoFocusDepth",
				Description = "3D eye focus depth"
			},
			new DvarEntry
			{
				Name = "r_stereoGunShift",
				Description = "3D gun shift"
			},
			new DvarEntry
			{
				Name = "r_stereoTurretShift",
				Description = "3D turret shift"
			},
			new DvarEntry
			{
				Name = "r_dualPlayEnable",
				Description = "DualPlay on/off toggle"
			},
			new DvarEntry
			{
				Name = "r_dualPlayActive",
				Description = "Set ingame when Split Screen is active"
			},
			new DvarEntry
			{
				Name = "r_dualPlayTestCount",
				Description = "Enable testing of backend framebuffer double counting"
			},
			new DvarEntry
			{
				Name = "r_blur",
				Description = "Dev tweak to blur the screen"
			},
			new DvarEntry
			{
				Name = "r_flame_allowed",
				Description = "Allow flame effect."
			},
			new DvarEntry
			{
				Name = "r_filmLut",
				Description = "Film LUT Index."
			},
			new DvarEntry
			{
				Name = "r_filmTweakLut",
				Description = "Tweak Film LUT Index."
			},
			new DvarEntry
			{
				Name = "r_forceCameraNode",
				Description = "Force camera to pathnode position."
			},
			new DvarEntry
			{
				Name = "r_forceCameraHdg",
				Description = "Force camera to heading."
			},
			new DvarEntry
			{
				Name = "r_forceCameraRecord",
				Description = "Turn on/off force camera record Mode."
			},
			new DvarEntry
			{
				Name = "r_enablePlayerShadow",
				Description = "Enable First Person Player Shadow."
			},
			new DvarEntry
			{
				Name = "v9",
				Description = "Enable Player Flashlight."
			},
			new DvarEntry
			{
				Name = "v9",
				Description = "Enable Player Flashlight."
			},
			new DvarEntry
			{
				Name = "r_waterFogTest",
				Description = "Enable Water Fog Test."
			},
			new DvarEntry
			{
				Name = "r_contrast",
				Description = "Contrast adjustment"
			},
			new DvarEntry
			{
				Name = "r_brightness",
				Description = "Brightness adjustment"
			},
			new DvarEntry
			{
				Name = "r_desaturation",
				Description = "Desaturation adjustment"
			},
			new DvarEntry
			{
				Name = "r_filmTweakBrightness",
				Description = "Tweak dev var; film color brightness"
			},
			new DvarEntry
			{
				Name = "r_filmTweakDesaturation",
				Description = "Tweak dev var; Desaturation applied after all 3D drawing"
			},
			new DvarEntry
			{
				Name = "r_filmTweakInvert",
				Description = "Tweak dev var; enable inverted video"
			},
			new DvarEntry
			{
				Name = "r_filmUseTweaks",
				Description = "Overide film effects with tweak dvar values"
			},
			new DvarEntry
			{
				Name = "r_filmTweakEnable",
				Description = "Tweak dev var; enable film color effects"
			},
			new DvarEntry
			{
				Name = "exp_softclip",
				Description = "soft clip value"
			},
			new DvarEntry
			{
				Name = "vc_LIB",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_LIG",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_LIW",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_LOB",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_LOW",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_RGBH",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_RGBL",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_YH",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_YL",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "r_bloomTweaks",
				Description = "enbale bloom tweaks"
			},
			new DvarEntry
			{
				Name = "r_bloomHiQuality",
				Description = "bloom quality"
			},
			new DvarEntry
			{
				Name = "r_dofHDR",
				Description = "0 = legacy 1 = hdr low 2 = hdr hi"
			},
			new DvarEntry
			{
				Name = "vc_RS",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_RE",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_SMR",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_SMG",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_SMB",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_MMR",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_MMG",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_MMB",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_HMR",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_HMG",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_HMB",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_FGM",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_FSM",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_FBM",
				Description = "Leonardo"
			},
			new DvarEntry
			{
				Name = "vc_LUT",
				Description = "Lut index"
			},
			new DvarEntry
			{
				Name = "vc_SNAP",
				Description = "hdr snapshot"
			},
			new DvarEntry
			{
				Name = "r_sunFlareTint",
				Description = "Sun Flare Sprite Color Tint"
			},
			new DvarEntry
			{
				Name = "r_superFlareDraw",
				Description = "toggle superflare rendering"
			},
			new DvarEntry
			{
				Name = "r_waterWaveAngle",
				Description = "water wave angle"
			},
			new DvarEntry
			{
				Name = "r_waterWaveWavelength",
				Description = "water wave wavelength"
			},
			new DvarEntry
			{
				Name = "r_waterWaveAmplitude",
				Description = "water wave amplitude"
			},
			new DvarEntry
			{
				Name = "r_waterWavePhase",
				Description = "water wave phase"
			},
			new DvarEntry
			{
				Name = "r_waterWaveSteepness",
				Description = "water wave steepness"
			},
			new DvarEntry
			{
				Name = "r_waterWaveSpeed",
				Description = "water wave speed"
			},
			new DvarEntry
			{
				Name = "r_waterWaveBase",
				Description = "water base height"
			},
			new DvarEntry
			{
				Name = "r_waterWaveNormalScale",
				Description = "water normal scale"
			},
			new DvarEntry
			{
				Name = "r_waterWaveScriptShader0",
				Description = "water shader parameters mapped to shader constant 'motionblurDirectionAndMagnitude'"
			},
			new DvarEntry
			{
				Name = "r_waterWaveScriptShader1",
				Description = "water shader parameters mapped to shader constant 'bloomScale'"
			},
			new DvarEntry
			{
				Name = "r_dof_enable",
				Description = "Enable the depth of field effect"
			},
			new DvarEntry
			{
				Name = "r_dof_tweak",
				Description = "Use dvars to set the depth of field effect; overrides r_dof_enable"
			},
			new DvarEntry
			{
				Name = "r_dof_nearBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "r_dof_farBlur",
				Description = "in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "r_dof_viewModelStart",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_viewModelEnd",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_nearStart",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_nearEnd",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_farStart",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_farEnd",
				Description = "in inches"
			},
			new DvarEntry
			{
				Name = "r_dof_bias",
				Description = "Depth of field bias as a power function (like gamma less than 1 is sharper"
			},
			new DvarEntry
			{
				Name = "r_dof_showdebug",
				Description = "displays DOF parameter debug"
			},
			new DvarEntry
			{
				Name = "r_flameFX_distortionScaleFactor",
				Description = "Distortion uv scales (Default to 1)"
			},
			new DvarEntry
			{
				Name = "r_flameFX_magnitude",
				Description = "Distortion magnitude"
			},
			new DvarEntry
			{
				Name = "r_flameFX_FPS",
				Description = "fire frames per sec"
			},
			new DvarEntry
			{
				Name = "r_flameFX_fadeDuration",
				Description = "Sets fade duration in seconds"
			},
			new DvarEntry
			{
				Name = "r_waterSheetingFX_allowed",
				Description = "Enable the water sheeting effect"
			},
			new DvarEntry
			{
				Name = "r_waterSheetingFX_enable",
				Description = "Enable the water sheeting effect"
			},
			new DvarEntry
			{
				Name = "r_waterSheetingFX_distortionScaleFactor",
				Description = "Distortion uv scales (Default to 1)"
			},
			new DvarEntry
			{
				Name = "r_waterSheetingFX_magnitude",
				Description = "Distortion magnitude"
			},
			new DvarEntry
			{
				Name = "r_waterSheetingFX_radius",
				Description = "Tweak dev var; Glow radius in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "r_anaglyphFX_enable",
				Description = "Enable red/green Anaglyph 3DS"
			},
			new DvarEntry
			{
				Name = "r_rimIntensity_debug",
				Description = "Enable the rim intensity debug"
			},
			new DvarEntry
			{
				Name = "r_rimIntensity",
				Description = "Rim intensity for character skin/cloth"
			},
			new DvarEntry
			{
				Name = "r_genericSceneVector_debug",
				Description = "Enable the generic scene vector debug"
			},
			new DvarEntry
			{
				Name = "r_genericSceneVector0",
				Description = "Generic Scene Vector 0"
			},
			new DvarEntry
			{
				Name = "r_genericSceneVector1",
				Description = "Generic Scene Vector 1"
			},
			new DvarEntry
			{
				Name = "r_genericSceneVector2",
				Description = "Generic Scene Vector 2"
			},
			new DvarEntry
			{
				Name = "r_genericSceneVector3",
				Description = "Generic Scene Vector 3"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_debug",
				Description = "Enable the revive effect debug"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeColorTemp",
				Description = "edge color temp"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeSaturation",
				Description = "edge saturation"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeScale",
				Description = "edge scale (tint) adjust RGB"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeContrast",
				Description = "edge contrast adjust RGB"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeOffset",
				Description = "edge tv style brightness adjust RGB"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeAmount",
				Description = "edge effect amount"
			},
			new DvarEntry
			{
				Name = "r_reviveFX_edgeMaskAdjust",
				Description = "edge mask expansion contraction"
			},
			new DvarEntry
			{
				Name = "r_poisonFX_debug_enable",
				Description = "Enable the poison effect"
			},
			new DvarEntry
			{
				Name = "r_poisonFX_pulse",
				Description = "pulse rate for distortion"
			},
			new DvarEntry
			{
				Name = "r_poisonFX_dvisionX",
				Description = "amount of double vision x"
			},
			new DvarEntry
			{
				Name = "r_poisonFX_blurMin",
				Description = "blur min"
			},
			new DvarEntry
			{
				Name = "r_poisonFX_blurMax",
				Description = "blur max"
			},
			new DvarEntry
			{
				Name = "r_zbufferDebug",
				Description = "debug zbuffer display"
			},
			new DvarEntry
			{
				Name = "r_zbufferDebugRange",
				Description = "debug zbufffer max display range"
			},
			new DvarEntry
			{
				Name = "r_fogTweak",
				Description = "enable dvar tweaks"
			},
			new DvarEntry
			{
				Name = "r_fogBaseDist",
				Description = "start distance"
			},
			new DvarEntry
			{
				Name = "r_fogHalfDist",
				Description = "distance at which fog is 50%"
			},
			new DvarEntry
			{
				Name = "r_fogBaseHeight",
				Description = "start height"
			},
			new DvarEntry
			{
				Name = "r_fogHalfHeight",
				Description = "height at which fog is 50%"
			},
			new DvarEntry
			{
				Name = "r_fogColor",
				Description = "color"
			},
			new DvarEntry
			{
				Name = "r_fogOpacity",
				Description = "opacity"
			},
			new DvarEntry
			{
				Name = "r_fogSunColor",
				Description = "sun color"
			},
			new DvarEntry
			{
				Name = "r_fogSunOpacity",
				Description = "sun opacity"
			},
			new DvarEntry
			{
				Name = "r_fogSunPitch",
				Description = "sun pitch"
			},
			new DvarEntry
			{
				Name = "r_fogSunYaw",
				Description = "sun yaw"
			},
			new DvarEntry
			{
				Name = "r_fogSunInner",
				Description = "sun angle start"
			},
			new DvarEntry
			{
				Name = "r_fogSunOuter",
				Description = "sun angle end"
			},
			new DvarEntry
			{
				Name = "r_exposureTweak",
				Description = "enable the exposure dvar tweak"
			},
			new DvarEntry
			{
				Name = "r_exposureValue",
				Description = "exposure ev stops"
			},
			new DvarEntry
			{
				Name = "r_finalShiftX",
				Description = "b channel shift x"
			},
			new DvarEntry
			{
				Name = "r_finalShiftY",
				Description = "b channel shift y"
			},
			new DvarEntry
			{
				Name = "r_primaryLightUseTweaks",
				Description = "Use primary light intensity tweaks"
			},
			new DvarEntry
			{
				Name = "r_primaryLightTweakDiffuseStrength",
				Description = "Tweak the diffuse intensity for primary lights"
			},
			new DvarEntry
			{
				Name = "r_primaryLightTweakSpecularStrength",
				Description = "Tweak the specular intensity for primary lights"
			},
			new DvarEntry
			{
				Name = "r_lightGridEnableTweaks",
				Description = "Enable tweaks of the light color from the light grid"
			},
			new DvarEntry
			{
				Name = "r_lightGridIntensity",
				Description = "Adjust the intensity of light color from the light grid"
			},
			new DvarEntry
			{
				Name = "r_lightGridContrast",
				Description = "Adjust the contrast of light color from the light grid"
			},
			new DvarEntry
			{
				Name = "r_heroLighting",
				Description = "Enable hero-only lighting"
			},
			new DvarEntry
			{
				Name = "r_heroLightScale",
				Description = "hero diffuse light scale"
			},
			new DvarEntry
			{
				Name = "r_num_viewports",
				Description = "number of viewports to expect to render"
			},
			new DvarEntry
			{
				Name = "r_pix_material",
				Description = "Enable pix material names"
			},
			new DvarEntry
			{
				Name = "r_outdoorAwayBias",
				Description = "Affects the height map lookup for making sure snow doesn't go indoors"
			},
			new DvarEntry
			{
				Name = "r_outdoorDownBias",
				Description = "Affects the height map lookup for making sure snow doesn't go indoors"
			},
			new DvarEntry
			{
				Name = "r_outdoorFeather",
				Description = "Outdoor z-feathering value"
			},
			new DvarEntry
			{
				Name = "r_sun_from_dvars",
				Description = "Set sun flare values from dvars rather than the level"
			},
			new DvarEntry
			{
				Name = "developer",
				Description = "Enable development environment"
			},
			new DvarEntry
			{
				Name = "sv_cheats",
				Description = "Allow server side cheats"
			},
			new DvarEntry
			{
				Name = "r_defaultMode",
				Description = "Default resolution mode"
			},
			new DvarEntry
			{
				Name = "r_monitor",
				Description = "Index of the monitor to use in a multi monitor system; 0 picks automatically."
			},
			new DvarEntry
			{
				Name = "r_currentMonitor",
				Description = "Index of the current full screen monitor."
			},
			new DvarEntry
			{
				Name = "r_monitorCount",
				Description = "Number of monitors connected."
			},
			new DvarEntry
			{
				Name = "r_aspectRatio",
				Description = "Screen aspect ratio.Most widescreen monitors are 16:10 instead of 16:9."
			},
			new DvarEntry
			{
				Name = "r_aspectRatioWindow",
				Description = "Screen aspect ratio."
			},
			new DvarEntry
			{
				Name = "r_customMode",
				Description = "Special resolution mode for the remote debugger"
			},
			new DvarEntry
			{
				Name = "r_open_automate",
				Description = "Enable Nvidia Open Automate testing"
			},
			new DvarEntry
			{
				Name = "r_superflare_drawlist",
				Description = "supreflare drawlist selection."
			},
			new DvarEntry
			{
				Name = "r_staticModelDumpLodInfo",
				Description = "Dump static model info for the next frame."
			},
			new DvarEntry
			{
				Name = "r_grassEnable",
				Description = "Diables grass movement"
			},
			new DvarEntry
			{
				Name = "r_skyTransition",
				Description = "Sky transition blend factor."
			},
			new DvarEntry
			{
				Name = "r_skyRotation",
				Description = "Sky rotation angle."
			},
			new DvarEntry
			{
				Name = "r_shaderDebugA",
				Description = "Shader Debug A"
			},
			new DvarEntry
			{
				Name = "r_shaderDebugB",
				Description = "Shader Debug B"
			},
			new DvarEntry
			{
				Name = "r_shaderDebugC",
				Description = "Shader Debug C"
			},
			new DvarEntry
			{
				Name = "r_enableCubicUpsample",
				Description = "Enable Cubic Upsample"
			},
			new DvarEntry
			{
				Name = "r_cubicUpsampleParam",
				Description = "Cubic Upsample Parameter"
			},
			new DvarEntry
			{
				Name = "r_skyColorTemp",
				Description = "Sky box color temp."
			},
			new DvarEntry
			{
				Name = "r_blinkLitQuasiOpaque",
				Description = "Blink Lit Transparencies with Depth write (Foliage Blend etc)."
			},
			new DvarEntry
			{
				Name = "r_blinkTrans",
				Description = "Blink All Transparencies."
			},
			new DvarEntry
			{
				Name = "r_blinkLayers",
				Description = "Blink materials with specific number of layers."
			},
			new DvarEntry
			{
				Name = "r_blinkCullNone",
				Description = "Blink materials with cull none."
			},
			new DvarEntry
			{
				Name = "r_modelSkelWorker",
				Description = "Enable model skel worker."
			},
			new DvarEntry
			{
				Name = "r_fullPrepass",
				Description = "Enable full prepass."
			},
			new DvarEntry
			{
				Name = "r_lightmapOnlyBspSurfs",
				Description = "Enable lightmap_only_surfs tech for BSP draw surfaces"
			},
			new DvarEntry
			{
				Name = "r_lightmapOnlySModelSurfs",
				Description = "Enable lightmap_only_surfs tech for static model draw surfaces"
			},
			new DvarEntry
			{
				Name = "r_lightmapOnlyEntSurfs",
				Description = "Enable lightmap_only_surfs tech for scene ent draw surfaces"
			},
			new DvarEntry
			{
				Name = "r_sortDrawSurfsBsp",
				Description = "Sort BSP draw surfaces."
			},
			new DvarEntry
			{
				Name = "r_sortDrawSurfsStaticModel",
				Description = "Sort static model draw surfaces."
			},
			new DvarEntry
			{
				Name = "r_sortBackToFront",
				Description = "Sort transparent models back to front."
			},
			new DvarEntry
			{
				Name = "r_swrk_override_characterCharredAmount",
				Description = "overrides the __characterCharredAmount Shaderworks tweak"
			},
			new DvarEntry
			{
				Name = "r_swrk_override_characterDissolveColor",
				Description = "overrides the __characterDissolveColor Shaderworks tweak"
			},
			new DvarEntry
			{
				Name = "r_swrk_override_wetness",
				Description = "Overrides the character wetness."
			},
			new DvarEntry
			{
				Name = "r_debugShowPrimaryLights",
				Description = "shows location of primary lights"
			},
			new DvarEntry
			{
				Name = "r_debugShowDynamicLights",
				Description = "shows location of dynamic lights"
			},
			new DvarEntry
			{
				Name = "r_debugShowCoronas",
				Description = "shows location of coronas"
			},
			new DvarEntry
			{
				Name = "r_debugMetalStorm",
				Description = "shows extra MetalStorm info"
			},
			new DvarEntry
			{
				Name = "r_disableGenericFilter",
				Description = "Stops the Generic Filters running"
			},
			new DvarEntry
			{
				Name = "r_drawDebugFogParams",
				Description = "enables the fog debug display"
			},
			new DvarEntry
			{
				Name = "r_debugShowPrimaryLightLines",
				Description = "Show primary light selection"
			},
			new DvarEntry
			{
				Name = "r_seethru_decal_enable",
				Description = "Toggles see-through impact holes"
			},
			new DvarEntry
			{
				Name = "r_tension_enable",
				Description = "Toggles tension"
			},
			new DvarEntry
			{
				Name = "r_MaterialParameterTweak",
				Description = "Modifies currently selected material parameter"
			},
			new DvarEntry
			{
				Name = "r_ui3d_debug_display",
				Description = "Show UI3D debug overlay"
			},
			new DvarEntry
			{
				Name = "r_ui3d_use_debug_values",
				Description = "Use UI debug values"
			},
			new DvarEntry
			{
				Name = "r_ui3d_x",
				Description = "ui3d texture window x"
			},
			new DvarEntry
			{
				Name = "r_ui3d_y",
				Description = "ui3d texture window y"
			},
			new DvarEntry
			{
				Name = "r_ui3d_w",
				Description = "ui3d texture window width"
			},
			new DvarEntry
			{
				Name = "r_ui3d_h",
				Description = "ui3d texture window height"
			},
			new DvarEntry
			{
				Name = "r_multi_extracam_debug",
				Description = "when r_missile_cam_debug_display==3 mode"
			},
			new DvarEntry
			{
				Name = "r_missile_cam_debug_display",
				Description = "Show missile camera debug overlay"
			},
			new DvarEntry
			{
				Name = "r_extracam_custom_aspectratio",
				Description = "custom extracam aspect ratio (width/height). Set to -1 to use default aspect ratio"
			},
			new DvarEntry
			{
				Name = "r_extracam_lod_scale",
				Description = "Scales an objects distance from the extracam for LOD calculation"
			},
			new DvarEntry
			{
				Name = "r_qrcode_debug_display",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_qrcode_debug_display_size",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_shader_constant_set_debug_range",
				Description = "How far to draw scs debug view"
			},
			new DvarEntry
			{
				Name = "r_shader_constant_set_enable",
				Description = "enables shader constant sets"
			},
			new DvarEntry
			{
				Name = "r_sky_intensity_showDebugDisplay",
				Description = "Enables sky intensity debugging display"
			},
			new DvarEntry
			{
				Name = "r_sky_intensity_angle0",
				Description = "angle0 of sky intensity"
			},
			new DvarEntry
			{
				Name = "r_sky_intensity_angle1",
				Description = "angle1 of sky intensity"
			},
			new DvarEntry
			{
				Name = "r_sky_intensity_factor0",
				Description = "angle0 of sky intensity"
			},
			new DvarEntry
			{
				Name = "r_sky_intensity_factor1",
				Description = "angle1 of sky intensity"
			},
			new DvarEntry
			{
				Name = "r_fog_disable",
				Description = "Disables fog"
			},
			new DvarEntry
			{
				Name = "r_grassWindForceEnable",
				Description = "Enables wind gusts that affect dynFoliage grass"
			},
			new DvarEntry
			{
				Name = "r_dpvs_useCellForceInvisibleBits",
				Description = "turns on/off the script-driven cell vis bits"
			},
			new DvarEntry
			{
				Name = "r_remotescreen_renderlastframe",
				Description = "toggles if remote screen update draws the last frame"
			},
			new DvarEntry
			{
				Name = "r_vc_compile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_occQueryDebug",
				Description = "draws occlusion query testing polygons"
			},
			new DvarEntry
			{
				Name = "r_useHidePartbits",
				Description = "toggles hide partbits usage"
			},
			new DvarEntry
			{
				Name = "r_cameraInfo",
				Description = "toggles exposure focal length display"
			},
			new DvarEntry
			{
				Name = "r_shaderbinddebug",
				Description = "toggles debug print of vertex/pixelshader binding"
			},
			new DvarEntry
			{
				Name = "r_warningRepeatDelay",
				Description = "Number of seconds after displaying a per-frame warning before it will display again"
			},
			new DvarEntry
			{
				Name = "r_sunsprite_shader",
				Description = "name for static sprite; can be any material"
			},
			new DvarEntry
			{
				Name = "r_sunsprite_size",
				Description = "diameter in pixels at 640x480 and 80 fov"
			},
			new DvarEntry
			{
				Name = "r_sunflare_shader",
				Description = "name for flare effect; can be any material"
			},
			new DvarEntry
			{
				Name = "r_sunflare_min_size",
				Description = "smallest size of flare effect in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "r_sunflare_min_angle",
				Description = "angle from sun in degrees outside which effect is 0"
			},
			new DvarEntry
			{
				Name = "r_sunflare_max_size",
				Description = "largest size of flare effect in pixels at 640x480"
			},
			new DvarEntry
			{
				Name = "r_sunflare_max_angle",
				Description = "angle from sun in degrees inside which effect is max"
			},
			new DvarEntry
			{
				Name = "r_sunflare_max_alpha",
				Description = "0-1 vertex color and alpha of sun at max effect"
			},
			new DvarEntry
			{
				Name = "r_sunflare_fadein",
				Description = "time in seconds to fade alpha from 0% to 100%"
			},
			new DvarEntry
			{
				Name = "r_sunflare_fadeout",
				Description = "time in seconds to fade alpha from 100% to 0%"
			},
			new DvarEntry
			{
				Name = "r_sunblind_min_angle",
				Description = "angle from sun in degrees outside which blinding is 0"
			},
			new DvarEntry
			{
				Name = "r_sunblind_max_angle",
				Description = "angle from sun in degrees inside which blinding is max"
			},
			new DvarEntry
			{
				Name = "r_sunblind_max_darken",
				Description = "0-1 fraction for how black the world is at max blind"
			},
			new DvarEntry
			{
				Name = "r_sunblind_fadein",
				Description = "time in seconds to fade blind from 0% to 100%"
			},
			new DvarEntry
			{
				Name = "r_sunblind_fadeout",
				Description = "time in seconds to fade blind from 100% to 0%"
			},
			new DvarEntry
			{
				Name = "r_sunglare_min_angle",
				Description = "angle from sun in degrees inside which glare is maximum"
			},
			new DvarEntry
			{
				Name = "r_sunglare_max_angle",
				Description = "angle from sun in degrees inside which glare is minimum"
			},
			new DvarEntry
			{
				Name = "r_sunglare_max_lighten",
				Description = "0-1 fraction for how white the world is at max glare"
			},
			new DvarEntry
			{
				Name = "r_sunglare_fadein",
				Description = "time in seconds to fade glare from 0% to 100%"
			},
			new DvarEntry
			{
				Name = "r_sunglare_fadeout",
				Description = "time in seconds to fade glare from 100% to 0%"
			},
			new DvarEntry
			{
				Name = "r_sun_fx_position",
				Description = "Position in degrees of the sun effect"
			},
			new DvarEntry
			{
				Name = "FriendXuidToJoinOnBoot",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_ErrorRecordEvent",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_apiUrl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_category",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_highRefreshRate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_listing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_liveLifeCycleRefreshRate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_liveStreamLeague",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_lowRefreshRate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_maxViewersForHighRefresh",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_minViewersForHighRefresh",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_minViewersToStartStream",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_minViewersToStream",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_miscRefreshRate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_slateImageUrl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_slateText",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_stateChange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_stopStreamForPublicGame",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_timeToRecoverFromLowStreamViewers",
				Description = ""
			},
			new DvarEntry
			{
				Name = "YouTube_verifyUrl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activeFriendsMaxBackoffLevel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activeFriendsNumDayBuckets",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activeFriendsNumPlayBuckets",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activeFriendsRefreshDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activeFriendsSecondsPerBucket",
				Description = ""
			},
			new DvarEntry
			{
				Name = "adsZeroSpread",
				Description = ""
			},
			new DvarEntry
			{
				Name = "allEmblemsPurchased",
				Description = ""
			},
			new DvarEntry
			{
				Name = "allEmblemsUnlocked",
				Description = ""
			},
			new DvarEntry
			{
				Name = "allowAllNAT",
				Description = ""
			},
			new DvarEntry
			{
				Name = "barebones_class_mode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_ally_kill_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_breathing_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_breathing_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_enemy_contact_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_enemy_contact_level_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_incoming_grenade_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_kill_inform_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_killstreak_incoming_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_last_stand_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_pain_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_pain_small_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_perk_call_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_sniper_kill_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_toss_grenade_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_toss_trophy_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_weapon_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_weapon_fire_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_weapon_fire_threat_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bcmp_weapon_reload_probability",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_ads",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_aimSpreadMoveSpeedThreshold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_aqs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_aqsStyle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_blendTimeOverride",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_bobMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotAutoDischargeDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotAutoFireDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotCenterSpeedReductionPerBullet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotDamageIncreasePerBullet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotDischargeWhenQueueReachesMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotFireWhenQueueReachesMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotMaxBulletQueueOnEMP",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotMaxBulletsInQueue",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotMaxViewKick",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotMinCenterSpeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotPenetrationMultiplier",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotQueueTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotUseOneAmmoForMultipleBullets",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_chargeShotViewKickIncreasePerBullet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_disableWeaponPlantingInWater",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_dog_swim_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_dog_swim_water_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_dog_swim_water_min",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_fallDamageMaxHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_fallDamageMinHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_foliagesnd_fastinterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_foliagesnd_maxspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_foliagesnd_minspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_foliagesnd_resetinterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_foliagesnd_slowinterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_forceAnimOverrideTimerCheck",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_forceDurationOverride",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_forceExplosiveBullets",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_gravity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_gunXOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_ladder_yawcap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_legYawCrouchTolerance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_legYawProneTolerance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_legYawTolerance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_lowGravity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_maxGrenadeIndicatorSpeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_moonGravity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_movingPlatformPitchScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_plantInWaterDepth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_playerAnimStanceAllowMovementInteruptTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_proneSwingSpeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_prone_yawcap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_serverDelayDamageKickForPing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shieldHitEncodeHeightVM",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shieldHitEncodeHeightWorld",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shieldHitEncodeWidthVM",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shieldHitEncodeWidthWorld",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_animation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_lookControl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_lookControl_fadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_lookControl_maxpitchspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_lookControl_maxyawspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_lookControl_mousesensitivityscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_movement",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_screenBlurBlendFadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_screenBlurBlendTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_screenFlashShotFadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_screenFlashWhiteFadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_screenType",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_sound",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundDryLevel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundEnd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundEndAbort",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundFadeInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundFadeOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundLoop",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundLoopEndDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundLoopFadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundLoopSilent",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundModEndDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundRoomType",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundSnapshot",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_soundWetLevel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_viewKickFadeTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_viewKickPeriod",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_viewKickRadius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_visionset_inTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_visionset_name",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_shock_visionset_outTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_slopeFrames",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_swingSpeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_teleportAlignTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_useClientDamageKick",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_gravity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_ground_max_normal",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_ground_min_normal",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_max_body_pitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_max_body_roll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_max_pitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_max_roll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_overclip",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_pitch_track",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_roll_track",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_slide_min_normal",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_sphere_bounds_offset_z",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_stepsize",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_tangential_clip_max_scale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_tangential_clip_vel_scale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vehicle_trace_offset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeDtp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeDucked",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeDuckedAds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeProne",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeRoll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeSprinting",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeStanding",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeStandingAds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewBobAmplitudeSwimming",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewKickMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewKickMin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewKickRandom",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_viewKickScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_vsmode_hud",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeBaseLaser",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeDtp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeDucked",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeProne",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeRiding",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeRoll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeRollLaser",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeSprinting",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeStanding",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobAmplitudeSwimming",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobFrequencySwimming",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobHeavyWeaponScalar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobLag",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponBobMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bg_weaponOffscreenReloadScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bullet_penetrationMinFxDist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bullet_ricochetBaseChance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_cinematicFullscreen",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_fov_default",
				Description = "Default field of view value"
			},
			new DvarEntry
			{
				Name = "cg_fov_default_thirdperson",
				Description = "Default field of view when in third-person"
			},
			new DvarEntry
			{
				Name = "cg_ufo_scaler",
				Description = ""
			},
			new DvarEntry
			{
				Name = "challengeResponseResendBackoffInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "challengeResponseResendInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "checkEmblemForRank",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cl_profileWriteLimiter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "com_recommendedSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0FadeInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0FadeOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0Filter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0LineCount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0MsgTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0ScrollTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow0SplitscreenScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1FadeInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1FadeOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1Filter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1LineCount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1MsgTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1ScrollTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow1SplitscreenScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2FadeInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2FadeOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2Filter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2LineCount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2MsgTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2ScrollTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow2SplitscreenScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3FadeInTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3FadeOutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3Filter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3LineCount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3MsgTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3ScrollTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_gameMsgWindow3SplitscreenScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "content_trialcontentpackbits",
				Description = ""
			},
			new DvarEntry
			{
				Name = "counterDownloadInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "counterUploadInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "currentTUVersion",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_1_kills",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_2_kills",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_killstreak_3_kills",
				Description = ""
			},
			new DvarEntry
			{
				Name = "custom_perks_allow_pro",
				Description = ""
			},
			new DvarEntry
			{
				Name = "debug_dog_notetracks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "debug_dog_sound",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicated",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_DoTestChance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_Interval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_MaxTestTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_ServerLocation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_TimesToPing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dedicatedPingLog_WaitBeforePing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "defaultDamageDuration",
				Description = ""
			},
			new DvarEntry
			{
				Name = "defaultDamageInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "defaultHitDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_jumptostart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_play",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_stop",
				Description = ""
			},
			new DvarEntry
			{
				Name = "disableLookAtEntityLogic",
				Description = ""
			},
			new DvarEntry
			{
				Name = "disable_rope",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dlc3_zm_ai_lookAheadAllowBackTrack",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dlc3_zm_ai_lookAheadAllowRestore",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_MeleeDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_force_run",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_force_walk",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_turn180_angle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_turn90_angle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dog_turn_min_goal_dist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dwVerboseQosLogging",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dw_logging_frequency",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dw_logging_last_match_logged",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dw_logging_level_chance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_config_valid",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_debug_render",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_kick_offset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_kick_recover_speed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_kick_speed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_render",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_system_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_team_damage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_test",
				Description = ""
			},
			new DvarEntry
			{
				Name = "flame_use_dvars",
				Description = ""
			},
			new DvarEntry
			{
				Name = "footstep_sounds_cutoff",
				Description = ""
			},
			new DvarEntry
			{
				Name = "friction",
				Description = ""
			},
			new DvarEntry
			{
				Name = "g_gameEnded",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_button_deadzone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_button_lstick_deflect_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_button_rstick_deflect_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_buttonsConfig",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_debug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_stick_deadzone_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_stick_deadzone_min",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_stick_pressed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_stick_pressed_hysteresis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gpad_sticksConfig",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gump_name3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gumpgump_name3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gumpgumpgump_name3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gumpgumpgumpgump_name3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "in_mouse",
				Description = ""
			},
			new DvarEntry
			{
				Name = "laggedDamageTagThreshold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "lanChallengeResponse",
				Description = ""
			},
			new DvarEntry
			{
				Name = "liveVideoURLEnv",
				Description = ""
			},
			new DvarEntry
			{
				Name = "liveVideoURLExpiration",
				Description = ""
			},
			new DvarEntry
			{
				Name = "liveVideoURLParam",
				Description = ""
			},
			new DvarEntry
			{
				Name = "liveVideoURLSalt",
				Description = ""
			},
			new DvarEntry
			{
				Name = "liveVideoURLServer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_dedicatedUnparkPingExcellent",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_dedicatedUnparkPingMax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_maxMatchMakingPing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_maxMostAwesomePing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_minMatchMakingPing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_service",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_statscaching",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_steamid",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_testValue",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_useActiveFriends",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_useTwitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_useTwitter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "live_useYouTube",
				Description = ""
			},
			new DvarEntry
			{
				Name = "livestreamcontrollerneeded",
				Description = ""
			},
			new DvarEntry
			{
				Name = "microwave_turret_placement_trace_maxs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "microwave_turret_placement_trace_mins",
				Description = ""
			},
			new DvarEntry
			{
				Name = "microwave_turretplacement_traceOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "missileDroneSpeedMin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "motdDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_chanceToFailConnection",
				Description = ""
			},
			new DvarEntry
			{
				Name = "perk_armorVest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "perk_bulletDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "perk_explosiveDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "playerPushAmount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_adsExitDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_animRunThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_animWalkThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_backSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_bayonetLaunchDebugging",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_bayonetLaunchProof",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_bayonetLaunchZCap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_bayonetRange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_bayonetTargetDist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_fire_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_gasp_lerp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_gasp_scale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_gasp_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_hold_lerp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_hold_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_snd_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_breath_snd_lerp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_clipSizeMultiplier",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_debugHealth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_disableWeaponsOnVehicle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_dmgtimer_flinchTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_dmgtimer_maxTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_dmgtimer_minScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_dmgtimer_stumbleTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_dmgtimer_timePerPoint",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_enableShuffleAnims",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_enduranceSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_footstepsThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_forceRedCrosshair",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_knockbackMoveThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lastStandBleedoutTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lastStandBleedoutTimeNoRevive",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lastStandHealthOverlayTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lean_rotate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lean_rotate_crouch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lean_shift",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lean_shift_crouch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_lookAtEntityAllowChildren",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeCalcSpeedFromTarget",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeChargeFriction",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeChargeMaxSpeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeInterruptFrac",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeRange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_meleeWidth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_moveThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_move_factor_on_torso",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_revivePlayerListCycleTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_reviveTriggerRadius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_runThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_runbkThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_scopeExitOnDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_slick_accel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_slick_invspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_slick_wishspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sliding_friction",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sliding_velocity_cap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sliding_wishspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_slopeAnimAngle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_spectateSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintCameraBob",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintForwardMinimum",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintMinTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintRechargePause",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintStrafeSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintThreshhold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sprintUnlimited",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_standingViewHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_strafeAnimCosAngle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_strafeSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_sustainAmmo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_swimDamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_swimDamagerInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_swimTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_turnAnims",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_viewLockEnt",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_viewRateScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_view_pitch_down",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_view_pitch_up",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_waterSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_zombieMeleeHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_zombieMeleeRange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_zombieMeleeWidth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_zombieSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "player_zombieSprintSpeedScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "profileDirtyInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_cmdbuf_worker",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_fxaa",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_mode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_mode1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_mode2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_shaderWarming",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread0",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread4",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_smp_worker_thread5",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_stereo3DIPD",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_textureMode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_watersim_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "r_zombieDarkness",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_enable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "revive_time_taken",
				Description = ""
			},
			new DvarEntry
			{
				Name = "safeArea_horizontal",
				Description = ""
			},
			new DvarEntry
			{
				Name = "safeArea_vertical",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_HeldKillstreak_Penalty",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_RequiredMapAspectratio",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_ai_tank_no_timeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_allow_killstreak_building",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_attack_dog_count_zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_attack_dog_health_zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_attack_dog_kills_zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_attack_dog_max_at_once_zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_attack_dog_time_zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_bomb_explode_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_cam_move_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_custom_score_assist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_deleteexplosivesonspawn",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_dial_rotate_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disable_air_death_ragdoll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disable_cac",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_disable_weapondrop",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_drawfriend",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_dynamic_source_loading",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_env_destroy_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_arcadescoring",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_bulletdamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_difficulty",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_medalsenabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_pinups",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_game_rankenabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowauto_turret",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowcounteruav",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowdogs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowhelicopter_comlink",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowradar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowradardirection",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowrcbomb",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_hardpoint_allowuav",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_armor",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_armor_bulletdamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_armored_maxhealth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_attract_range",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_attract_strength",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_debug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_debug_crash",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_dest_wait",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_guard_debug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_guard_no_timeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_health_degrade",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_loopmax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_maxhealth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_friendlycare",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_range",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_regen_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_reload_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_rof",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_target_cone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_missile_valid_target_cone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_protect_pos_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_protect_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_protect_time",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_target_recognition",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_target_spawnprotection",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_targeting_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_turretClipSize",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_turretReloadTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_turret_angle_tan",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_turret_spinup_delay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_turret_target_cone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_visual_range",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_heli_warning_distance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_helicopterTurretMaxAngle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_help_dist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_mapsize",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_max_rank",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_min_prestige",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_missile_swarm_lifetime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_motd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_oldschool",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_player_allowrevive",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_player_sprinttime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeActivationTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDOTDamageAmount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDOTDamageAmountHardcore",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDOTDamageInstances",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDOTDamageTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDamageRadius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeDetectionRadius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeEffectDebug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeGracePeriod",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_proximityGrenadeMaxInstances",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_qrdrone_no_timeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_rcbomb_car_size",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_rcbomb_notimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_remote_mortar_lifetime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_script_based_influencer_system",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_selecting_location",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_showperksonspawn",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_sideBetTimer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_aitank_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_aitank_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_aitank_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_artillery_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_artillery_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_artillery_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_close_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_close_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_close_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_auto_turret_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_claymore_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_claymore_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_claymore_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dead_friend_influencer_count",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dead_friend_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dead_friend_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dead_friend_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dead_friend_influencer_timeout_seconds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dog_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dog_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_dog_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_spawned_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_spawned_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_spawned_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemy_spawned_influencer_timeout_seconds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemyavoiddist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_enemyavoidweight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_force_unified",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_friend_weak_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_friend_weak_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_friend_weak_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_endpoint_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_endpoint_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_endpoint_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_grenade_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_helicopter_influencer_length",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_helicopter_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_helicopter_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_helicopter_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_napalm_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_napalm_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_napalm_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_objective_facing_bonus",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_pegasus_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_pegasus_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_pegasus_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_cylinder_influencer_length",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_cylinder_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_cylinder_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_cylinder_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_qrdrone_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_randomness_range",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_rcbomb_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_rcbomb_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_rcbomb_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_tvmissile_influencer_length",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_tvmissile_influencer_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_tvmissile_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_tvmissile_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_vehicle_influencer_lead_seconds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_vehicle_influencer_score",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_spawn_vehicle_influencer_score_curve",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_tdm_friendlyFireDelayTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_team_fftype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_team_teamkillerplaylistbanpenalty",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_team_teamkillerplaylistbanquantum",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_teambalance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_timeplayedcap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_turret_no_timeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_alive_cleanuptimemax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_alive_cleanuptimemin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanupabandoned",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanupdebugprint",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanupdrifted",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanupmaxspeedmph",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanupmindistancefeet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanuptime_dmgfactor_deadtread",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanuptime_dmgfactor_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanuptime_dmgfactor_min",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanuptime_dmgfraction_curve_begin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_cleanuptime_dmgfraction_curve_end",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_dead_cleanuptimemax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_dead_cleanuptimemin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_disableoverturndamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_disablerespawn",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_disappear_maxpreventdistancefeet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_disappear_maxpreventvisibilityfeet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_disappear_maxwaittime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_driversarehidden",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_driversareinvulnerable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explode_on_cleanup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_doradiusdamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_husk_forcepointvariance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_husk_horzvelocityvariance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_husk_vertvelocitymax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_husk_vertvelocitymin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_maxdamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_mindamage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_explosion_spawnfx",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_health_jeep",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_health_tank",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_ondeath_createhusk",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_ondeath_usevehicleashusk",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_respawnafterhuskcleanup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_respawntimemax",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_respawntimemin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_respawnwait_iterationwaitseconds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_respawnwait_maxiterations",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_waittillstoppedandmindist_maxtime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_veh_waittillstoppedandmindist_maxtimeenabledis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_vehicle_damage_scalar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wagerPool",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wagerSideBet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_defaultScore",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_firstPayout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_firstPlayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_secondPayout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_secondPlayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_thirdPayout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_wager_thirdPlayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowbetty",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowc4",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowflash",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowfrags",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowmines",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowrpgs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowsatchel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weapon_allowsmoke",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weaponobject_coneangle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weaponobject_graceperiod",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weaponobject_mindist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_weaponobject_radius",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scr_xpzmscale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionDedicatedGeoMin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionDedicatedMaxPing",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionIgnoreMapPacks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionMaxIntervalTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionMaxIntervalTimeBeforeUnpark",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionRandom_0",
				Description = ""
			},
			new DvarEntry
			{
				Name = "searchSessionRandom_1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sensitivity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sessionTaskFailDebug",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sidebet_made",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sm_enable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sm_polygonOffsetScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "snd_losOcclusion",
				Description = ""
			},
			new DvarEntry
			{
				Name = "stopspeed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_configSum",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_configureGHz",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_cpuGHz",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_cpuName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_gpu",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sys_sysMB",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_demo_oldposInsteadOfMapCenter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_demo_skipBuildingDemoSnapshotDuringCinematicP",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_eliteMarketingOptInPopupEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_noProfileWriteSleep",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_reconnectToClientOnDTLSTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_searchSessionIgnoreMapPacks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_statsCheckIW6promo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu10_updateLobbyMapPackFlagsOnClientJoin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_AddMapPackFlagsUserInfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_cg_killstreak_target_diamond_when_emped",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_deleteSessionIfNotHost",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_demoSendEventOnFailure",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_gateInGameMenusOnInitialPlayersConnectedRespo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_handleLowmipReadErrors",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_luiCompleteAnimationFix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_partymigrate_WirelessLatencyIncrease",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_partymigrate_allowPrivatePartyClientsToHost",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_partymigrate_useStdDev",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_player_keepZVelocity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_resetGameModesOnCablePull",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_returnChangedInUpdateClientInfoWhenRemovingAt",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_sendVoteToFBEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_showGeoInfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_statsSetConnectionType",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_useMissileKnockbackHeldWeaponsOnly",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_use_animscripted_blends",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_waitOnContent",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_waitOnContentTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu11_zombie_turret_placement_ignores_bodies",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_always_switch_away_from_briefcase",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_cg_vehicleCamAboveWater",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_destructible_entity_radius_damage_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_mtxLostVoteChecks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_searchSessionOverrideGeoLocation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_updatePCacheOfAllLocalPlayers",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_validate_bonus_cards_on_server",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_zm_force_center_cg_cursorhint",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_zm_stack_fire_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_zm_stop_firing_when_overheated",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_zombie_allow_switch_to_detonator_only",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu12_zombies_allow_hint_weapon_from_script",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu13_allow_no_player_melee_blood",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu13_bg_enableBulletWeaponBounce",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu13_filterdedicatedserverresults",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu13_recordContentAvailable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu13_zm_check_traversal_max_z",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_aiAllowForceNoCullCheck",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_bg_chargeShotExponentialAmmoPerChargeLevel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_demo_enableHeliHeightLockExcludeFromDemo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_initialize_groundEntityNum",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_preventStartingChargeShotWhileFiring",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_reloadCustomGameTypesAfterFFOTD",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu14_resumeLobbyCountdown",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu15_quadrotorPathingFix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu15_zombie_local_player_test_honors_client_server",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu16_waitOnGhostLBRetrieval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu16_waitOnGhostLBRetrievalTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu2_luiHacksDisabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu3_canSetDvars",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu3_disableDWGuests",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu5_check_unique_attachments_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu5_uav_ads_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu6_clearFileShareOnSignOut",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu6_hideDLCImages",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu6_player_jump_blocks_tac_insert",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu6_player_shallowWaterHeight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_clampMeleeChargeHorzLaunch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_clampMeleeChargeJumping",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_clampMeleeChargeJumpingMaxZVel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_mapbased_killstreaks_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_scoreboardPingAsNumbers",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_usePCmatchmaking",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu7_usePingSlider",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu8_additionalMTXChecks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu8_mtx_enabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_checkForValidGameMode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_clearedMapPackFlagsFix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_deletePresenceSessionInGraveYardFix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_ingnoreValidateWeaponOnDeath",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_keepSwappedPlayersInPartyToNotify",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_offlinehostdisconnectfix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_partyErrorOnInGameMigrateFail",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_projectile_dobj_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_rerunPlaylistRulesOnHost",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_steamCheckMTX",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_steamRetryServerInit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_tank_minimap_fix",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_testMissingContentPacks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_turret_mark_rate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu9_validateStatsOnSignout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_10_matchRatingSampleChance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_cleanUpTurretOnDisconnect",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_deferScriptMissileDetonation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_enforceRechamberOnSwitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_isolateDamageFlash",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tu_limitGrenadeImpacts",
				Description = ""
			},
			new DvarEntry
			{
				Name = "turret_placement_trace_maxs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "turret_placement_trace_mins",
				Description = ""
			},
			new DvarEntry
			{
				Name = "turretplacement_traceOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "turretplacement_useTraceOffset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "twEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_DSPPromotionInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_SPReminderPopupInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_allow_controlschange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_allow_teamchange",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_allowvote",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_currentNetMap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_dedicated",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_detailedMM",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_drawBuildNumber",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_enableDSPPromotion",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_enableGhostUpsellPopup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_enableSPReminderPopup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_extraBigFont",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_friendMessage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_friendNameNew",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_friendPendingSelectedInd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_friendSelectedInd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_friendlyfire",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_generic_status_bar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_ghostUpsellPopupInterval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_guncycle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_gv_reloadSpeedModifier",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_hideMiniLeaderboards",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_hostname",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_inviteScreen",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_inviteSelectedInd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_isDLCPopupEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_isDLCRequiredPopupEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_joinGametype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh_0",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh_1",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh_2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh_3",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_lastServerRefresh_4",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_motd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mousePitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mpTheaterEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mpWagerMatchEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_mtxid",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_netGametypeName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_options_open",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_safearea",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_scorelimit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_serverinfomessage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_serverinfomessagehostname",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_showNewestLeaderboards",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_showmap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_storeButtonPressed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_text_endreason",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_timelimit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_totalDLCReleased",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_useCustomClassInfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_weapon_tiers",
				Description = ""
			},
			new DvarEntry
			{
				Name = "useMapPreloading",
				Description = ""
			},
			new DvarEntry
			{
				Name = "useSvMapPreloading",
				Description = ""
			},
			new DvarEntry
			{
				Name = "username",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehLocationalVehicleSeatEntry",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehLockTurretToPlayerView",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehicle_riding",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehicle_selfCollision",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vehicle_sounds_cutoff",
				Description = ""
			},
			new DvarEntry
			{
				Name = "wallmount_turret_placement_trace_maxs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "wallmount_turret_placement_trace_mins",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_a",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_b",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_c",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_d",
				Description = ""
			},
			new DvarEntry
			{
				Name = "war_e",
				Description = ""
			},
			new DvarEntry
			{
				Name = "waterbrush_entity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "waypointMaxDrawDist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webmDwReadDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webmDwReadTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webmDwWriteDelay",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webmDwWriteTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_arnr_maxframes",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_arnr_strength",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_arnr_type",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_auto_kf",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_bitrate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_buffer_high_timeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_buffer_high_water_mark",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_buffer_low_water_mark",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_drop_thresh",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_enableautoaltref",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encAllowCamera",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encEliteRequired",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encIdentityVerificationRequired",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encRetryTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encSendBufferTimeout",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encStatus",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encStreamEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encTwitchEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encUiEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encUiEnabledCustom",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encUiEnabledPublic",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_encUiSigningIn",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_highactivitythreshold",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_hq_bandwidth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpAuthLogin",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpAuthMode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpAuthPass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpAuthToken",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpUploadUrl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpUploadUrlTwitch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_httpUploadUrlYouTube",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_kf_interval",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_lag",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_lq_bandwidth",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_max_intra_bitrate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_mode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_profile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_q_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_q_min",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_rc_buf_initial_sz",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_rc_buf_optimal_sz",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_rc_buf_sz",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_auto_kf",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_bitrate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_dont_connect_upfront",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_fps",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_profile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_q_max",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_q_min",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_realtime_scale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_send_audio_first",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_threads",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_render_uv_step",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_target_fps",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_twitchLasterror",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_twitchTransferChunkSize",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_twitch_summaryRefresh",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_twitch_summaryUrl",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_usersStreaming",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_usersWaitingToStream",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_vol_game",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_vol_headset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "webm_youtube_max_posts_per_second",
				Description = ""
			},
			new DvarEntry
			{
				Name = "welcome_shown",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_shellshock",
				Description = "Usage: cg_shellshock <duration> <filename?>"
			},
			new DvarEntry
			{
				Name = "cg_shellshock_load",
				Description = "Usage: cg_shellshock_load <name>"
			},
			new DvarEntry
			{
				Name = "cg_shellshock_save",
				Description = "Usage: cg_shellshock_save <name>"
			},
			new DvarEntry
			{
				Name = "playrumble",
				Description = "Usage: playrumble <rumblename>"
			},
			new DvarEntry
			{
				Name = "xshowgamercard",
				Description = "Usage: xshowgamercard <xuid>"
			},
			new DvarEntry
			{
				Name = "logo",
				Description = "Usage: logo <image name> <fadein seconds> <full duration seconds> <fadeout seconds>"
			},
			new DvarEntry
			{
				Name = "openscriptmenu",
				Description = "Usage: openscriptmenu <parent menu name> <script menu response>"
			},
			new DvarEntry
			{
				Name = "party_mutePlayer",
				Description = "Usage: party_mutePlayer <selected player xuid>"
			},
			new DvarEntry
			{
				Name = "visionSetNaked",
				Description = "Usage: visionSetNaked <name> <duration>"
			},
			new DvarEntry
			{
				Name = "visionSetNight",
				Description = "Usage: visionSetNight <name> <duration>"
			},
			new DvarEntry
			{
				Name = "addip",
				Description = "Usage: addip <ip-mask>"
			},
			new DvarEntry
			{
				Name = "sv_removeip",
				Description = "Usage: sv_removeip <ip-mask>"
			},
			new DvarEntry
			{
				Name = "twitchRegister",
				Description = "Usage: twitchRegister <accountName> <token>"
			},
			new DvarEntry
			{
				Name = "twitchUnregister",
				Description = "Usage: twitchUnregister"
			},
			new DvarEntry
			{
				Name = "youTubeUpload",
				Description = "Usage: youTubeUpload <fileID>"
			},
			new DvarEntry
			{
				Name = "gamesettings_upload",
				Description = "Usage: gamesettings_upload <slot number>"
			},
			new DvarEntry
			{
				Name = "gamesettings_download",
				Description = "Usage: gamesettings_download <fileID> <gametype>"
			},
			new DvarEntry
			{
				Name = "set",
				Description = "Usage: set <variable> <value>"
			},
			new DvarEntry
			{
				Name = "set",
				Description = "Usage: set <variable> <value>"
			},
			new DvarEntry
			{
				Name = "writeconfig",
				Description = "Usage: writeconfig <filename>"
			},
			new DvarEntry
			{
				Name = "writekeyconfig",
				Description = "Usage: writekeyconfig <filename>"
			},
			new DvarEntry
			{
				Name = "writedefaults",
				Description = "Usage: writedefaults <filename>"
			},
			new DvarEntry
			{
				Name = "set",
				Description = "Usage: set <variable> <value>"
			},
			new DvarEntry
			{
				Name = "seta",
				Description = "Usage: seta <variable> <value>"
			},
			new DvarEntry
			{
				Name = "set",
				Description = "Usage: set <variable>"
			},
			new DvarEntry
			{
				Name = "reset",
				Description = "Usage: reset <variable>"
			},
			new DvarEntry
			{
				Name = "dir",
				Description = "Usage: dir <directory> [extension]"
			},
			new DvarEntry
			{
				Name = "fdir",
				Description = "Usage: fdir <filter>"
			},
			new DvarEntry
			{
				Name = "touchFile",
				Description = "Usage: touchFile <file>"
			},
			new DvarEntry
			{
				Name = "setqport",
				Description = "Usage: setqport <qport>"
			},
			new DvarEntry
			{
				Name = "banUser",
				Description = "Usage: banUser <player name>"
			},
			new DvarEntry
			{
				Name = "banClient",
				Description = "Usage: banClient <client number>"
			},
			new DvarEntry
			{
				Name = "info",
				Description = "Usage: info <userid>"
			},
			new DvarEntry
			{
				Name = "scriptVarUsage",
				Description = "Usage: scriptVarUsage [-spreadsheet] [-summary] [-functionSummary] [-total] [-filename name]  [-function name] [-lin"
			},
			new DvarEntry
			{
				Name = "logmessage",
				Description = "Usage: logmessage severity message"
			},
			new DvarEntry
			{
				Name = "ui_keyboard_new",
				Description = "Usage: ui_keyboard_new <type>"
			},
			new DvarEntry
			{
				Name = "changeMenuOpenSlideDirection",
				Description = "Usage: changeMenuOpenSlideDirection <menu name> <new direction>"
			},
			new DvarEntry
			{
				Name = "changeMenuCloseSlideDirection",
				Description = "Usage: changeMenuCloseSlideDirection <menu name> <new direction>"
			},
			new DvarEntry
			{
				Name = "addToFeeder",
				Description = "Usage: addToFeeder <event index> <args>.."
			},
			new DvarEntry
			{
				Name = "addToFeederExtended",
				Description = "Usage: addToFeederExtended <onAction event> <onFocus event>  <disable condition> <args>.."
			},
			new DvarEntry
			{
				Name = "clearFeeder",
				Description = "Usage: clearFeeder"
			},
			new DvarEntry
			{
				Name = "clearFeederWithoutResetCursor",
				Description = "Usage: clearFeederWithoutResetCursor"
			},
			new DvarEntry
			{
				Name = "raiseFeederEvent",
				Description = "Usage: raiseFeederEvent <optional event name>"
			},
			new DvarEntry
			{
				Name = "refreshFeeder",
				Description = "Usage: refreshFeeder <populate event name>"
			},
			new DvarEntry
			{
				Name = "changeRowStatus",
				Description = "Usage: changeRowStatus <menu name> <row index> <new status>"
			},
			new DvarEntry
			{
				Name = "setActiveMenu",
				Description = "Usage: setActiveMenu <menuType>"
			},
			new DvarEntry
			{
				Name = "kickplayer",
				Description = "Usage: kickplayer xuid"
			},
			new DvarEntry
			{
				Name = "selectStringTableEntryInDvar",
				Description = "Usage: selectStringTableEntryInDvar <tableFileName> <columnNum> <dvarName>"
			},
			new DvarEntry
			{
				Name = "ddlLoadAsset",
				Description = "Usage: ddlLoadAsset <DDL Asset Name>"
			},
			new DvarEntry
			{
				Name = "ddlShow",
				Description = "Usage: ddlShow <DDL Asset Name>"
			},
			new DvarEntry
			{
				Name = "ai",
				Description = "Usage: ai (!)target field (value), or ai (!) target [list/delete]"
			},
			new DvarEntry
			{
				Name = "fileShareAbortOperation",
				Description = "Usage: fileShareAbortOperation"
			},
			new DvarEntry
			{
				Name = "fileshareGetSummary",
				Description = "Usage: fileshareGetSummary <fileID> <summaryFileSize>"
			},
			new DvarEntry
			{
				Name = "fileshareDelete",
				Description = "Usage: fileshareDelete <fileID>"
			},
			new DvarEntry
			{
				Name = "fileshareGetSlots",
				Description = "Usage: fileshareGetSlots or fileshareGetSlots <groupName>"
			},
			new DvarEntry
			{
				Name = "fileshareDelete",
				Description = "Usage: fileshareDelete <fileID> <isPooled> <slot>"
			},
			new DvarEntry
			{
				Name = "statsReadDDLExt",
				Description = "Usage: statsReadDDLExt <STATS_LOCATION enum value> <path>."
			},
			new DvarEntry
			{
				Name = "statsReadDDL",
				Description = "Usage: statsReadDDL <path>."
			},
			new DvarEntry
			{
				Name = "statWriteDDL",
				Description = "Usage: statWriteDDL <path> <value>"
			},
			new DvarEntry
			{
				Name = "motdSetViewed",
				Description = "Usage: motdSetViewed <motd version>"
			},
			new DvarEntry
			{
				Name = "statset",
				Description = "Usage: statset <statname> <value>"
			},
			new DvarEntry
			{
				Name = "statset",
				Description = "Usage: statset <statname> <value>"
			},
			new DvarEntry
			{
				Name = "statgetindvar",
				Description = "Usage: statgetindvar <statname> <dvar>"
			},
			new DvarEntry
			{
				Name = "setrankxp",
				Description = "Usage: setrankxp <targetRankXP>"
			},
			new DvarEntry
			{
				Name = "setzombierank",
				Description = "Usage: setzombierank <targetRank> <targetDaysPlayed>"
			},
			new DvarEntry
			{
				Name = "trackerUpdate",
				Description = "Usage: trackerUpdate [entityID (optional)] <columnName> <value>"
			},
			new DvarEntry
			{
				Name = "demo_switchplayer",
				Description = "Usage: demo_switchplayer <direction> <clientNum>. <direction> :  0 - clockwise, 1 - anticlockwise. "
			},
			new DvarEntry
			{
				Name = "demo_saveanduploadclip",
				Description = "Usage: demo_saveanduploadclip <slotNum>."
			},
			new DvarEntry
			{
				Name = "demo_switchtransition",
				Description = "Usage: demo_switchtransition <index> <transitionValue>."
			},
			new DvarEntry
			{
				Name = "demo_keyboard",
				Description = "Usage: demo_keyboard <type> [segmentIndex]"
			},
			new DvarEntry
			{
				Name = "demo_downloadandplay",
				Description = "Usage: demo_downloadandplay <pooled storage fileID>"
			},
			new DvarEntry
			{
				Name = "demo_play",
				Description = "Usage: demo_play <demoname> [optionalParam] . [OptionalParam] currently handles RenderMovie <matchID> <fileSlot>"
			},
			new DvarEntry
			{
				Name = "demo_startcliprecord",
				Description = "Usage: demo_startcliprecord"
			},
			new DvarEntry
			{
				Name = "demo_previewclip",
				Description = "Usage: demo_previewclip"
			},
			new DvarEntry
			{
				Name = "demo_deleteclip",
				Description = "Usage: demo_deleteclip"
			},
			new DvarEntry
			{
				Name = "demo_savesegment",
				Description = "Usage: demo_savesegment <discard>"
			},
			new DvarEntry
			{
				Name = "demo_movesegment",
				Description = "Usage: demo_movesegment <fromSegmentIndex> <toSegmentIndex>"
			},
			new DvarEntry
			{
				Name = "demo_movesegment",
				Description = "Usage: demo_movesegment <segmentIndex>."
			},
			new DvarEntry
			{
				Name = "demo_previewsegment",
				Description = "Usage: demo_previewsegment [segmentIndex]."
			},
			new DvarEntry
			{
				Name = "demo_screenshot",
				Description = "Usage: demo_screenshot <height>."
			},
			new DvarEntry
			{
				Name = "demo_savescreenshot",
				Description = "Usage: demo_savescreenshot <discard> [slot]."
			},
			new DvarEntry
			{
				Name = "demo_capturesegmentthumbnail",
				Description = "Usage: demo_capturesegmentthumbnail"
			},
			new DvarEntry
			{
				Name = "demo_regeneratehighlightreel",
				Description = "Usage: demo_regeneratehighlightreel [rebuildHighlightReelTimeline]"
			},
			new DvarEntry
			{
				Name = "demo_rebuildhighlightreeltimeline",
				Description = "Usage: demo_rebuildhighlightreeltimeline"
			},
			new DvarEntry
			{
				Name = "demo_removedollycammarker",
				Description = "Usage: demo_removedollycammarker <markerNum>"
			},
			new DvarEntry
			{
				Name = "demo_switchdollycammarker",
				Description = "Usage: demo_switchdollycammarker <currentMarker> [direction]. [Direction] is optional - 0 for anticlockwise, 1 for clockwise"
			},
			new DvarEntry
			{
				Name = "demo_repositiondollycammarker",
				Description = "Usage: demo_repositiondollycammarker <markerNum>"
			},
			new DvarEntry
			{
				Name = "demo_updatedollycammarkerparameters",
				Description = "Usage: demo_updatedollycammarkerparameters <markerNum>"
			},
			new DvarEntry
			{
				Name = "demo_setlagflag",
				Description = "Usage: demo_setlagflag <low/med/high>"
			},
			new DvarEntry
			{
				Name = "demo_setlagflag",
				Description = "Usage: demo_setlagflag <low/med/high>"
			},
			new DvarEntry
			{
				Name = "setGunXP",
				Description = "Usage: setGunXP <itemIndex> <value>"
			},
			new DvarEntry
			{
				Name = "setAllGunXPToMax",
				Description = "Usage: setAllGunXPToMax"
			},
			new DvarEntry
			{
				Name = "equipdefaultclass",
				Description = "Usage: equipdefaultclass <customclassname> <defaultClass>"
			},
			new DvarEntry
			{
				Name = "equipdefaultclass",
				Description = "Usage: equipdefaultclass <customclassname> <defaultClass>"
			},
			new DvarEntry
			{
				Name = "equipdefaultclass",
				Description = "Usage: equipdefaultclass <customclassname> <defaultClass>"
			},
			new DvarEntry
			{
				Name = "zeroClassSet",
				Description = "Usage: zeroClassSet <classSetIndex>"
			},
			new DvarEntry
			{
				Name = "copyToClassSet",
				Description = "Usage: copyToClassSet <classSetIndex>"
			},
			new DvarEntry
			{
				Name = "setClassSetNameFromLocString",
				Description = "Usage: setClassSetNameFromLocString <classSetIndex> <stringReference>"
			},
			new DvarEntry
			{
				Name = "buildItemListForGroup",
				Description = "Usage: buildItemListForGroup <group> "
			},
			new DvarEntry
			{
				Name = "buildItemListForGroupForWeaponTable",
				Description = "Usage: buildItemListForGroupForWeaponTable <group> "
			},
			new DvarEntry
			{
				Name = "copyclass",
				Description = "Usage: copyclass <classIndexToCopy> <classIndexToReplace>"
			},
			new DvarEntry
			{
				Name = "setClanTag",
				Description = "Usage: setClanTag <clantagFeatureIndex> "
			},
			new DvarEntry
			{
				Name = "equipclass",
				Description = "Usage: equipclass <customclassname> <item>"
			},
			new DvarEntry
			{
				Name = "equipdefaultitemtoslot",
				Description = "Usage: equipdefaultitemtoslot <customclassname> <slotname>"
			},
			new DvarEntry
			{
				Name = "clearitemnew",
				Description = "Usage: clearitemnew <itemname>"
			},
			new DvarEntry
			{
				Name = "buildItemListForSlotName",
				Description = "Usage: buildItemListForSlotName <loadout slot> "
			},
			new DvarEntry
			{
				Name = "buildItemListForGroupName",
				Description = "Usage: buildItemListForGroupName <group name> "
			},
			new DvarEntry
			{
				Name = "buildItemListForSlotNameAndGroup",
				Description = "Usage: buildItemListForSlotNameAndGroup <slot name> <group name> "
			},
			new DvarEntry
			{
				Name = "purchaseitem",
				Description = "Usage: purchaseitem <itemindex>"
			},
			new DvarEntry
			{
				Name = "validateClass",
				Description = "Usage: validateClass <customclassname>"
			},
			new DvarEntry
			{
				Name = "emblemSetEmptyBoxIconId",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_forward",
				Description = ""
			},
			new DvarEntry
			{
				Name = "recorder_memResize",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSelectBackground",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fshSearchTest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bbdisable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "skillTest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "scriptUsage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipDefaultClass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zeroPublicMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveDownRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "togglebandwidthprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setPerk",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setLeagueMatchClassSetNameFromLocString",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setviewpos",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemShowFileID",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteCreateClan",
				Description = ""
			},
			new DvarEntry
			{
				Name = "netqueue",
				Description = ""
			},
			new DvarEntry
			{
				Name = "callvote",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setFocusScoreboard",
				Description = ""
			},
			new DvarEntry
			{
				Name = "heartbeat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "listassetpool",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpLiveGroups",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateFilmTweaks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getxp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpmateriallist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetLeagueIdentity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "VoiceChat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveLeftRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpfs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeSetStat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_clear",
				Description = ""
			},
			new DvarEntry
			{
				Name = "entitycount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clearMatchHistory",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemClearAll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "checkdlcownership",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bind",
				Description = ""
			},
			new DvarEntry
			{
				Name = "copyToPublicMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clearProbation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "isBonusCardInSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetRecentColorRGBA",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRevertColorChanges",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemGetProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_joint",
				Description = ""
			},
			new DvarEntry
			{
				Name = "+moveup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipDefaultClassToProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemLoadFromFile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "kick",
				Description = ""
			},
			new DvarEntry
			{
				Name = "statReadDDLExt",
				Description = ""
			},
			new DvarEntry
			{
				Name = "checkforinvites",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getServiceRecord",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteLaunchAppExec",
				Description = ""
			},
			new DvarEntry
			{
				Name = "-moveup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ntpsync",
				Description = ""
			},
			new DvarEntry
			{
				Name = "find_cycles",
				Description = ""
			},
			new DvarEntry
			{
				Name = "purchaseItem",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetAsDefault",
				Description = ""
			},
			new DvarEntry
			{
				Name = "listdefaultassets",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipDefaultItemToSlot",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clearAllItemsNew",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipDefaultCustomMatchClass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getBonusCardSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "visionsetnight",
				Description = ""
			},
			new DvarEntry
			{
				Name = "downloaddemofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_showchannel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteClanLeave",
				Description = ""
			},
			new DvarEntry
			{
				Name = "-speed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_back",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vcs_start",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zeroCustomMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvar_float",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_clearrenderflag",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetLayerColorRGB",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvarListByCount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "followprev",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemToggleFlip",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote_getVote",
				Description = ""
			},
			new DvarEntry
			{
				Name = "say",
				Description = ""
			},
			new DvarEntry
			{
				Name = "hostmigration_start",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ddlShowPaths",
				Description = ""
			},
			new DvarEntry
			{
				Name = "kill",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setCurrentContract",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tempBanUser",
				Description = ""
			},
			new DvarEntry
			{
				Name = "teamstatus",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_complete",
				Description = ""
			},
			new DvarEntry
			{
				Name = "showActiveContracts",
				Description = ""
			},
			new DvarEntry
			{
				Name = "StatsCheck",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devmap",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leagueRefresh",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvar_int",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clientkick_for_reason",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpTasks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "raisestance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setMOTDViewed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_getLobbyState",
				Description = ""
			},
			new DvarEntry
			{
				Name = "follownext",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leagueStatus",
				Description = ""
			},
			new DvarEntry
			{
				Name = "assertDWConnection",
				Description = ""
			},
			new DvarEntry
			{
				Name = "trackerStressTest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemClearUploadInfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fileshareAbortSummary",
				Description = ""
			},
			new DvarEntry
			{
				Name = "net_dumpnetfieldchanges",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "freeDemoMemory",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemScaleDownRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "take",
				Description = ""
			},
			new DvarEntry
			{
				Name = "xpartyupdatedemo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_channellist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cmdlist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "activateContract",
				Description = ""
			},
			new DvarEntry
			{
				Name = "backupStats",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemEndEdit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemDelete",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipBonusCard",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updategamerprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "xpartystopdemo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "assert",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gts",
				Description = ""
			},
			new DvarEntry
			{
				Name = "lbreport",
				Description = ""
			},
			new DvarEntry
			{
				Name = "stringUsage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demigod",
				Description = ""
			},
			new DvarEntry
			{
				Name = "weapnext",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sendNewBaseline",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemFlip",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devgui_list",
				Description = ""
			},
			new DvarEntry
			{
				Name = "deadcode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "printclientfields",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setStatFromLocString",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetLayerColorFromSwatch",
				Description = ""
			},
			new DvarEntry
			{
				Name = "statAddByName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemCopy",
				Description = ""
			},
			new DvarEntry
			{
				Name = "glassMemInfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "codtvVideoPlaybackEnded",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemUploadToSlot",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvarlist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpuser",
				Description = ""
			},
			new DvarEntry
			{
				Name = "printenthandleinfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvar_color",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tempBanClient",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fakeDWDisconnect",
				Description = ""
			},
			new DvarEntry
			{
				Name = "PrestigeAddCAC",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restartsmokegrenades",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteTeamSetPrivateProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateInfoForInGameList",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setZombieRank",
				Description = ""
			},
			new DvarEntry
			{
				Name = "where",
				Description = ""
			},
			new DvarEntry
			{
				Name = "wait",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpMatchHistory",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ddlTestFloat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "noclip",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fast_restart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "PrestigeRespec",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemToggleOutline",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteLaunchAppStore",
				Description = ""
			},
			new DvarEntry
			{
				Name = "onlykick",
				Description = ""
			},
			new DvarEntry
			{
				Name = "net_dumpprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "CompareStatsVsStableBuffer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_bone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "chooseclass_hotkey",
				Description = ""
			},
			new DvarEntry
			{
				Name = "shatterAllGlass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_emailentry",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRotateRightRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "copyToCustomMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_checkvalidemail",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getLatestWAD",
				Description = ""
			},
			new DvarEntry
			{
				Name = "glassHWM",
				Description = ""
			},
			new DvarEntry
			{
				Name = "notarget",
				Description = ""
			},
			new DvarEntry
			{
				Name = "chatmodepublic",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRepeatBttnsLooseFocus",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clientkick",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bind2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote",
				Description = ""
			},
			new DvarEntry
			{
				Name = "joinLiveGroup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "if_sp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMove",
				Description = ""
			},
			new DvarEntry
			{
				Name = "resetGlass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setdvartotime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "showForceEliteCmds",
				Description = ""
			},
			new DvarEntry
			{
				Name = "map_rotate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fxSetTestPosition",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetSelectedLayerIconId",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_switchcontrols",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeRegister",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fshSearchClear",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setCustomMatchClassSetNameFromLocString",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_stop",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemPalette",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveLayerRelative",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeCancel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipDefaultLeagueClass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gametype_setting",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clear",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bbsend",
				Description = ""
			},
			new DvarEntry
			{
				Name = "GetCurrentChallengeRow",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zeroLeagueMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "serverinfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "error",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_limit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote_submitDislike",
				Description = ""
			},
			new DvarEntry
			{
				Name = "statGetByNameInDvar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "set_gametype",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unbind2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restrict_attachment",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_checkPlaylist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveLayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setPublicMatchClassSetNameFromLocString",
				Description = ""
			},
			new DvarEntry
			{
				Name = "say_team",
				Description = ""
			},
			new DvarEntry
			{
				Name = "uiEquipDefaultClass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leaguefake",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvar_bool",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unbindall",
				Description = ""
			},
			new DvarEntry
			{
				Name = "give",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemBeginEdit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateMustHaveBindings",
				Description = ""
			},
			new DvarEntry
			{
				Name = "freeze",
				Description = ""
			},
			new DvarEntry
			{
				Name = "spawndebug_user_badspawn",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_selfpair",
				Description = ""
			},
			new DvarEntry
			{
				Name = "mr",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateCharPrimaryTweaks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ffotdversion",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRevertLayerChanges",
				Description = ""
			},
			new DvarEntry
			{
				Name = "crash",
				Description = ""
			},
			new DvarEntry
			{
				Name = "map_restart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setRankXP",
				Description = ""
			},
			new DvarEntry
			{
				Name = "checkGamerTags",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetSelectedRecentColor",
				Description = ""
			},
			new DvarEntry
			{
				Name = "giveProbation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "xpartyplaydemo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemDuplicate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetScaleMode",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetFromDefault",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leagueFetchLbData",
				Description = ""
			},
			new DvarEntry
			{
				Name = "gamesettings_clearuploadinfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveUpRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "loadcommonff",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_abortfilesharedownload",
				Description = ""
			},
			new DvarEntry
			{
				Name = "deactivateContract",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ui_keyboard_cancel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "uploadStats",
				Description = ""
			},
			new DvarEntry
			{
				Name = "god",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateVehicleBindings",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeGetAccount",
				Description = ""
			},
			new DvarEntry
			{
				Name = "mp_QuickMessage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leagueForce",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unbindallaxis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRotateLeftRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "quit",
				Description = ""
			},
			new DvarEntry
			{
				Name = "toggle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "cg_toggleScores",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fakeComError",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveNotification",
				Description = ""
			},
			new DvarEntry
			{
				Name = "statSetByName",
				Description = ""
			},
			new DvarEntry
			{
				Name = "togglep",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fileshareCopy",
				Description = ""
			},
			new DvarEntry
			{
				Name = "+speed",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_visiblechannellist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getqport",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fileshareClearCopyParams",
				Description = ""
			},
			new DvarEntry
			{
				Name = "sendNoDelta",
				Description = ""
			},
			new DvarEntry
			{
				Name = "lowerstance",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bbstart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "net_restart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "win_content_enable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemIncreaseOpacity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "forcePartyupdate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvardump",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dwPrintAddrs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_statechanged",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemScale",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devgui_dvar",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ddlShowMember",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ddlTestBool",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setprofilelocclass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_jumptostart",
				Description = ""
			},
			new DvarEntry
			{
				Name = "removeFriendsFromRecentPlayerList",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeGetStat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_mergesegments",
				Description = ""
			},
			new DvarEntry
			{
				Name = "refetchWAD",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bbenable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemClearClipboard",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_baselerp_bone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "LiveEliteTeamSetPublicProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetPosition",
				Description = ""
			},
			new DvarEntry
			{
				Name = "zm",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemRotate",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpmodels",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemClear",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unbind",
				Description = ""
			},
			new DvarEntry
			{
				Name = "exec",
				Description = ""
			},
			new DvarEntry
			{
				Name = "VoiceTeamChat",
				Description = ""
			},
			new DvarEntry
			{
				Name = "status",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fxTest",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeSetViewers",
				Description = ""
			},
			new DvarEntry
			{
				Name = "tell",
				Description = ""
			},
			new DvarEntry
			{
				Name = "resetprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "win_content_disable",
				Description = ""
			},
			new DvarEntry
			{
				Name = "crashGlass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "weapprev",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemDump",
				Description = ""
			},
			new DvarEntry
			{
				Name = "recorder_gotoTime",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vcs_stop",
				Description = ""
			},
			new DvarEntry
			{
				Name = "killserver",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote_getHistory",
				Description = ""
			},
			new DvarEntry
			{
				Name = "printfxnameusage",
				Description = ""
			},
			new DvarEntry
			{
				Name = "exec_addtext",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bindaxis",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getprofile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ddlTestFixedPoint",
				Description = ""
			},
			new DvarEntry
			{
				Name = "freefs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemClearDefaults",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bbthrottle",
				Description = ""
			},
			new DvarEntry
			{
				Name = "setContractFilter",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_deletesegment",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ragdoll_pin_bone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "generatePlaylistPopulation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "visionsetnaked",
				Description = ""
			},
			new DvarEntry
			{
				Name = "loadzone",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fullpath",
				Description = ""
			},
			new DvarEntry
			{
				Name = "updateBloomTweaks",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemPasteLayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote_fillVoteHistory",
				Description = ""
			},
			new DvarEntry
			{
				Name = "leaveLiveGroup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "statReadDDL",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restoreDvars",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemCopyLayer",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_echo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSelect",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemScaleUpRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_testTeamCreation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "equipClass",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_removeTestClient",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dvarAddConfigFlag",
				Description = ""
			},
			new DvarEntry
			{
				Name = "reportunused",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devgui_cmd",
				Description = ""
			},
			new DvarEntry
			{
				Name = "fileshareAbortOperation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetRGBTweakedColor",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_addTestClients",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devgui",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetOpacity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "clearItemNew",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemMoveRightRepeatEnabled",
				Description = ""
			},
			new DvarEntry
			{
				Name = "chatmodeteam",
				Description = ""
			},
			new DvarEntry
			{
				Name = "PrestigeStatsResetAll",
				Description = ""
			},
			new DvarEntry
			{
				Name = "viewpos",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemIcon",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetAndUploadProfile",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetIdentity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemReset",
				Description = ""
			},
			new DvarEntry
			{
				Name = "path",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemOutline",
				Description = ""
			},
			new DvarEntry
			{
				Name = "bindlist",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restoreStatsFromBackup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "con_hidechannel",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unbindall2",
				Description = ""
			},
			new DvarEntry
			{
				Name = "reportUser",
				Description = ""
			},
			new DvarEntry
			{
				Name = "devgui_open",
				Description = ""
			},
			new DvarEntry
			{
				Name = "copyToLeagueMatchClassSet",
				Description = ""
			},
			new DvarEntry
			{
				Name = "unequipBonusCard",
				Description = ""
			},
			new DvarEntry
			{
				Name = "getUsedAllocation",
				Description = ""
			},
			new DvarEntry
			{
				Name = "ufo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "if_mp",
				Description = ""
			},
			new DvarEntry
			{
				Name = "readStatsBackup",
				Description = ""
			},
			new DvarEntry
			{
				Name = "dumpdir",
				Description = ""
			},
			new DvarEntry
			{
				Name = "recorder_togglePlayback",
				Description = ""
			},
			new DvarEntry
			{
				Name = "youTubeUnregister",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemDecreaseOpacity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "vote_submitLike",
				Description = ""
			},
			new DvarEntry
			{
				Name = "restrict_item",
				Description = ""
			},
			new DvarEntry
			{
				Name = "emblemSetClanIdentity",
				Description = ""
			},
			new DvarEntry
			{
				Name = "demo_adddollycammarker",
				Description = ""
			},
			new DvarEntry
			{
				Name = "map",
				Description = ""
			},
			new DvarEntry
			{
				Name = "systeminfo",
				Description = ""
			},
			new DvarEntry
			{
				Name = "printentities",
				Description = ""
			},
			new DvarEntry
			{
				Name = "party_toggleMute",
				Description = ""
			},
			new DvarEntry
			{
				Name = "usefs",
				Description = ""
			},
			new DvarEntry
			{
				Name = "PrestigeStatsReset",
				Description = ""
			}
		};
	}
}

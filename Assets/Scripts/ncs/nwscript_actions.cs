﻿using AuroraEngine;
using NCSInstructions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using Newtonsoft.Json;
using System.Net.Mime;
using System.Reflection;

public class NWScript_Actions
{
    public static Dictionary<int, string> ACTIONS = new Dictionary<int, string>
    {
        { 0, "Random" },
        { 1, "PrintString" },
        { 2, "PrintFloat" },
        { 3, "FloatToString" },
        { 4, "PrintInteger" },
        { 5, "PrintObject" },
        { 6, "AssignCommand" },
        { 7, "DelayCommand" },
        { 8, "ExecuteScript" },
        { 9, "ClearAllActions" },
        { 10, "SetFacing" },
        { 11, "SwitchPlayerCharacter" },
        { 12, "SetTime" },
        { 13, "SetPartyLeader" },
        { 14, "SetAreaUnescapable" },
        { 15, "GetAreaUnescapable" },
        { 16, "GetTimeHour" },
        { 17, "GetTimeMinute" },
        { 18, "GetTimeSecond" },
        { 19, "GetTimeMillisecond" },
        { 20, "ActionRandomWalk" },
        { 21, "ActionMoveToLocation" },
        { 22, "ActionMoveToObject" },
        { 23, "ActionMoveAwayFromObject" },
        { 24, "GetArea" },
        { 25, "GetEnteringObject" },
        { 26, "GetExitingObject" },
        { 27, "GetPosition" },
        { 28, "GetFacing" },
        { 29, "GetItemPossessor" },
        { 30, "GetItemPossessedBy" },
        { 31, "CreateItemOnObject" },
        { 32, "ActionEquipItem" },
        { 33, "ActionUnequipItem" },
        { 34, "ActionPickUpItem" },
        { 35, "ActionPutDownItem" },
        { 36, "GetLastAttacker" },
        { 37, "ActionAttack" },
        { 38, "GetNearestCreature" },
        { 39, "ActionSpeakString" },
        { 40, "ActionPlayAnimation" },
        { 41, "GetDistanceToObject" },
        { 42, "GetIsObjectValid" },
        { 43, "ActionOpenDoor" },
        { 44, "ActionCloseDoor" },
        { 45, "SetCameraFacing" },
        { 46, "PlaySound" },
        { 47, "GetSpellTargetObject" },
        { 48, "ActionCastSpellAtObject" },
        { 49, "GetCurrentHitPoints" },
        { 50, "GetMaxHitPoints" },
        { 51, "EffectAssuredHit" },
        { 52, "GetLastItemEquipped" },
        { 53, "GetSubScreenID" },
        { 54, "CancelCombat" },
        { 55, "GetCurrentForcePoints" },
        { 56, "GetMaxForcePoints" },
        { 57, "PauseGame" },
        { 58, "SetPlayerRestrictMode" },
        { 59, "GetStringLength" },
        { 60, "GetStringUpperCase" },
        { 61, "GetStringLowerCase" },
        { 62, "GetStringRight" },
        { 63, "GetStringLeft" },
        { 64, "InsertString" },
        { 65, "GetSubString" },
        { 66, "FindSubString" },
        { 67, "fabs" },
        { 68, "cos" },
        { 69, "sin" },
        { 70, "tan" },
        { 71, "acos" },
        { 72, "asin" },
        { 73, "atan" },
        { 74, "log" },
        { 75, "pow" },
        { 76, "sqrt" },
        { 77, "abs" },
        { 78, "EffectHeal" },
        { 79, "EffectDamage" },
        { 80, "EffectAbilityIncrease" },
        { 81, "EffectDamageResistance" },
        { 82, "EffectResurrection" },
        { 83, "GetPlayerRestrictMode" },
        { 84, "GetCasterLevel" },
        { 85, "GetFirstEffect" },
        { 86, "GetNextEffect" },
        { 87, "RemoveEffect" },
        { 88, "GetIsEffectValid" },
        { 89, "GetEffectDurationType" },
        { 90, "GetEffectSubType" },
        { 91, "GetEffectCreator" },
        { 92, "IntToString" },
        { 93, "GetFirstObjectInArea" },
        { 94, "GetNextObjectInArea" },
        { 95, "d2" },
        { 96, "d3" },
        { 97, "d4" },
        { 98, "d6" },
        { 99, "d8" },
        { 100, "d10" },
        { 101, "d12" },
        { 102, "d20" },
        { 103, "d100" },
        { 104, "VectorMagnitude" },
        { 105, "GetMetaMagicFeat" },
        { 106, "GetObjectType" },
        { 107, "GetRacialType" },
        { 108, "FortitudeSave" },
        { 109, "ReflexSave" },
        { 110, "WillSave" },
        { 111, "GetSpellSaveDC" },
        { 112, "MagicalEffect" },
        { 113, "SupernaturalEffect" },
        { 114, "ExtraordinaryEffect" },
        { 115, "EffectACIncrease" },
        { 116, "GetAC" },
        { 117, "EffectSavingThrowIncrease" },
        { 118, "EffectAttackIncrease" },
        { 119, "EffectDamageReduction" },
        { 120, "EffectDamageIncrease" },
        { 121, "RoundsToSeconds" },
        { 122, "HoursToSeconds" },
        { 123, "TurnsToSeconds" },
        { 124, "SoundObjectSetFixedVariance" },
        { 125, "GetGoodEvilValue" },
        { 126, "GetPartyMemberCount" },
        { 127, "GetAlignmentGoodEvil" },
        { 128, "GetFirstObjectInShape" },
        { 129, "GetNextObjectInShape" },
        { 130, "EffectEntangle" },
        { 131, "SignalEvent" },
        { 132, "EventUserDefined" },
        { 133, "EffectDeath" },
        { 134, "EffectKnockdown" },
        { 135, "ActionGiveItem" },
        { 136, "ActionTakeItem" },
        { 137, "VectorNormalize" },
        { 138, "GetItemStackSize" },
        { 139, "GetAbilityScore" },
        { 140, "GetIsDead" },
        { 141, "PrintVector" },
        { 142, "Vector" },
        { 143, "SetFacingPoint" },
        { 144, "AngleToVector" },
        { 145, "VectorToAngle" },
        { 146, "TouchAttackMelee" },
        { 147, "TouchAttackRanged" },
        { 148, "EffectParalyze" },
        { 149, "EffectSpellImmunity" },
        { 150, "SetItemStackSize" },
        { 151, "GetDistanceBetween" },
        { 152, "SetReturnStrref" },
        { 153, "EffectForceJump" },
        { 154, "EffectSleep" },
        { 155, "GetItemInSlot" },
        { 156, "EffectTemporaryForcePoints" },
        { 157, "EffectConfused" },
        { 158, "EffectFrightened" },
        { 159, "EffectChoke" },
        { 160, "SetGlobalString" },
        { 161, "EffectStunned" },
        { 162, "SetCommandable" },
        { 163, "GetCommandable" },
        { 164, "EffectRegenerate" },
        { 165, "EffectMovementSpeedIncrease" },
        { 166, "GetHitDice" },
        { 167, "ActionForceFollowObject" },
        { 168, "GetTag" },
        { 169, "ResistForce" },
        { 170, "GetEffectType" },
        { 171, "EffectAreaOfEffect" },
        { 172, "GetFactionEqual" },
        { 173, "ChangeFaction" },
        { 174, "GetIsListening" },
        { 175, "SetListening" },
        { 176, "SetListenPattern" },
        { 177, "TestStringAgainstPattern" },
        { 178, "GetMatchedSubstring" },
        { 179, "GetMatchedSubstringsCount" },
        { 180, "EffectVisualEffect" },
        { 181, "GetFactionWeakestMember" },
        { 182, "GetFactionStrongestMember" },
        { 183, "GetFactionMostDamagedMember" },
        { 184, "GetFactionLeastDamagedMember" },
        { 185, "GetFactionGold" },
        { 186, "GetFactionAverageReputation" },
        { 187, "GetFactionAverageGoodEvilAlignment" },
        { 188, "SoundObjectGetFixedVariance" },
        { 189, "GetFactionAverageLevel" },
        { 190, "GetFactionAverageXP" },
        { 191, "GetFactionMostFrequentClass" },
        { 192, "GetFactionWorstAC" },
        { 193, "GetFactionBestAC" },
        { 194, "GetGlobalString" },
        { 195, "GetListenPatternNumber" },
        { 196, "ActionJumpToObject" },
        { 197, "GetWaypointByTag" },
        { 198, "GetTransitionTarget" },
        { 199, "EffectLinkEffects" },
        { 200, "GetObjectByTag" },
        { 201, "AdjustAlignment" },
        { 202, "ActionWait" },
        { 203, "SetAreaTransitionBMP" },
        { 204, "ActionStartConversation" },
        { 205, "ActionPauseConversation" },
        { 206, "ActionResumeConversation" },
        { 207, "EffectBeam" },
        { 208, "GetReputation" },
        { 209, "AdjustReputation" },
        { 210, "GetModuleFileName" },
        { 211, "GetGoingToBeAttackedBy" },
        { 212, "EffectForceResistanceIncrease" },
        { 213, "GetLocation" },
        { 214, "ActionJumpToLocation" },
        { 215, "Location" },
        { 216, "ApplyEffectAtLocation" },
        { 217, "GetIsPC" },
        { 218, "FeetToMeters" },
        { 219, "YardsToMeters" },
        { 220, "ApplyEffectToObject" },
        { 221, "SpeakString" },
        { 222, "GetSpellTargetLocation" },
        { 223, "GetPositionFromLocation" },
        { 224, "EffectBodyFuel" },
        { 225, "GetFacingFromLocation" },
        { 226, "GetNearestCreatureToLocation" },
        { 227, "GetNearestObject" },
        { 228, "GetNearestObjectToLocation" },
        { 229, "GetNearestObjectByTag" },
        { 230, "IntToFloat" },
        { 231, "FloatToInt" },
        { 232, "StringToInt" },
        { 233, "StringToFloat" },
        { 234, "" },
        { 235, "GetIsEnemy" },
        { 236, "GetIsFriend" },
        { 237, "GetIsNeutral" },
        { 238, "GetPCSpeaker" },
        { 239, "GetStringByStrRef" },
        { 240, "ActionSpeakStringByStrRef" },
        { 241, "DestroyObject" },
        { 242, "GetModule" },
        { 243, "CreateObject" },
        { 244, "EventSpellCastAt" },
        { 245, "GetLastSpellCaster" },
        { 246, "GetLastSpell" },
        { 247, "GetUserDefinedEventNumber" },
        { 248, "GetSpellId" },
        { 249, "RandomName" },
        { 250, "EffectPoison" },
        { 251, "GetLoadFromSaveGame" },
        { 252, "EffectAssuredDeflection" },
        { 253, "GetName" },
        { 254, "GetLastSpeaker" },
        { 255, "BeginConversation" },
        { 256, "GetLastPerceived" },
        { 257, "GetLastPerceptionHeard" },
        { 258, "GetLastPerceptionInaudible" },
        { 259, "GetLastPerceptionSeen" },
        { 260, "GetLastClosedBy" },
        { 261, "GetLastPerceptionVanished" },
        { 262, "GetFirstInPersistentObject" },
        { 263, "GetNextInPersistentObject" },
        { 264, "GetAreaOfEffectCreator" },
        { 265, "ShowLevelUpGUI" },
        { 266, "SetItemNonEquippable" },
        { 267, "GetButtonMashCheck" },
        { 268, "SetButtonMashCheck" },
        { 269, "EffectForcePushTargeted" },
        { 270, "EffectHaste" },
        { 271, "GiveItem" },
        { 272, "ObjectToString" },
        { 273, "EffectImmunity" },
        { 274, "GetIsImmune" },
        { 275, "EffectDamageImmunityIncrease" },
        { 276, "" },
        { 277, "SetEncounterActive" },
        { 278, "GetEncounterSpawnsMax" },
        { 279, "SetEncounterSpawnsMax" },
        { 280, "" },
        { 281, "SetEncounterSpawnsCurrent" },
        { 282, "GetModuleItemAcquired" },
        { 283, "GetModuleItemAcquiredFrom" },
        { 284, "SetCustomToken" },
        { 285, "GetHasFeat" },
        { 286, "GetHasSkill" },
        { 287, "ActionUseFeat" },
        { 288, "ActionUseSkill" },
        { 289, "GetObjectSeen" },
        { 290, "GetObjectHeard" },
        { 291, "GetLastPlayerDied" },
        { 292, "GetModuleItemLost" },
        { 293, "GetModuleItemLostBy" },
        { 294, "ActionDoCommand" },
        { 295, "EventConversation" },
        { 296, "SetEncounterDifficulty" },
        { 297, "GetEncounterDifficulty" },
        { 298, "GetDistanceBetweenLocations" },
        { 299, "GetReflexAdjustedDamage" },
        { 300, "PlayAnimation" },
        { 301, "TalentSpell" },
        { 302, "TalentFeat" },
        { 303, "TalentSkill" },
        { 304, "GetHasSpellEffect" },
        { 305, "GetEffectSpellId" },
        { 306, "GetCreatureHasTalent" },
        { 307, "GetCreatureTalentRandom" },
        { 308, "GetCreatureTalentBest" },
        { 309, "ActionUseTalentOnObject" },
        { 310, "ActionUseTalentAtLocation" },
        { 311, "GetGoldPieceValue" },
        { 312, "GetIsPlayableRacialType" },
        { 313, "JumpToLocation" },
        { 314, "EffectTemporaryHitpoints" },
        { 315, "GetSkillRank" },
        { 316, "GetAttackTarget" },
        { 317, "GetLastAttackType" },
        { 318, "GetLastAttackMode" },
        { 319, "GetDistanceBetween2D" },
        { 320, "GetIsInCombat" },
        { 321, "GetLastAssociateCommand" },
        { 322, "GiveGoldToCreature" },
        { 323, "SetIsDestroyable" },
        { 324, "SetLocked" },
        { 325, "GetLocked" },
        { 326, "GetClickingObject" },
        { 327, "SetAssociateListenPatterns" },
        { 328, "GetLastWeaponUsed" },
        { 329, "ActionInteractObject" },
        { 330, "GetLastUsedBy" },
        { 331, "GetAbilityModifier" },
        { 332, "GetIdentified" },
        { 333, "SetIdentified" },
        { 334, "GetDistanceBetweenLocations2D" },
        { 335, "GetDistanceToObject2D" },
        { 336, "GetBlockingDoor" },
        { 337, "GetIsDoorActionPossible" },
        { 338, "DoDoorAction" },
        { 339, "GetFirstItemInInventory" },
        { 340, "GetNextItemInInventory" },
        { 341, "GetClassByPosition" },
        { 342, "GetLevelByPosition" },
        { 343, "GetLevelByClass" },
        { 344, "GetDamageDealtByType" },
        { 345, "GetTotalDamageDealt" },
        { 346, "GetLastDamager" },
        { 347, "GetLastDisarmed" },
        { 348, "GetLastDisturbed" },
        { 349, "GetLastLocked" },
        { 350, "GetLastUnlocked" },
        { 351, "EffectSkillIncrease" },
        { 352, "GetInventoryDisturbType" },
        { 353, "GetInventoryDisturbItem" },
        { 354, "ShowUpgradeScreen" },
        { 355, "VersusAlignmentEffect" },
        { 356, "VersusRacialTypeEffect" },
        { 357, "VersusTrapEffect" },
        { 358, "GetGender" },
        { 359, "GetIsTalentValid" },
        { 360, "ActionMoveAwayFromLocation" },
        { 361, "GetAttemptedAttackTarget" },
        { 362, "GetTypeFromTalent" },
        { 363, "GetIdFromTalent" },
        { 364, "PlayPazaak" },
        { 365, "GetLastPazaakResult" },
        { 366, "DisplayFeedBackText" },
        { 367, "AddJournalQuestEntry" },
        { 368, "RemoveJournalQuestEntry" },
        { 369, "GetJournalEntry" },
        { 370, "PlayRumblePattern" },
        { 371, "StopRumblePattern" },
        { 372, "EffectDamageForcePoints" },
        { 373, "EffectHealForcePoints" },
        { 374, "SendMessageToPC" },
        { 375, "GetAttemptedSpellTarget" },
        { 376, "GetLastOpenedBy" },
        { 377, "GetHasSpell" },
        { 378, "OpenStore" },
        { 379, "ActionSurrenderToEnemies" },
        { 380, "GetFirstFactionMember" },
        { 381, "GetNextFactionMember" },
        { 382, "ActionForceMoveToLocation" },
        { 383, "ActionForceMoveToObject" },
        { 384, "GetJournalQuestExperience" },
        { 385, "JumpToObject" },
        { 386, "SetMapPinEnabled" },
        { 387, "EffectHitPointChangeWhenDying" },
        { 388, "PopUpGUIPanel" },
        { 389, "AddMultiClass" },
        { 390, "GetIsLinkImmune" },
        { 391, "EffectDroidStun" },
        { 392, "EffectForcePushed" },
        { 393, "GiveXPToCreature" },
        { 394, "SetXP" },
        { 395, "GetXP" },
        { 396, "IntToHexString" },
        { 397, "GetBaseItemType" },
        { 398, "GetItemHasItemProperty" },
        { 399, "ActionEquipMostDamagingMelee" },
        { 400, "ActionEquipMostDamagingRanged" },
        { 401, "GetItemACValue" },
        { 402, "EffectForceResisted" },
        { 403, "ExploreAreaForPlayer" },
        { 404, "ActionEquipMostEffectiveArmor" },
        { 405, "GetIsDay" },
        { 406, "GetIsNight" },
        { 407, "GetIsDawn" },
        { 408, "GetIsDusk" },
        { 409, "GetIsEncounterCreature" },
        { 410, "GetLastPlayerDying" },
        { 411, "GetStartingLocation" },
        { 412, "ChangeToStandardFaction" },
        { 413, "SoundObjectPlay" },
        { 414, "SoundObjectStop" },
        { 415, "SoundObjectSetVolume" },
        { 416, "SoundObjectSetPosition" },
        { 417, "SpeakOneLinerConversation" },
        { 418, "GetGold" },
        { 419, "GetLastRespawnButtonPresser" },
        { 420, "EffectForceFizzle" },
        { 421, "SetLightsaberPowered" },
        { 422, "GetIsWeaponEffective" },
        { 423, "GetLastSpellHarmful" },
        { 424, "EventActivateItem" },
        { 425, "MusicBackgroundPlay" },
        { 426, "MusicBackgroundStop" },
        { 427, "MusicBackgroundSetDelay" },
        { 428, "MusicBackgroundChangeDay" },
        { 429, "MusicBackgroundChangeNight" },
        { 430, "MusicBattlePlay" },
        { 431, "MusicBattleStop" },
        { 432, "MusicBattleChange" },
        { 433, "AmbientSoundPlay" },
        { 434, "AmbientSoundStop" },
        { 435, "AmbientSoundChangeDay" },
        { 436, "AmbientSoundChangeNight" },
        { 437, "GetLastKiller" },
        { 438, "GetSpellCastItem" },
        { 439, "GetItemActivated" },
        { 440, "GetItemActivator" },
        { 441, "GetItemActivatedTargetLocation" },
        { 442, "GetItemActivatedTarget" },
        { 443, "GetIsOpen" },
        { 444, "TakeGoldFromCreature" },
        { 445, "GetIsInConversation" },
        { 446, "EffectAbilityDecrease" },
        { 447, "EffectAttackDecrease" },
        { 448, "EffectDamageDecrease" },
        { 449, "EffectDamageImmunityDecrease" },
        { 450, "EffectACDecrease" },
        { 451, "EffectMovementSpeedDecrease" },
        { 452, "EffectSavingThrowDecrease" },
        { 453, "EffectSkillDecrease" },
        { 454, "EffectForceResistanceDecrease" },
        { 455, "GetPlotFlag" },
        { 456, "SetPlotFlag" },
        { 457, "EffectInvisibility" },
        { 458, "EffectConcealment" },
        { 459, "EffectForceShield" },
        { 460, "EffectDispelMagicAll" },
        { 461, "SetDialogPlaceableCamera" },
        { 462, "GetSoloMode" },
        { 463, "EffectDisguise" },
        { 464, "GetMaxStealthXP" },
        { 465, "EffectTrueSeeing" },
        { 466, "EffectSeeInvisible" },
        { 467, "EffectTimeStop" },
        { 468, "SetMaxStealthXP" },
        { 469, "EffectBlasterDeflectionIncrease" },
        { 470, "EffectBlasterDeflectionDecrease" },
        { 471, "EffectHorrified" },
        { 472, "EffectSpellLevelAbsorption" },
        { 473, "EffectDispelMagicBest" },
        { 474, "GetCurrentStealthXP" },
        { 475, "GetNumStackedItems" },
        { 476, "SurrenderToEnemies" },
        { 477, "EffectMissChance" },
        { 478, "SetCurrentStealthXP" },
        { 479, "GetCreatureSize" },
        { 480, "AwardStealthXP" },
        { 481, "GetStealthXPEnabled" },
        { 482, "SetStealthXPEnabled" },
        { 483, "ActionUnlockObject" },
        { 484, "ActionLockObject" },
        { 485, "EffectModifyAttacks" },
        { 486, "GetLastTrapDetected" },
        { 487, "EffectDamageShield" },
        { 488, "GetNearestTrapToObject" },
        { 489, "GetAttemptedMovementTarget" },
        { 490, "GetBlockingCreature" },
        { 491, "GetFortitudeSavingThrow" },
        { 492, "GetWillSavingThrow" },
        { 493, "GetReflexSavingThrow" },
        { 494, "GetChallengeRating" },
        { 495, "GetFoundEnemyCreature" },
        { 496, "GetMovementRate" },
        { 497, "GetSubRace" },
        { 498, "GetStealthXPDecrement" },
        { 499, "SetStealthXPDecrement" },
        { 500, "DuplicateHeadAppearance" },
        { 501, "ActionCastFakeSpellAtObject" },
        { 502, "ActionCastFakeSpellAtLocation" },
        { 503, "CutsceneAttack" },
        { 504, "SetCameraMode" },
        { 505, "SetLockOrientationInDialog" },
        { 506, "SetLockHeadFollowInDialog" },
        { 507, "CutsceneMove" },
        { 508, "EnableVideoEffect" },
        { 509, "StartNewModule" },
        { 510, "DisableVideoEffect" },
        { 511, "GetWeaponRanged" },
        { 512, "DoSinglePlayerAutoSave" },
        { 513, "GetGameDifficulty" },
        { 514, "GetUserActionsPending" },
        { 515, "RevealMap" },
        { 516, "SetTutorialWindowsEnabled" },
        { 517, "ShowTutorialWindow" },
        { 518, "StartCreditSequence" },
        { 519, "IsCreditSequenceInProgress" },
        { 520, "SWMG_SetLateralAccelerationPerSecond" },
        { 521, "SWMG_GetLateralAccelerationPerSecond" },
        { 522, "GetCurrentAction" },
        { 523, "GetDifficultyModifier" },
        { 524, "GetAppearanceType" },
        { 525, "FloatingTextStrRefOnCreature" },
        { 526, "FloatingTextStringOnCreature" },
        { 527, "GetTrapDisarmable" },
        { 528, "GetTrapDetectable" },
        { 529, "GetTrapDetectedBy" },
        { 530, "GetTrapFlagged" },
        { 531, "GetTrapBaseType" },
        { 532, "GetTrapOneShot" },
        { 533, "GetTrapCreator" },
        { 534, "GetTrapKeyTag" },
        { 535, "GetTrapDisarmDC" },
        { 536, "GetTrapDetectDC" },
        { 537, "GetLockKeyRequired" },
        { 538, "GetLockKeyTag" },
        { 539, "GetLockLockable" },
        { 540, "GetLockUnlockDC" },
        { 541, "GetLockLockDC" },
        { 542, "GetPCLevellingUp" },
        { 543, "GetHasFeatEffect" },
        { 544, "SetPlaceableIllumination" },
        { 545, "GetPlaceableIllumination" },
        { 546, "GetIsPlaceableObjectActionPossible" },
        { 547, "DoPlaceableObjectAction" },
        { 548, "GetFirstPC" },
        { 549, "GetNextPC" },
        { 550, "SetTrapDetectedBy" },
        { 551, "GetIsTrapped" },
        { 552, "SetEffectIcon" },
        { 553, "FaceObjectAwayFromObject" },
        { 554, "PopUpDeathGUIPanel" },
        { 555, "SetTrapDisabled" },
        { 556, "GetLastHostileActor" },
        { 557, "ExportAllCharacters" },
        { 558, "MusicBackgroundGetDayTrack" },
        { 559, "MusicBackgroundGetNightTrack" },
        { 560, "WriteTimestampedLogEntry" },
        { 561, "GetModuleName" },
        { 562, "GetFactionLeader" },
        { 563, "SWMG_SetSpeedBlurEffect" },
        { 564, "EndGame" },
        { 565, "GetRunScriptVar" },
        { 566, "GetCreatureMovmentType" },
        { 567, "AmbientSoundSetDayVolume" },
        { 568, "AmbientSoundSetNightVolume" },
        { 569, "MusicBackgroundGetBattleTrack" },
        { 570, "GetHasInventory" },
        { 571, "GetStrRefSoundDuration" },
        { 572, "AddToParty" },
        { 573, "RemoveFromParty" },
        { 574, "AddPartyMember" },
        { 575, "RemovePartyMember" },
        { 576, "IsObjectPartyMember" },
        { 577, "GetPartyMemberByIndex" },
        { 578, "GetGlobalBoolean" },
        { 579, "SetGlobalBoolean" },
        { 580, "GetGlobalNumber" },
        { 581, "SetGlobalNumber" },
        { 582, "AurPostString" },
        { 583, "SWMG_GetLastEvent" },
        { 584, "SWMG_GetLastEventModelName" },
        { 585, "SWMG_GetObjectByName" },
        { 586, "SWMG_PlayAnimation" },
        { 587, "SWMG_GetLastBulletHitDamage" },
        { 588, "SWMG_GetLastBulletHitTarget" },
        { 589, "SWMG_GetLastBulletHitShooter" },
        { 590, "SWMG_AdjustFollowerHitPoints" },
        { 591, "SWMG_OnBulletHit" },
        { 592, "SWMG_OnObstacleHit" },
        { 593, "SWMG_GetLastFollowerHit" },
        { 594, "SWMG_GetLastObstacleHit" },
        { 595, "SWMG_GetLastBulletFiredDamage" },
        { 596, "SWMG_GetLastBulletFiredTarget" },
        { 597, "SWMG_GetObjectName" },
        { 598, "SWMG_OnDeath" },
        { 599, "SWMG_IsFollower" },
        { 600, "SWMG_IsPlayer" },
        { 601, "SWMG_IsEnemy" },
        { 602, "SWMG_IsTrigger" },
        { 603, "SWMG_IsObstacle" },
        { 604, "SWMG_SetFollowerHitPoints" },
        { 605, "SWMG_OnDamage" },
        { 606, "SWMG_GetLastHPChange" },
        { 607, "SWMG_RemoveAnimation" },
        { 608, "SWMG_GetCameraNearClip" },
        { 609, "SWMG_GetCameraFarClip" },
        { 610, "SWMG_SetCameraClip" },
        { 611, "SWMG_GetPlayer" },
        { 612, "SWMG_GetEnemyCount" },
        { 613, "SWMG_GetEnemy" },
        { 614, "SWMG_GetObstacleCount" },
        { 615, "SWMG_GetObstacle" },
        { 616, "SWMG_GetHitPoints" },
        { 617, "SWMG_GetMaxHitPoints" },
        { 618, "SWMG_SetMaxHitPoints" },
        { 619, "SWMG_GetSphereRadius" },
        { 620, "SWMG_SetSphereRadius" },
        { 621, "SWMG_GetNumLoops" },
        { 622, "SWMG_SetNumLoops" },
        { 623, "SWMG_GetPosition" },
        { 624, "SWMG_GetGunBankCount" },
        { 625, "SWMG_GetGunBankBulletModel" },
        { 626, "SWMG_GetGunBankGunModel" },
        { 627, "SWMG_GetGunBankDamage" },
        { 628, "SWMG_GetGunBankTimeBetweenShots" },
        { 629, "SWMG_GetGunBankLifespan" },
        { 630, "SWMG_GetGunBankSpeed" },
        { 631, "SWMG_GetGunBankTarget" },
        { 632, "SWMG_SetGunBankBulletModel" },
        { 633, "SWMG_SetGunBankGunModel" },
        { 634, "SWMG_SetGunBankDamage" },
        { 635, "SWMG_SetGunBankTimeBetweenShots" },
        { 636, "SWMG_SetGunBankLifespan" },
        { 637, "SWMG_SetGunBankSpeed" },
        { 638, "SWMG_SetGunBankTarget" },
        { 639, "SWMG_GetLastBulletHitPart" },
        { 640, "SWMG_IsGunBankTargetting" },
        { 641, "SWMG_GetPlayerOffset" },
        { 642, "SWMG_GetPlayerInvincibility" },
        { 643, "SWMG_GetPlayerSpeed" },
        { 644, "SWMG_GetPlayerMinSpeed" },
        { 645, "SWMG_GetPlayerAccelerationPerSecond" },
        { 646, "SWMG_GetPlayerTunnelPos" },
        { 647, "SWMG_SetPlayerOffset" },
        { 648, "SWMG_SetPlayerInvincibility" },
        { 649, "SWMG_SetPlayerSpeed" },
        { 650, "SWMG_SetPlayerMinSpeed" },
        { 651, "SWMG_SetPlayerAccelerationPerSecond" },
        { 652, "SWMG_SetPlayerTunnelPos" },
        { 653, "SWMG_GetPlayerTunnelNeg" },
        { 654, "SWMG_SetPlayerTunnelNeg" },
        { 655, "SWMG_GetPlayerOrigin" },
        { 656, "SWMG_SetPlayerOrigin" },
        { 657, "SWMG_GetGunBankHorizontalSpread" },
        { 658, "SWMG_GetGunBankVerticalSpread" },
        { 659, "SWMG_GetGunBankSensingRadius" },
        { 660, "SWMG_GetGunBankInaccuracy" },
        { 661, "SWMG_SetGunBankHorizontalSpread" },
        { 662, "SWMG_SetGunBankVerticalSpread" },
        { 663, "SWMG_SetGunBankSensingRadius" },
        { 664, "SWMG_SetGunBankInaccuracy" },
        { 665, "SWMG_GetIsInvulnerable" },
        { 666, "SWMG_StartInvulnerability" },
        { 667, "SWMG_GetPlayerMaxSpeed" },
        { 668, "SWMG_SetPlayerMaxSpeed" },
        { 669, "AddJournalWorldEntry" },
        { 670, "AddJournalWorldEntryStrref" },
        { 671, "BarkString" },
        { 672, "DeleteJournalWorldAllEntries" },
        { 673, "DeleteJournalWorldEntry" },
        { 674, "DeleteJournalWorldEntryStrref" },
        { 675, "EffectForceDrain" },
        { 676, "EffectPsychicStatic" },
        { 677, "PlayVisualAreaEffect" },
        { 678, "SetJournalQuestEntryPicture" },
        { 679, "GetLocalBoolean" },
        { 680, "SetLocalBoolean" },
        { 681, "GetLocalNumber" },
        { 682, "SetLocalNumber" },
        { 683, "SWMG_GetSoundFrequency" },
        { 684, "SWMG_SetSoundFrequency" },
        { 685, "SWMG_GetSoundFrequencyIsRandom" },
        { 686, "SWMG_SetSoundFrequencyIsRandom" },
        { 687, "SWMG_GetSoundVolume" },
        { 688, "SWMG_SetSoundVolume" },
        { 689, "SoundObjectGetPitchVariance" },
        { 690, "SoundObjectSetPitchVariance" },
        { 691, "SoundObjectGetVolume" },
        { 692, "GetGlobalLocation" },
        { 693, "SetGlobalLocation" },
        { 694, "AddAvailableNPCByObject" },
        { 695, "RemoveAvailableNPC" },
        { 696, "IsAvailableCreature" },
        { 697, "AddAvailableNPCByTemplate" },
        { 698, "SpawnAvailableNPC" },
        { 699, "IsNPCPartyMember" },
        { 700, "ActionBarkString" },
        { 701, "GetIsConversationActive" },
        { 702, "EffectLightsaberThrow" },
        { 703, "EffectWhirlWind" },
        { 704, "GetPartyAIStyle" },
        { 705, "GetNPCAIStyle" },
        { 706, "SetPartyAIStyle" },
        { 707, "SetNPCAIStyle" },
        { 708, "SetNPCSelectability" },
        { 709, "GetNPCSelectability" },
        { 710, "ClearAllEffects" },
        { 711, "GetLastConversation" },
        { 712, "ShowPartySelectionGUI" },
        { 713, "GetStandardFaction" },
        { 714, "GivePlotXP" },
        { 715, "GetMinOneHP" },
        { 716, "SetMinOneHP" },
        { 717, "SWMG_GetPlayerTunnelInfinite" },
        { 718, "SWMG_SetPlayerTunnelInfinite" },
        { 719, "SetGlobalFadeIn" },
        { 720, "SetGlobalFadeOut" },
        { 721, "GetLastHostileTarget" },
        { 722, "GetLastAttackAction" },
        { 723, "GetLastForcePowerUsed" },
        { 724, "GetLastCombatFeatUsed" },
        { 725, "GetLastAttackResult" },
        { 726, "GetWasForcePowerSuccessful" },
        { 727, "GetFirstAttacker" },
        { 728, "GetNextAttacker" },
        { 729, "SetFormation" },
        { 730, "ActionFollowLeader" },
        { 731, "SetForcePowerUnsuccessful" },
        { 732, "GetIsDebilitated" },
        { 733, "PlayMovie" },
        { 734, "SaveNPCState" },
        { 735, "GetCategoryFromTalent" },
        { 736, "SurrenderByFaction" },
        { 737, "ChangeFactionByFaction" },
        { 738, "PlayRoomAnimation" },
        { 739, "ShowGalaxyMap" },
        { 740, "SetPlanetSelectable" },
        { 741, "GetPlanetSelectable" },
        { 742, "SetPlanetAvailable" },
        { 743, "GetPlanetAvailable" },
        { 744, "GetSelectedPlanet" },
        { 745, "SoundObjectFadeAndStop" },
        { 746, "SetAreaFogColor" },
        { 747, "ChangeItemCost" },
        { 748, "GetIsLiveContentAvailable" },
        { 749, "ResetDialogState" },
        { 750, "SetGoodEvilValue" },
        { 751, "GetIsPoisoned" },
        { 752, "GetSpellTarget" },
        { 753, "SetSoloMode" },
        { 754, "EffectCutSceneHorrified" },
        { 755, "EffectCutSceneParalyze" },
        { 756, "EffectCutSceneStunned" },
        { 757, "CancelPostDialogCharacterSwitch" },
        { 758, "SetMaxHitPoints" },
        { 759, "NoClicksFor" },
        { 760, "HoldWorldFadeInForDialog" },
        { 761, "ShipBuild" },
        { 762, "SurrenderRetainBuffs" },
        { 763, "SuppressStatusSummaryEntry" },
        { 764, "GetCheatCode" },
        { 765, "SetMusicVolume" },
        { 766, "CreateItemOnFloor" },
        { 767, "SetAvailableNPCId" },
        { 768, "GetScriptParameter" },
        { 769, "SetFadeUntilScript" },
        { 770, "EffectForceBody" },
        { 771, "GetItemComponent" },
        { 773, "ShowChemicalUpgradeScreen" },
        { 774, "GetChemicals" },
        { 775, "GetChemicalPieceValue" },
        { 776, "GetSpellForcePointCost" },
        { 777, "EffectFury" },
        { 778, "EffectBlind" },
        { 779, "EffectFPRegenModifier" },
        { 780, "EffectVPRegenModifier" },
        { 781, "EffectCrush" },
        { 782, "SWMG_GetSwoopUpgrade" },
        { 783, "GetFeatAcquired" },
        { 784, "GetSpellAcquired" },
        { 785, "ShowSwoopUpgradeScreen" },
        { 786, "GrantFeat" },
        { 787, "GrantSpell" },
        { 788, "SpawnMine" },
        { 789, "SWMG_GetTrackPosition" },
        { 790, "SWMG_SetFollowerPosition" },
        { 791, "SetFakeCombatState" },
        { 792, "SWMG_DestroyMiniGameObject" },
        { 793, "GetOwnerDemolitionsSkill" },
        { 794, "SetOrientOnClick" },
        { 795, "GetInfluence" },
        { 796, "SetInfluence" },
        { 797, "ModifyInfluence" },
        { 798, "GetRacialSubType" },
        { 799, "IncrementGlobalNumber" },
        { 800, "DecrementGlobalNumber" },
        { 801, "SetBonusForcePoints" },
        { 802, "AddBonusForcePoints" },
        { 803, "GetBonusForcePoints" },
        { 804, "SWMG_SetJumpSpeed" },
        { 805, "IsMoviePlaying" },
        { 806, "QueueMovie" },
        { 807, "PlayMovieQueue" },
        { 808, "YavinHackDoorClose" },
        { 809, "EffectDroidConfused" },
        { 810, "IsStealthed" },
        { 811, "IsMeditating" },
        { 812, "IsInTotalDefense" },
        { 813, "SetHealTarget" },
        { 814, "GetHealTarget" },
        { 815, "GetRandomDestination" },
        { 816, "IsFormActive" },
        { 817, "GetSpellFormMask" },
        { 818, "GetSpellBaseForcePointCost" },
        { 819, "SetKeepStealthInDialog" },
        { 820, "HasLineOfSight" },
        { 821, "ShowDemoScreen" },
        { 822, "ForceHeartbeat" },
        { 823, "EffectForceSight" },
        { 824, "IsRunning" },
        { 825, "SWMG_PlayerApplyForce" },
        { 826, "SetForfeitConditions" },
        { 827, "GetLastForfeitViolation" },
        { 828, "ModifyReflexSavingThrowBase" },
        { 829, "ModifyFortitudeSavingThrowBase" },
        { 830, "ModifyWillSavingThrowBase" },
        { 831, "GetScriptStringParameter" },
        { 832, "GetObjectPersonalSpace" },
        { 833, "AdjustCreatureAttributes" },
        { 834, "SetCreatureAILevel" },
        { 835, "ResetCreatureAILevel" },
        { 836, "AddAvailablePUPByTemplate" },
        { 837, "AddAvailablePUPByObject" },
        { 838, "AssignPUP" },
        { 839, "SpawnAvailablePUP" },
        { 840, "AddPartyPuppet" },
        { 841, "GetPUPOwner" },
        { 842, "GetIsPuppet" },
        { 843, "ActionFollowOwner" },
        { 844, "GetIsPartyLeader" },
        { 845, "GetPartyLeader" },
        { 846, "RemoveNPCFromPartyToBase" },
        { 847, "CreatureFlourishWeapon" },
        { 848, "EffectMindTrick" },
        { 849, "EffectFactionModifier" },
        { 850, "ChangeObjectAppearance" },
        { 851, "GetIsXBox" },
        { 852, "EffectDroidScramble" },
        { 853, "ActionSwitchWeapons" },
        { 854, "PlayOverlayAnimation" },
        { 855, "UnlockAllSongs" },
        { 856, "DisableMap" },
        { 857, "DetonateMine" },
        { 858, "DisableHealthRegen" },
        { 859, "SetCurrentForm" },
        { 860, "SetDisableTransit" },
        { 861, "SetInputClass" },
        { 862, "SetForceAlwaysUpdate" },
        { 866, "RemoveHeartbeat" },
        { 869, "AdjustCreatureSkills" },
        { 870, "GetSkillRankBase" },
        { 871, "EnableRendering" },
        { 872, "GetCombatActionsPending" },
        { 873, "SaveNPCByObject" },
        { 874, "SavePUPByObject" },
        { 875, "GetIsPlayerMadeCharacter" },
        { 876, "RebuildPartyTable" }
    };
}
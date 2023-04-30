using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace ShelterTemperatureTweaks
{
    class Patches
    {
        // For locations with IndoorSpaceTrigger
        [HarmonyPatch(typeof(IndoorSpaceTrigger), "OnTriggerEnter")]
        internal class ChangeIndoorSpaceTrigger
        {
            private static void Postfix(IndoorSpaceTrigger __instance)
            {
                string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

                // Ash Canyon - NONE
                
                // Bleak Inlet
                if (__instance.m_TriggerID == "AbandonedLookout" && sceneName == "CanneryRegion")
                {
                    if (Settings.settings.lookouts)
                    {
                        if (Settings.settings.lookoutsOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsFixedTemp +1;
                        }
                    }
                    else if (Settings.settings.pensiveLookout)
                    {
                        if (Settings.settings.pensiveLookoutOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.pensiveLookoutBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.pensiveLookoutFixedTemp +1;
                        }
                    }
                    else
                    {
                        __instance.m_UseOutdoorTemperature = false;
                        __instance.m_TemperatureDeltaCelsius = 0;
                    }
                }
                else if (__instance.name == "EnclosedWarehouseSpace" && sceneName == "CanneryRegion")
                {
                    __instance.m_TemperatureDeltaCelsius = Settings.settings.enclosedWarehouseSpaceBonus;
                }
                else if (__instance.name == "WarehouseSupervisorRoom" && sceneName == "CanneryRegion") 
                {
                    __instance.m_TemperatureDeltaCelsius = Settings.settings.warehouseSupervisorRoomBonus;
                }
                else if (__instance.name == "WorkshopThresholdRooms" && sceneName == "CanneryRegion")
                {
                    __instance.m_TemperatureDeltaCelsius = Settings.settings.workshopThresholdRoomsBonus;
                }

                // Broken Railroad
                else if (__instance.name == "ShedExteriorIndoorSpace" && sceneName == "TracksRegion")
                {
                    __instance.m_TemperatureDeltaCelsius = 8;
                    if (Settings.settings.maintenanceShed)
                    {
                        __instance.m_TemperatureDeltaCelsius = Settings.settings.maintenanceShedBonus;
                    }
                }

                // Coastal Highway
                else if (__instance.m_TriggerID == "AbandonedLookout" && sceneName == "CoastalRegion")
                {
                    if (Settings.settings.lookouts)
                    {
                        if (Settings.settings.lookoutsOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsFixedTemp +3;
                        }
                    }
                    else if (Settings.settings.abandonedLookout)
                    {
                        if (Settings.settings.abandonedLookoutOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.abandonedLookoutBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.abandonedLookoutFixedTemp +3;
                        }
                    }
                    else
                    {
                        __instance.m_UseOutdoorTemperature = false;
                        __instance.m_TemperatureDeltaCelsius = 0;
                    }
                }

                // Desolation Point - NONE

                // Forlorn Muskeg - NONE

                // Hushed River Valley - NONE

                // Mountain Town
                else if (sceneName == "MountainTownRegion" && __instance.name == "TRIGGER_indoorspace(1)")
                {
                    __instance.m_TemperatureDeltaCelsius = 3;
                    {
                        if (Settings.settings.parkOffice)
                        {
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.parkOfficeBonus;
                        }
                    }
                }
                
                // Mystery Lake
                else if (__instance.m_TriggerID == "ForestryLookout" && sceneName == "LakeRegion")
                {
                    if (Settings.settings.lookouts)
                    {
                        if (Settings.settings.lookoutsOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.lookoutsFixedTemp +5;
                        }
                    }
                    else if (Settings.settings.forestryLookout)
                    {
                        if (Settings.settings.forestryLookoutOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.forestryLookoutBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.forestryLookoutFixedTemp +5;
                        }
                    }
                    else
                    {
                        __instance.m_UseOutdoorTemperature = false;
                        __instance.m_TemperatureDeltaCelsius = 0;
                    }
                }

                // Old Island Connector - NONE

                // Pleasant Valley
                else if (__instance.name == "IndoorSpace" && sceneName == "RuralRegion")
                {
                    if (Settings.settings.farmhousePorch)
                    {
                        if (Settings.settings.farmhousePorchOutdoors)
                        {
                            __instance.m_UseOutdoorTemperature = true;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.farmhousePorchBonus;
                        }
                        else
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.farmhousePorchFixedTemp + 5;
                        }
                    }
                    else
                    {
                        __instance.m_UseOutdoorTemperature = false;
                        __instance.m_TemperatureDeltaCelsius = 8;
                    }
                }

                // Ravine - NONE

                // Timberwolf Mountain
                else if (__instance.m_TriggerID == "CrashMountaineersLodge" && sceneName == "CrashMountainRegion")
                {
                    __instance.m_UseOutdoorTemperature = true;
                    __instance.m_TemperatureDeltaCelsius = 10;
                    if (Settings.settings.mountaineersHut)
                    {
                        __instance.m_TemperatureDeltaCelsius = Settings.settings.mountaineersHutBonus;
                        if (Settings.settings.mountaineersHutIndoors)
                        {
                            __instance.m_UseOutdoorTemperature = false;
                            __instance.m_TemperatureDeltaCelsius = Settings.settings.mountaineersHutFixedTemp + 5;
                        }
                    }
                }

                // Winding River - NONE

                // All Regions
                else if (GameManager.IsOutDoorsScene(GameManager.m_ActiveScene) && sceneName != "DamTransitionZone")
                {
                    __instance.m_TemperatureDeltaCelsius = 8;
                    if (Settings.settings.caves)
                    {
                        __instance.m_TemperatureDeltaCelsius = Settings.settings.caveBonus;
                    }
                }
            }
        }



        // For locations with IncreaseTemperatureTrigger
        [HarmonyPatch(typeof(IncreaseTemperatureTrigger), "OnTriggerEnter")]
        internal class ChangeIncreaseTemperatureTrigger
        {
            private static bool Prefix(IncreaseTemperatureTrigger __instance)
            {
                string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

                // Ash Canyon - NONE

                // Bleak Inlet - NONE

                // Broken Railroad - NONE

                // Coastal Highway
                if (sceneName == "CoastalRegion" && __instance.name == "TRIGGER_TemperatureIncrease")
                {
                    __instance.m_TempIncrease = 3;
                    if (Settings.settings.fishingHuts)
                    {
                        __instance.m_TempIncrease = Settings.settings.fishingHutsBonus;
                    }
                }

                // Desolation Point - NONE

                // Forlorn Muskeg
                else if (sceneName == "MarshRegion")
                {
                    IncreaseTemperatureTrigger workshop = GameObject.Find("Design/Workshop/TRIGGER_TemperatureIncrease")?.GetComponentInChildren<IncreaseTemperatureTrigger>();
                    if (__instance.name == "TRIGGER_ParticleKiller_RailCar")
                    {
                        __instance.m_TempIncrease = 2;
                        if (Settings.settings.railCar)
                        {
                            __instance.m_TempIncrease = Settings.settings.railCarBonus;
                        }
                    }
                    else if (__instance == workshop)
                    {
                        __instance.m_TempIncrease = 3;
                        if (Settings.settings.workshop)
                        {
                            __instance.m_TempIncrease = Settings.settings.workshopBonus;
                        }
                    }
                }

                // Hushed River Valley - NONE

                // Mountain Town
                else if (sceneName == "MountainTownRegion")
                {
                    if (__instance.name == "TRIGGER_TemperatureIncrease_BowlCave")
                    {
                        __instance.m_TempIncrease = 3;
                        if (Settings.settings.bowlCave)
                        {
                            __instance.m_TempIncrease = Settings.settings.bowlCaveBonus;
                        }
                    }
                    /*
                    if (__instance.name == "TRIGGER_TemperatureIncrease_RavineCave")
                    {
                        __instance.m_TempIncrease = 8;
                        if (Settings.settings.ravineCave)
                        {
                            __instance.m_TempIncrease = Settings.settings.ravineCaveBonus;
                        }
                    }
                    if (__instance.name == "TRIGGER_TemperatureIncrease_BasinCave")
                    {
                        __instance.m_TempIncrease = 8;
                        if (Settings.settings.basinCave)
                        {
                            __instance.m_TempIncrease = Settings.settings.basinCaveBonus;
                        }
                    }
                    */
                }

                // Mystery Lake
                else if (sceneName == "LakeRegion" && __instance.name == "TRIGGER_TemperatureIncrease")
                {
                    IncreaseTemperatureTrigger hut1 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts1/STRSPAWN_FishingCabinDoor_fresh_Prefab/Tech/TRIGGER_TemperatureIncrease")?.GetComponentInChildren<IncreaseTemperatureTrigger>();
                    IncreaseTemperatureTrigger hut2 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts2/STRSPAWN_FishingCabinDoor_fresh_Prefab/Tech/TRIGGER_TemperatureIncrease")?.GetComponentInChildren<IncreaseTemperatureTrigger>();
                    IncreaseTemperatureTrigger hut3 = GameObject.Find("Design/RandomSpawnStructures/RanomFishHuts/FishHuts3/STRSPAWN_FishingCabinDoor_fresh_Prefab/Tech/TRIGGER_TemperatureIncrease")?.GetComponentInChildren<IncreaseTemperatureTrigger>();

                    if (__instance == hut1 || __instance == hut2 || __instance == hut3)
                    {
                        __instance.m_TempIncrease = 3;
                        if (Settings.settings.fishingHuts)
                        {
                            __instance.m_TempIncrease = Settings.settings.fishingHutsBonus;
                        }
                    } 
                }

                // Old Island Connector - NONE

                // Pleasant Valley
                else if (sceneName == "RuralRegion" && __instance.name == "TRIGGER_TemperatureIncrease")
                {
                    IncreaseTemperatureTrigger hut = GameObject.Find("Art/Structures_Group/Forest/STRSPAWN_FishingCabinDoor_fresh_Prefab/Tech/TRIGGER_TemperatureIncrease")?.GetComponentInChildren<IncreaseTemperatureTrigger>();
                    if (__instance == hut)
                    {
                        __instance.m_TempIncrease = 3;
                        if (Settings.settings.fishingHuts)
                        {
                            __instance.m_TempIncrease = Settings.settings.fishingHutsBonus;
                        }
                    }
                }

                // Ravine
                if (__instance.name == "TRIGGER_TemperatureIncrease_crummy" && sceneName == "RavineTransitionZone")
                {
                    __instance.m_TempIncrease = 2;
                    if (Settings.settings.crummy)
                    {
                        __instance.m_TempIncrease = Settings.settings.crummyBonus;
                    }
                }


                // Timberwolf Mountain
                else if (sceneName == "CrashMountainRegion")
                {
                    if (__instance.name == "TRIGGER_TemperatureIncrease_BigCave")
                    {
                        __instance.m_TempIncrease = 8;
                        if (Settings.settings.bigCave)
                        {
                            __instance.m_TempIncrease = Settings.settings.bigCaveBonus;
                        }
                    }
                    if (__instance.name == "TRIGGER_TemperatureIncrease_MountainCave")
                    {
                        __instance.m_TempIncrease = 3;
                        if (Settings.settings.mountainCave)
                        {
                            __instance.m_TempIncrease = Settings.settings.mountainCaveBonus;
                        }
                    }
                    if (__instance.name == "TRIGGER_TemperatureIncrease_plane")
                    {
                        __instance.m_TempIncrease = 5;
                        if (Settings.settings.tailSection) 
                        {
                            __instance.m_TempIncrease = Settings.settings.tailSectionBonus;
                        }
                    }
                }

                // Winding River - NONE

                return true;
            }
        }
    }
}

using ModSettings;
using System.Reflection;

namespace ShelterTemperatureTweaks
{
    internal class ShelterTemperatureTweaksSettings : JsonModSettings
    {
        //All Regions
        [Section("All Regions")]

        [Name("Tweak Cave Temperatures")]
        [Description("This is for the majority of OUTDOOR caves")]
        public bool caves = false;

        [Name("    Cave Temperature Bonus")]
        [Description("How much warmer caves are than the outdoor temperature. Game default is +8°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float caveBonus = 8;


        [Name("Tweak Fishing Hut Temperatures")]
        [Description("This is only for Fishing Huts WITH DOORS")]
        public bool fishingHuts = false;

        [Name("    Fishing Hut Temperature Bonus")]
        [Description("How much warmer the Fishing Huts are than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float fishingHutsBonus = 3;


        [Name("Tweak ALL Lookout Temperatures")]
        [Description("Use this setting to change ALL Lookouts at once. Setting to NO allows separate settings for each Lookout under their Region headings")]
        public bool lookouts = false;

        [Name("    DISABLE Fixed Interior Temperature")]
        [Description("By default, Lookouts have a fixed interior temperature. Set to YES to make Lookout temperatures dependent on the outdoor temperature")]
        public bool lookoutsOutdoors = false;

        [Name("    Fixed Interior Temperature")]
        [Description("Change the fixed interior temperature for Lookouts")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float lookoutsFixedTemp = 0;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Lookout is than the outdoor temperature")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float lookoutsBonus = 10;


        // Toggle Regions
        [Section("Show Individual Location Options")]
        [Name("These options contain location spoilers!")]
        [Description("Show temperature settings for individual locations, sorted by Region")]
        public bool spoilers = false;

        // Ash Canyon - NONE

        // Bleak Inlet
        [Section("Bleak Inlet")]

        [Name("Tweak Break Room Temperature")]
        [Description("This is the ground floor room around the back of the warehouse with the rope climb")]
        public bool warehouseSupervisorRoom = false;

        [Name("    Break Room Temperature Bonus")]
        [Description("How much warmer the Break Room is than the outdoor temperature. Game default is +8°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float warehouseSupervisorRoomBonus = 8;


        [Name("Tweak Pensive Lookout Temperature")]
        [Description("This is the Lookout in Bleak Inlet")]
        public bool pensiveLookout = false;

        [Name("    DISABLE Fixed Interior Temperature")]
        [Description("By default, the Lookout has a fixed interior temperature. Set to YES to make the Lookout temperature dependent on the outdoor temperature")]
        public bool pensiveLookoutOutdoors = false;

        [Name("    Fixed Interior Temperature")]
        [Description("Change the fixed interior temperature for the Lookout. Game default is -1°C")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float pensiveLookoutFixedTemp = -1;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Lookout is than the outdoor temperature")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float pensiveLookoutBonus = 0;


        [Name("Tweak Warehouse Temperature")]
        [Description("This is the warehouse only accessible via the rope climb path, past the boat")]
        public bool enclosedWarehouseSpace = false;

        [Name("    Warehouse Temperature Bonus")]
        [Description("How much warmer the Warehouse is than the outdoor temperature. Game default is +4°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float enclosedWarehouseSpaceBonus = 4;


        [Name("Tweak Workshop Exterior Temperature")]
        [Description("These are the rooms outside the Ammunition Workshop")]
        public bool workshopThresholdRooms = false;

        [Name("    Workshop Exterior Temperature Bonus")]
        [Description("How much warmer the Workshop exterior rooms are than the outdoor temperature. Game default is +8°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float workshopThresholdRoomsBonus = 8;


        //Broken Railroad
        [Section("Broken Railroad")]

        [Name("Tweak Maintenance Shed Temperature")]
        [Description("This is the open EXTERIOR section of the Maintenance Shed")]
        public bool maintenanceShed = false;

        [Name("    Maintenance Shed Temperature Bonus")]
        [Description("How much warmer the Maintenance Shed exterior section is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float maintenanceShedBonus = 3;


        // Coastal Highway
        [Section("Coastal Highway")]

        [Name("Tweak Abandoned Lookout Temperature")]
        [Description("This is the Lookout in Coastal Highway")]
        public bool abandonedLookout = false;

        [Name("    DISABLE Fixed Interior Temperature")]
        [Description("By default, the Lookout has a fixed interior temperature. Set to YES to make the Lookout temperature dependent on the outdoor temperature")]
        public bool abandonedLookoutOutdoors = false;

        [Name("    Fixed Interior Temperature")]
        [Description("Change the fixed interior temperature for the Lookout. Game default is -3°C")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float abandonedLookoutFixedTemp = -3;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Lookout is than the outdoor temperature")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float abandonedLookoutBonus = 0;

        // Desolation Point - NONE

        // Forlorn Muskeg
        [Section("Forlorn Muskeg")]

        [Name("Tweak Rail Car Temperature")]
        [Description("This is the Rail Car at the Poacher's Camp")]
        public bool railCar = false;

        [Name("    Rail Car Temperature Bonus")]
        [Description("How much warmer the Rail Car is than the outdoor temperature. Game default is +2°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float railCarBonus = 2;


        [Name("Tweak Workshop Temperature")]
        [Description("This is the back of the shed with the forge at Old Spence Family Homestead")]
        public bool workshop = false;

        [Name("    Workshop Temperature Bonus")]
        [Description("How much warmer the Workshop is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float workshopBonus = 3;

        // Hushed River Valley - NONE

        //Mountain Town
        [Section("Mountain Town")]

        [Name("Tweak Crash Cave Temperature")]
        [Description("This is the cave below Mackenzie's crashed plane")]
        public bool bowlCave = false;

        [Name("    Crash Cave Temperature Bonus")]
        [Description("How much warmer the Crash Cave is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float bowlCaveBonus = 3;

        /*
        [Name("Basin Cave Temperature")]
        [Description("???")]
        public bool basinCave = false;

        [Name("    Basin Cave Temperature Bonus")]
        [Description("How much warmer the Basin Cave is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float basinCaveBonus = 3;
        */

        [Name("Tweak Park Office Temperature")]
        [Description("This is the small open building in Milton Park")]
        public bool parkOffice = false;

        [Name("    Park Office Temperature Bonus")]
        [Description("How much warmer the Park Office is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float parkOfficeBonus = 3;

        /*
        [Name("Ravine Cave Temperature")]
        [Description("???")]
        public bool ravineCave = false;

        [Name("    Basin Cave Temperature Bonus")]
        [Description("How much warmer the Basin Cave is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float ravineCaveBonus = 3;
        */

        // Mystery Lake
        [Section("Mystery Lake")]

        [Name("Tweak Foresty Lookout Temperature")]
        [Description("This is the intact Lookout in Mystery Lake")]
        public bool forestryLookout = false;

        [Name("    DISABLE Fixed Interior Temperature")]
        [Description("By default, the Lookout has a fixed interior temperature. Set to YES to make the Lookout temperature dependent on the outdoor temperature.")]
        public bool forestryLookoutOutdoors = false;

        [Name("    Fixed Interior Temperature")]
        [Description("Change the fixed interior temperature for the Lookout. Game default is -5°C")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float forestryLookoutFixedTemp = -5;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Lookout is than the outdoor temperature")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float forestryLookoutBonus = 10;


        // Pleasant Valley
        [Section("Pleasant Valley")]

        [Name("Tweak Farmhouse Porch Temperature")]
        [Description("This is the enclosed porch on the side of the Farmhouse")]
        public bool farmhousePorch = false;

        [Name("    DISABLE Fixed Interior Temperature")]
        [Description("By default, the Farmhouse Porch has a fixed interior temperature. Set to YES to make the Farmhouse Porch temperature dependent on the outdoor temperature.")]
        public bool farmhousePorchOutdoors = false;

        [Name("    Fixed Interior Temperature")]
        [Description("Change the fixed interior temperature for the Farmhouse Porch. Game default is 3°C")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float farmhousePorchFixedTemp = 3;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Farmhouse Porch is than the outdoor temperature")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float farmhousePorchBonus = 10;


        // Ravine
        [Section("Raven Falls Railway Line (Ravine)")]

        [Name("Tweak Yellow Carriage Temperature")]
        [Description("This is the yellow train carriage in the Ravine Basin")]
        public bool crummy = false;

        [Name("    Yellow Carriage Temperature Bonus")]
        [Description("How much warmer the Yellow Carriage is than the outdoor temperature. Game default is +2°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float crummyBonus = 2;


        // Timberwolf Mountain
        [Section("TimberWolf Mountain")]

        [Name("Tweak Big Cave Temperature")]
        [Description("This is the large open cave with 3 entrances")]
        public bool bigCave = false;

        [Name("    Mountain Cave Temperature Bonus")]
        [Description("How much warmer the Mountain Cave is than the outdoor temperature. Game default is +8°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float bigCaveBonus = 8;

        [Name("Tweak Mountain Cave Temperature")]
        [Description("This is the shallow cave below the summit")]
        public bool mountainCave = false;

        [Name("    Mountain Cave Temperature Bonus")]
        [Description("How much warmer the Mountain Cave is than the outdoor temperature. Game default is +3°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float mountainCaveBonus = 3;


        [Name("Tweak Mountaineer's Hut Temperature")]
        [Description("This is the stone cabin on Crystal Lake")]
        public bool mountaineersHut = false;

        [Name("    ENABLE Fixed Interior Temperature")]
        [Description("If set to YES the Hut will have a fixed interior temperature like other indoor locations")]
        public bool mountaineersHutIndoors = false;

        [Name("    Interior Temperature Bonus")]
        [Description("How much warmer the Hut is than the outdoor temperature. Game default is +10°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float mountaineersHutBonus = 10;

        [Name("    Fixed Interior Temperature")]
        [Description("Set a fixed interior temperature for the Hut")]
        [Slider(-25f, 5f, 31, NumberFormat = "{0:0.##}°C")]
        public float mountaineersHutFixedTemp = 0;


        [Name("Tweak Tail Section Temperature")]
        [Description("This is the Tail Section of the crashed plane on the Summit")]
        public bool tailSection = false;

        [Name("    Tail Section Temperature Bonus")]
        [Description("How much warmer the Tail Section is than the outdoor temperature. Game default is +5°C")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##}°C")]
        public float tailSectionBonus = 5;

        // Winding River - NONE


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(caves) || field.Name == nameof(fishingHuts) || field.Name == nameof(lookouts) || field.Name == nameof(lookoutsOutdoors) || field.Name == nameof(spoilers) || 
                field.Name == nameof(enclosedWarehouseSpace) || field.Name == nameof(pensiveLookout) || field.Name == nameof(pensiveLookoutOutdoors) || field.Name == nameof(warehouseSupervisorRoom) || field.Name == nameof(workshopThresholdRooms) ||
                field.Name == nameof(maintenanceShed) || 
                field.Name == nameof(abandonedLookout) || field.Name == nameof(abandonedLookoutOutdoors) || 
                field.Name == nameof(bowlCave) || field.Name == nameof(parkOffice) || //field.Name == nameof(basinCave) ||  || field.Name == nameof(ravineCave) ||
                field.Name == nameof(forestryLookout) || field.Name == nameof(forestryLookoutOutdoors) ||
                field.Name == nameof(workshop) || field.Name == nameof(railCar) ||
                field.Name == nameof(farmhousePorch) || field.Name == nameof(farmhousePorchOutdoors) ||
                field.Name == nameof(crummy) ||
                field.Name == nameof(bigCave) || field.Name == nameof(mountainCave) || field.Name == nameof(mountaineersHut) || field.Name == nameof(mountaineersHutIndoors) || field.Name == nameof(tailSection))
            {
                RefreshFields();
            }
        }
        internal void RefreshFields()
        {
            // All regions
            SetFieldVisible(nameof(caveBonus), caves);
            SetFieldVisible(nameof(fishingHutsBonus), fishingHuts);
            SetFieldVisible(nameof(lookoutsOutdoors), lookouts);
            SetFieldVisible(nameof(lookoutsFixedTemp), lookouts && !lookoutsOutdoors);
            SetFieldVisible(nameof(lookoutsBonus), lookouts && lookoutsOutdoors);

            // Ash Canyon - NONE

            // Bleak Inlet
            SetFieldVisible(nameof(warehouseSupervisorRoom), spoilers);
            SetFieldVisible(nameof(warehouseSupervisorRoomBonus), warehouseSupervisorRoom && spoilers);

            SetFieldVisible(nameof(pensiveLookout), spoilers);
            SetFieldVisible(nameof(pensiveLookoutOutdoors), pensiveLookout && spoilers);
            SetFieldVisible(nameof(pensiveLookoutFixedTemp), pensiveLookout && !pensiveLookoutOutdoors && spoilers);
            SetFieldVisible(nameof(pensiveLookoutBonus), pensiveLookout && pensiveLookoutOutdoors && spoilers);

            SetFieldVisible(nameof(enclosedWarehouseSpace), spoilers);
            SetFieldVisible(nameof(enclosedWarehouseSpaceBonus), enclosedWarehouseSpace && spoilers);

            SetFieldVisible(nameof(workshopThresholdRooms), spoilers);
            SetFieldVisible(nameof(workshopThresholdRoomsBonus), workshopThresholdRooms && spoilers);

            // Broken Railroad
            SetFieldVisible(nameof(maintenanceShed), spoilers);
            SetFieldVisible(nameof(maintenanceShedBonus), maintenanceShed && spoilers);

            // Coastal Highway
            SetFieldVisible(nameof(abandonedLookout), spoilers);
            SetFieldVisible(nameof(abandonedLookoutOutdoors), abandonedLookout && spoilers);
            SetFieldVisible(nameof(abandonedLookoutFixedTemp), abandonedLookout && !abandonedLookoutOutdoors && spoilers);
            SetFieldVisible(nameof(abandonedLookoutBonus), abandonedLookout && abandonedLookoutOutdoors && spoilers);

            // Desolation Point - NONE

            // Forlorn Muskeg
            SetFieldVisible(nameof(workshop), spoilers);
            SetFieldVisible(nameof(workshopBonus), workshop && spoilers);

            SetFieldVisible(nameof(railCar), spoilers);
            SetFieldVisible(nameof(railCarBonus), railCar && spoilers);

            // Hushed River Valley - NONE

            // Mountain Town
            SetFieldVisible(nameof(bowlCave), spoilers);
            SetFieldVisible(nameof(bowlCaveBonus), bowlCave && spoilers);

            SetFieldVisible(nameof(parkOffice), spoilers);
            SetFieldVisible(nameof(parkOfficeBonus), parkOffice && spoilers);

            /*
            SetFieldVisible(nameof(basinCave), spoilers);
            SetFieldVisible(nameof(basinCaveBonus), basinCave && spoilers);

            SetFieldVisible(nameof(ravineCave), spoilers);
            SetFieldVisible(nameof(ravineCaveBonus), ravineCave && spoilers);
            */

            // Mystery Lake
            SetFieldVisible(nameof(forestryLookout), spoilers);
            SetFieldVisible(nameof(forestryLookoutOutdoors), forestryLookout && spoilers);
            SetFieldVisible(nameof(forestryLookoutFixedTemp), forestryLookout && !forestryLookoutOutdoors && spoilers);
            SetFieldVisible(nameof(forestryLookoutBonus), forestryLookout && forestryLookoutOutdoors && spoilers);

            // Old Island Connector - NONE

            // Pleasant Valley
            SetFieldVisible(nameof(farmhousePorch), spoilers);
            SetFieldVisible(nameof(farmhousePorchOutdoors), farmhousePorch && spoilers);
            SetFieldVisible(nameof(farmhousePorchFixedTemp), farmhousePorch && !farmhousePorchOutdoors && spoilers);
            SetFieldVisible(nameof(farmhousePorchBonus), farmhousePorch && farmhousePorchOutdoors && spoilers);

            // Ravine
            SetFieldVisible(nameof(crummy), spoilers);
            SetFieldVisible(nameof(crummyBonus), crummy && spoilers);

            //Timberwolf Mountain
            SetFieldVisible(nameof(bigCave), spoilers);
            SetFieldVisible(nameof(bigCaveBonus), bigCave && spoilers);

            SetFieldVisible(nameof(mountainCave), spoilers);
            SetFieldVisible(nameof(mountainCaveBonus), mountainCave && spoilers);

            SetFieldVisible(nameof(mountaineersHut), spoilers);
            SetFieldVisible(nameof(mountaineersHutIndoors), mountaineersHut && spoilers);
            SetFieldVisible(nameof(mountaineersHutBonus), mountaineersHut && !mountaineersHutIndoors && spoilers);
            SetFieldVisible(nameof(mountaineersHutFixedTemp), mountaineersHut && mountaineersHutIndoors && spoilers);

            SetFieldVisible(nameof(tailSection), spoilers);
            SetFieldVisible(nameof(tailSectionBonus), tailSection && spoilers);

            // Winding River - NONE
        }
    }

    internal static class Settings
    {
        internal static ShelterTemperatureTweaksSettings settings;

        internal static void OnLoad()
        {
            settings = new ShelterTemperatureTweaksSettings();
            settings.RefreshFields();
            settings.AddToModSettings("Shelter Temperature Tweaks");
        }
    }
}

using MelonLoader;
using UnityEngine;

namespace ShelterTemperatureTweaks
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}

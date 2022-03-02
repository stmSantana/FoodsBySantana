using MelonLoader;
using UnityEngine;

namespace FoodsBySantana
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
        	//Debug.Log($"[{Info.Name}] Version {Info.Version} Loaded!");
            LoggerInstance.Msg($"Ver_ {BuildInfo.Version}");
        }
    }
}

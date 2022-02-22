using MelonLoader;
using UnityEngine;

namespace FoodsBySantana
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            //Settings.instance.AddToModSettings(BuildInfo.Name);
            LoggerInstance.Msg($"Ver_ {BuildInfo.Version}");
        }
    }
}

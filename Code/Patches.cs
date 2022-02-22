using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using HarmonyLib;

namespace FoodsBySantana
{
    //[HarmonyPatch(typeof(PlayerManager), "ProcessPickupItemInteraction")]
    public class Patches
    {
        [HarmonyPatch(typeof(GameManager),"Awake")]
        internal class GameManager_Awake
        {
            private static void Postfix()
            {
                MelonLoader.MelonLogger.Msg("Foods-By-Santana!");
            }
        }
    }
}

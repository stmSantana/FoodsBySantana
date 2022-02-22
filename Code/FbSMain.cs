using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using MelonLoader;

namespace FoodsBySantana
{
    internal class FbSMain : MelonMod
    {
        // pot texture
        public static bool loadedCookingTex;
        private static List<string> cookableGear = new List<string>();

        public override void OnSceneWasInitialized(int level, string name)
        {

            if (!loadedCookingTex) // adding pot cooking textures
            {
                cookableGear.Add("SoyRamen");
                cookableGear.Add("SoyRamenCooked");
                cookableGear.Add("CupNoodles"); // case-sensitive
                cookableGear.Add("CupNoodlesOpen");

                Material potMat;
                GameObject potGear;

                for (int i = 0; i < cookableGear.Count; i++)
                {
                    //potMat = new Material(Shader.Find("Shader Forge/TLD_Food_Liquid"));
                    potGear = Resources.Load("GEAR_" + cookableGear[i]).TryCast<GameObject>();
                    if (potGear == null) return;

                    potMat = new Material(Resources.Load("GEAR_CoffeeCup").TryCast<GameObject>().GetComponent<Cookable>().m_CookingPotMaterialsList[0]);
                    potMat.name = ("CKN_" + cookableGear[i] + "_MAT");
                    potMat.mainTexture = potGear.transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture;

                    potGear.GetComponent<Cookable>().m_CookingPotMaterialsList = new Material[1] { potMat };
                    // Debug // MelonLogger.Msg("potGear value====================1: " + potGear.name); 
                    // Debug // MelonLogger.Msg("potMat  value====================2: " + potMat.name); 

                }
                loadedCookingTex = true;
            }
        }
    }

}
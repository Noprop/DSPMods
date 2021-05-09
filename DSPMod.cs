using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace DysonSphereProgram
{
    /*public class MyPatcher
    {
        public static void DoPatching()
        {
            var harmony = new Harmony("com.noprop.plugins.DSPMod");
            harmony.PatchAll();
        }
    }*/

    [BepInPlugin("com.gregforster.plugins.DSPMod", "Example DSP Mod", "1.0.0.0")]
    public class DSPMod : BaseUnityPlugin
    {
        /*void Awake() {
            UnityEngine.Debug.Log("Hello, world!");
        }*/

        private Harmony harmony;

        internal void Awake()
        {
            Console.WriteLine("patching with harmony...");
            harmony = new Harmony("com.noprop.plugins.DSPMod");
            harmony.PatchAll();
        }

        /*[HarmonyPrefix, HarmonyPatch(typeof(DSPGame), "StartGameSkipPrologue")]
        public static void StartGameSkipPrologue(GameDesc _gameDesc)
        {
            Console.WriteLine("harmony injected into skip button");
            return;
        }*/
        /*[HarmonyPatch(typeof(DSPGame), "StartGameSkipPrologue")]
        class Patch
        {
            static bool Prefix(GameDesc _gameDesc)
            {
                Console.WriteLine("prologue patched");
                return false;
            }
        }*/

        [HarmonyPatch(typeof(PlayerAction_Build), "AddBuildPreview")]
        class Patch
        {
            static bool Prefix(BuildPreview bp)
            {
                Console.WriteLine("build preview patched");
                return false;
            }
        }
    }
}

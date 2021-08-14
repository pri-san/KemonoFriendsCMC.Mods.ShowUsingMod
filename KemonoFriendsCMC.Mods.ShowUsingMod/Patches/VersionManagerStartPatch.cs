using HarmonyLib;
using UnityEngine;

namespace KemonoFriendsCMC.Mods.ShowUsingMod.Patches
{
    [HarmonyPatch(typeof(VersionManager), "Start")]
    static class VersionManagerStartPatch
    {
        static void Postfix(VersionManager __instance)
        {
            __instance.mod.enabled = true;
            __instance.mod.text = "MOD(addon)";
            __instance.mod.faceColor = new Color32(255, 64, 64, 255);
        }
    }
}

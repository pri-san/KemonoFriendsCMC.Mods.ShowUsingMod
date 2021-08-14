using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace KemonoFriendsCMC.Mods.ShowUsingMod
{
    /// <summary>
    /// BepInExのパッチのエントリーポイント
    /// </summary>
    [BepInPlugin("KemonoFriendsCMC.Mods.ShowUsingMod", "ShowUsing Plug-In", "1.0.0.0")]
    public class EntryPoint : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("KemonoFriendsCMC.Mods.ShowUsingMod");
            harmony.PatchAll(); // ここでHarmonyによるモンキーパッチが実行される

            Debug.Log("KemonoFriendsCMC.Mods.ShowUsingMod Patch OK");
        }
    }
}

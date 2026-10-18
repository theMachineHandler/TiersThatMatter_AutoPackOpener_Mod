//////////////////////////////
//    AutoPackOpener Mod    //
//   by theMachineHandler   //
//           2026           //
//                          //
//   Reduces the time all   //
//    tiers of auto pack    //
//  opening machines spend  //
//  working to just 4 min.  //
//    (at max. capacity)    //
//////////////////////////////

using BepInEx;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("theMachineHandler.autopackopenermod", "TiersThatMatter - AutoPackOpener Mod", "1.0.0")]
public class AutoPackOpenerMod : BaseUnityPlugin
{
    private Harmony harmony;

    private void Awake()
    {
        harmony = new Harmony("theMachineHandler.autopackopenermod");
        harmony.PatchAll();

        Logger.LogInfo("TiersThatMatter - AutoPackOpener Mod loaded. Made by theMachineHandler");
    }

    private void OnDestroy()
    {
        harmony?.UnpatchSelf();
    }
}

[HarmonyPatch(typeof(InteractableAutoPackOpener), "Awake")]
internal static class AutoPackOpenerAwakePatch
{
    private static void Postfix(InteractableAutoPackOpener __instance)
    {
        if (__instance == null)
            return;

        float time_to_process_pack;

        switch ((int)__instance.m_ObjectType)
        {
            case 34:
                time_to_process_pack = 7.5f;
                break;

            case 35:
                time_to_process_pack = 3.75f;
                break;

            case 36:
                time_to_process_pack = 1.875f;
                break;

            default:
                return;
        }

        __instance.m_PackOpenTime = time_to_process_pack;

        Debug.Log(
            $"[Auto Pack Opener Mod] AutoCardOpener Machine type {(int)__instance.m_ObjectType}: " +
            $"Time to process each pack set to {time_to_process_pack}s."
        );
    }
}

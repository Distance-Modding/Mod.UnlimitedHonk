using HarmonyLib;

namespace UnlimitedHonk.Patches
{
    [HarmonyPatch(typeof(HornGadget), "GadgetUpdateLocal")]
    internal class HornGadget__GadgetUpdateLocal
    {
        [HarmonyPrefix]
        internal static void UnlockHornPrefix(HornGadget __instance)
        {
            __instance.delayBetweenHorn_ = 0.00001f;
            __instance.maxButtonDownTime_ = 10000f;
            __instance.maxBubbleTime_ = 10000f;
            __instance.minBubbleTime_ = 0.5f;
        }
    }
}

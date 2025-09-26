using HarmonyLib;
using Reactor.Utilities.Extensions;
using Rewired.Utils;
using TMPro;

namespace Emojis
{
    [HarmonyPatch]
    public class ChatPatches
    {
        [HarmonyPatch(typeof(ChatBubble), nameof(ChatBubble.SetText))]
        [HarmonyPostfix]
        public static void SetTextPostfix(ChatBubble __instance, ref string chatText)
        {
            if (Assets.EmojiIndex.IsNullOrDestroyed()) Assets.EmojiIndex = Assets.Bundle.LoadAsset<TMP_SpriteAsset>("index.asset");
            __instance.TextArea.m_spriteAsset = Assets.EmojiIndex;
            __instance.TextArea.text = Utils.ReformatForEmojis(chatText);
        }
    }
}

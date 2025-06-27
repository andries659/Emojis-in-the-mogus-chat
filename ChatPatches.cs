using System;
using HarmonyLib;
using Reactor.Utilities.Extensions;
using Rewired.Utils;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

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
        [HarmonyPatch(typeof(ChatController), nameof(ChatController.OnEnable))]
        [HarmonyPostfix]
        public static void ChatControllerOpenPostfix(ChatController __instance)
        {
            if (false)
            {
                Action OnClick()
                {
                    void Listener()
                    {
                        
                    }

                    return Listener;
                }
                ChatInputFieldButton EmojisButton = Object.Instantiate<ChatInputFieldButton>(__instance.freeChatField.submitButton, __instance.freeChatField.submitButton.gameObject.transform.parent);
                EmojisButton.gameObject.name = "EmojisButton";
                EmojisButton.gameObject.transform.localPosition = new(1.145f, 0.02f, -0.1f);
                EmojisButton.OnPressed = OnClick();
                EmojisButton.collider.size = new(0.45f, 0.45f);
                EmojisButton.button.activeSprites.GetComponent<SpriteRenderer>().sprite = Assets.IconOn;
                EmojisButton.button.inactiveSprites.GetComponent<SpriteRenderer>().sprite = Assets.IconOff;
            }
        }
    }
}

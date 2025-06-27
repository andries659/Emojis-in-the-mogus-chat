using Reactor.Utilities;
using Reactor.Utilities.Extensions;
using TMPro;
using UnityEngine;

namespace Emojis;

public static class Assets
{
    public static AssetBundle Bundle { get; set; } = AssetBundleManager.Load("emojibundle");
    public static TMP_SpriteAsset EmojiIndex { get; set; } = Bundle.LoadAsset<TMP_SpriteAsset>("index.asset");
    public static Sprite IconOff { get; set; } = Bundle.LoadAsset<Sprite>("icon-off.png");
    public static Sprite IconOn { get; set; } = Bundle.LoadAsset<Sprite>("icon-on.png");
}
using Reactor.Utilities;
using Reactor.Utilities.Extensions;
using TMPro;
using UnityEngine;

namespace Emojis;
 
public static class Assets
{
    public static AssetBundle Emojis { get; set; } = AssetBundleManager.Load("emojis");
    public static TMP_SpriteAsset EmojiIndex { get; set; } = Emojis.LoadAsset<TMP_SpriteAsset>("index.asset");
}
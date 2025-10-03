using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace Emojis;

[BepInAutoPlugin("angel.EmojisMod", "Among Us Emojis", "v1.0.0-r")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[ReactorModFlags(ModFlags.None)]
public partial class EmojisInTheChat : BasePlugin
{
    public Harmony Harmony { get; } = new(Id);
    public ConfigFile GetConfigFile() => Config;
    public override void Load()
    {
        Harmony.PatchAll();
        ReactorCredits.Register<EmojisInTheChat>(ReactorCredits.AlwaysShow);
    }
}

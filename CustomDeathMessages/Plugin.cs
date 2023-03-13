using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace CustomDeathMessages
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name => "CustomDeathReason";
        public override string Prefix => "CRD";
        public override string Author => "NotIntense#1613";
        public override PluginPriority Priority => PluginPriority.Medium;

        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(6, 0, 0);

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
            Instance = null;
            base.OnDisabled();
        }

        public Handlers.Player player;

        public void RegisterEvents()
        {
            player = new Handlers.Player();

            Player.SpawningRagdoll += player.PlayerDied;
        }

        public void UnRegisterEvents()
        {
            player = null;
        }
    }
}
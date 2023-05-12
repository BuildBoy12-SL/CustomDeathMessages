namespace CustomDeathMessages
{
    using Exiled.API.Features;
    using System;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;
        public override string Author => "NotIntense & Build";
        public override string Name => "CustomDeathReason";
        public override Version RequiredExiledVersion { get; } = new(7, 0, 0);
        public override Version Version { get; } = new(3, 0, 0);

        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.SpawningRagdoll += eventHandlers.OnSpawningRagdoll;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandlers.SpawningRagdoll -= eventHandlers.OnSpawningRagdoll;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}
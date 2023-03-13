namespace CustomDeathMessages
{
    using System;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc/>
        public override string Author => "NotIntense#1613 & Build";

        /// <inheritdoc/>
        public override string Name => "CustomDeathReason";

        /// <inheritdoc/>
        public override Version RequiredExiledVersion { get; } = new(6, 0, 0);

        /// <inheritdoc/>
        public override Version Version { get; } = new(1, 0, 0);

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.SpawningRagdoll += eventHandlers.OnSpawningRagdoll;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            PlayerHandlers.SpawningRagdoll -= eventHandlers.OnSpawningRagdoll;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}

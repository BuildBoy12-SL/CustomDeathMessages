namespace CustomDeathMessages
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using Exiled.Loader;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the <see cref="Plugin"/> class.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnSpawningRagdoll(SpawningRagdollEventArgs)"/>
        public void OnSpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            if (!plugin.Config.DeathMessages.TryGetValue(ev.Role, out List<string> deathMessages))
                return;

            string deathReason = deathMessages[Loader.Random.Next(deathMessages.Count)];
            Ragdoll.CreateAndSpawn(ev.Role, ev.Nickname, deathReason, ev.Position, ev.Rotation, ev.Player);
            ev.IsAllowed = false;
        }
    }
}

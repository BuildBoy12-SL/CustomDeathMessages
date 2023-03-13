
namespace CustomDeathMessages
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using Exiled.Loader;
    public class EventHandlers
    {
        private readonly Plugin plugin;    
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

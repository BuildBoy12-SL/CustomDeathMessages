namespace CustomDeathMessages
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.DamageHandlers;
    using Exiled.Events.EventArgs.Player;
    using PlayerRoles;
    using System.Collections.Generic;

    public class EventHandlers
    {
        private readonly Plugin plugin;

        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public string deathCause { get; set; }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnSpawningRagdoll(SpawningRagdollEventArgs)"/>
     
        public void OnSpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            CustomDamageHandler damageHandler = new CustomDamageHandler(ev.Player, ev.DamageHandlerBase);
            if (!plugin.Config.DeathMessages.TryGetValue(ev.Role, out Dictionary<DamageType, string> damageMessages) ||
                !damageMessages.TryGetValue(damageHandler.Type, out string deathReason))
                return;

            Ragdoll.CreateAndSpawn(ev.Role, ev.Nickname, deathReason, ev.Position, ev.Rotation, ev.Player);
            ev.IsAllowed = false;
        }
    }
}
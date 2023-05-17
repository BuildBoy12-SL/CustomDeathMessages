namespace CustomDeathMessages
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.DamageHandlers;
    using Exiled.Events.EventArgs.Player;
    using System.Collections.Generic;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void Dying(DyingEventArgs ev)
        {
            CustomDamageHandler damnit = new CustomDamageHandler(ev.Player, ev.DamageHandler.Base);
            if(ev.DamageHandler != damnit && plugin.Config.DisplayDeathMessageOnScreen)
            {
                if (!plugin.Config.DeathMessages.TryGetValue(ev.Player.Role, out Dictionary<DamageType, string> damageMessages) || !damageMessages.TryGetValue(damnit.Type, out string deathReason)) return;
                ev.DamageHandler = damnit;
                ev.Player.Kill(deathReason);
                ev.IsAllowed = false;
            }
        }
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
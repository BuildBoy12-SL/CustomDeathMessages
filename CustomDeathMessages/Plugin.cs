namespace CustomDeathMessages
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.DamageHandlers;
    using Exiled.Events.EventArgs.Player;
    using System;
    using System.Collections.Generic;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    public class Plugin : Plugin<Config>
    {
        public override string Author => "NotIntense & Build";
        public override string Name => "CustomDeathReason";
        public override Version RequiredExiledVersion { get; } = new(7, 0, 0);
        public override Version Version { get; } = new(4, 1, 9);

        public override void OnEnabled()
        {
            PlayerHandlers.SpawningRagdoll += OnSpawningRagdoll;
            PlayerHandlers.Dying += Dying;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandlers.SpawningRagdoll -= OnSpawningRagdoll;
            PlayerHandlers.Dying -= Dying;
            base.OnDisabled();
        }
        public void Dying(DyingEventArgs ev)
        {
            CustomDamageHandler damnit = new CustomDamageHandler(ev.Player, ev.DamageHandler.Base);
            if (ev.DamageHandler != damnit && Config.DisplayDeathMessageOnScreen)
            {
                if (!Config.DeathMessages.TryGetValue(ev.Player.Role, out Dictionary<DamageType, string> damageMessages) || !damageMessages.TryGetValue(damnit.Type, out string deathReason)) return;
                ev.DamageHandler = damnit;
                ev.Player.Kill(deathReason);
                ev.IsAllowed = false;
            }
        }
        public void OnSpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            CustomDamageHandler damageHandler = new CustomDamageHandler(ev.Player, ev.DamageHandlerBase);
            if (!Config.DeathMessages.TryGetValue(ev.Role, out Dictionary<DamageType, string> damageMessages) ||
                !damageMessages.TryGetValue(damageHandler.Type, out string deathReason))
                return;

            Ragdoll.CreateAndSpawn(ev.Role, ev.Nickname, deathReason, ev.Position, ev.Rotation, ev.Player);
            ev.IsAllowed = false;
        }
    }
}

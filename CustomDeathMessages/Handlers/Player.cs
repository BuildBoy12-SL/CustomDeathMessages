using PlayerRoles;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using PlayerStatsSystem;
using Exiled.API.Features.DamageHandlers;
using UnityEngine;

namespace CustomDeathMessages.Handlers
{
    public class Player
    {
        public void PlayerDied(SpawningRagdollEventArgs ev)
        {
            switch (ev.Player.Role.Type)
            {
                case RoleTypeId.ClassD:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ClassD, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.ClassDdeathreason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.ChaosConscript:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosConscript, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.ChaosConscriptDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.ChaosMarauder:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosMarauder, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.ChaosMarauderDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.ChaosRepressor:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosRepressor, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.ChaosRepressorDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.FacilityGuard:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.FacilityGuard, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.FacilityGuardDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.NtfCaptain:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfCaptain, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.NtfCaptainDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.NtfPrivate:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfPrivate, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.NtfPrivateDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.NtfSergeant:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSergeant, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.NtfSergeantDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.NtfSpecialist:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.NtfSpecialistDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scientist:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scientist, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.ScientistDeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp049:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp049, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp049DeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp0492:
                    break;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp0492, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp0492DeathReason}", position: ev.Position, rotation: ev.Rotation);
                case RoleTypeId.Scp079:
                    break;
                case RoleTypeId.Scp096:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp096, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp096DeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp106:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp106, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp106DeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp173:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp173, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp173DeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp939:
                    ev.IsAllowed = false;
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.Scp939, ev.Player.Nickname, deathReason: $"{Plugin.Instance.Config.Scp939DeathReason}", position: ev.Position, rotation: ev.Rotation);
                    break;              
            }
        }
    }
}
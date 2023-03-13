using PlayerRoles;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using PlayerStatsSystem;
using Exiled.API.Features.DamageHandlers;
using UnityEngine;
using System;


namespace CustomDeathMessages.Handlers
{
    public class Player
    {
        public void PlayerDied(SpawningRagdollEventArgs ev)
        {
            System.Random random = new System.Random();
            string deathReason;

            switch (ev.Player.Role.Type)
            {
                case RoleTypeId.ClassD:
                    deathReason = Plugin.Instance.Config.ClassDdeathreason[random.Next(Plugin.Instance.Config.ClassDdeathreason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ClassD, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.ChaosRifleman:
                    deathReason = Plugin.Instance.Config.ChaosRiflemenDeathReason[random.Next(Plugin.Instance.Config.ChaosRiflemenDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ClassD, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.ChaosConscript:
                    deathReason = Plugin.Instance.Config.ChaosConscriptDeathReason[random.Next(Plugin.Instance.Config.ChaosConscriptDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosConscript, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.ChaosMarauder:
                    deathReason = Plugin.Instance.Config.ChaosMarauderDeathReason[random.Next(Plugin.Instance.Config.ChaosMarauderDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosMarauder, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.ChaosRepressor:
                    deathReason = Plugin.Instance.Config.ChaosRepressorDeathReason[random.Next(Plugin.Instance.Config.ChaosRepressorDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.ChaosRepressor, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.FacilityGuard:
                    deathReason = Plugin.Instance.Config.FacilityGuardDeathReason[random.Next(Plugin.Instance.Config.FacilityGuardDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.FacilityGuard, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.NtfCaptain:
                    deathReason = Plugin.Instance.Config.NtfCaptainDeathReason[random.Next(Plugin.Instance.Config.NtfCaptainDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfCaptain, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.NtfPrivate:
                    deathReason = Plugin.Instance.Config.NtfPrivateDeathReason[random.Next(Plugin.Instance.Config.NtfPrivateDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfPrivate, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.NtfSergeant:
                    deathReason = Plugin.Instance.Config.NtfSergeantDeathReason[random.Next(Plugin.Instance.Config.NtfSergeantDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSergeant, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    ev.IsAllowed = false;
                    break;
                case RoleTypeId.NtfSpecialist:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.NtfSpecialistDeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp049:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp049DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp0492:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp0492DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp096:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp096DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp106:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp106DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp173:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp173DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
                case RoleTypeId.Scp939:
                    deathReason = Plugin.Instance.Config.NtfSpecialistDeathReason[random.Next(Plugin.Instance.Config.Scp939DeathReason.Count)];
                    Ragdoll.CreateAndSpawn(roleType: RoleTypeId.NtfSpecialist, ev.Player.Nickname, deathReason: deathReason, position: ev.Position, rotation: ev.Rotation);
                    break;
            }

        }
    }
}
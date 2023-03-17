namespace CustomDeathMessages
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config : IConfig
    {
        private readonly RoleTypeId[] blacklistedRoles =
        {
            RoleTypeId.None,
            RoleTypeId.Spectator,
            RoleTypeId.CustomRole,
            RoleTypeId.Overwatch,
        };

        public Dictionary<RoleTypeId, Dictionary<DamageType, string>> DeathMessages { get; set; } = new()
        {
            {
                RoleTypeId.ClassD,
                new Dictionary<DamageType, string>
                {
                    { DamageType.Tesla, "Dosent know how to jump" },
                }
            },
            {
                RoleTypeId.NtfCaptain,
                new Dictionary<DamageType, string>
                {
                    { DamageType.Scp939, "Didnt pet the doggy enough" },
                }
            },
            {
                RoleTypeId.NtfPrivate,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.NtfSergeant,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.NtfSpecialist,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.FacilityGuard,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scientist,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.ChaosConscript,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.ChaosMarauder,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.ChaosRepressor,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp049,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp0492,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp096,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp106,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp173,
                new Dictionary<DamageType, string>
                {
                }
            },
            {
                RoleTypeId.Scp939,
                new Dictionary<DamageType, string>
                {
                }
            }
        };

        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The roles and the death messages their ragdolls can be labelled with.")]
        private Dictionary<RoleTypeId, Dictionary<DamageType, string>> Deathnames
        {
            get => DeathMessages;
            set
            {
                foreach (RoleTypeId blacklistedRole in blacklistedRoles)
                {
                    if (value.Remove(blacklistedRole))
                        Log.Warn($"Removed invalid configuration. '{blacklistedRole}' cannot have custom death messages.");
                }

                DeathMessages = value;
            }
        }
    }
}
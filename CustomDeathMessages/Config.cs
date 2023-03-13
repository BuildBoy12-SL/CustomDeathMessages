namespace CustomDeathMessages
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using PlayerRoles;

    /// <inheritdoc cref="IConfig"/>
    public class Config : IConfig
    {
        private readonly RoleTypeId[] blacklistedRoles =
        {
            RoleTypeId.None,
            RoleTypeId.Spectator,
            RoleTypeId.CustomRole,
            RoleTypeId.Overwatch,
        };

        private Dictionary<RoleTypeId, List<string>> deathMessages = new()
        {
            { RoleTypeId.Scp173, new List<string> { "Unset" } },
            { RoleTypeId.ClassD, new List<string> { "Unset" } },
            { RoleTypeId.Scp106, new List<string> { "Unset" } },
            { RoleTypeId.NtfSpecialist, new List<string> { "Unset" } },
            { RoleTypeId.Scp049, new List<string> { "Unset" } },
            { RoleTypeId.Scientist, new List<string> { "Unset" } },
            { RoleTypeId.Scp079, new List<string> { "Unset" } },
            { RoleTypeId.ChaosConscript, new List<string> { "Unset" } },
            { RoleTypeId.Scp096, new List<string> { "Unset" } },
            { RoleTypeId.Scp0492, new List<string> { "Unset" } },
            { RoleTypeId.NtfSergeant, new List<string> { "Unset" } },
            { RoleTypeId.NtfCaptain, new List<string> { "Unset" } },
            { RoleTypeId.NtfPrivate, new List<string> { "Unset" } },
            { RoleTypeId.Tutorial, new List<string> { "Unset" } },
            { RoleTypeId.FacilityGuard, new List<string> { "Unset" } },
            { RoleTypeId.Scp939, new List<string> { "Unset" } },
            { RoleTypeId.ChaosRifleman, new List<string> { "Unset" } },
            { RoleTypeId.ChaosRepressor, new List<string> { "Unset" } },
            { RoleTypeId.ChaosMarauder, new List<string> { "Unset" } },
        };

        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc/>
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets or sets the roles and the death messages their ragdolls can be labelled with.
        /// </summary>
        [Description("The roles and the death messages their ragdolls can be labelled with.")]
        public Dictionary<RoleTypeId, List<string>> DeathMessages
        {
            get => deathMessages;
            set
            {
                foreach (RoleTypeId blacklistedRole in blacklistedRoles)
                {
                    if (value.Remove(blacklistedRole))
                        Log.Warn($"Removed invalid configuration. '{blacklistedRole}' cannot have custom death messages.");
                }

                deathMessages = value;
            }
        }
    }
}
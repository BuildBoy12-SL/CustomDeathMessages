using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CustomDeathMessages
{
    public class Config : IConfig
    {
        [Description("Sets the plugin enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("No need to touch this :3")]
        public bool Debug { get; set; } = false;

        [Description("The death reason for Class-D personnel.")]
        public string ClassDdeathreason { get; set; } = "Unset";

        [Description("The death reason for Chaos Conscripts.")]
        public string ChaosConscriptDeathReason { get; set; } = "Unset";

        [Description("The death reason for Chaos Marauders.")]
        public string ChaosMarauderDeathReason { get; set; } = "Unset";

        [Description("The death reason for Chaos Repressors.")]
        public string ChaosRepressorDeathReason { get; set; } = "Unset";

        [Description("The death reason for Facility Guards.")]
        public string FacilityGuardDeathReason { get; set; } = "Unset";

        [Description("The death reason for NTF Captains.")]
        public string NtfCaptainDeathReason { get; set; } = "Unset";

        [Description("The death reason for NTF Privates.")]
        public string NtfPrivateDeathReason { get; set; } = "Unset";

        [Description("The death reason for NTF Sergeants.")]
        public string NtfSergeantDeathReason { get; set; } = "Unset";

        [Description("The death reason for NTF Specialists.")]
        public string NtfSpecialistDeathReason { get; set; } = "Unset";

        [Description("The death reason for Scientists.")]
        public string ScientistDeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-049.")]
        public string Scp049DeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-049-2.")]
        public string Scp0492DeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-079.")]
        public string Scp079DeathReason { get; set; } = "DONT SET | DOSENT WORK";

        [Description("The death reason for SCP-096.")]
        public string Scp096DeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-106.")]
        public string Scp106DeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-173.")]
        public string Scp173DeathReason { get; set; } = "Unset";

        [Description("The death reason for SCP-939.")]
        public string Scp939DeathReason { get; set; } = "Unset";

    }
}
using Exiled.API.Interfaces;
using System.Collections.Generic;
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
        public List<string> ClassDdeathreason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for Chaos Conscripts.")]
        public List<string> ChaosConscriptDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for Chaos Marauders.")]
        public List<string> ChaosMarauderDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for Chaos Repressors.")]
        public List<string> ChaosRepressorDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for Facility Guards.")]
        public List<string> FacilityGuardDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for NTF Captains.")]
        public List<string> NtfCaptainDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for NTF Privates.")]
        public List<string> NtfPrivateDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for NTF Sergeants.")]
        public List<string> NtfSergeantDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for NTF Specialists.")]
        public List<string> NtfSpecialistDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for Scientists.")]
        public List<string> ScientistDeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-049.")]
        public List<string> Scp049DeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-049-2.")]
        public List<string> Scp0492DeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-079.")]
        public List<string> Scp079DeathReason { get; set; } = new List<string> { "Dont touch this please" };

        [Description("The death reason for SCP-096.")]
        public List<string> Scp096DeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-106.")]
        public List<string> Scp106DeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-173.")]
        public List<string> Scp173DeathReason { get; set; } = new List<string> { "Unset" };

        [Description("The death reason for SCP-939.")]
        public List<string> Scp939DeathReason { get; set; } = new List<string> { "Unset" };


    }
}
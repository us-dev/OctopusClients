﻿using System;
using System.Collections.Generic;

namespace Octopus.Client.Model.Accounts.Usages
{
    public class AccountUsageResource : Resource
    {
        public AccountUsageResource()
        {
            Targets = new List<TargetUsageEntry>();
            DeploymentProcesses = new List<StepUsage>();
            Releases = new List<ReleaseUsage>();
            ProjectVariableSets = new List<ProjectVariableSetUsage>();
            LibraryVariableSets = new List<LibraryVariableSetUsageEntry>();
        }

        public ICollection<TargetUsageEntry> Targets { get; set; }
        public ICollection<StepUsage> DeploymentProcesses { get; set; }
        public ICollection<ReleaseUsage> Releases { get; set; }
        public ICollection<ProjectVariableSetUsage> ProjectVariableSets { get; set; }
        public ICollection<LibraryVariableSetUsageEntry> LibraryVariableSets { get; set; }
    }

    public class TargetUsageEntry
    {
        public string TargetName { get; set; }
        public string TargetId { get; set; }
    }

    public class ProjectVariableSetUsage
    {
        public ProjectVariableSetUsage()
        {
            Releases = new List<ReleaseUsageEntry>();
        }

        public string ProjectSlug { get; set; }
        public string ProjectName { get; set; }
        public string ProjectId { get; set; }
        public ICollection<ReleaseUsageEntry> Releases { get; set; }
        public bool IsCurrentlyBeingUsedInProject { get; set; }
    }

    public class LibraryVariableSetUsageEntry
    {
        public string LibraryVariableSetId { get; set; }
        public string LibraryVariableSetName { get; set; }
    }

    public class ReleaseUsage
    {
        public ReleaseUsage()
        {
            Releases = new List<ReleaseUsageEntry>();
        }

        public string ProjectName { get; set; }
        public string ProjectId { get; set; }
        public ICollection<ReleaseUsageEntry> Releases { get; set; }
    }

    public class ReleaseUsageEntry
    {
        public string ReleaseId { get; set; }
        public string ReleaseVersion { get; set; }
    }

    public class StepUsage
    {
        public StepUsage()
        {
            Steps = new List<StepUsageEntry>();
        }

        public string ProjectName { get; set; }
        public string ProjectSlug { get; set; }
        public string ProjectId { get; set; }

        public ICollection<StepUsageEntry> Steps { get; set; }
    }

    public class StepUsageEntry
    {
        public string StepName { get; set; }
        public string StepId { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Extensions;

    /// <summary>Actions to invoke when the alert fires.</summary>
    public partial class Actions :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActions,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsInternal
    {

        /// <summary>Backing field for <see cref="ActionGroup" /> property.</summary>
        private string[] _actionGroup;

        /// <summary>Action Group resource Ids to invoke when the alert fires.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.PropertyOrigin.Owned)]
        public string[] ActionGroup { get => this._actionGroup; set => this._actionGroup = value; }

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsCustomProperties _customProperty;

        /// <summary>The properties of an alert payload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsCustomProperties CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.ActionsCustomProperties()); set => this._customProperty = value; }

        /// <summary>Creates an new <see cref="Actions" /> instance.</summary>
        public Actions()
        {

        }
    }
    /// Actions to invoke when the alert fires.
    public partial interface IActions :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.IJsonSerializable
    {
        /// <summary>Action Group resource Ids to invoke when the alert fires.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Action Group resource Ids to invoke when the alert fires.",
        SerializedName = @"actionGroups",
        PossibleTypes = new [] { typeof(string) })]
        string[] ActionGroup { get; set; }
        /// <summary>The properties of an alert payload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The properties of an alert payload.",
        SerializedName = @"customProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsCustomProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsCustomProperties CustomProperty { get; set; }

    }
    /// Actions to invoke when the alert fires.
    internal partial interface IActionsInternal

    {
        /// <summary>Action Group resource Ids to invoke when the alert fires.</summary>
        string[] ActionGroup { get; set; }
        /// <summary>The properties of an alert payload.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IActionsCustomProperties CustomProperty { get; set; }

    }
}
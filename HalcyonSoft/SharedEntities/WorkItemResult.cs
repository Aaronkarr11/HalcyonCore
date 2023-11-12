using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HalcyonCore.SharedEntities
{

    public class WorkItemResult
    {
        public class WorkItemDetails
        {
            public int count { get; set; }
            public Value[] value { get; set; }
        }

        public class Value
        {
            public int id { get; set; }
            public int rev { get; set; }
            public Fields fields { get; set; }
            public string url { get; set; }
        }

        public class Fields
        {
            [JsonProperty(PropertyName = "System.Id")]
            public int SystemId { get; set; }
            [JsonProperty(PropertyName = "System.AreaPath")]
            public string SystemAreaPath { get; set; }
            [JsonProperty(PropertyName = "System.Parent")]
            public int SystemParentId { get; set; }
            [JsonProperty(PropertyName = "System.IterationId")]
            public string SystemIterationId { get; set; }
            [JsonProperty(PropertyName = "System.WorkItemType")]
            public string SystemWorkItemType { get; set; }
            [JsonProperty(PropertyName = "System.State")]
            public string SystemState { get; set; }
            [JsonProperty(PropertyName = "System.AssignedTo")]
            public SystemAssignedto SystemAssignedTo { get; set; }
            [JsonProperty(PropertyName = "System.CreatedDate")]
            public DateTime SystemCreatedDate { get; set; }
            [JsonProperty(PropertyName = "System.Title")]
            public string SystemTitle { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Common.Severity")]
            public string MicrosoftVSTSCommonSeverity { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Common.Risk")]
            public string MicrosoftVSTSCommonRisk { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.Effort")]
            public float MicrosoftVSTSSchedulingEffort { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.StartDate")]
            public DateTime MicrosoftVSTSSchedulingStartDate { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.FinishDate")]
            public DateTime MicrosoftVSTSSchedulingFinishDate { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.DueDate")]
            public DateTime MicrosoftVSTSSchedulingDueDate { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.TargetDate")]
            public DateTime MicrosoftVSTSSchedulingTargetDate { get; set; }
            [JsonProperty(PropertyName = "System.Description")]
            public string SystemDescription { get; set; }
            [JsonProperty(PropertyName = "Microsoft.VSTS.Common.Priority")]
            public int MicrosoftVSTSCommonPriority { get; set; }
            [JsonProperty(PropertyName = "Custom.Assignment")]
            public string CustomAssignment { get; set; }
            [JsonProperty(PropertyName = "Custom.LocationCategory")]
            public string LocationCategory { get; set; }
            [JsonProperty(PropertyName = "Custom.Icon")]
            public string Icon { get; set; }
        }

        public class SystemAssignedto
        {
            public string displayName { get; set; }
            public string url { get; set; }
            public _Links _links { get; set; }
            public string id { get; set; }
            public string uniqueName { get; set; }
            public string imageUrl { get; set; }
            public string descriptor { get; set; }
        }

        public class _Links
        {
            public Avatar avatar { get; set; }
        }

        public class Avatar
        {
            public string href { get; set; }
        }

    }

    public class HalcyonWorkItems
    {
        public int SystemId { get; set; }
        public string AreaPath { get; set; }
        public int IterationId { get; set; }
        public string IterationName { get; set; }
        public string WorkItemType { get; set; }
        public int ParentId { get; set; }
        public string State { get; set; }
        public string Assignment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Title { get; set; }
        public string Severity { get; set; }
        public string Risk { get; set; }
        public int Effort { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? TargetDate { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public string LocationCategory { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }

    public class QueryResults
    {
        public class QueryResultItems
        {
            public string queryType { get; set; }
            public string queryResultType { get; set; }
            public DateTime asOf { get; set; }
            public Column[] columns { get; set; }
            public Workitem[] workItems { get; set; }
        }

        public class Column
        {
            public string referenceName { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Workitem
        {
            public int id { get; set; }
            public string url { get; set; }
        }
    }

    public class AssigneePercents
    {
        public string AssigneeName { get; set; }
        public double PercentValue { get; set; }
    }

    public class Iterations
    {
        public int count { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public string structureType { get; set; }
        public bool hasChildren { get; set; }
        public List<Child> children { get; set; }
        public string path { get; set; }
        public string url { get; set; }
    }

    public class Child
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

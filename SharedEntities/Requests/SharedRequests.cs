using System;
using System.Collections.Generic;
using System.Text;

namespace HalcyonCore.SharedEntities
{
    public class GetCompletedWorkItemsPercentageRequestBody
    {
        public DateTime CurrentDay { get; set; }
        public List<string> Householdmembers { get; set; }
    }

    public class GetWorkItemsRequestBody
    {
        public string WiqlQuery { get; set; }
    }

    public class DeleteWorkItemsRequestBody
    {
        public int WorkItemId { get; set; }
    }


    public class CreateWorkItemsRequestBody
    {
        public int WorkItemId { get; set; }
    }

    public class CreateOrUpdateWorkItems
    {
        public int? workitemid { get; set; }
        public string worktemtype { get; set; }
        public string operation { get; set; }
        public string workitevalues { get; set; }
        public bool sendsms { get; set; }
    }

    public class WorkItemValue
    {
        public object op { get; set; }
        public string path { get; set; }
        public string from { get; set; }
        public object value { get; set; }
    }

    public class HalcyonWorkItemRequestModel
    {
        public string AreaPath { get; set; }
        public int IterationId { get; set; }
        public string IterationName { get; set; }
        public string WorkItemType { get; set; }
        public int ParentId { get; set; }
        public string State { get; set; }
        public string Assignment { get; set; }
        public string Title { get; set; }
        public string Severity { get; set; }
        public string Risk { get; set; }
        public int Effort { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? TargetDate { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public string LocationCategory { get; set; }
        public string Url { get; set; }
    }

    public class RequestItemRequest
    {
        public string Operation { get; set; }
        public string DeviceName { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Title { get; set; }
        public string ReasonDescription { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int IsFulfilled { get; set; }
    }
}

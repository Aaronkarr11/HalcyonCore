using Azure;
using Azure.Data.Tables;
using System.Drawing;

namespace HalcyonCore.SharedEntities
{

	public class HouseHoldMember : PersonDetails
	{
		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string DeviceName { get; set; }
	}

	public class PersonDetails
    {
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}

	public class HouseHoldMemberTableTemplate
	{
		public string DeviceName { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

    }

	public class HouseHoldMemberTableEntity : ITableEntity
	{
		public string DeviceName { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }

    public class OperationHierarchy
	{
		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
        public string DisplayStartDate { get; set; }
        public string DisplayTargetDate { get; set; }
        public string Description { get; set; }
		public string Icon { get; set; }
		public int Completed { get; set; }
		public List<ProjectHierarchy> ProjectHierarchy { get; set; }
	}

	public class ProjectHierarchy
	{
        public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
        public string DisplayStartDate { get; set; }
        public string DisplayTargetDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public string LocationCategory { get; set; }
		public string Severity { get; set; }
		public int Priority { get; set; }
		public int Completed { get; set; }
		public List<WorkTaskModel> WorkTaskHierarchy { get; set; }
	}


	public class OperationModel
	{
		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
		public int Completed { get; set; }
	}

	public class ProjectModel
	{
		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
		public string LocationCategory { get; set; }
		public string Severity { get; set; }
		public int Priority { get; set; }
		public int Completed { get; set; }
	}


	//Model
	public class WorkTaskModel : PersonDetails
	{
		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public string ParentPartitionKey { get; set; }
		public string ParentRowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public Color StateColor { get; set; }
        public string Title { get; set; }
		public string Risk { get; set; }
		public int Effort { get; set; }
		public int Priority { get; set; }
        public string DisplayStartDate { get; set; }
        public string DisplayTargetDate { get; set; }
        public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public bool SendSMS { get; set; }
		public int Completed { get; set; }
	}

    public class ErrorLogModel
    {
        public string MethodName { get; set; }
        public string ClassName { get; set; }
        public string Message { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string DeviceName { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }

    public class ErrorLogTableEntity : ITableEntity
    {
        public string MethodName { get; set; }
        public string ClassName { get; set; }
        public string Message { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string DeviceName { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }

    public class ErrorLogModelTableTemplate
    {
        public string MethodName { get; set; }
        public string ClassName { get; set; }
        public string Message { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string DeviceName { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }

	public class OperationModelTableEntity : ITableEntity
	{
		public string Title { get; set; }
		public string DeviceName { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
		public int Completed { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }

	public class ProjectModelTableTemplate
	{
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
		public string LocationCategory { get; set; }
		public string Severity { get; set; }
		public int Priority { get; set; }
		public int Completed { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }

	public class ProjectModelTableEntity : ITableEntity
	{
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Title { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
		public string LocationCategory { get; set; }
		public string Severity { get; set; }
		public int Priority { get; set; }
		public int Completed { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }

	public class WorkTaskModelTableTemplate
	{
		public string ParentPartitionKey { get; set; }
		public string ParentRowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Assignment { get; set; }
		public string Title { get; set; }
		public string Risk { get; set; }
		public int Effort { get; set; }
		public int Priority { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public bool SendSMS { get; set; }
		public int Completed { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }

	public class WorkTaskModelTableEntity : ITableEntity
	{
		public string ParentPartitionKey { get; set; }
		public string ParentRowKey { get; set; }
		public string DeviceName { get; set; }
		public string State { get; set; }
		public string Assignment { get; set; }
		public string Title { get; set; }
		public string Risk { get; set; }
		public int Effort { get; set; }
		public int Priority { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? TargetDate { get; set; }
		public string Description { get; set; }
		public bool SendSMS { get; set; }
		public int Completed { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }

	public class RequestItemsTableTemplate
	{
		public string DeviceName { get; set; }
		public string Title { get; set; }
		public string ReasonDescription { get; set; }
		public DateTime? DesiredDate { get; set; }
		public int IsFulfilled { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }

	public class RequestItemsTableEntity : ITableEntity
	{
		public string DeviceName { get; set; }
		public string Title { get; set; }
		public string ReasonDescription { get; set; }
		public DateTime? DesiredDate { get; set; }
		public int IsFulfilled { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}

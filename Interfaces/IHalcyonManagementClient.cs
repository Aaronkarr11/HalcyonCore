using HalcyonCore.SharedEntities;

namespace HalcyonCore.Interfaces
{
    public interface IHalcyonManagementClient
    {
        Task<string> AzureFunctionPostTransaction(string uri, string content);
        Task<string> CreateRequestItem(RequestItemsTableTemplate requestItemRequest);
        Task<DashBoard> GetDashBoardData(string deviceName);
        Task<List<HouseHoldMember>> GetHouseHoldMembers(string deviceName);
        Task<List<ProjectModel>> GetProjectList(string deviceName);
        Task<List<RequestItemsModel>> GetRequestItems(string deviceName);
        Task<List<ProjectHierarchy>> GetWorkItemHierarchy(string deviceName);
        Task<List<WorkTaskModel>> GetWorkTaskPrioritiesList(string deviceName);
        Task<string> DeleteRequestItem(RequestItemsTableTemplate requestItemRequest);
        Task<HttpResponseMessage> GetWorkItemHierarchyHttpResponseMessage(string deviceName);
        Task<HttpResponseMessage> GetDashBoardDataHttpResponseMessage(string deviceName);
    }
}
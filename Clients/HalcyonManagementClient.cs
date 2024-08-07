﻿using HalcyonCore.Interfaces;
using HalcyonCore.SharedEntities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace HalcyonCore.Clients
{
    public class HalcyonManagementClient : IHalcyonManagementClient
    {
        private static HttpClient _client { get; set; }
        public HalcyonManagementClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<RequestItemsModel>> GetRequestItems(string deviceName)
        {
            try
            {
                RequestItemsModel model = new RequestItemsModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetRequestItems?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var rawResponse = stringResponse.Content.ReadAsStringAsync().Result;

                var filteredResult = JsonConvert.DeserializeObject<List<RequestItemsModel>>(rawResponse).Where(o => o.IsFulfilled == 0);
                return filteredResult.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<HouseHoldMember>> GetHouseHoldMembers(string deviceName)
        {
            try
            {
                HouseHoldMember model = new HouseHoldMember();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetHouseHold?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var rawResponse = stringResponse.Content.ReadAsStringAsync().Result;

                var filteredResult = JsonConvert.DeserializeObject<List<HouseHoldMember>>(rawResponse);
                return filteredResult.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<DashBoard> GetDashBoardData(string deviceName)
        {
            try
            {
                WorkTaskModel model = new WorkTaskModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetDashBoardData?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var res = await _client.PostAsync(uri, stringContent);
                var result = res.Content.ReadAsStringAsync().Result;
                var filteredResult = JsonConvert.DeserializeObject<DashBoard>(result);
                return filteredResult;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> GetDashBoardDataHttpResponseMessage(string deviceName)
        {
            try
            {
                WorkTaskModel model = new WorkTaskModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetDashBoardData?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(uri, stringContent);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage errorHTTPResponseMessage = new HttpResponseMessage();
                errorHTTPResponseMessage.StatusCode = System.Net.HttpStatusCode.BadRequest;
                errorHTTPResponseMessage.Content = new StringContent(ex.Message, Encoding.UTF8, "application/json");
                return errorHTTPResponseMessage;
            }
        }


        public async Task<List<ProjectHierarchy>> GetWorkItemHierarchy(string deviceName)
        {
            try
            {
                ProjectModel model = new ProjectModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetWorkItemHierarchy?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var rawResponse = stringResponse.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<ProjectHierarchy>>(rawResponse);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<HttpResponseMessage> GetWorkItemHierarchyHttpResponseMessage(string deviceName)
        {
            try
            {
                OperationModel model = new OperationModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetWorkItemHierarchy?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(uri, stringContent);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage errorHTTPResponseMessage = new HttpResponseMessage();
                errorHTTPResponseMessage.StatusCode = System.Net.HttpStatusCode.BadRequest;
                errorHTTPResponseMessage.Content = new StringContent(ex.Message, Encoding.UTF8, "application/json");
                return errorHTTPResponseMessage;
            }
        }

        public async Task<List<ProjectModel>> GetProjectList(string deviceName)
        {
            try
            {
                ProjectModel model = new ProjectModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetProjects?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var rawResponse = stringResponse.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<ProjectModel>>(rawResponse);

                ProjectModel emptyProject = new ProjectModel();
                emptyProject.Title = "Create New";
                emptyProject.RowKey = "1";
                result.Add(emptyProject);
                return result;
            }
            catch (Exception ex)
            {
                List<ProjectModel> emptyProjectList = new List<ProjectModel>();
                ProjectModel model = new ProjectModel();
                model.Title = "Create New";
                model.RowKey = "1";
                emptyProjectList.Add(model);
                return emptyProjectList;
            }
        }

        public async Task<List<WorkTaskModel>> GetWorkTaskPrioritiesList(string deviceName)
        {
            try
            {
                WorkTaskModel model = new WorkTaskModel();
                model.DeviceName = deviceName;
                string content = JsonConvert.SerializeObject(model);

                string uri = "https://halcyontransactions.azurewebsites.net/api/GetWorkTasks?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var rawResponse = stringResponse.Content.ReadAsStringAsync().Result;
                var results = JsonConvert.DeserializeObject<List<WorkTaskModel>>(rawResponse);

                return results.OrderBy(o => o.Priority).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> AzureFunctionPostTransaction(string uri, string content)
        {
            try
            {
                var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
                var stringResponse = await _client.PostAsync(uri, stringContent);
                var result = stringResponse.Content.ReadAsStringAsync().Result;
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public async Task<string> CreateRequestItem(RequestItemsTableTemplate requestItemRequest)
        {
            try
            {
                RequestItemsTableTemplate req = new RequestItemsTableTemplate();

                string uri = "https://halcyontransactions.azurewebsites.net/api/CreateOrUpdateRequestItems?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";


                if (requestItemRequest.PartitionKey != null)
                {
                    req.PartitionKey = requestItemRequest.PartitionKey.Trim();
                    req.RowKey = requestItemRequest.RowKey.Trim();
                    req.IsFulfilled = 1;
                    req.DesiredDate = requestItemRequest.DesiredDate;
                    req.DeviceName = requestItemRequest.DeviceName;
                }
                else
                {
                    req.PartitionKey = System.Guid.NewGuid().ToString();
                    req.RowKey = System.Guid.NewGuid().ToString();
                    req.DesiredDate = requestItemRequest.DesiredDate;
                    req.ReasonDescription = requestItemRequest.ReasonDescription;
                    req.Title = requestItemRequest.Title;
                    req.IsFulfilled = requestItemRequest.IsFulfilled;
                    req.DeviceName = requestItemRequest.DeviceName;
                }

                var objAsJson = JsonConvert.SerializeObject(req);
                var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

                var rawResponse = await _client.PostAsync(uri, content);
                var stringResponse = rawResponse.Content.ReadAsStringAsync().Result;
                return stringResponse;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> DeleteRequestItem(RequestItemsTableTemplate requestItemRequest)
        {
            try
            {
                RequestItemsTableTemplate req = new RequestItemsTableTemplate();

                string uri = "https://halcyontransactions.azurewebsites.net/api/DeleteRequestItem?code=fXB5yroHKAH8GBb3M9VouDv2WTNjOR0AeBa_McAn6i6bAzFuJ2yxJg%3D%3D";

                req.PartitionKey = requestItemRequest.PartitionKey.Trim();
                req.RowKey = requestItemRequest.RowKey.Trim();
                req.IsFulfilled = 1;
                req.DesiredDate = requestItemRequest.DesiredDate;
                req.DeviceName = requestItemRequest.DeviceName;

                var objAsJson = JsonConvert.SerializeObject(req);
                var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");

                var rawResponse = await _client.PostAsync(uri, content);
                var stringResponse = rawResponse.Content.ReadAsStringAsync().Result;
                return stringResponse;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
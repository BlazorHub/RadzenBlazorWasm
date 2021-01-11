
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using Sde3.Models.Sde;

namespace Sde3
{
    public partial class SdeService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public SdeService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/SDE/");
        }

        public async System.Threading.Tasks.Task ExportExtractsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/sde/extracts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/sde/extracts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportExtractsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/sde/extracts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/sde/extracts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetExtracts(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.Sde.Extract>> GetExtracts(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Extracts");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetExtracts(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.Sde.Extract>>();
        }
        partial void OnCreateExtract(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.Sde.Extract> CreateExtract(dynamic extract = default(dynamic))
        {
            var uri = new Uri(baseUri, $"Extracts");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(extract), Encoding.UTF8, "application/json");

            OnCreateExtract(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.Sde.Extract>();
        }

        public async System.Threading.Tasks.Task ExportParametersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/sde/parameters/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/sde/parameters/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportParametersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/sde/parameters/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/sde/parameters/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetParameters(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.Sde.Parameter>> GetParameters(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Parameters");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetParameters(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.Sde.Parameter>>();
        }
        partial void OnCreateParameter(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.Sde.Parameter> CreateParameter(dynamic parameter = default(dynamic))
        {
            var uri = new Uri(baseUri, $"Parameters");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(parameter), Encoding.UTF8, "application/json");

            OnCreateParameter(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.Sde.Parameter>();
        }
        partial void OnDeleteExtract(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteExtract(int? extractId = default(int?))
        {
            var uri = new Uri(baseUri, $"Extracts({extractId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteExtract(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetExtractByExtractId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.Sde.Extract> GetExtractByExtractId(int? extractId = default(int?))
        {
            var uri = new Uri(baseUri, $"Extracts({extractId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetExtractByExtractId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.Sde.Extract>();
        }
        partial void OnUpdateExtract(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateExtract(int? extractId = default(int?), dynamic extract = default(dynamic))
        {
            var uri = new Uri(baseUri, $"Extracts({extractId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(extract), Encoding.UTF8, "application/json");

            OnUpdateExtract(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteParameter(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteParameter(int? parameterId = default(int?))
        {
            var uri = new Uri(baseUri, $"Parameters({parameterId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteParameter(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetParameterByParameterId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.Sde.Parameter> GetParameterByParameterId(int? parameterId = default(int?))
        {
            var uri = new Uri(baseUri, $"Parameters({parameterId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetParameterByParameterId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.Sde.Parameter>();
        }
        partial void OnUpdateParameter(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateParameter(int? parameterId = default(int?), dynamic parameter = default(dynamic))
        {
            var uri = new Uri(baseUri, $"Parameters({parameterId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(parameter), Encoding.UTF8, "application/json");

            OnUpdateParameter(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}

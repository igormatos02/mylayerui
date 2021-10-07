using apiclient.mylayersapi;
using clientlib.mylayers;
using common.sismo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Client.Api
{
    public class ProjectApi
    {
        private readonly IHttpClientFactory _factory;
        public ProjectApi(IHttpClientFactory factory)
        {
            this._factory = factory;
        }

        public async Task<ClientResponse<List<SeismicProjectModel>>> ListAsync()
        {
            using var client = new ProjectClient("https://mylayersapi.azurewebsites.net/", _factory);
            client.AuthenticateBypass("");
            return await client.ListProjectsAsync();
        }
    }
}

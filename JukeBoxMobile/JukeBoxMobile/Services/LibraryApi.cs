using JukeBoxMobile.Models;
using JukeBoxMobile.Models.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxMobile.Services
{
  public  class LibraryApi
    {
        public static async Task<Library> ApiLoginClient()
        {
            var req = new RestRequest("api/admin/login", Method.POST);
            req.RequestFormat = DataFormat.Json;
            req.JsonSerializer = JsonSerializer.Default;
          //  req.AddBody(login);
            var response = await RestJukeBox.ExecuteAsync<LibraryResponse>(req);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (response.StatusCode != HttpStatusCode.Accepted)
                {
                    throw new Exception(response.StatusDescription, new Exception(response.Content));
                }
            }

            return response.Data.ResponseObject;
        }
    }
}

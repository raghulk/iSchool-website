using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Project3_FinalExam.Services
{
    public class GetEmployment : IGetEmployment
    {
        public async Task<String> GetEmpInfo()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/employmentTable/professionalEmploymentInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    return data;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    return "";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    return "";
                }
            }
        }

        public async Task<String> GetCoopInfo()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/coopTable/coopInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    return data;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Coop> coopInfo = new List<Coop>();
                    return "";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Coop> coopInfo = new List<Coop>();
                    return "";
                }
            }
        }
    }
}

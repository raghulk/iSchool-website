using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetUndergraduate : IGetUndergraduate
    {
        public async Task<List<UnderGradMajors>> GetUnderGradDegrees()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/degrees/undergraduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UnderGradMajors>>>(data);
                    List<UnderGradMajors> underGradMajorsList = new List<UnderGradMajors>();

                    foreach (KeyValuePair<string, List<UnderGradMajors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            underGradMajorsList.Add(item);
                        }
                    }

                    return underGradMajorsList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UnderGradMajors> underGradMajorsList = new List<UnderGradMajors>();
                    return underGradMajorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UnderGradMajors> underGradMajorsList = new List<UnderGradMajors>();
                    return underGradMajorsList;
                }
            }
        }
        public async Task<List<UnderGradMinors>> GetUnderGradMinors()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/minors", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UnderGradMinors>>>(data);
                    List<UnderGradMinors> underGradMinorsList = new List<UnderGradMinors>();

                    foreach (KeyValuePair<string, List<UnderGradMinors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            underGradMinorsList.Add(item);
                        }
                    }

                    return underGradMinorsList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UnderGradMinors> underGradMinorsList = new List<UnderGradMinors>();
                    return underGradMinorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UnderGradMinors> underGradMinorsList = new List<UnderGradMinors>();
                    return underGradMinorsList;
                }
            }
        }
    }
}

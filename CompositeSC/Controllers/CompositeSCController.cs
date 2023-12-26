using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CompositeSC.Models;
using Newtonsoft.Json;
using СompositeSC.Models;

namespace CompositeSC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompositeSCController : ControllerBase
    {
        private readonly string _studentServiceAddress = "https://localhost:7010/api/students";
        private readonly string _courseServiceAddress = "https://localhost:7009/api/courses";
        [HttpGet("courses/{ownerId}")]
        public async Task<List<Student>> GetStudents(long ownerId)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback =
            (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (HttpClient client = new HttpClient(clientHandler))
            {
                HttpResponseMessage response = await
                client.GetAsync($"{_studentServiceAddress}");
                if (response.IsSuccessStatusCode)
                {
                    List<Student> patients = await response.Content.ReadFromJsonAsync<List<Student>>();
                    return patients.Where(patients => patients.OwnerId
                    == ownerId).ToList();
                }
            }
            return null;
        }
    }
}
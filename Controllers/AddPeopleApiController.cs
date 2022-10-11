using System;
using CodeTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeTest.Controllers
{
    [Route("/api2/[controller]")]
    public class AddPeopleApiController : ControllerBase
    {
        [HttpPost("/createNewPeople2")]
        public People Post([FromBody] People req)
        {
            People resp = new People();
            Console.WriteLine("344334");
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return resp;
        }

    }
}


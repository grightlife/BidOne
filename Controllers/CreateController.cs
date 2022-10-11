using Microsoft.AspNetCore.Mvc;
using Test.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Test.Controllers;

[ApiController]
[Route("[controller]")]
public class CreateController : Controller
{
    [HttpPost]
    public People Post([FromBody] People req)
    {
        People resp = new People();
        try
        {
            resp.FirstName = req.FirstName;
            resp.LastName = req.LastName;
            string json = JsonSerializer.Serialize(req);
            var saveName = req.FirstName + "_" + req.LastName + ".json";
            System.IO.File.WriteAllText("./Upload/" + saveName, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
        return resp;
    }

}

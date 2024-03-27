// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Refit;

Console.WriteLine("Hello, World!");
//var baseUrl = "https://hospital-management-system-backend-7fee.vercel.app/api/v1";
var baseUrl = "https://hospital-management-system-backend.vercel.app/api/v1";

//var jsonStr = await File.ReadAllTextAsync("diseases.json");
//var lst = JsonConvert.DeserializeObject<List<Disease>>(jsonStr);

//var apiService = RestService.For<IDiseaseApi>(baseUrl);
//foreach (var item in lst)
//{
//    await apiService.Post(item);
//}

//var jsonStr = await File.ReadAllTextAsync("room.json");
//var lst = JsonConvert.DeserializeObject<List<Room>>(jsonStr);

//var apiService = RestService.For<IRoomApi>(baseUrl);
//foreach (var item in lst)
//{
//    await apiService.Post(item);
//}

var jsonStr = await File.ReadAllTextAsync("role.json");
var lst = JsonConvert.DeserializeObject<List<Role>>(jsonStr);


var apiService = RestService.For<IRoleApi>(baseUrl);
foreach (var item in lst)
{
    await apiService.Post(item);
}
Console.WriteLine("completed...");
Console.ReadKey();

public interface IDiseaseApi
{ 
    [Post("/Diseases")]
    Task Post(Disease item);
}

public interface IRoomApi
{
    [Post("/Rooms")]
    Task Post(Room item);
}

public interface IRoleApi
{
    [Post("/doctor-specialist/create")]
    Task Post(Role item);
}


public class Disease
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Room
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Role
{
    public string Name { get; set; }
    public string Description { get; set; }
}
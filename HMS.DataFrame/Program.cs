// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Refit;

Console.WriteLine("Hello, World!");

//var jsonStr = await File.ReadAllTextAsync("diseases.json");
//var lst = JsonConvert.DeserializeObject<List<Disease>>(jsonStr);

//var baseUrl = "https://hospital-management-system-backend-7fee.vercel.app/api/v1";

//var apiService = RestService.For<IDiseaseApi>(baseUrl);
//foreach (var item in lst)
//{
//    await apiService.Post(item);
//}



Console.ReadKey();

public interface IDiseaseApi
{
    [Post("/diseases")]
    Task Post(Disease disease);
}

public class Disease
{
    public int id { get; set; }
    public string name { get; set; }
}
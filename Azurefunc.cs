#r "Newtonsoft.Json"
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
  dynamic content = await req.Content.ReadAsStringAsync();
  
  log.Info("C# HTTP trigger function processed a request: " + content);
  
  
  return req.CreateResponse(HttpStatusCode.OK, "Executed");

  } 

  


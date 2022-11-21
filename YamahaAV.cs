using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using YamahaReceiverLib.System;

namespace YamahaReceiverLib;

public class YamahaAV
{
    public static string ip { get; set; }
    public bool MinimalLog { get; set; }
    public static bool AutoFormatedJson { get; set; }

    public string HttpGet(string path)
    {
        if (ip != null)
        {
            if (path != null)
            {
                try
                {
                    using (WebClient webClient = new())
                    {
                        var url = $"http://{ip}/YamahaExtendedControl{path}";
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        var response = webClient.DownloadString(url);
                        if (AutoFormatedJson)
                            return JValue.Parse(response).ToString(Formatting.Indented);
                        else
                            return response;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "PATH ERROR";
            }
        }
        else
        {
            return "NO IP FOUND !";
        }
    }

    public string HttpSet(string path, string header = "")
    {
        if (ip != null)
        {
            if (path != null)
            {
                try
                {
                    using (WebClient webClient = new())
                    {
                        var url = $"http://{ip}/YamahaExtendedControl{path}";
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        Console.WriteLine(header);
                        var response = webClient.UploadString(url, "post" ,header);
                        if (AutoFormatedJson)
                            return JValue.Parse(response).ToString(Formatting.Indented);
                        else
                            return response;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "PATH ERROR";
            }
        }
        else
        {
            return "NO IP FOUND !";
        }
    }
}
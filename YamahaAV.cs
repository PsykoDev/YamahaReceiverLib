#region

using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

#endregion

namespace YamahaReceiverLib;

public class YamahaAV
{
    public static string ip { get; set; }
    public static bool MinimalLog { get; set; } = false;
    public static bool AutoFormatedJson { get; set; } = false;

    public async Task<string> HttpGet(string path)
    {
        if (ip != null)
        {
            if (path != null)
                try
                {
                    using (HttpClient webClient = new())
                    {
                        var url = $"http://{ip}/YamahaExtendedControl{path}";
                        webClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                        var response = await webClient.GetStringAsync(url);
                        if (AutoFormatedJson)
                        {
                            var options = new JsonSerializerOptions { WriteIndented = true };
                            return JsonNode.Parse(response).ToJsonString(options);
                        }

                        if (MinimalLog)
                            return ErrorCode(response);
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            return "PATH ERROR";
        }

        return "NO IP FOUND !";
    }

    public async Task<string> HttpSet(string path, string header = "")
    {
        if (ip != null)
        {
            if (path != null)
                try
                {
                    using (HttpClient httpclient = new())
                    {
                        var url = $"http://{ip}/YamahaExtendedControl{path}";
                        httpclient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                        var response = await httpclient.PostAsJsonAsync(url, header);
                        if (AutoFormatedJson)
                        {
                            var options = new JsonSerializerOptions { WriteIndented = true };
                            return JsonNode.Parse(response.Content.ReadAsStringAsync().Result).ToJsonString(options);
                        }

                        if (MinimalLog)
                            return ErrorCode(response.Content.ReadAsStringAsync().Result);
                        return response.Content.ReadAsStringAsync().Result;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            return "PATH ERROR";
        }

        return "NO IP FOUND !";
    }

    private string ErrorCode(string data)
    {
        var parse = JsonNode.Parse(data);
        switch ((int)parse["response_code"])
        {
            case 0: return "0 Successful request";
            case 1: return "1 Initializing";
            case 2: return "2 Internal Error";
            case 3: return "3 Invalid Request (A method did not exist, a method wasn’t appropriate etc.)";
            case 4: return "4 Invalid Parameter (Out of range, invalid characters etc.)";
            case 5: return "5 Guarded (Unable to setup in current status etc.)";
            case 6: return "6 Time Out";
            case 99: return "99 Firmware Updating";
            case 100: return "(Streaming Service related errors) \n\t100 Access Error";
            case 101: return "(Streaming Service related errors) \n\t101 Other Errors";
            case 102: return "(Streaming Service related errors) \n\t102 Wrong User Name";
            case 103: return "(Streaming Service related errors) \n\t103 Wrong Password";
            case 104: return "(Streaming Service related errors) \n\t104 Account Expired";
            case 105: return "(Streaming Service related errors) \n\t105 Account Disconnected/Gone Off/Shut Down";
            case 106: return "(Streaming Service related errors) \n\t106 Account Number Reached to the Limit";
            case 107: return "(Streaming Service related errors) \n\t107 Server Maintenance";
            case 108: return "(Streaming Service related errors) \n\t108 Invalid Account";
            case 109: return "(Streaming Service related errors) \n\t109 License Error";
            case 110: return "(Streaming Service related errors) \n\t110 Read Only Mode";
            case 111: return "(Streaming Service related errors) \n\t111 Max Stations";
            case 112: return "(Streaming Service related errors) \n\t112 Access Denied";
            case 113: return "(Streaming Service related errors) \n\t113 There is a need to specify the additional destination Playlist";
            case 114: return "(Streaming Service related errors) \n\t114 There is a need to create a new Playlist";
            case 115: return "(Streaming Service related errors) \n\t115 Simultaneous logins has reached the upper limit";
            case 200: return "(distribution related errors) \n\t200 Linking in progress";
            case 201: return "(distribution related errors) \n\t201 Unlinking in progress";
            default: return data;
        }
    }
}
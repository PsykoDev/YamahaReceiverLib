namespace YamahaReceiverLib.Network_USB;

/// <summary>
///     APIs in regard to Link distribution related setting and getting information
/// </summary>
public class DistributionConfig : YamahaAV
{
    public enum zone
    {
        main,
        zone2,
        zone3,
        zone4
    }


    /// <summary>
    ///     For retrieving a Device information related to Link distribution
    /// </summary>
    /// <returns></returns>
    public async Task<string> getDistributionInfo() => await HttpGet("/v1/dist/getDistributionInfo");

    /// <summary>
    ///     For setting a Link distribution server (Link master)
    /// </summary>
    /// <param name="data"></param>
    /// <example>
    ///     {
    ///     "group_id":"9A237BF5AB80ED3C7251DFF49825CA42",
    ///     "zone":"main",
    ///     "type":"add",
    ///     "client_list":[
    ///     "192.168.0.5",
    ///     "192.168.0.11"
    ///     ]
    ///     }
    /// </example>
    /// <returns></returns>
    public async Task<string> setServerInfo(string data) => await HttpSet("/v1/dist/setServerInfo", data);

    /// <summary>
    /// </summary>
    /// <param name="data"></param>
    /// <example>
    ///     {
    ///     "group_id":"9A237BF5AB80ED3C7251DFF49825CA42",
    ///     "zone":[
    ///     "main",
    ///     "zone2"
    ///     ]
    ///     }
    /// </example>
    /// <returns></returns>
    public async Task<string> setClientInfo(string data) => await HttpSet("/v1/dist/setClientInfo", data);

    /// <summary>
    ///     For initiating Link distribution. This is valid to a Device that is setup as Link distribution server
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> startDistribution(int num) => await HttpGet($"/v1/dist/startDistribution?num={num}");

    /// <summary>
    ///     For quitting Link distribution. This is valid to a Device that is setup as Link distribution server
    /// </summary>
    /// <returns></returns>
    public async Task<string> stopDistribution() => await HttpGet("/v1/dist/stopDistribution");

    /// <summary>
    ///     For setting up Group Name. Note that Group Name is reserved in volatile memory
    /// </summary>
    /// <param name="data"></param>
    /// <example>
    ///     {
    ///     "name":"[Link] Living Room"
    ///     }
    /// </example>
    /// <returns></returns>
    public async Task<string> setGroupName(string data) => await HttpSet("/v1/dist/setGroupName", data);
}
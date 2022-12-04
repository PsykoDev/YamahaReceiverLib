namespace YamahaReceiverLib.Clock;

public partial class ClockConfig : YamahaAV
{
    /// <summary>
    /// For retrieving setting related to Clock function
    /// </summary>
    /// <returns></returns>
    public async Task<string> getSettings() => await HttpGet("/v1/clock/getSettings");

    /// <summary>
    /// For setting clock time auto sync. Available only when "date_and_time" exists in clock - func_list under /system/getFeatures.
    /// </summary>
    /// <returns></returns>
    public async Task<string> setAutoSync() => await HttpGet("/v1/clock/setAutoSync");

    /// <summary>
    /// For setting date and clock time. Available only when "date_and_time" exists in clock - func_list under /system/getFeatures.
    /// </summary>
    /// <param name="YYMMDDhhmmss"></param>
    /// <returns></returns>
    public async Task<string> setDateAndTime(string YYMMDDhhmmss) => await HttpGet($"/v1/clock/setDateAndTime?data_time={YYMMDDhhmmss}");

    /// <summary>
    /// For setting format of time display. Available only when " clock_format " exists in clock - func_list under /system/getFeatures.
    /// </summary>
    /// <param name="clock_format"></param>
    /// <returns></returns>
    public async Task<string> setClockFormat(string clock_format = "24h") => await HttpGet($"/v1/clock/setClockFormat?format={clock_format}");

    /// <summary>
    /// For setting aram function
    /// </summary>
    /// <example>
    /// {
    ///  "alarm_on":true,
    ///  "volume":40,
    ///  "fade_interval":180,
    ///  "fade_type":1,
    ///  "mode":"oneday",
    ///  "repeat":false,
    ///  "detail":{
    ///  "day":"oneday",
    ///  "enable":true,
    ///  "time":"0730",
    ///  "beep":false,
    ///  "playback_type":"preset",
    ///  "preset":{
    ///  "type":"netusb",
    ///  "num":8
    ///  }
    ///  }
    /// }
    /// </example>
    /// <param name="data"></param>
    /// <returns></returns>
    public async Task<string> setAlarmSettings(string data) => await HttpSet("/v1/clock/setAlarmSettings", data);
}
namespace YamahaReceiverLib.Clock;

public class ClockConfig : YamahaAV
{
    public string getSettings()
    {
        return HttpGet($"/v1/clock/getSettings");
    }

    public string setAutoSync()
    {
        return HttpGet($"/v1/clock/setAutoSync");
    }

    public string setDateAndTime(string YYMMDDhhmmss)
    {
        return HttpGet($"/v1/clock/setDateAndTime?data_time={YYMMDDhhmmss}");
    }

    public string setClockFormat(string clock_format = "24h")
    {
        return HttpGet($"/v1/clock/setClockFormat?format={clock_format}");
    }

    public string setAlarmSettings()
    {
        return HttpSet($"/v1/clock/setAlarmSettings");
    }
}

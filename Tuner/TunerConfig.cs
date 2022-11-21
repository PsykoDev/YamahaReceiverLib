namespace YamahaReceiverLib.Tuner;

public class TunerConfig : YamahaAV
{
    public enum zoneTuner
    {
        main,
        zone2,
        zone3,
        zone4
    }

    public enum dir
    {
        next,
        previous
    }

    public enum action
    {
        start,
        stop,
        up,
        down
    }

    public enum band
    {
        am,
        fm,
        dab
    }

    public enum tuning
    {
        up,
        down,
        cancel,
        auto_up,
        auto_down,
        tp_up,
        tp_down,
        direct
    }

    public string getPresetInfo(zoneTuner zone, string band)
    {
        return HttpGet($"/v1/{zone}/getPresetInfo?band={band}");
    }

    public string getPlayInfo()
    {
        return HttpGet($"/v1/tuner/getPlayInfo");
    }

    public string setBand(band band)
    {
        return HttpGet($"/v1/tuner/setBand?band={band}");
    }

    public string setFreq(band band, tuning tuning)
    {
        return HttpGet($"/v1/tuner/setFreq?band={band}&tuning={tuning}");
    }

    public string recallPreset(zoneTuner zone, band band, int num)
    {
        return HttpGet($"/v1/tuner/recallPreset?zone={zone}&band={band}&num={num}");
    }

    public string switchPreset(dir dir)
    {
        return HttpGet($"/v1/tuner/switchPreset?dir={dir}");
    }

    public string storePreset(int num)
    {
        return HttpGet($"/v1/tuner/storePreset?num={num}");
    }

    public string clearPreset(band band, int num)
    {
        return HttpGet($"/v1/tuner/clearPreset?band={band}&num={num}");
    }

    public string startAutoPreset(band band)
    {
        return HttpGet($"/v1/tuner/startAutoPreset?band={band}");
    }

    public string cancelAutoPreset(band band)
    {
        return HttpGet($"/v1/tuner/cancelAutoPreset?band={band}");
    }

    public string movePreset(band band, int from, int to)
    {
        return HttpGet($"/v1/tuner/movePreset?band={band}&from={from}&to={to}");
    }

    public string startDabInitialScan()
    {
        return HttpGet($"/v1/tuner/startDabInitialScan");
    }

    public string cancelDabInitialScan()
    {
        return HttpGet($"/v1/tuner/cancelDabInitialScan");
    }

    public string setDabTuneAid(action action)
    {
        return HttpGet($"/v1/tuner/setDabTuneAid?action={action}");
    }

    public string setDabService(dir dir)
    {
        return HttpGet($"/v1/tuner/setDabService?dir={dir}");
    }
}

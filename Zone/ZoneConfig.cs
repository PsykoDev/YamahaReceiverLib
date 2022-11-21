namespace YamahaReceiverLib.Zone;

public class ZoneConfig : YamahaAV
{
    public enum zone
    {
        main,
        zone2,
        zone3,
        zone4
    }

    public string getStatus(zone zone)
    {
        return HttpGet($"/v1/{zone}/getStatus");
    }

    public string getSoundProgramList(zone zone)
    {
        return HttpGet("/v1/{zone}/getSoundProgramList");
    }

    public string setPower(zone zone, string code)
    {
        return HttpGet($"/v1/{zone}/setPower?code={code}"); // ??????
    }


    public string setSleep(zone zone, int sleep)
    {
        return HttpGet($"/v1/{zone}/setSleep?sleep={sleep}");
    }

    public string setVolume(zone zone, int level)
    {
        return HttpGet($"/v1/{zone}/setVolume?volume={level}");
    }

    public string setMute(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setMute?enable={boolvalue.ToLower()}");
    }

    public string setInput(zone zone, string boolvalue, string mode)
    {
        return HttpGet($"/v1/{zone}/setInput?input={boolvalue.ToLower()}&mode={mode}");
    }

    public string setSoundProgram(zone zone, string program)
    {
        return HttpGet($"/v1/{zone}/setSoundProgram?program={program}");
    }

    public string set3dSurround(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/set3dSurround?enable={boolvalue.ToLower()}");
    }

    public string setDirect(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setDirect?enable={boolvalue.ToLower()}");
    }

    public string setPureDirect(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setPureDirect?enable={boolvalue.ToLower()}");
    }

    public string setEnhancer(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setEnhancer?enable={boolvalue.ToLower()}");
    }

    public string setToneControl(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setToneControl?enable={boolvalue.ToLower()}");
    }

    public string setEqualizer(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setEqualizer?enable={boolvalue.ToLower()}");
    }

    public string setBalance(zone zone, int value = 0)
    {
        return HttpGet($"/v1/{zone}/setBalance?value={value}");
    }

    public string setDialogueLevel(zone zone, int value = 0)
    {
        return HttpGet($"/v1/{zone}/setDialogueLevel?value={value}");
    }

    public string setDialogueLift(zone zone, int value = 0)
    {
        return HttpGet($"/v1/{zone}/setDialogueLift?value={value}");
    }

    public string setClearVoice(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setClearVoice?enable={boolvalue.ToLower()}");
    }
    
    public string setSubwooferVolume(zone zone, int volume = 0)
    {
        return HttpGet($"/v1/{zone}/setSubwooferVolume?volume={volume}");
    }

    public string setBassExtension(zone zone, string boolvalue)
    {
        return HttpGet($"/v1/{zone}/setBassExtension?enable={boolvalue.ToLower()}");
    }


    public string getSignalInfo(zone zone)
    {
        return HttpGet($"/v1/{zone}/getSignalInfo");
    }

    public string prepareInputChange(zone zone, string input)
    {
        return HttpGet($"/v1/{zone}/prepareInputChange?input={input}");
    }

}

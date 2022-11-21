namespace YamahaReceiverLib.Network_USB;

public class Network_USBConfig : YamahaAV
{
    public string getPresetInfo()
    {
        return HttpGet($"/v1/netusb/getPresetInfo");
    }

    public string getPlayInfo()
    {
        return HttpGet($"/v1/netusb/getPlayInfo");
    }

    public enum playback
    {
        play,
        stop,
        pause,
        play_pause,
        previous,
        next,
        fast_reverse_start,
        fast_reverse_end,
        fast_forward_start,
        fast_forward_end
    }

    public string setPlayback(playback playback)
    {
        return HttpGet($"/v1/netusb/setPlayback?playback={playback}");
    }

    public string setPlayPosition(int position)
    {
        return HttpGet($"/v1/netusb/setPlayPosition?position={position}");
    }

    public string toggleRepeat()
    {
        return HttpGet($"/v1/netusb/toggleRepeat");
    }

    public string toggleShuffle()
    {
        return HttpGet($"/v1/netusb/toggleShuffle");
    }

    public string getListInfo(int index, int size, string lang, string input = "usb")
    {
        return HttpGet($"/v1/netusb/getListInfo?input={input}&index={index}&size={size}&lang={lang}");
    }

    public string setListControl(int index, int size, string lang, string list_id = "auto_complete")
    {
        return HttpGet($"/v1/netusb/setListControl?list_id={list_id}&index={index}&size={size}&lang={lang}");
    }

    public string setSearchString()
    {
        return HttpGet($"/v1/netusb/setSearchString");
    }

    public enum zoneNetUsb
    {
        main,
        zone2,
        zone3,
        zone4
    }

    public string recallPreset(zoneNetUsb zone, int num)
    {
        return HttpGet($"/v1/netusb/recallPreset?zone={zone}&num={num}");
    }

    public string storePreset(int num)
    {
        return HttpGet($"/v1/netusb/storePreset?num={num}");
    }

    public string clearPreset(int num)
    {
        return HttpGet($"/v1/netusb/clearPreset?num={num}");
    }

    public string movePreset(int from, int to)
    {
        return HttpGet($"/v1/netusb/movePreset?from={from}&to={to}");
    }

    public string getSettings()
    {
        return HttpGet($"/v1/netusb/getSettings");
    }

    public enum quality
    {
        hr_192_24,
        hr_96_24,
        cd_44_16,
        mp3_320
    }

    public string setQuality(quality value, string input = "qobuz")
    {
        return HttpGet($"/v1/netusb/setQuality?input={input}&value={value}");
    }

    public string getRecentInfo()
    {
        return HttpGet($"/v1/netusb/getRecentInfo");
    }

    public string recallRecentItem(zoneNetUsb zone, int num)
    {
        return HttpGet($"/v1/netusb/recallRecentItem?zone={zone}&num={num}");
    }

    public string clearRecentInfo()
    {
        return HttpGet($"/v1/netusb/clearRecentInfo");
    }

    public string managePlay()
    {
        return HttpGet($"/v1/netusb/managePlay"); // ???????
    }

    public string manageList()
    {
        return HttpGet($"/v1/netusb/manageList"); // ???????
    }

    public string getPlayDescription(string type = "why_this_song", int timeout = 0)
    {
        return HttpGet($"/v1/netusb/getPlayDescription?type={type}&timeout={timeout}");
    }

    public string setListSortOption(string input = "pandora", string type = "alphabet")
    {
        return HttpGet($"/v1/netusb/setListSortOption?input={input}&timeout={type}");
    }

    public string getAccountStatus()
    {
        return HttpGet($"/v1/netusb/getAccountStatus");
    }

    public string switchAccount(string input = "pandora", int index = 0, int timeout = 0)
    {
        return HttpGet($"/v1/netusb/switchAccount?type={input}&index={index}&timeout={timeout}");
    }

    public string getServiceInfo()
    {
        return HttpGet($"/v1/netusb/getServiceInfo"); // ???????
    }
}

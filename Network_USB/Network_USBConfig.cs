using System;

namespace YamahaReceiverLib.Network_USB;

public partial class Network_USBConfig : YamahaAV
{
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

    public enum quality
    {
        hr_192_24,
        hr_96_24,
        cd_44_16,
        mp3_320
    }

    public enum zoneNetUsb
    {
        main,
        zone2,
        zone3,
        zone4
    }

    /// <summary>
    /// For retrieving preset information. Presets are common use among Net/USB related input sources
    /// </summary>
    /// <returns></returns>
    public async Task<string> getPresetInfo() => await HttpGet("/v1/netusb/getPresetInfo");

    /// <summary>
    /// For retrieving playback information
    /// </summary>
    /// <returns></returns>
    public async Task<string> getPlayInfo() => await HttpGet("/v1/netusb/getPlayInfo");

    /// <summary>
    /// For controlling playback status
    /// </summary>
    /// <param name="playback"></param>
    /// <returns></returns>
    public async Task<string> setPlayback(playback playback) => await HttpGet($"/v1/netusb/setPlayback?playback={playback}");

    /// <summary>
    /// For setting track play position. This API is available only when input is Server.
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    public async Task<string> setPlayPosition(int position) => await HttpGet($"/v1/netusb/setPlayPosition?position={position}");

    /// <summary>
    /// For toggling repeat setting. No direct / discrete setting commands available
    /// </summary>
    /// <returns></returns>
    public async Task<string> toggleRepeat() => await HttpGet("/v1/netusb/toggleRepeat");

    /// <summary>
    /// For toggling shuffle setting. No direct / discrete setting commands available
    /// </summary>
    /// <returns></returns>
    public async Task<string> toggleShuffle() => await HttpGet("/v1/netusb/toggleShuffle");

    /// <summary>
    /// For retrieving list information. Basically this info is available to all relevant inputs, not limited to or independent from current input
    /// </summary>
    /// <param name="index"></param>
    /// <param name="size"></param>
    /// <param name="lang"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<string> getListInfo(int index, int size, string lang, string input = "usb") => await HttpGet($"/v1/netusb/getListInfo?input={input}&index={index}&size={size}&lang={lang}");

    /// <summary>
    /// For control a list. Controllable list info is not limited to or independent from current input
    /// </summary>
    /// <param name="index"></param>
    /// <param name="size"></param>
    /// <param name="lang"></param>
    /// <param name="list_id"></param>
    /// <returns></returns>
    public async Task<string> setListControl(int index, int size, string lang, string list_id = "auto_complete") => await HttpGet($"/v1/netusb/setListControl?list_id={list_id}&index={index}&size={size}&lang={lang}");

    /// <summary>
    /// For setting search text. Specifies string executing this API before select an element with its attribute being “Capable of Search” or retrieve info about searching list(Pandora).
    /// </summary>
    /// <returns></returns>
    public async Task<string> setSearchString() => await HttpGet("/v1/netusb/setSearchString");

    /// <summary>
    /// For recalling a content preset
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> recallPreset(zoneNetUsb zone, int num) => await HttpGet($"/v1/netusb/recallPreset?zone={zone}&num={num}");

    /// <summary>
    /// For registering current content to a preset. Presets are common use among Net/USB related input sources.
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> storePreset(int num) => await HttpGet($"/v1/netusb/storePreset?num={num}");

    /// <summary>
    /// For clearing Preset
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> clearPreset(int num) => await HttpGet($"/v1/netusb/clearPreset?num={num}");

    /// <summary>
    /// For moving preset. For example, if excute movePreset?from=4&to=2 for list {[A], [B], [C], [D], [E] ...}, list is arranged as {[A], [D], [B], [C], [E] ...}. 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public async Task<string> movePreset(int from, int to) => await HttpGet($"/v1/netusb/movePreset?from={from}&to={to}");

    /// <summary>
    /// For retrieving setup of Net/USB
    /// </summary>
    /// <returns></returns>
    public async Task<string> getSettings() => await HttpGet("/v1/netusb/getSettings");

    /// <summary>
    /// For setting the reproduction quality of streaming. Refer to available Input/setting value via /system/getSetting.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<string> setQuality(quality value, string input = "qobuz") => await HttpGet($"/v1/netusb/setQuality?input={input}&value={value}");

    /// <summary>
    /// For retrieving playback history. History is shared among all Net/USB Input sources.
    /// </summary>
    /// <returns></returns>
    public async Task<string> getRecentInfo() => await HttpGet("/v1/netusb/getRecentInfo");

    /// <summary>
    /// For recalling a content via playback history
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> recallRecentItem(zoneNetUsb zone, int num) => await HttpGet($"/v1/netusb/recallRecentItem?zone={zone}&num={num}");

    /// <summary>
    /// For clearing all recent history informaiton
    /// </summary>
    /// <returns></returns>
    public async Task<string> clearRecentInfo() => await HttpGet("/v1/netusb/clearRecentInfo");

    /// <summary>
    /// For special processing for track
    /// </summary>
    /// <returns></returns>
    public async Task<string> managePlay() => await HttpGet("/v1/netusb/managePlay"); // ???????

    /// <summary>
    /// For special processing for list
    /// </summary>
    /// <returns></returns>
    public async Task<string> manageList() => await HttpGet("/v1/netusb/manageList"); // ???????

    /// <summary>
    /// For retrieving track’s detail information
    /// </summary>
    /// <param name="type"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<string> getPlayDescription(string type = "why_this_song", int timeout = 0) => await HttpGet($"/v1/netusb/getPlayDescription?type={type}&timeout={timeout}");

    /// <summary>
    /// For setting List sorting method. Retrieve List information via /netusb/getListInfo after setting.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public async Task<string> setListSortOption(string input = "pandora", string type = "alphabet") => await HttpGet($"/v1/netusb/setListSortOption?input={input}&timeout={type}");

    /// <summary>
    /// For retrieving account information registered on Device
    /// </summary>
    /// <returns></returns>
    public async Task<string> getAccountStatus() => await HttpGet("/v1/netusb/getAccountStatus");

    /// <summary>
    /// For switching account for service corresponding multi account
    /// </summary>
    /// <param name="input"></param>
    /// <param name="index"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<string> switchAccount(string input = "pandora", int index = 0, int timeout = 0) => await HttpGet($"/v1/netusb/switchAccount?type={input}&index={index}&timeout={timeout}");

    /// <summary>
    /// For retrieving information of various Streaming Service. The combination of Input/Type is available as follows;
    /// </summary>
    /// <returns></returns>
    public async Task<string> getServiceInfo() => await HttpGet("/v1/netusb/getServiceInfo"); // ???????
}
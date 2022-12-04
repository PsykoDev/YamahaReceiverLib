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

    /// <summary>
    ///     For retrieving basic information of each Zone like power, volume, input and so on
    /// </summary>
    /// <param name="zone"></param>
    /// <returns></returns>
    public async Task<string> getStatus(zone zone) => await HttpGet($"/v1/{zone}/getStatus");

    /// <summary>
    ///     For retrieving a list of Sound Program available in each Zone. It is possible for the list contents to be
    ///     dynamically changed
    /// </summary>
    /// <param name="zone"></param>
    /// <returns></returns>
    public async Task<string> getSoundProgramList(zone zone) => await HttpGet("/v1/{zone}/getSoundProgramList");

    /// <summary>
    ///     For setting power status of each Zone
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="code"></param>
    /// <returns></returns>
    public async Task<string> setPower(zone zone, string code = "toggle") => await HttpGet($"/v1/{zone}/setPower?code={code}");// ??????

    /// <summary>
    ///     For setting Sleep Timer for each Zone With Zone B enabled Devices, target Zone is described as Master Power, but
    ///     Main Zone is used to set it up via YXC
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="sleep"></param>
    /// <returns></returns>
    public async Task<string> setSleep(zone zone, int sleep) => await HttpGet($"/v1/{zone}/setSleep?sleep={sleep}");

    /// <summary>
    ///     For setting volume in each Zone. Values of specifying range and steps are different. There are some Devices that
    ///     cannot allow this value to be go up to Device’s maximum volume.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="level"></param>
    /// <returns></returns>
    public async Task<string> setVolume(zone zone, int level) => await HttpGet($"/v1/{zone}/setVolume?volume={level}");

    /// <summary>
    ///     For setting mute status in each Zone
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setMute(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setMute?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For selecting each Zone input
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public async Task<string> setInput(zone zone, string boolvalue, string mode) => await HttpGet($"/v1/{zone}/setInput?input={boolvalue.ToLower()}&mode={mode}");

    /// <summary>
    ///     For selecting Sound Programs
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="program"></param>
    /// <returns></returns>
    public async Task<string> setSoundProgram(zone zone, string program) => await HttpGet($"/v1/{zone}/setSoundProgram?program={program}");

    /// <summary>
    ///     For setting 3D Surround status
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> set3dSurround(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/set3dSurround?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Direct status
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setDirect(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setDirect?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Pure Direct status
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setPureDirect(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setPureDirect?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Enhancer status
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setEnhancer(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setEnhancer?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Tone Control in each Zone. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setToneControl(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setToneControl?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Equalizer in each Zone. Values of specifying range and steps are different
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setEqualizer(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setEqualizer?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting L/R Balance in each Zone’s speaker. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task<string> setBalance(zone zone, int value = 0) => await HttpGet($"/v1/{zone}/setBalance?value={value}");

    /// <summary>
    ///     For setting Dialogue Level in each Zone. Values of specifying range and steps are different
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task<string> setDialogueLevel(zone zone, int value = 0) => await HttpGet($"/v1/{zone}/setDialogueLevel?value={value}");

    /// <summary>
    ///     For setting Dialogue Lift in each Zone. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task<string> setDialogueLift(zone zone, int value = 0) => await HttpGet($"/v1/{zone}/setDialogueLift?value={value}");

    /// <summary>
    ///     For setting Clear Voice in each Zone.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setClearVoice(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setClearVoice?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For setting Subwoofer Volume in each Zone
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="volume"></param>
    /// <returns></returns>
    public async Task<string> setSubwooferVolume(zone zone, int volume = 0) => await HttpGet($"/v1/{zone}/setSubwooferVolume?volume={volume}");

    /// <summary>
    ///     For setting Bass Extension in each Zone.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setBassExtension(zone zone, string boolvalue) => await HttpGet($"/v1/{zone}/setBassExtension?enable={boolvalue.ToLower()}");

    /// <summary>
    ///     For retrieving current playback signal information in each Zone
    /// </summary>
    /// <param name="zone"> Enum Zone</param>
    /// <returns></returns>
    public async Task<string> getSignalInfo(zone zone) => await HttpGet($"/v1/{zone}/getSignalInfo");

    /// <summary>
    ///     Let a Device do necessary process before changing input in a specific zone. This is valid only when
    ///     “prepare_input_change” exists in “func_list” found in /system/getFuncStatus. MusicCast CONTROLLER executes this API
    ///     when an input icon is selected in a Room, right before sending various APIs (of retrieving list information etc.)
    ///     regarding selecting input
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<string> prepareInputChange(zone zone, string input) => await HttpGet($"/v1/{zone}/prepareInputChange?input={input}");

    /// <summary>
    ///     For setting Link Control in each Zone
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<string> setLinkControl(zone zone, string control) => await HttpGet($"/v1/{zone}/setLinkControl?control={control}");

    /// <summary>
    ///     For setting Link Audio Delay in each Zone. This setting is invalid when Link Control setting is " Stability Boost "
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="delay"></param>
    /// <returns></returns>
    public async Task<string> setLinkAudioDelay(zone zone, string delay) => await HttpGet($"/v1/{zone}/setLinkAudioDelay?delay={delay}");

    /// <summary>
    ///     For setting Link Audio Quality in each Zone.
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public async Task<string> setLinkAudioQuality(zone zone, string mode) => await HttpGet($"/v1/{zone}/setLinkAudioQuality?mode={mode}");
}
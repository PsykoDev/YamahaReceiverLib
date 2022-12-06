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
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> getStatus(zone zone = zone.main) => await HttpGet($"/v1/{zone}/getStatus");

    /// <summary>
    ///     For retrieving a list of Sound Program available in each Zone. It is possible for the list contents to be
    ///     dynamically changed
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> getSoundProgramList(zone zone = zone.main) => await HttpGet("/v1/{zone}/getSoundProgramList");

    /// <summary>
    ///     For setting power status of each Zone
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="power">Values: "on" / "standby" / "toggle"</param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setPower(zone zone = zone.main, string power = "toggle") => await HttpGet($"/v1/{zone}/setPower?power={power}");

    /// <summary>
    ///     For setting Sleep Timer for each Zone With Zone B enabled Devices, target Zone is described as Master Power, but
    ///     Main Zone is used to set it up via YXC
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="sleep"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setSleep(int sleep, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setSleep?sleep={sleep}");

    /// <summary>
    ///     For setting volume in each Zone. Values of specifying range and steps are different. There are some Devices that
    ///     cannot allow this value to be go up to Device’s maximum volume.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="volume"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setVolume(int volume, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setVolume?volume={volume}");

    /// <summary>
    ///     For setting mute status in each Zone
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setMute(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setMute?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For selecting each Zone input
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="input"></param>
    /// <param name="mode"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setInput(string input, zone zone = zone.main, string mode = "") => await HttpGet($"/v1/{zone}/setInput?input={input}&mode={mode}");

    /// <summary>
    ///     For selecting Sound Programs
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="program"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setSoundProgram(string program, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setSoundProgram?program={program}");

    /// <summary>
    ///     For setting 3D Surround status
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> set3dSurround(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/set3dSurround?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Direct status
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setDirect(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setDirect?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Pure Direct status
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setPureDirect(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setPureDirect?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Enhancer status
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setEnhancer(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setEnhancer?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    /// For setting Tone Control in each Zone. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="bass"></param>
    /// <param name="mode"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setToneControl(int? treble, int? bass, zone zone = zone.main, string mode = "Manual") => await HttpGet($"/v1/{zone}/setToneControl?mode={mode}&bass={bass}&treble={treble}");

    /// <summary>
    ///     For setting Equalizer in each Zone. Values of specifying range and steps are different
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setEqualizer(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setEqualizer?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting L/R Balance in each Zone’s speaker. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="value"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setBalance(zone zone = zone.main, int value = 0) => await HttpGet($"/v1/{zone}/setBalance?value={value}");

    /// <summary>
    ///     For setting Dialogue Level in each Zone. Values of specifying range and steps are different
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="value"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setDialogueLevel(zone zone = zone.main, int value = 0) => await HttpGet($"/v1/{zone}/setDialogueLevel?value={value}");

    /// <summary>
    ///     For setting Dialogue Lift in each Zone. Values of specifying range and steps are different.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="value"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setDialogueLift(zone zone = zone.main, int value = 0) => await HttpGet($"/v1/{zone}/setDialogueLift?value={value}");

    /// <summary>
    ///     For setting Clear Voice in each Zone.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setClearVoice(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setClearVoice?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Subwoofer Volume in each Zone
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="volume"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setSubwooferVolume(zone zone = zone.main, int volume = 0) => await HttpGet($"/v1/{zone}/setSubwooferVolume?volume={volume}");

    /// <summary>
    ///     For setting Bass Extension in each Zone.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setBassExtension(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setBassExtension?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For retrieving current playback signal information in each Zone
    /// </summary>
    /// <param name="zone"> Enum Zone</param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> getSignalInfo(zone zone = zone.main) => await HttpGet($"/v1/{zone}/getSignalInfo");

    /// <summary>
    ///     Let a Device do necessary process before changing input in a specific zone. This is valid only when
    ///     “prepare_input_change” exists in “func_list” found in /system/getFuncStatus. MusicCast CONTROLLER executes this API
    ///     when an input icon is selected in a Room, right before sending various APIs (of retrieving list information etc.)
    ///     regarding selecting input
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="input"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> prepareInputChange(string input, zone zone = zone.main) => await HttpGet($"/v1/{zone}/prepareInputChange?input={input}");

    /// <summary>
    ///     For setting Link Control in each Zone
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="input"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setLinkControl(string control, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setLinkControl?control={control}");

    /// <summary>
    ///     For setting Link Audio Delay in each Zone. This setting is invalid when Link Control setting is " Stability Boost "
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="delay"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setLinkAudioDelay(string delay, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setLinkAudioDelay?delay={delay}");

    /// <summary>
    ///     For setting Link Audio Quality in each Zone.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="mode"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setLinkAudioQuality(string mode, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setLinkAudioQuality?mode={mode}");

    /// <summary>
    /// For setting Extra Bass in each Zone.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setExtraBass(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setExtraBass?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    /// For setting Adaptive DRC in each Zone.
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setAdaptiveDrc(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setAdaptiveDrc?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    /// idk what is that
    /// </summary>
    /// <param name="zone">Values: "main" / "zone2" / "zone3" / "zone4"</param>
    /// <param name="boolvalue"></param>
    /// <returns>String data or just response_code</returns>
    public async Task<string> setContentsDisplay(bool boolvalue, zone zone = zone.main) => await HttpGet($"/v1/{zone}/setContentsDisplay?enable={boolvalue.ToString().ToLower()}");

}
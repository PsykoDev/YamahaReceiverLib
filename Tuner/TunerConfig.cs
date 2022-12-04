namespace YamahaReceiverLib.Tuner;

public partial class TunerConfig : YamahaAV
{
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

    public enum dir
    {
        next,
        previous
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

    public enum zoneTuner
    {
        main,
        zone2,
        zone3,
        zone4
    }

    /// <summary>
    /// For retrieving Tuner preset information
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="band"></param>
    /// <returns></returns>
    public async Task<string> getPresetInfo(zoneTuner zone, string band) => await HttpGet($"/v1/{zone}/getPresetInfo?band={band}");

    /// <summary>
    /// For retrieving playback information of Tuner
    /// </summary>
    /// <returns></returns>
    public async Task<string> getPlayInfo() => await HttpGet("/v1/tuner/getPlayInfo");

    /// <summary>
    /// For setting Tuner Band
    /// </summary>
    /// <param name="band"></param>
    /// <returns></returns>
    public async Task<string> setBand(band band) => await HttpGet($"/v1/tuner/setBand?band={band}");

    /// <summary>
    /// For setting Tuner frequency
    /// </summary>
    /// <param name="band"></param>
    /// <param name="tuning"></param>
    /// <returns></returns>
    public async Task<string> setFreq(band band, tuning tuning) => await HttpGet($"/v1/tuner/setFreq?band={band}&tuning={tuning}");

    /// <summary>
    /// For recalling a Tuner preset
    /// </summary>
    /// <param name="zone"></param>
    /// <param name="band"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> recallPreset(zoneTuner zone, band band, int num) => await HttpGet($"/v1/tuner/recallPreset?zone={zone}&band={band}&num={num}");

    /// <summary>
    /// For selecting Tuner preset. Call this API after change the target zone’s input to Tuner. It is possible to change Band in case of preset type is “common”. In case of preset type is “separate”, need to change the target Band before calling this API. This API is available on and after API Version 1.17.
    /// </summary>
    /// <param name="dir"></param>
    /// <returns></returns>
    public async Task<string> switchPreset(dir dir) => await HttpGet($"/v1/tuner/switchPreset?dir={dir}");

    /// <summary>
    /// For registering current station to a preset
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> storePreset(int num) => await HttpGet($"/v1/tuner/storePreset?num={num}");

    /// <summary>
    /// For clearing Tuner preset. 
    /// </summary>
    /// <param name="band"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public async Task<string> clearPreset(band band, int num) => await HttpGet($"/v1/tuner/clearPreset?band={band}&num={num}");

    /// <summary>
    /// For starting Auto Preset. Available only when "fm_auto_preset" exists in tuner - func_list under /system/getFeatures.
    /// </summary>
    /// <param name="band"></param>
    /// <returns></returns>
    public async Task<string> startAutoPreset(band band) => await HttpGet($"/v1/tuner/startAutoPreset?band={band}");

    /// <summary>
    /// For canceling Auto Preset. Available only when "fm_auto_preset" exists in tuner - func_list under /system/getFeatures
    /// </summary>
    /// <param name="band"></param>
    /// <returns></returns>
    public async Task<string> cancelAutoPreset(band band) => await HttpGet($"/v1/tuner/cancelAutoPreset?band={band}");

    /// <summary>
    /// For moving preset. For example, if excute movePreset?from=4&to=2 for list {[A], [B], [C], [D], [E] ...}, list is arranged as {[A], [D], [B], [C], [E] ...}. 
    /// </summary>
    /// <param name="band"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public async Task<string> movePreset(band band, int from, int to) => await HttpGet($"/v1/tuner/movePreset?band={band}&from={from}&to={to}");

    /// <summary>
    /// For starting DAB Initial Scan. Available only when " dab_initial_scan " exists in tuner - func_list under /system/getFeatures.
    /// </summary>
    /// <returns></returns>
    public async Task<string> startDabInitialScan() => await HttpGet("/v1/tuner/startDabInitialScan");

    /// <summary>
    /// For canceling DAB Initial Scan. Available only when " dab_initial_scan " exists in tuner - func_list under /system/getFeatures.
    /// </summary>
    /// <returns></returns>
    public async Task<string> cancelDabInitialScan() => await HttpGet("/v1/tuner/cancelDabInitialScan");

    /// <summary>
    /// For executing DAB Tune Aid. Available only when " dab_tune_aid " exists in tuner - func_list under /system/getFeatures.
    /// </summary>
    /// <param name="action"></param>
    /// <returns></returns>
    public async Task<string> setDabTuneAid(action action) => await HttpGet($"/v1/tuner/setDabTuneAid?action={action}");

    /// <summary>
    /// For selecting DAB Service. Available only when DAB is valid to use
    /// </summary>
    /// <param name="dir"></param>
    /// <returns></returns>
    public async Task<string> setDabService(dir dir) => await HttpGet($"/v1/tuner/setDabService?dir={dir}");
}
namespace YamahaReceiverLib.CD;

public class CDConfig : YamahaAV
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

    /// <summary>
    ///     For retrieving playback information of CD
    /// </summary>
    /// <returns></returns>
    public async Task<string> getPlayInfo() => await HttpGet("/v1/cd/getPlayInfo");

    /// <summary>
    ///     For controlling playback status
    /// </summary>
    /// <param name="playback"></param>
    /// <returns></returns>
    public async Task<string> setPlayback(playback playback) => await HttpGet($"/v1/cd/setPlayback?playback={playback}");

    /// <summary>
    ///     For toggling CD tray Open/Close setting
    /// </summary>
    /// <returns></returns>
    public async Task<string> toggleTray() => await HttpGet("/v1/cd/toggleTray");

    /// <summary>
    ///     For toggling repeat setting. No direct / discrete setting commands available
    /// </summary>
    /// <returns></returns>
    public async Task<string> toggleRepeat() => await HttpGet("/v1/cd/toggleRepeat");

    /// <summary>
    ///     For toggling shuffle setting. No direct / discrete setting commands available
    /// </summary>
    /// <returns></returns>
    public async Task<string> toggleShuffle() => await HttpGet("/v1/cd/toggleShuffle");
}
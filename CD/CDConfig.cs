
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

    public string getPlayInfo()
    {
        return HttpGet($"/v1/cd/getPlayInfo");
    }

    public string setPlayback(playback playback)
    {
        return HttpGet($"/v1/cd/setPlayback?playback={playback}");
    }

    public string toggleTray()
    {
        return HttpGet($"/v1/cd/toggleTray");
    }

    public string toggleRepeat()
    {
        return HttpGet($"/v1/cd/toggleRepeat");
    }

    public string toggleShuffle()
    {
        return HttpGet($"/v1/cd/toggleShuffle");
    }
}

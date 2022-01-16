using UnityEngine.Audio;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AudioManager : MonoBehaviour
{
    public List<Sound> sounds;
    public enum SoundNames
    {
        Jump,
        Theme,
        Boost,
        Finish,
        CoinPickUp,
        CoinBoost
    }
    void Awake()
    {
        foreach (var s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play(SoundNames.Theme);

    }
    public void Play(SoundNames sound)
    {
        Sound s = sounds.FirstOrDefault(x => x.name == sound.ToString("G"));
        if(s == null)
        {
            Debug.LogWarning($"Sound with name: {sound.ToString("G")} doesnt exist");
            return;
        }
        s.source.Play();
    }
    public void FinishLine()
    {
        foreach (var s in sounds)
        {
            s.source.Stop();
        }
        Play(SoundNames.Finish);
    }
 
}

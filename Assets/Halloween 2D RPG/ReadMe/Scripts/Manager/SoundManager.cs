using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] EffectSource;
    public AudioSource[] BGM;
    public void StartES(int ES)
    {
        EffectSource[ES].Play();
    }
    public void StopES(int ES)
    {
        EffectSource[ES].Stop();
    }
    public void StartBGM(int bgm)
    {
        BGM[bgm].Play();
    }
    public void StopBGM(int bgm)
    {
        BGM[bgm].Stop();
    }
}

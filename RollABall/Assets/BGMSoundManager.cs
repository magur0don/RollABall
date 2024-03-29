using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    // BGMの音源
    public AudioClip BGMAudioClip;



    // BGMを再生するSource
    public AudioSource BGMAudioSource;

    private void Start()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameOverBGM(){ 
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameClearBGM(){ 
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

}

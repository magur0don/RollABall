using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    // BGMÇÃâπåπ
    public AudioClip BGMAudioClip;



    // BGMÇçƒê∂Ç∑ÇÈSource
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

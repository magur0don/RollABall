using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    // BGM�̉���
    public AudioClip BGMAudioClip;



    // BGM���Đ�����Source
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESoundManager : MonoBehaviour
{
    // SE�̉���
    public AudioClip SEAudioClip;

    // SE���Đ�����Source
    public AudioSource SEAudioSource;

    public void PlayPickupItemSE()
    {
        SEAudioSource.clip = SEAudioClip;
        SEAudioSource.Play();
    }

}

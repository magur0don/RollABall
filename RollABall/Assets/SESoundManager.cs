using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESoundManager : MonoBehaviour
{
    // SEÇÃâπåπ
    public AudioClip SEAudioClip;

    // SEÇçƒê∂Ç∑ÇÈSource
    public AudioSource SEAudioSource;

    public void PlayPickupItemSE()
    {
        SEAudioSource.clip = SEAudioClip;
        SEAudioSource.Play();
    }

}

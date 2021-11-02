using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class FishSoundFX : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;
    [SerializeField]private AudioSource audioSource;

    public static FishSoundFX fishSoundFx;
    private void Awake()
    {
        fishSoundFx = this;
    }
    internal void PlayFoodFx()
    {
        RandonPitch();
        audioSource.PlayOneShot(audios[0]);

    }

    internal void PlayObstacleFx(int id)
    {
        RandonPitch();
        audioSource.PlayOneShot(audios[id]);
    }

    void RandonPitch()
    {
        audioSource.pitch = Random.Range(0.5f, 1.5f);
    }
}

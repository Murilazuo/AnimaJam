using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFish : MonoBehaviour
{
    [SerializeField] internal AudioClip[] audioClip;
    [SerializeField] public AudioSource audioFish;
    public static SoundFish soundFish;
    internal int idAudio = 0;
    void Start()
    {
        audioFish.mute = Menu.mute;
        StartCoroutine(nameof(SetAudioClip),0);
        soundFish = this;
    }

    internal IEnumerator SetAudioClip(int audioId)
    {
        idAudio = audioId;

        while (audioFish.volume > 0)
        {
            audioFish.volume -= 0.1f;
            yield return new WaitForSeconds(0.05f);
        }
            audioFish.clip = audioClip[audioId];
            audioFish.Play();
        while (audioFish.volume < Menu.volume)
        {
            audioFish.volume += 0.1f;
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(0.05f);
    }

    public IEnumerator StopAudio()
    {
        while (audioFish.volume > 0)
        {
            audioFish.volume -= 0.1f;
            yield return new WaitForSeconds(0.05f);
        }
        audioFish.Stop();
        audioFish.volume = Menu.volume;
    }

    public void PlaySound(int idSound)
    {
        audioFish.clip = audioClip[idSound];
        audioFish.Play();
    }



}

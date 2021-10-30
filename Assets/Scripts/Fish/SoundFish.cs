using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFish : MonoBehaviour
{
    [SerializeField] internal AudioClip[] audioClip;
    internal AudioSource audioFish;
    
    void Start()
    {
        audioFish = gameObject.AddComponent<AudioSource>();
        audioFish.loop = true;
        StartCoroutine(nameof(SetAudioClip),0);
    }

    internal IEnumerator SetAudioClip(int audioId)
    {
        while (audioFish.volume > 0)
        {
            audioFish.volume -= 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
            audioFish.clip = audioClip[audioId];
            audioFish.Play();
        while (audioFish.volume < Menu.volume)
        {
            audioFish.volume += 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    
   

}

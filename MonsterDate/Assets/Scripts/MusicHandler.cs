using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    public AudioClip[] songs;
    int currentSong = 0;

    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying == false)
        {
            currentSong++;
            if (currentSong == songs.Length)
            {
                currentSong = 1;
                GetComponent<AudioSource>().clip = songs[currentSong];
                GetComponent<AudioSource>().Play();
            }
        }
    }
}

﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager3 : MonoBehaviour
{

    public Sound[] sounds;

    // Awake ist die Methode die vorm Start Audio erstellt
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    void Start()
    {

        Play("Theme");

    }

    public void Play(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{

    public string color;

    private AudioSource bucketAudio;
    public AudioClip bucketAudioName;
    // Start is called before the first frame update
    void Start()
    {
        bucketAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(color);
    }

    internal void PlayColorName()
    {
        bucketAudio.PlayOneShot(bucketAudioName, 1.0f);
    }
}

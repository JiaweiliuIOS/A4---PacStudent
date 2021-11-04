using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource newTrack;
    public AudioSource pellet;
    // Start is called before the first frame update
    void Start()
    {
        bgm.Play();
        newTrack.Stop();
        pellet.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            bgm.Stop();
            newTrack.Play();
        }else if (Input.GetKeyDown(KeyCode.S)){
            bgm.Stop();
            newTrack.Play();
        }
    }

    
    
}

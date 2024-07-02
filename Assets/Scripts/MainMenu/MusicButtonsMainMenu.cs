using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButtonsMainMenu : MonoBehaviour
{

    private AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void ClickButton()
    {
        source.PlayOneShot(clip);
    }
}

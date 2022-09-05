using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    public AudioClip Click;
    public AudioSource music;
    // Start is called before the first frame update


    public void ClickSound(){
        music.PlayOneShot(Click);
    }
    public void QuitButton (){
        Application.Quit();
    }
}

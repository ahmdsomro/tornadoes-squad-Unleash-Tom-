using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{
    public AudioClip click;
    public AudioSource music;
    // Start is called before the first frame update
   public void soundClick(){
    music.PlayOneShot(click);
   }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{
    public AudioSource BGM;
    public GameObject soundOn;
    public GameObject soundOff;
    

    // Start is called before the first frame update
    public void Start(){
        
    }
   public void MuteAllSound(){
    AudioListener.volume=0;
    soundOn.SetActive(true);
    soundOff.SetActive(false);
    
   }
   public void UnMuteSound(){
   
       AudioListener.volume=1;
       soundOn.SetActive(false);
       soundOff.SetActive(true);
   
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;  //value of collectables that player has colllected
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        GameManager.instance.Collect(value,gameObject);
        
    }

}

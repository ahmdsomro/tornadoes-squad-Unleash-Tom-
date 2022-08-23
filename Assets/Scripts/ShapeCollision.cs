using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "Player" :
            Destroy(gameObject);
            break;
        }
    }
}

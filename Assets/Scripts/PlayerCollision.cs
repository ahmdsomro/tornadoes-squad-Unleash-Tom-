using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "obstacle" :
            Destroy(gameObject);
            break;

            case "cubeshape" :
            transform.localScale = new Vector3(1, 1, 1);
            break;

            case "horrectangleshape" :
            transform.localScale = new Vector3(2, 0.5f, 1);
            break;

            case "verrectangleshape" :
            transform.localScale = new Vector3(0.5f, 2, 1);
            break;
        }
    }
}

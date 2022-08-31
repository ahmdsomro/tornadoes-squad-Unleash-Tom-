using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag== "obstacle")
        {
            gameManager.GameOver(); //calling game over panel when player collides with obstacles
            Destroy(gameObject);
        }

       
        switch (other.gameObject.tag)
        {
          

            case "cubeshape" :
            transform.localScale = new Vector3(1, 1, 1);
            break;

            case "horrectangleshape" :
            transform.localScale = new Vector3(2, 0.5f, 1);
            break;

            case "verrectangleshape" :
            transform.localScale = new Vector3(0.5f, 2, 1);
            break;

            case "capsule":
            transform.localScale = new Vector3(0.735362f, 0.716704f, 0.706597f);
            break;

            case "sphere":
            transform.localScale = new Vector3(0.5f, 2, 1);
            break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Success")
        {
            gameManager.GameSuccess();
            Destroy(gameObject);

        }
        
    }
}

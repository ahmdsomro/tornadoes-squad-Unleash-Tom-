using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCollision : MonoBehaviour
{
    [SerializeField] float rotatespeed;
    public AudioSource shapeSound;    
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //below we are rotating the shapes about their positions
        transform.Rotate(Vector3.up * Time.deltaTime * rotatespeed);
       
    }

    //below if the collison is with player so we will destroy the shape it collided with
    void OnTriggerEnter (Collider other)
    {
       
        
        switch(other.gameObject.tag)
        {
            case "Player" :
            shapeSound.Play();
            Destroy(gameObject);
            break;
        }
        
        
    }
}

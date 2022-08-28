using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float explosionforce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Player" :
            rb.AddRelativeForce(Vector3.forward * explosionforce);
            break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCollision : MonoBehaviour
{
    [SerializeField] float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotatespeed);
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

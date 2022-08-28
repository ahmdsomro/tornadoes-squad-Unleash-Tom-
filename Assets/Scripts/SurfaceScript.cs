using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceScript : MonoBehaviour
{
    private Vector3 startposition;
    [SerializeField] float speed;
    void Start()
    {
        startposition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if(transform.position.z < startposition.z - 500)
        {
            transform.position = startposition;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnspeed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * turnspeed);
        }

        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.right * -turnspeed);
        }

        else if(transform.position.x > 4)
        {
            transform.Translate(2, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < -4)
        {
            transform.Translate(-2, transform.position.y, transform.position.z);
        }
    }
}

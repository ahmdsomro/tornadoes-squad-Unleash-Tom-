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

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * turnspeed);
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.right * -turnspeed);
        }

        else if (transform.position.x > 4)
        {
            transform.Translate(2, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -4)
        {
            transform.Translate(-2, transform.position.y, transform.position.z);
        }

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2, 2);
        transform.position = pos;
    }

    public void turnright()
    {
        transform.Translate(Vector3.right * turnspeed);

    }
    public void turnleft()
    {
        transform.Translate(Vector3.right * -turnspeed);
    }
    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "x10":
                speed = 10;
                break;
            case "x15":
                speed = 15;
                break;
            case "x17":
                speed = 17;
                break;
            case "x20":
                speed = 20;
                break;
        }
    }
}

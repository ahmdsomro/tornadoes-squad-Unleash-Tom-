using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] float distToCover = 2.0f;
    [SerializeField] float speed = 2.0f;

    private Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        //initial position for shape to make it move back and forth about their fixed positions:
        startingPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startingPosition;
        v.x += distToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;

    }

   


    }

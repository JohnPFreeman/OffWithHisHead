using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{
    private GameManager gm;

    private Rigidbody rb;
    private float moveSpeed = .25f;
    private Vector3 v;

    private bool headMode = false;


    // Start is called before the first frame update
    void Start()
    {
        gm = gameObject.GetComponent<GameManager>();

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        v = Vector3.zero;
        headMode = gm.headMode;


        if (Input.GetKey(KeyCode.W))
        {
            v += transform.forward;

        }
        if (Input.GetKey(KeyCode.A))
        {
            v -= transform.right;

        }
        if (Input.GetKey(KeyCode.S))
        {
            v -= transform.forward;

        }
        if (Input.GetKey(KeyCode.D))
        {
            v += transform.right;
        }

        v = v.normalized * moveSpeed * (headMode?1:0);

        transform.position += v;
    }
}

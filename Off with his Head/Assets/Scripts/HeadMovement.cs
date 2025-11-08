using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{
    private Vector2 v;


    // Start is called before the first frame update
    void Start()
    {


        // Update is called once per frame
        void Update()
        {
            v = Vector3.zero;

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
        }
    }
}

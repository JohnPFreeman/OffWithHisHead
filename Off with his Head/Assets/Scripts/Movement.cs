using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject headObject;
    private GameManager gm;

    private Rigidbody rb;
    private float moveSpeed = .25f;
    private Vector3 v;

    private bool xMostRecent = false;

    private bool headMode = false;
    public bool isHead = true;

    public GameObject sprite;


    // Start is called before the first frame update
    void Start()
    {
        gm = headObject.GetComponent<GameManager>();

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    {
        updateRecentDir();
    }

    void FixedUpdate()
    {
        v = Vector3.zero;
        headMode = gm.headMode;

        movement();
        
    }

    void movement()
    {

        if (Input.GetKey(KeyCode.W))
        {
            v += new Vector3(0, 0, 1);

        }

        if (Input.GetKey(KeyCode.S))
        {
            v -= new Vector3(0, 0, 1);

        }

        if (Input.GetKey(KeyCode.A))
        {
            v -= new Vector3(1, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            v += new Vector3(1, 0, 0);

        }

        if (xMostRecent & (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
           v[2] = 0;

        } else if (!xMostRecent & (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            v[0] = 0;
        }

        if (headMode)
        {
            updateRotation();
        }
       
        
        

        v = v.normalized * moveSpeed * (headMode == isHead ? 1 : 0);

        transform.position += v;


    }

    void updateRecentDir()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            xMostRecent = true;
            Debug.Log(xMostRecent);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            xMostRecent = false;
            Debug.Log(xMostRecent);
        }
    }

    void updateRotation()
    {
        if (v == new Vector3(1, 0, 0))
        {
            sprite.transform.localEulerAngles = new Vector3(90, 90, 0);
                
        } else if (v == new Vector3(-1, 0, 0))
        {
            sprite.transform.localEulerAngles = new Vector3(90,-90, 0);

        } else if (v == new Vector3(0, 0, 1))
        {
            sprite.transform.localEulerAngles = new Vector3(90, 0, 0);

        } else if (v == new Vector3(0, 0, -1))
        {
            sprite.transform.localEulerAngles = new Vector3(90, 180, 0);

        }
    }
}

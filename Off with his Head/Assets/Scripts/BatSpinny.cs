using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float rotation = 180f;
    private float angleDif = 0f;
    private float rotateSpeed = 0f;
    private float rotateMod = 10f;

    public GameObject body;
    private char facing;

    //private bool freeSwing = true;
    private float target = 180f;
    private float airRes = .8f;
    private float springConst = .25f;

    private float batA = 0f;
    private float batV = 0f;

    private Rigidbody rb;

    private ForceMode forceMode = ForceMode.Acceleration;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        rb = GetComponent<Rigidbody>();

        

    }

    // Update is called once per frame
    void Update()
    { 

        facing = body.GetComponent<Movement>().facing;
        switch (facing)
        {
            case 'D':
                //rotation = trueRotation + 180;
                spriteRenderer.sortingOrder = 3;
                target = 180;
                break;

            case 'U':
                //rotation = trueRotation;
                spriteRenderer.sortingOrder = 1;
                target = 0;
                break;

            case 'L':
                //rotation = trueRotation + 270;
                spriteRenderer.sortingOrder = 3;
                target = 270;
                break;

            case 'R':
                //rotation = trueRotation + 90;
                spriteRenderer.sortingOrder = 3;
                target = 90;
                break;
        }

        angleDif = angleDisplacement(rotation, target);
        //if (angleDif == 0f) angleDif = .001f;

        rotateSpeed = rotateMod * (1 - Mathf.Abs(angleDif / 150));
        //if (rotateSpeed > 3) rotateSpeed = 3;

        //Debug.Log(rotateSpeed + ", " + angleDif);

        transform.localEulerAngles = new Vector3(90, rotation, 0);
        //rb.rotation = Quaternion.Euler(90, rotation, 0);
        

    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rotation -= rotateSpeed;

        }else if (Input.GetMouseButton(1))
        {
            rotation += rotateSpeed;

        } else
        {
            batA = -springConst * angleDif;
            batV = (batV + batA) * airRes;
            rotation += batV;

            //rb.angularVelocity = new Vector3(0, batV, 0);


            if (Mathf.Abs(batV) < 2 && Mathf.Abs(angleDif) < 2)
            {
                rotation = target;
                batV = 0f;
            }
        }

        rotation %= 360;
        while (rotation < 0) rotation += 360;

        Debug.Log("Rotation: " + rotation + ", BatV: " + batV + ", Angle Diff: " + angleDif);
    }


    private float angleDisplacement(float angle, float target)
    {
        angle -= target;
        if (angle >= 180) return angle - 360;
        if (angle < -180) return angle + 360;
        return angle;
    }
}

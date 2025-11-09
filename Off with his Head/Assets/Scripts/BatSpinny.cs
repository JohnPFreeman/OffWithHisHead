using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float rotation = 0f;
    //private float trueRotation = 0f;
    private float rotateSpeed = 1f;

    public GameObject body;
    private char facing;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


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
                break;

            case 'U':
                //rotation = trueRotation;
                spriteRenderer.sortingOrder = 1;
                break;

            case 'L':
                //rotation = trueRotation + 270;
                spriteRenderer.sortingOrder = 3;
                break;

            case 'R':
                //rotation = trueRotation + 90;
                spriteRenderer.sortingOrder = 3;
                break;
        }

        transform.localEulerAngles = new Vector3(90, rotation, 0);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rotation -= rotateSpeed;

        }

        if (Input.GetMouseButton(1))
        {
            rotation += rotateSpeed;

        }
    }
}

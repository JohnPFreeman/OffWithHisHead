using UnityEngine;

public class AnimateHead : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    public GameObject head;
    private char facing;

    public Sprite frontSprite;
    public Sprite backSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;

    //private int rollDir = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        facing = head.GetComponent<Movement>().facing;

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("rollDir", 0);


        }

        switch (facing)
        {
            case 'D':
                
                if (Input.GetKeyDown(KeyCode.S))
                {
                    animator.SetInteger("rollDir", 2);

                } else { spriteRenderer.sprite = frontSprite; }
                break;

            case 'U':
                
                if (Input.GetKeyDown(KeyCode.W))
                {
                    animator.SetInteger("rollDir", 1);

                } else { spriteRenderer.sprite = backSprite; }
                break;

            case 'L':
                
                if (Input.GetKeyDown(KeyCode.A))
                {
                    animator.SetInteger("rollDir", 3);

                } else { spriteRenderer.sprite = leftSprite; }
                break;

            case 'R':
                
                if (Input.GetKeyDown(KeyCode.D))
                {
                    animator.SetInteger("rollDir", 4);

                }
                else { spriteRenderer.sprite = rightSprite; }
                break;
        }
        

        //Debug.Log(animator.GetInteger("rollDir"));

        //Debug.Log(facing + ", " + animator.GetInteger("rollDir"));
    }
}

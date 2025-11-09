using System;
using UnityEngine;

public class animateBody : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public GameObject body;
    private char facing;

    public Sprite frontSprite;
    public Sprite backSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;

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
                spriteRenderer.sprite = frontSprite;
                break;

            case 'U':
                spriteRenderer.sprite = backSprite;
                break;

            case 'L':
                spriteRenderer.sprite = leftSprite;
                break;

            case 'R':
                spriteRenderer.sprite = rightSprite;
                break;
        }

        Debug.Log(facing + " -> " + spriteRenderer.sprite);
    }
}

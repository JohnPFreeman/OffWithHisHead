using UnityEngine;

public class deathAnimation : MonoBehaviour
{

    public Animator animator;
   
    public int animType = 0; //1 is stabby, 2 is molotov

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("EntityKilled", animType);
    }

    public void endDeathAnimation()
    {
        Destroy(gameObject);
    }
}

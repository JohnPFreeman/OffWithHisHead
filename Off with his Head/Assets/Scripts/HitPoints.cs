using UnityEngine;

public class HitPoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float hp = 100;
    public int scoreValue = 0;

    public GameObject deathAnimation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject.Find("ScoreBoard").GetComponent<Scoreboard>().score += scoreValue;

            if (gameObject.CompareTag("Enemy"))
            {
                gameObject.GetComponent<animateMelee>().animator.SetBool("Dead", true);
                deathAnimation = Instantiate(deathAnimation, gameObject.transform);

                if (gameObject.GetComponent<enemyMelee>() != null)
                {
                    deathAnimation.GetComponent<deathAnimation>().animType = 1;
                    Destroy(gameObject);
                } else if (gameObject.GetComponent<enemyMolotov>() != null)
                {
                    deathAnimation.GetComponent<deathAnimation>().animType = 2;
                    Destroy(gameObject);
                }

            }

            
        }
    }
}

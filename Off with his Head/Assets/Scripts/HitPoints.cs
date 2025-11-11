using UnityEngine;

public class HitPoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float hp = 100;
    public int scoreValue = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject.Find("ScoreBoard").GetComponent<Scoreboard>().score += scoreValue;
            Destroy(gameObject);
        }
    }
}

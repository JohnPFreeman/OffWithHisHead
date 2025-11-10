using UnityEngine;

public class HitPoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float hp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) Destroy(gameObject);
    }
}

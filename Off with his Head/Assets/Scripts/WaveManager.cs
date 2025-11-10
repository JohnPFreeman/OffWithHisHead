using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float spawnFreq = 5;
    private double[,] corners = {{-11,-7.5},{ 11, -7.5 } };
    public GameObject[] enemies;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRandomEnemy()
    {
        yield return new WaitForSeconds(spawnFreq);
        //Instantiate(enemies[Random.Range(0, enemies.Length),1]);
        if (spawnFreq>0.2f){ spawnFreq -= 0.2f; }
        StartCoroutine(SpawnRandomEnemy());
    }
}

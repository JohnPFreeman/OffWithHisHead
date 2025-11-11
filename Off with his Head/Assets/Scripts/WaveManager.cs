using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float spawnFreq = 10;
    private double[,] corners = {{-11,-7.5},{ 11, -7.5 }, {-11,7}, {11,7}};
    public GameObject[] enemies;
    public GameObject Body;
    public GameObject Head;
    void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRandomEnemy()
    {
        yield return new WaitForSeconds(spawnFreq);
        double[] RandCorner = {0,0};
        while (RandCorner[0]==0){
            RandCorner[0] = corners[Random.Range(0, corners.GetLength(0)), 0];
            RandCorner[1] = corners[Random.Range(0, corners.GetLength(0)), 1];
            if ((Head.transform.position.x - 10 < RandCorner[0] && Head.transform.position.x + 10 > RandCorner[0]) ||
                (Head.transform.position.z - 10 < RandCorner[1] && Head.transform.position.z + 10 > RandCorner[1]) ||
                (Body.transform.position.x - 2 < RandCorner[0] && Body.transform.position.x + 2 > RandCorner[0]) ||
                (Body.transform.position.z - 2 < RandCorner[1] && Body.transform.position.z + 2 > RandCorner[1]))
            {
                RandCorner[0] = 0;
            }
        }
        Instantiate(enemies[Random.Range(0, enemies.Length)],new Vector3((float)RandCorner[0],1,(float)RandCorner[1]),transform.rotation);
        if (spawnFreq>0.2f){ spawnFreq -= 0.05f; }
        StartCoroutine(SpawnRandomEnemy());
    }
}

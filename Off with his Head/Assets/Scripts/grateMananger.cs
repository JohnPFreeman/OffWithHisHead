using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class grateMananger : MonoBehaviour
{
    private int closedGrates = 5;
    private int maxClosedGrates = length * width - 10;
    public static int length = 11;
    public static int width = 14;
    public GameObject gratePrefab;
    public static GameObject[,] grateArray = new GameObject[length, width];
    public Boolean[,] grateOpen= new Boolean[length, width];
    void Start()
    {
        StartCoroutine(CycleClosedGrates());
        for (int l = 0; l < length; l++)
        {
            for (int w = 0; w < width; w++)
            {
                grateOpen[l, w] = true;
                grateArray[l, w] = Instantiate(gratePrefab, transform.position + new Vector3(l * -4.7f/2, 0, w * -3.2f/2), transform.rotation);
                grateArray[l, w].GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        //changeGrateState(1, 2); obsolete demo
        //changeGrateState(2, 3);
        //changeGrateState(2, 2);
        //changeGrateState(4, 2);
        //changeGrateState(3, 4);
        //changeGrateState(1, 4);
        //changeGrateState(3, 2);
    }
    public void changeGrateState(int row, int coll)
    {
        grateArray[row, coll].GetComponent<SpriteRenderer>().enabled = !grateOpen[row, coll];
        grateOpen[row, coll] = !grateOpen[row, coll];
    }
    public void openGrate(int row, int coll)
    {
        grateArray[row, coll].GetComponent<SpriteRenderer>().enabled = false;
        grateOpen[row, coll] = true;
    }
    public void closeGrate(int row, int coll)
    {
        grateArray[row, coll].GetComponent<SpriteRenderer>().enabled = true;
        grateOpen[row, coll] = false;
    }
    IEnumerator CycleClosedGrates()
    {
        yield return new WaitForSeconds(3.5f);
        for (int l = 0; l < length; l++)
        {
            for (int w = 0; w < width; w++)
            {
                openGrate(l, w);
            }
        }
        int currentClosedGrates = 0;
        while (currentClosedGrates < closedGrates)
        {
            int randomcoll = UnityEngine.Random.Range(0, width - 1);
            int randomrow = UnityEngine.Random.Range(0, length - 1);
            if (grateOpen[randomrow, randomcoll])
            {
                closeGrate(randomrow, randomcoll);
                currentClosedGrates++;
            }
        }
        if (closedGrates < maxClosedGrates){
            closedGrates+=2;   
        }
        StartCoroutine(CycleClosedGrates());
    }
}

using System;
using UnityEngine;
using UnityEngine.UIElements;

public class grateMananger : MonoBehaviour
{
    public static int length = 5;
    public static int width = 7;
    public GameObject gratePrefab;
    public static GameObject[,] grateArray = new GameObject[length, width];
    public Boolean[,] grateOpen= new Boolean[length, width];
    void Start()
    {
        for (int l = 0; l < length; l++)
        {
            for (int w = 0; w < width; w++)
            {
                grateOpen[l, w] = false;
                grateArray[l, w] = Instantiate(gratePrefab, transform.position + new Vector3(l * -4.7f, 0, w * -3.2f), transform.rotation);
                grateArray[l, w].GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        changeGrateState(1, 2);
        changeGrateState(2, 3);
        changeGrateState(2, 2);
        changeGrateState(4, 2);
        changeGrateState(3, 4);
        changeGrateState(1, 4);
        changeGrateState(3, 2);
    }
    public void changeGrateState(int row, int coll)
    {
        grateArray[row, coll].GetComponent<SpriteRenderer>().enabled = !grateOpen[row, coll];
        grateOpen[row, coll]=!grateOpen[row, coll];
    }
}

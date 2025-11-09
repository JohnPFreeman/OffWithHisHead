using System;
using Unity.Mathematics;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;
public class LookAtPlayer : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        //int x = Input.
        //print(gameObject.name);
        
    }
    void Update()
    {
        float angle = 0;
        if (player.transform.position.x >= transform.position.x)
        {
            
                angle = 270 + (float) (Math.Atan((player.transform.position.z - transform.position.z) /
                                           (player.transform.position.x - transform.position.x)) * 360 / (2 * Math.PI));
            
        }
        else
        {
            angle = 90 + (float)(Math.Atan((player.transform.position.z - transform.position.z) /
                                        (player.transform.position.x - transform.position.x)) * 360 / (2 * Math.PI));
        }
        //else
        //{
        //    
        //}
        transform.eulerAngles = new Vector3(90, 0, angle);// LookAt(player.transform, Vector3.up))
        //transform.position += Vector3.zero;
        //transform.LookAt(player.transform, Vector3.left);
        //transform.LookAt(player.transform.position);
        //transform.eulerAngles = new Vector3(90, 0, transform.eulerAngles.z);
    }
}

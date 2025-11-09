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
        //Quaternion direction = Quaternion.FromToRotation(player.transform.position, transform.position);
        //direction.x = 90;
        //direction.y = 0;
        //direction.z = 0;
        //direction.w = 1;
        //transform.rotation = direction;
        if (player.transform.position.x >= transform.position.x)
        {//} >= 1 ^ (player.transform.position.x - transform.position.x) < 1)
            
                angle = (float)Math.Atan(player.transform.position.z - transform.position.z /
                                            (player.transform.position.x - transform.position.x)* 360 / (2 * Math.PI) * (1));
            
        }
        else
        {
            // if ((player.transform.position.z - transform.position.z) < 1 ^ (player.transform.position.x - transform.position.x) > 1)
            angle = (float)(180 + Math.Atan((transform.position.z-player.transform.position.z) /
                                        (transform.position.x-player.transform.position.x )) * 360 / (2 * Math.PI));
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

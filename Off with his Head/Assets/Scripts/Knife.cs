using System;
using Unity.Mathematics;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;
public class Knife : MonoBehaviour
{
    Rigidbody rb;
    public int StabSpeed = 2;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        double timeElapsed = (double)Time.time;
        transform.localPosition = new Vector3(0, ((float)Math.Sin(timeElapsed*StabSpeed)+1.2f)/4, 0);
    }
}

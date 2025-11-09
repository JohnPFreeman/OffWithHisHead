using System;
using UnityEngine;

public class Molotov : MonoBehaviour
{
    public Boolean Moving = true;
    public int speed = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Moving)
        {
            transform.position = Vector3.forward*Time.deltaTime*speed+transform.position;
        }
    }
}

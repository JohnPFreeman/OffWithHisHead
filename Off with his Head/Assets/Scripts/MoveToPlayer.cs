using System;
using Unity.Mathematics;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;
public class MoveToPlayer : MonoBehaviour
{
    Rigidbody rb;
    public int MaxSpeed = 1;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (rb.linearVelocity.magnitude < MaxSpeed)
        {
            rb.AddForce(transform.up, ForceMode.Force);
        }
    }
}

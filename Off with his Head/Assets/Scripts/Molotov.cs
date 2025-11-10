using System;
using System.Collections;
using UnityEngine;

public class Molotov : MonoBehaviour
{
    public Boolean Moving = true;
    public GameObject Explosion;
    public int speed = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Fuse());
    }

    // Update is called once per frame
    void Update()
    {
        if (Moving)
        {
            transform.position = transform.up * Time.deltaTime * speed + transform.position;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Moving = false;
        }
    }
    IEnumerator Fuse()
    {
        yield return new WaitForSeconds(2);
        Instantiate(Explosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}

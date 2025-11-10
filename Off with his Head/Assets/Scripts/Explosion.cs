using System;
using System.Collections;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Boolean active=true;
    void Start()
    {
        StartCoroutine(disapate());
    }
    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("Enemy"))&&active)
        {
            other.gameObject.GetComponent<HitPoints>().hp -= 20;
            active = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator disapate()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}

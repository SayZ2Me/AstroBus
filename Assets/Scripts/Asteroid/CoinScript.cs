using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private Rigidbody bus;
    private Rigidbody rb;

    void Start()
    {
        bus = (GameObject.Find("Bus")).GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        Vector3 directionToBus = (bus.position - transform.position).normalized;
        rb.velocity = directionToBus * 100;

    }

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.name == "Bus")
            Destroy(gameObject);
    }



}

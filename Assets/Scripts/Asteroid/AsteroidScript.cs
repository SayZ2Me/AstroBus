using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    [SerializeField]
	float Speed;
    [SerializeField]
    int Health;
    Rigidbody RB;
    private int Type;
    [SerializeField]
    GameObject explosion;
    [SerializeField]
    GameObject breakdown;
    [SerializeField]
    GameObject coin;
	
    void Start()
    {
        Type = 0;
        RB = GetComponent<Rigidbody>();
		RB.velocity = Vector3.down * Speed;
    }
    private void Update()
    {
        if (gameObject.transform.position.y < -700f)
        {
            Destroy(gameObject);
        }
    }
    void ReceiveDamage(int Damage) 
    {
        Health -= Damage;
        if (Health < 1)
        {
        Debug.Log("Destroyed");
            //Instantiate(breakdown, transform.position, transform.rotation);
            Destroy(gameObject);
            Instantiate(coin, transform.position, Quaternion.Euler(0, 0, 0));
        }
    }
}

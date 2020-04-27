using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
public int coinlifetime; // время жизни монетки

    // пока не переделал на притяжение к кораблю
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.up * 100f, ForceMode2D.Impulse);
		Destroy(gameObject, coinlifetime); // падение и уничтожение монетки
    }


}

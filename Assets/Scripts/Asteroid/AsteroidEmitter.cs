using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidEmitter : MonoBehaviour
{
	public GameObject asteroid;
	public float mindelay;
	public float maxdelay;
	private float nextspawn;
    
    void Update()
    {
    	if (Time.time > nextspawn){
			float randXpos = Random.Range(transform.localPosition.x, transform.localPosition.x*2); // позиция спавна по х
			Vector2 randpos = new Vector2(randXpos, transform.position.y); //позиция спавна по у
			Instantiate(asteroid, randpos, Quaternion.identity); // спавн астероида
			nextspawn +=Random.Range(mindelay, maxdelay); // задержка до нового спавна
		}


    
    }
}

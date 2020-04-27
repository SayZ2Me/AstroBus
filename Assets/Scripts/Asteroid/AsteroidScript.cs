using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript: MonoBehaviour
{
	public float minspeed;
	public float maxspeed;
	public float rotationspeed;
	public int Health;
	private int Type; //это тип астероида: 0-обычный, 1-взрывной, 2-бессмертный
	public GameObject explosion;
	public GameObject breakdown;
	public GameObject coin;
	
    void Start()
    {
		Type = Random.Range(0, 3); // задается тип астероида (0- обычный, 1- взрывной, 2- неуничтожаемый)
		
		Rigidbody2D asteroidRB = GetComponent<Rigidbody2D>();
        asteroidRB.angularVelocity = Random.insideUnitCircle.x * rotationspeed; // задается скорость кручения
		asteroidRB.velocity = Vector2.down * Random.Range(minspeed, maxspeed); // задается скорость движения
		
    }

	void OnCollisionEnter2D (Collision2D other) // столкновение астероида с объектом
    {
		if (other.gameObject.tag == "Player"){ // проверка на столкновение именно с игроком
			Destroy(gameObject); // уничтожается сам астероид
			Destroy(other.gameObject); // уничтожается игрок
			if (Type == 1){
				Instantiate(explosion, transform.position, transform.rotation); // анимация взрыва для взрывного астероида
			}
			else {
				Instantiate(breakdown, transform.position, transform.rotation); // анимация ломания для обычного
			}
		}
		
	}


	void OnMouseDown () { //тапы по астероиду
		if (Type == 3){ // реакция неуничтожаемого
			return;
		}
		else {
			if (Health>5){ //отнимание здоровья, если ещё есть запас
				Health-=5;
			}
			else {
				Destroy(gameObject); // иначе уничтожение астероида
				if (Type == 1){
					Instantiate(coin, transform.position, Quaternion.Euler(0,0,0)); //спавн монеты
					Instantiate(explosion, transform.position, transform.rotation); // взрыв
				}
				else {
					Instantiate(breakdown, transform.position, transform.rotation); //ломание
				}
				Instantiate(coin, transform.position, Quaternion.Euler(0,0,0)); //спавн ещё одной монеты (типо для обычного будет 1, а для взрывного 2)
			}
		}
	}
	
}

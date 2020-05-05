using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidEmitter : MonoBehaviour
{
    [SerializeField]
	GameObject asteroid;
    [SerializeField]
    float SpawnDelay;
    [SerializeField]
    float SpawnDelaySpacing;
    float SpawnLast, dir;
    bool play;
    private void Start()
    {
        SpawnLast = Time.time;
        play = false;
        
    }
    void Update()
    {
        if (play)
        {
            if (Time.time > SpawnLast + SpawnDelay + SpawnDelaySpacing)
            {
                if (Random.Range(-10, 10) > 0) { dir = -1f; } else { dir = 1f; }
                Debug.Log(dir);
                Instantiate(asteroid, new Vector3(Mathf.Pow(Random.Range(0f, 16f), 2) * dir, 700, 0), Quaternion.identity);
                SpawnLast = Time.time;
            }
        }
    }
    void Play()
    {
        play = true;
    }
}

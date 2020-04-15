using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static Score instance;
    
    [SerializeField]
    public Text Money;
    public int MoneyCounter=0;

    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Money", MoneyCounter);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            PlayerPrefs.SetInt("Money", MoneyCounter + 10);
            Debug.Log(MoneyCounter);
        }
        
        Money.text = "Money: " + MoneyCounter;

        
        MoneyCounter = PlayerPrefs.GetInt("Money");
    }
}

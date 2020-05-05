using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    Text Text;
    [SerializeField]
    string Type;
    int Value = 0;

    void Update()
    {
        Text.text = Value.ToString();
        Value = PlayerPrefs.GetInt(Type);
    }
}
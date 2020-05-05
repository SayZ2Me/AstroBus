using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    [SerializeField]
    GameObject Emitter;
    public void OnClick() 
    {
        Emitter.SendMessage("Play");
        Debug.Log("play");
    }
}

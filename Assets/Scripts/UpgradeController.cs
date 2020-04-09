using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour
{

    public GameObject ButtonsMenu;
    public GameObject UpgradeScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuScene()
    {
        Application.LoadLevel("MainMenu");
    }
}

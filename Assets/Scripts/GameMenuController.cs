using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuController : MonoBehaviour
{

    public GameObject GameSettings;
    public GameObject GameScene;
    public GameObject ButtonsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        GameSettings.SetActive(false);
        GameScene.SetActive(true);
    }

    public void showGameSettings()
    {
        GameScene.SetActive(false);
        GameSettings.SetActive(true);
    }

    public void BackInMenu()
    {
        ButtonsMenu.SetActive(true);
        GameSettings.SetActive(false);
    }

    public void MenuScene()
    {
        Application.LoadLevel("MainMenu");
    }

}

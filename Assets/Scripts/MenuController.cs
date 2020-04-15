using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public GameObject ButtonsMenu;
    public GameObject ButtonsExit;
    public GameObject ButtonsSettings;
    public GameObject ButtonsCredits;
    public GameObject SceneUpgrade;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showSettings()
    {
        ButtonsMenu.SetActive(false);
        ButtonsSettings.SetActive(true);
    }

    public void showCredits()
    {
        ButtonsMenu.SetActive(false);
        ButtonsCredits.SetActive(true);
    }

    public void showUpgrade()
    {
        ButtonsMenu.SetActive(false);
        SceneUpgrade.SetActive(true);
    }

    public void showExitButtons() 
    {
        ButtonsMenu.SetActive(false);
        ButtonsExit.SetActive(true);
    }

    public void BackInMenu()
    {
        ButtonsMenu.SetActive(true);
        ButtonsExit.SetActive(false);
        ButtonsCredits.SetActive(false);
        ButtonsSettings.SetActive(false);
        SceneUpgrade.SetActive(false);
    }

    public void NewGameLoadSceneGame()
    {
        Application.LoadLevel("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

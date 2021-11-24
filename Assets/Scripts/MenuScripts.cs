using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

    int sceneIndex;
    [SerializeField] GameObject rotateButton;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void loadMegoPlayset()
    {
        SceneManager.LoadScene(0);
    }

    public void loadLandOfGiants()
    {
        SceneManager.LoadScene(1);
    }

    public void loadDancingOnCeiling()
    {
        SceneManager.LoadScene(2);
    }

    public void rotateRoom()
    {
        if(sceneIndex == 2)
        {
            /* Show the button */
            rotateButton.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

    int sceneIndex;
    [SerializeField] GameObject rotateButton;
    [SerializeField] GameObject ScenePrefab;
    Vector3 rotationVector;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 2)
        {
            /* Show the button */
            rotateButton.SetActive(true);
            rotationVector = transform.rotation.eulerAngles;
        }
    }

    void Update()
    {
       
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
        Debug.Log("Rotate Room");
        
        rotationVector.z += 90;
        ScenePrefab.transform.rotation = Quaternion.Euler(rotationVector);
        Debug.Log(ScenePrefab);
        Debug.Log(ScenePrefab.transform.rotation);
    }
}

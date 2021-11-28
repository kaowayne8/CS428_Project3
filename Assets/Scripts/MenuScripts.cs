using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

    int sceneIndex;
    [SerializeField] GameObject rotateButton;
    [SerializeField] GameObject ScenePrefab;
    private bool rotating;
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

        if (rotationVector.z != 360)
        {
            rotationVector.z += 90;
        }
        else
        {
            rotationVector.z = 0;
        }
        
        rotating = true;
        //ScenePrefab.transform.rotation = Quaternion.Euler(rotationVector);
        StartCoroutine(Rotate(rotationVector,5));
        Debug.Log(ScenePrefab);
        Debug.Log(ScenePrefab.transform.rotation);
    }

    private IEnumerator Rotate(Vector3 angles, float duration)
    {
        rotating = true;
        Quaternion startRotation = ScenePrefab.transform.rotation;
        Quaternion endRotation = Quaternion.Euler(angles) * startRotation;
        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            ScenePrefab.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t / duration);
            yield return null;
        }
        ScenePrefab.transform.rotation = endRotation;
        rotating = false;
    }

    public void StartRotation()
    {
        if (!rotating)
            StartCoroutine(Rotate(new Vector3(0, 90, 0), 1));
    }
}

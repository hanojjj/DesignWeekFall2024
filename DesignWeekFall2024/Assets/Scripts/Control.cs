using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Warning");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Closed");
    }
}
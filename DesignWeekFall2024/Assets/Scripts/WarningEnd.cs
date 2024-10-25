using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningEnd : MonoBehaviour
{

    public void Update()
    {
        StartCoroutine(WarningDelay());
    }

    public IEnumerator WarningDelay()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("SampleScene");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashLight;

    bool flashOn = false;

    private void Start()
    {
        flashLight = GetComponent<Light>();
        flashLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.L))
        {
            flashLight.enabled = true;
            Debug.Log("Working");

        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            flashLight.enabled = false;
        }
        */


    }


    public void FlashOnOff()
    {
        flashOn = !flashOn;
        flashLight.enabled = flashOn;
    }
}

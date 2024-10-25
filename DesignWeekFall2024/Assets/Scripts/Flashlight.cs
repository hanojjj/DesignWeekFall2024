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

        
    }


    public void FlashlightOnOff()
    {

        flashOn = !flashOn;
        flashLight.enabled = !flashLight.enabled;
    }
}

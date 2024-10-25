using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashLight;
    public GameObject monster;

    bool flashOn = false;

    private void Start()
    {
        flashLight = GetComponent<Light>();
        monster = GetComponent<GameObject>();
        flashLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     


    }


    public void FlashOnOff()
    {
        flashOn = !flashOn;
        flashLight.enabled = flashOn;
    }
}

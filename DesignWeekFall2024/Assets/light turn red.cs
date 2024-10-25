using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightturnred : MonoBehaviour
{
    public GameObject CreatureWip;
    public GameObject CealingLight;
    // Start is called before the first frame update
    void Start()
    {
        CealingLight = GetComponent<GameObject>();
        CreatureWip = GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        if (CreatureWip)
        {

        }
    }
}

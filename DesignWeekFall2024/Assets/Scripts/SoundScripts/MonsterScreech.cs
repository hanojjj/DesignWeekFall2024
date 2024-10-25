using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScreech : MonoBehaviour
{

    public AudioSource source;
    public AudioClip monsterScreech;


    public void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(monsterScreech);
    }
}

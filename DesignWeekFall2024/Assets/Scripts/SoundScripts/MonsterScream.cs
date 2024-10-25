using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScream : MonoBehaviour
{
    public AudioSource source;
    public AudioClip monsterScream;


    public void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(monsterScream);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{
    public GameObject wall;

    public Transform transform;

    public AudioSource source;
    public AudioClip monsterScream;
    public AudioSource source2;
    public AudioClip jumpScare;

    public float movementSpeed = 0.5f;
    public Vector3 playerStartPos;

    private void Start()
    {
        playerStartPos = new Vector3(22.8260002f, 1.53900003f, -8.89000034f);
        wall.SetActive(false);
    }



    void Update()
    {
        Move();
        
    }

    //Static Movements
    public void Move()
    {
        if (transform.position.x < 60.5f)
        {
            MoveRight();
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            MoveBackwards();
            //transform.eulerAngles = new Vector3(0, 90, 0);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        transform.position = playerStartPos;
        source.PlayOneShot(monsterScream);
        wall.SetActive(true);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            movementSpeed = 0f;
            source2.PlayOneShot(jumpScare);
            StartCoroutine(DeathDelay());

        }
    }



    //Movements
    public void MoveRight()
    {
        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
    }

    public void MoveBackwards()
    {
        transform.position = transform.position + new Vector3(0, 0, -movementSpeed * Time.deltaTime);

    }


    public IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("hi");
    }
    

}

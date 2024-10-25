using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Vector3 playerStartRot;

    private void Start()
    {
        playerStartPos = new Vector3(22.8260002f, 1.53900003f, -8.89000034f);
        playerStartRot = new Vector3(0, 0, 0);
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
            //transform.eulerAngles = new Vector3(0, 0, 0);
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
            Debug.Log("Hit wall");
            Input.gyro.enabled = false;
            transform.eulerAngles = playerStartRot;
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
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("EndScreen");

    }


}

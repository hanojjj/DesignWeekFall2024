using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{

    public Transform transform;

    public float movementSpeed = 5f;
    public Vector3 playerStartPos;

    private void Start()
    {
        playerStartPos = new Vector3(16.1f, 2.35f, -16.24f);
    }



    void Update()
    {
        MoveRight();

        if (transform.position.x == transform.position.x + 1 * Time.deltaTime)
        {
            MoveLeft();
        }

    }


    //Static Movements
    public void MoveRight()
    {
        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
    }

    public void MoveLeft()
    {
        transform.position = transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
    }

    public void MoveForward()
    {
        transform.position = transform.position + new Vector3(0, 0, movementSpeed * Time.deltaTime);
    }

    public void MoveBackwards()
    {
        transform.position = transform.position + new Vector3(0, 0, -movementSpeed * Time.deltaTime);

    }

}

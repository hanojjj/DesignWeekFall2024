using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{

    public Transform transform;

    public float movementSpeed = 0.5f;
    public Vector3 playerStartPos;

    private void Start()
    {
        playerStartPos = new Vector3(22.8260002f, 1.53900003f, -8.89000034f);
        
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

    

}

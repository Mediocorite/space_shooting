using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Variable for speed 
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        // Script responsible for vertical motion
        if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("d") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("a") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }


        // Script resposible for Horizontal motion
        if (Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s") && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("s") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= transform.TransformDirection(Vector3.up) * Time.deltaTime * movementSpeed;
        }

    }
}

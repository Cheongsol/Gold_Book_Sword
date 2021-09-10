using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour
{
    static float moveSpeed = 1.0f;
    static float rotateSpeed = 10.0f;
    public GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0.0f, 0.0f, Space.Self);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(new Vector3(-0.1f, 0.0f, 0.0f)), Time.deltaTime * rotateSpeed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0.0f, 0.0f, Space.Self);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(new Vector3(0.1f, 0.0f, 0.0f)), Time.deltaTime * rotateSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.1f, Space.Self);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(new Vector3(0.0f, 0.0f, -0.1f)), Time.deltaTime * rotateSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, 0.1f, Space.Self);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(new Vector3(0.0f, 0.0f, 0.1f)), Time.deltaTime * rotateSpeed);
        }
    }
    
}

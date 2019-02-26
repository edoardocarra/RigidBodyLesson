using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterControl : MonoBehaviour
{
    public GameObject bullet;
    public Camera cam;
    public float speed = 100f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instbullet = Instantiate(bullet) as GameObject;

            instbullet.transform.position = transform.position + cam.transform.forward * 2;
           
            Rigidbody rb = instbullet.GetComponent<Rigidbody>();

            rb.AddForce(cam.transform.forward * speed);
        }
    }
}

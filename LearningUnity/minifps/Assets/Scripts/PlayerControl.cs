using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //the rigid body we want to apply forces on input
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

        }

    // Update is called once per frame
    void Update()
    {
        
    }

    //We use fixed update because we want to perform the force application before physics calculations
    void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        transform.Translate(movehorizontal*speed*Time.deltaTime
        , 0.0f, movevertical*speed*Time.deltaTime
            );
    }
}

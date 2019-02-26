using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
 
    //variable to hold the game object's rigid body reference in the script
    private Rigidbody rb;
    //public float speed = 60; //-> this requires new compilation every time we tune!!
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //search and set a reference to the attached rigidbody, if present
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called before doing physics calculations
    void FixedUpdate()
    {
        // fill physics code here
        // Input - cmd/ctrl + ' to check API

        /* we use those inputs to add forces to the rigid body 
        associated to the game object we want to move */ 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Rigidbody - cmd/ctrl + ' to check API

        //public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed); //force mode is the default one
    
    }

    //we need to test if the player collides with an object with a Pick Up tag
    //if it happens we made that object disappear

    //OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        //quando triggera, dobbiamo capire se l'oggetto colliso e' un pick up
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //non vogliamo distruggere l'oggetto, solo renderlo inattivo
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }
        //non vogliamo distruggere l'oggetto, solo renderlo inattivo
        //Destroy(other.gameObject);
    }


}

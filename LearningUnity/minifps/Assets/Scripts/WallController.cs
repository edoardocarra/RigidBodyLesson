using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    public int tower;
    public int wall_width;
    public int wall_height;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tower; i++) 
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0.5f+i, 20);
            cube.AddComponent<Rigidbody>();
        }



        for (int i = 0; i < wall_height; i++)
        { 
            for (int j = 0; j < wall_width; j++) 
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(-wall_width/2 + j, 0.5f + i, 20);
                cube.AddComponent<Rigidbody>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}

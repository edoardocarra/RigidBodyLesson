using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //e' uno script_component della camera. Quindi transform riferisce implicitamente alla camera
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    //usimo lateupdate per avere la certezza che la nuova posizione della camera viene calcolata quando 
    //quella del player e' stata gia' calcolata
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

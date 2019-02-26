using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    Vector2 mouselook; //movimento complessivo della camera
    Vector2 smoothv; //migliora la smoothness nel movimento della camera

    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity*smoothing, sensitivity*smoothing));

        smoothv.x = Mathf.Lerp(smoothv.x, md.x, 1f / smoothing);
        smoothv.y = Mathf.Lerp(smoothv.y, md.y, 1f / smoothing);

        mouselook += smoothv;

        //looking up will rotate only the camera - the player does not move
        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);

        //looking horizontally will rotate only the player. And since the player is parent of camera
        //the camera will rotate too
        character.transform.localRotation = Quaternion.AngleAxis(mouselook.x, character.transform.up);

    
    }

}

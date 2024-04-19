using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the position of the camera to follow the target horizontally
        // while keeping the same y and z position
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}

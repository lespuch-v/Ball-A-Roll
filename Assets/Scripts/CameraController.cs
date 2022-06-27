using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    public float sensitivity;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
    private void Update()
    {
        //AroundTheObject();
    }


    private void AroundTheObject()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.RotateAround(player.transform.position, -Vector3.down, rotateHorizontal * sensitivity);
        transform.RotateAround(Vector3.zero, -transform.right, rotateVertical * sensitivity);
    }

}

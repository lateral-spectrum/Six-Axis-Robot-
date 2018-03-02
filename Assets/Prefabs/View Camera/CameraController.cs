using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Rate;

    public float speedHoriz = 0;
    public float speedVert = 0;
    public float yaw = 0;
    public float pitch = 0;

    void Start()
    {

    }

    void Update()
    {
        HandleLookInputs();
        HandleMoveInputs();
    }

    void HandleMoveInputs()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Rate);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Rate);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * Rate);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Rate);
        }
    }

    void HandleLookInputs()
    {
        yaw += speedHoriz * Input.GetAxis("Mouse X");
        pitch -= speedVert * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

}

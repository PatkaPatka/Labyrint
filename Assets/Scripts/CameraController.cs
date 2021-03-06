using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float mouseSensivity = 5;
    float xRot = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.localRotation = Quaternion.identity;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -60, 60);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        playerTransform.Rotate(0, mouseX, 0);
    }
}

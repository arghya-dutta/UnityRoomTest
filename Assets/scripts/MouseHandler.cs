using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
 [SerializeField] Transform cam;
[SerializeField] float sensitivity;
float headRotation = 0f;

    void Start()
    {
        sensitivity = 300f;
            Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main.transform;
    }

void Update() {
    float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
    float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1f;
    transform.Rotate(0f, x, 0f);
    headRotation += y;
    cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
}
}

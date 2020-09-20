using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamera : MonoBehaviour
{

//public CharacterController characterController;
    public Transform playerBody;
   public float turnSpeed = 100.0f;
public float moveSpeed = 2.0f;
 
public float minTurnAngle = -90.0f;
public float maxTurnAngle = 90.0f;
private float rotX;

private float rotY;
  void Start() {
     Cursor.lockState =CursorLockMode.Locked;

 }
void Update ()
{
    MouseAiming();
   // KeyboardMovement();
}
 
void MouseAiming ()
{
    // get the mouse inputs
    float x = Input.GetAxis("Mouse X") * turnSpeed;
    float y= Input.GetAxis("Mouse Y") * turnSpeed;
    rotX +=x;
    rotY -=y;
 
    // clamp the vertical rotation
    //rotY = Mathf.Clamp(rotY, minTurnAngle, maxTurnAngle);
 
    // rotate the camera
    playerBody.localRotation = Quaternion.Euler(rotY,rotX,0f);
    playerBody.Rotate(Vector3.up*x);
    
}
 
void KeyboardMovement ()
{
    Vector3 dir = new Vector3(0, 0, 0);
 
    dir.x = Input.GetAxis("Horizontal");
    dir.z = Input.GetAxis("Vertical");
    
   // characterController.Move(dir * moveSpeed * Time.deltaTime);
 
   // transform.Translate();
}
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //
    public CharacterController characterController;

    Vector3 moveDirection = Vector3.zero;
    public float moveSpeed = 2.0f;
    public float gravity = -9.81f;

    Vector3 velocity;

    void Update()
    {

        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        moveDirection = (forward * x) + (right * y);

        characterController.Move(moveDirection * moveSpeed* Time.deltaTime);
        //velocity.y += gravity* Time.deltaTime;
        // characterController.Move(velocity * Time.deltaTime);
    }
}

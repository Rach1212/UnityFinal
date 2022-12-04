using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // making a player controller - character movement 
    public CharacterController controller; 

    //referencing player to camera 
    public Transform cam;

    // setting the speef of the player movement 
    public float speed = 4f; 

    //smoothing movement rotation 
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity; 


    // Update is called once per frame
    void Update()
    {
        // horizontal and vertical input for the player movement
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical"); 
        // want to move our character in the Z and X axis and not the Y 
        //normalized makes it so that the player doesnt speed up when holding two keys at once 
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; 

        
        if(direction.magnitude >= 0.1f)
        {
            // pointing the player towards the way that the camera is facing.
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            // checks if we are moving in a direciton 
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);    
        }

    }
}

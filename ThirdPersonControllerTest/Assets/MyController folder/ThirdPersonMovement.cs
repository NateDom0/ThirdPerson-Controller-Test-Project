using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller; //thing, motor that drives our player

    //create a reference to our camera
    public Transform cam; 

    public float speed = 6f; //speed variable

    public float turnSmoothTime = 0.1f; //makes head turns more smooth

    float turnSmoothVelocity; 


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //left-right keys, A-D keys
        float vertical = Input.GetAxisRaw("Vertical");     //up-down keys, W-S keys
        
        //use to move along X,Y axis, and not Z(up/down)
        //And 'normalized' to prevent moving faster when going diagonal 
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; 

        if(direction.magnitude >= 0.1f)
        {
            //use to have character move in direction of the camera
            //direction.y -> direction.z, because y axis is zero
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; //then add cam.eulerAngles.y
            

            //used to smooth numbers, and putting angles in Unity
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f); //swap targetAngle for angle

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; 

            //use Time.deltaTime in order to make it frame rate independent
            controller.Move(moveDir.normalized * speed * Time.deltaTime);  //swap direction with moveDir
        }



    }
}

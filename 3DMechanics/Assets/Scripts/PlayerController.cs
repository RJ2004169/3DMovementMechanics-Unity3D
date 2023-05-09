using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController playerController;
    public Camera cameraControl;

    public float speed;
    

    // Update is called once per frame
    void Update()
    {

        //getting inputs and calculating direction
        float horizontalF = Input.GetAxisRaw("Horizontal");
        float verticalF = Input.GetAxisRaw("Vertical");

        Vector3 directionV3 = new Vector3(horizontalF, 0f, verticalF).normalized;

        //checking if there is any input
        if(directionV3.magnitude >= 0.1f)
        {
            //there is some kind of movement input, so we need to move the player
            //if there is any input then we need to calculate the direction to move in by using atan2
            // also need to add camera pointing direction
            float targetDirectionF = Mathf.Atan2(directionV3.x, directionV3.z) * Mathf.Rad2Deg + cameraControl.transform.eulerAngles.y;
            
            //calculate vector for that direction
            Vector3 movingDirectionV3 = Quaternion.Euler(0, targetDirectionF, 0) * Vector3.forward;

            //rotate the character // -90 rotation is added as a hard coded fix for rotation
            //TODO: fix initial rotation of object maybe?
            transform.rotation = Quaternion.Euler(0f, targetDirectionF - 90, 0f);

            //move the character
            playerController.Move(movingDirectionV3.normalized * speed * Time.deltaTime);
            

        }
    }
}

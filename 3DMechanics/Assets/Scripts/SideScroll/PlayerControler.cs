using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public Rigidbody playerRB;
    public float speed;
    public float jumpForce;

    private bool isGrounded;
    private int jumpCount;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, Mathf.Min(Camera.main.transform.position.z+9f, transform.position.z - horizontal*speed)), Time.deltaTime);
       
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && jumpCount<2)
        {
            playerRB.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
            
            jumpCount++;
            if (jumpCount == 2)
            {
                isGrounded = false;
            }

        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == 3)
        {
            jumpCount = 0;
            isGrounded = true;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject playerGO;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerGO.transform.position.z < transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerGO.transform.position.z);
        }
    }
}

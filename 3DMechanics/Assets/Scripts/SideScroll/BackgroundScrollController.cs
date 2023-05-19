using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrollController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", Vector2.right * 0.1f);
    }
}

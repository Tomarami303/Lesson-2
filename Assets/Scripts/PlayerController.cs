using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //Fixed update updates the frame when all the logic happens (physics and other stuff)
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}

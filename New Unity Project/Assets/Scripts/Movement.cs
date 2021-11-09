using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController2D controller; 

    float horizontalMov = 0f;
    bool jump = false; 

    public float runSpeed = 40f;


    // Update is called once per frame
    void Update()
    {
        horizontalMov = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
         controller.Move(horizontalMov * Time.fixedDeltaTime, false, jump);
         jump = false;
    }
}

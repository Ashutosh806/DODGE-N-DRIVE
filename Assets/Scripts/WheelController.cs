using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public GameObject[] wheelsToRotate;
    public TrailRenderer[] trails;
    public float rotationSpeed;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float verticalAxis = Input.GetAxisRaw("Vertical");
        float horizontalAxis = Input.GetAxisRaw("Horizontal");

        foreach (var wheel in wheelsToRotate)
        {
            wheel.transform.Rotate(Time.deltaTime*verticalAxis*rotationSpeed, 0 , 0 , Space.Self);
        }

        if (horizontalAxis > 0)
        {
            anim.SetBool("Left",false);
            anim.SetBool("Right",true);
        }
        else if (horizontalAxis < 0)
        {
            anim.SetBool("Left",true);
            anim.SetBool("Right",false);   
        }
        else
        {
            anim.SetBool("Left",false);
            anim.SetBool("Right",false); 
        }

        if (horizontalAxis!=0)
        {
            foreach (var trail in trails)
            {
               trail.emitting = true; 
            }
        }

        else
        {
            foreach (var trail in trails)
            {
               trail.emitting = false; 
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Meter : MonoBehaviour
{
    public float maxSpeed = 0f;
    private float speed = 0f;
    
    public float MaxArrowAngle,MinArrowAngle;

    public Rigidbody rb;
    public RectTransform value;
  
    void Update()
    {
        speed = rb.velocity.magnitude * 3.6f;
        value.localEulerAngles = new Vector3(0,0,Mathf.Lerp(MinArrowAngle,MaxArrowAngle,speed/maxSpeed));
    }
}
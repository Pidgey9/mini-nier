using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] 
    float speed = 0.1f;
    Vector3 moveInput;
    Vector3 rotaInput;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();   
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveInput = new (h, 0, v);
        //Debug.Log(moveInput);
        Vector3.Normalize(moveInput);
        //transform.Translate(moveInput*speed);
        //transform.position = transform.position + moveInput*speed;
        float rotah = Input.GetAxis("orientationHorizontal");
        float rotav = Input.GetAxis("orientationVertical");
        rotaInput = new (rotah, 0, rotav);
        //transform.Rotate(rotaInput);
    }
    private void FixedUpdate()
    {
        Vector3 velocity = moveInput*speed;
        rb.velocity = velocity;
        if (rotaInput != Vector3.zero)
        {
            Quaternion lookRota = Quaternion.LookRotation(rotaInput);
            rb.MoveRotation(lookRota);
        }
    }
}   

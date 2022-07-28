using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Rigidbody rb;
    //Transform bulletTf;
    [SerializeField]
    float speed = 1f;
    ConstantForce con;
    int count;
    public int timeDestroy;
    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
        //bulletTf = GetComponent<Transform>();
        con = GetComponent<ConstantForce>();
    }
    private void Start()
    {
        count = 0; 
    }
    private void FixedUpdate()
    {
        //float trueSpeed = speed * Time.fixedDeltaTime;
        //rb.AddForce(0, 0, speed);
        con.force = transform.forward * speed;
        //rb.velocity = transform.forward * trueSpeed;
        if (count > timeDestroy)
        {
            Destroy(gameObject);
        }
        count++;
    }
}

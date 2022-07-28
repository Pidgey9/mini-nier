using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    Quaternion rota;
    [SerializeField]
    float rotaSpeed = 1f;
    Rigidbody rb;
    [SerializeField]
    float speed = 1f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //transform.rotation = Quaternion.Inverse(playerTransform.rotation);
        //transform.rotation.SetFromToRotation(transform.position, playerTransform.position);
        TurnTowardsPlayer();
        transform.rotation = rota;
        rb.velocity = transform.forward * speed;
    }
    void TurnTowardsPlayer()
    {
        Vector3 dir = -(transform.position - playerTransform.position).normalized;
        if (dir != Vector3.zero)
        {
            Quaternion look = Quaternion.LookRotation(dir);
            rota = Quaternion.RotateTowards(transform.rotation, look, rotaSpeed);
        }
    }
}

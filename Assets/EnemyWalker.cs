using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    Quaternion rota;
    private void FixedUpdate()
    {
        //transform.rotation = Quaternion.Inverse(playerTransform.rotation);
        //transform.rotation.SetFromToRotation(transform.position, playerTransform.position);
        TurnTowardsPlayer();
        transform.rotation = rota;
    }
    void TurnTowardsPlayer()
    {
        Vector3 dir = -(transform.position - playerTransform.position).normalized;
        if (dir != Vector3.zero)
        {
            Quaternion look = Quaternion.LookRotation(dir);
            rota = Quaternion.RotateTowards(transform.rotation, look, 1);
        }
    }
}

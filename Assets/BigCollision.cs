using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCollision : MonoBehaviour
{
    public IntVariable playerCurrentHP;
    public IntVariable enemyCurrentHP;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerCurrentHP.value--;
        }
        if (collision.collider.CompareTag("Bullet"))
        {
            enemyCurrentHP.value--;
            if (enemyCurrentHP.value <= 0)
            {
                Destroy(gameObject);
            }

        }
    }
}

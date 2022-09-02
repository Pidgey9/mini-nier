using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigCollision : MonoBehaviour
{
    public IntVariable playerCurrentHP;
    public IntVariable enemyCurrentHP;
    public IntVariable level;
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
                SceneManager.LoadScene(0);
                level.value++;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    //[SerializeField]
    public IntVariable playerCurrentHP;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("DEAD");
            playerCurrentHP.value--;
        }
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}

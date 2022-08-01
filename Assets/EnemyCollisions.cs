using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    //[SerializeField]
    public IntVariable playerCurrentHP;
    public IntVariable numberKill;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerCurrentHP.value--;
        }
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            numberKill.value--;
        }
    }
}

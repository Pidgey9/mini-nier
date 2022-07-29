using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    IntVariable enemyCount;
    GameObject[] number;
    private void Awake()
    {
        number = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount.value = number.Length;
    }
}

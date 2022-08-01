using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    IntVariable enemyCount;
    GameObject[] number;
    public IntVariable numberKill;
    public IntVariable enemyStartHP;
    public IntVariable enemyCurrentHP;
    public int numberSpawn;
    private void Awake()
    {
        number = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount.value = number.Length*numberSpawn;
        numberKill.value = enemyCount.value;
        enemyCurrentHP.value = enemyStartHP.value;
    }
}

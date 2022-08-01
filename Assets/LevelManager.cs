using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public IntVariable playerCurrentHP;
    public IntVariable enemyCount;
    public IntVariable l;
    private void Win()
    {
        Debug.Log("YOU WIN!!!!!");
        l.value = 10;
    }
    private void Lose()
    {
        Debug.Log("FAILURE!!!!");
        l.value = 0;
    }
    private void Awake()
    {
        l.value = 1;
    }
    private void Update()
    {
        if (enemyCount.value == 0)
        {
            Win();
        }
        if (playerCurrentHP.value == 0)
        {
            Lose();
        }
    }
}

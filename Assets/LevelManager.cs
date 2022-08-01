using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public IntVariable playerCurrentHP;
    public IntVariable numberKill;
    public IntVariable l;
    public IntVariable enemyCurrentHP;
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
    private void NotWin()
    {
        l.value = 5;
    }
    private void Awake()
    {
        l.value = 1;
    }
    private void Update()
    {
        if (numberKill.value <= 0)
        {
            NotWin();
        }
        if (playerCurrentHP.value <= 0)
        {
            Lose();
        }
        if(enemyCurrentHP.value <= 0)
        {
            Win();
        }
    }
}

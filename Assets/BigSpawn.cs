using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigSpawn : MonoBehaviour
{
    public GameObject bigEnemy;
    public IntVariable l;
    private int count;
    public IntVariable level;
    private void Start()
    {
        count = 0;
    }
    private void Update()
    {
        if (l.value == 5)
        {
            count++;
            if (count == 100)
            {
                if (level.value == 1)
                {
                    Instantiate(bigEnemy, transform);
                }
                if (level.value == 2)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 3)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);


                }
                if (level.value == 4)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 5)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 6)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 7)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 8)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 9)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 10)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);

                }
                if (level.value == 11)
                {
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                    Instantiate(bigEnemy, transform);
                }
                if (level.value > 11)
                {
                    level.value = 1;
                    SceneManager.LoadScene(0);
                }
            }
        }   
    }
}

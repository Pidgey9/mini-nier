using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSpawn : MonoBehaviour
{
    public GameObject bigEnemy;
    public IntVariable l;
    private int count;
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
                Instantiate(bigEnemy, transform);
            }
        }   
    }
}

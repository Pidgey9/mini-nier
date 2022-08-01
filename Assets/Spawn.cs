using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    private int count;
    public IntVariable l;
    private void Start()
    {
        count = 0;
    }
    private void Update()
    {
        if (count%2 == 0 && l.value != 10 && l.value!= 5 && l.value != 6)
        Instantiate(enemy, transform);
        count++;
    }
}

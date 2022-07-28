using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform canon;
    int count;
    public int cadence = 1;
    private void Start()
    {
        count = 0;
    }
    private void FireBullet()
    {
        Instantiate(bullet, canon);
    }
    private void Update()
    {
        count++;

        if (/*Input.GetButton("Fire1") &&*/ count%cadence==0)
        {
            FireBullet();
        }
    }
}

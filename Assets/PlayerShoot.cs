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
    public IntVariable l;
    public IntVariable level;
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
        if (l.value == 10)
        {
            if(count%10 == 0)
            {
                FireBullet();
            }
            return;
        }
        if (/*Input.GetButton("Fire1") &&*/ count%(cadence) == 0 && l.value != 0)
        {
            FireBullet();
        }
    }
}

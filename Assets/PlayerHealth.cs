using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    IntVariable playerStartHp;
    [SerializeField]
    IntVariable playerCurrentHP;
    private void Awake()
    {
        playerCurrentHP.value = playerStartHp.value;
    }
}

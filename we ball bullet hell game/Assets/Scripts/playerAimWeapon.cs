using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAimWeapon : MonoBehaviour
{
    private Transform aimTransform;

    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }
}

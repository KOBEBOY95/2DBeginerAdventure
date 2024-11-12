using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColllectablle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Other)
    {
        Debug.Log("object that entered the trigger is:" + Other);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColllectablle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Other)
    {
      DuckyController controller = Other.GetComponent<DuckyController>();
        if (controller != null)
        {
            if(controller.health < controller.maxhealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
            
        }
        
    }
}

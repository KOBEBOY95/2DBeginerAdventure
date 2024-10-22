using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // QualitySettings.vSyncCount = 0;
       // Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal  = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        
        Vector2 Position = transform.position;
        Position.x = Position.x + 0.1f * horizontal * Time.DeltaTime;
        Position.y = Position.y + 0.1f * Vertical;

        transform.position = Position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
       // QualitySettings.vSyncCount = 0;
       // Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal  = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        

        
    }

    private void FixedUpdate()
    {
        Vector2 Position = rigidbody2d.position;
        Position.x = Position.x + 3.0f * horizontal * Time.deltaTime;
        Position.y = Position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(Position);
    }
}

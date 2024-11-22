using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckyController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxhealth = 5;
    public int health { get { return currenthealth; } }
    int currenthealth;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currenthealth = maxhealth;
        currenthealth = 1;
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
        Position.x = Position.x + speed * horizontal * Time.deltaTime;
        Position.y = Position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(Position);
    }
    public void ChangeHealth(int amount)
    {
     currenthealth = Mathf.Clamp(currenthealth + amount, 0, maxhealth);
        Debug.Log(currenthealth +"/" + maxhealth);
    }
}

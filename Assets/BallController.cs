using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Визначаємо напрямок руху
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Застосовуємо рух до м'яча
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}

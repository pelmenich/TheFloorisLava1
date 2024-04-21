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

        // ��������� �������� ����
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // ����������� ��� �� �'���
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}

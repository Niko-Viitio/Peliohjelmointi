using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float turnSpeed = 10f;

    float moveX, moveZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * moveSpeed * moveZ * Time.deltaTime, Space.World);

        transform.Rotate(Vector3.up * turnSpeed * moveX * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 10f;
    public float turnSpeed = 45f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Lerp position
        transform.position = Vector3.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);

        //Slerp rotation
        Vector3 targetEulers = target.eulerAngles;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetEulers), turnSpeed * Time.deltaTime);
    }
}

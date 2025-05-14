using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCTRL : MonoBehaviour
{
    public float speed = 1500f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
    }
}

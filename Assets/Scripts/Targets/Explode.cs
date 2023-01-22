using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    Rigidbody rb;
    public float maxThrust = 2f;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
    }
}

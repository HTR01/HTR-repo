using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    private Rigidbody rb;
    public float ballThrust;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        new Vector3(0, 0, 1);
        rb.AddForce(transform.forward * ballThrust, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

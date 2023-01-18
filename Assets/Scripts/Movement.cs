using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float RocketThrust = 1000f;
    [SerializeField] float rotationThrust = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        ProcessRoatation();
    }

    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * RocketThrust * Time.deltaTime);
        }

        
    }

    void ProcessRoatation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime);
        }
    }
}

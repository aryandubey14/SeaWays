using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float forceMag;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceMag);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceMag);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceMag);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * forceMag);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceMag);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
}

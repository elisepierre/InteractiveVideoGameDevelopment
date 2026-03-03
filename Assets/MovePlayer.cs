using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public float jump;
    private bool onplane;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalmove = Input.GetAxis("Vertical");
        float horizontalmove = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3 (verticalmove, 0.0f, horizontalmove);
        rb.AddForce(move*speed*Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetButton("Jump") && onplane)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
    }
}

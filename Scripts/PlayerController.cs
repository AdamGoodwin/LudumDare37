using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
    public float rotatespeed = 30;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.WakeUp();

        float horizontal = Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;
    public float maxSpeed = 20f;
    public float drag = 0.98f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = drag; // Asegura que el drag se aplique al Rigidbody
    }

    void FixedUpdate()
    {
        // Obtener la entrada del jugador
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        // Mover el coche hacia adelante y hacia atrás
        Vector3 move = transform.forward * moveInput * speed * Time.fixedDeltaTime;
        rb.AddForce(move, ForceMode.VelocityChange);

        // Limitar la velocidad máxima
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        // Girar el coche
        if (moveInput != 0)
        {
            float turn = turnInput * turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float playerSpeed;

    public Vector3 velocity;

    public bool isGrounded;

    public LayerMask groundMask;

    private float groundDistance = 0.1f;

    public Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isGrounded) {
            velocity.y = Mathf.Sqrt(1.2f * -2 * -9.8f);
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -1f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveVectors = transform.right * x + transform.forward * z;
        controller.Move(moveVectors * playerSpeed * Time.deltaTime);

        velocity.y += -9.8f * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {
    public float rotationSpeed = 1;
    
    public Transform target, player;
    float mouseX, mouseY;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate() {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}

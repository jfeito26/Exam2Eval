using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2000f;
    private float verticalRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float mouseDeltaX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseDeltaY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        verticalRotation -= mouseDeltaY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseDeltaX);
    }
}

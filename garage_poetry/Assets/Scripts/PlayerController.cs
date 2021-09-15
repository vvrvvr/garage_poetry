using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float mouseSensivity = 100f;
    private Transform playerTransform;
    private float mouseX;
    private float mouseY;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") *  mouseSensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") *  mouseSensivity * Time.deltaTime;

        playerTransform.Rotate(Vector3.up * mouseX);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public bool isDragging = false;
    private Vector3 dragStartPosition;
    public float rotationSpeed = 1f;
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            dragStartPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    void LateUpdate()
    {
        if (isDragging)
        {
            Vector3 dragCurrentPosition = Input.mousePosition;
            float deltaX = (dragCurrentPosition.x - dragStartPosition.x) * rotationSpeed * Time.deltaTime;
            float deltaY = (dragCurrentPosition.y - dragStartPosition.y) * rotationSpeed * Time.deltaTime;

            playerTransform.Rotate(Vector3.up, -deltaX, Space.World);
            playerTransform.Rotate(transform.right, deltaY, Space.World);

            dragStartPosition = dragCurrentPosition;
        }
    }
}

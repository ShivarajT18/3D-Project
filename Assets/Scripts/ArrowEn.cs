using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsEnlarge : MonoBehaviour
{
    public float scaleFactor = 1.2f;

    private Vector3 originalScale;

    private void Start()
    {
        // Store original size
        originalScale = transform.localScale;
    }

    private void OnMouseEnter()
    {
        // Enlarge object
        transform.localScale = originalScale * scaleFactor;
    }

    private void OnMouseExit()
    {
        // Back to normal size
        transform.localScale = originalScale;
    }

    private void OnMouseDown()
    {
        // Reset scale when clicked
        transform.localScale = originalScale;
    }
}
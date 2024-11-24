using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanAndZoom : MonoBehaviour
{
    public RectTransform imageTransform; // The image to manipulate
    public float zoomSpeed = 0.1f; // Speed for zooming
    public float panSpeed = 1.0f; // Speed for panning
    public Vector2 panBounds; // Limits for panning (optional)

    private Vector3 lastMousePosition;

    void Update()
    {
        // Pan with mouse movement
        Vector3 delta = Input.mousePosition - lastMousePosition;
        if (delta != Vector3.zero)
        {
            imageTransform.anchoredPosition += new Vector2(delta.x, delta.y) * panSpeed;

            // Optional: Clamp position to pan bounds
            if (panBounds != Vector2.zero)
            {
                Vector2 clampedPosition = imageTransform.anchoredPosition;
                clampedPosition.x = Mathf.Clamp(clampedPosition.x, -panBounds.x, panBounds.x);
                clampedPosition.y = Mathf.Clamp(clampedPosition.y, -panBounds.y, panBounds.y);
                imageTransform.anchoredPosition = clampedPosition;
            }
        }

        // Zoom with scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            Vector3 scale = imageTransform.localScale;
            scale += Vector3.one * scroll * zoomSpeed;
            scale = Vector3.Max(Vector3.one * 0.5f, scale); // Minimum zoom level
            scale = Vector3.Min(Vector3.one * 5.0f, scale); // Maximum zoom level
            imageTransform.localScale = scale;
        }

        // Return to Scene 1 on left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }

        lastMousePosition = Input.mousePosition; // Update the last mouse position
    }

}
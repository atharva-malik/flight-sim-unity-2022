using UnityEngine;

public class PlaneCamera : MonoBehaviour
{
    public Transform view_point;  // Reference to the plane's transform
    public Transform airplane;  // Reference to the plane's transform
    public Vector3 offset = new Vector3(0f, 0f, 0f);  // Camera offset relative to the plane

    private void LateUpdate()
    {
        if (view_point == null)
        {
            Debug.LogWarning("Plane view_point not set for PlaneCamera!");
            return;
        }

        // Set the camera's position to the plane's position plus the offset
        transform.position = view_point.position + offset;

        // Make the camera look at the plane
        transform.LookAt(airplane);
    }
}
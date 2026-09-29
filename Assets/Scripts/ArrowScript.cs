using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;

    public float newCameraPositionX = -15f;
    public float newCameraPositionY = 15f;
    public float newCameraPositionZ = -15f;

    private void OnMouseDown()
    {
        ChangeSphere();
    }

    private void ChangeSphere()
    {
        // Disable first sphere
        sphere1.SetActive(false);

        // Enable second sphere
        sphere2.SetActive(true);

        // Move Main Camera
        Camera.main.transform.position =
            new Vector3(newCameraPositionX,
                        newCameraPositionY,
                        newCameraPositionZ);
    }
}
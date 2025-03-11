using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform objective;
    public float cameraSpeed = 0.025f;
    public Vector3 movement;

    private void LateUpdate()
    {
        Vector3 desiredPosition = objective.position + movement;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, cameraSpeed);
        transform.position = smoothPosition;
    }

}

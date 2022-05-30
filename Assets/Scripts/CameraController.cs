using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform pos;

    private void Update()
    {
        transform.LookAt(pos);
    }
}

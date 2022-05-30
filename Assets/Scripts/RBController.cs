using UnityEngine;

public class RBController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
    }

    // let the falling begin!
    public void Init() {
        rb.isKinematic = false;
    }
}

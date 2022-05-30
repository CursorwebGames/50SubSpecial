using UnityEngine;

public class FocusBehavior : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gm;

    public int max;

    private bool done = false;
    private bool tick = false;

    private float n = 0;


    private void Update()
    {
        if (!done && transform.position.y <= 9)
        {
            gm.Init();
            done = true;
        }

        if (tick)
        {
            n += Time.deltaTime;
        }

        if (n > max)
        {
            gm.ShowCanvas();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            rb.isKinematic = true;
            tick = true;
        }
    }
}

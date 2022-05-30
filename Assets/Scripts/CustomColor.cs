using UnityEngine;

public class CustomColor : MonoBehaviour
{
    public Renderer matRef;
    public Material[] mats;

    private void Start()
    {
        matRef.material = mats[Random.Range(0, mats.Length)];
    }
}

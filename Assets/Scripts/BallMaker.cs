using UnityEngine;

public class BallMaker : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 five1;
    public Vector3 five2;
    public Vector3 zero1;
    public Vector3 zero2;

    public float range;

    private void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            Instantiate(prefab, five1 + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }

        for (int i = 0; i < 13; i++)
        {
            Instantiate(prefab, five2 + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }

        for (int i = 0; i < 12; i++) {
            Instantiate(prefab, zero1 + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }

        for (int i = 0; i < 13; i++) {
            Instantiate(prefab, zero2 + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;

    public void Init()
    {
        // gameobject
        RBController[] go = FindObjectsOfType<RBController>();

        foreach (RBController o in go) {
            o.Init();
        }
    }

    public void ShowCanvas()
    {
        canvas.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}

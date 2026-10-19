
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    public GameObject ViewCamera;
    public float cameraX = 0;

    // Update is called once per frame
    void Update()
    {
        ViewCamera.transform.rotation = Quaternion.Euler(cameraX, 0f, 0f);
    }
}

using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float radius = 2f;
    public float speed = 1f;
    private float angle;
    void Update()
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, 1f, z);
    }
}
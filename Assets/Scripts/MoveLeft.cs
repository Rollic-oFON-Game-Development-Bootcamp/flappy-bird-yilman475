using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 1.2f;

    void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
    }
}

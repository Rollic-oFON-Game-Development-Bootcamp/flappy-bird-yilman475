using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    [SerializeField] private float speed = 1.5f;

    void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFromPool : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private PipePool pipepool = null;
    [SerializeField] private float minHeight, maxHeight;

    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            var obj = pipepool.GetObjects();
            obj.transform.position = Vector3.up * 
                Random.Range(minHeight, maxHeight);

            yield return new WaitForSeconds(spawnInterval);
        }

    }
}

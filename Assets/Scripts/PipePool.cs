using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PipePool : MonoBehaviour
{
    public Queue<GameObject> pooledPipes;

    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private int poolSize;
    

    private void Awake()
    {
        pooledPipes= new Queue<GameObject>();

        for (int i = 0 ; i < poolSize; i++)
        {
            GameObject obj = Instantiate(pipePrefab);
            obj.SetActive(false);
             
            pooledPipes.Enqueue(obj);
        }
    }

    public GameObject GetObjects()
    {
        GameObject obj = pooledPipes.Dequeue();
        obj.SetActive(true);
        pooledPipes.Enqueue(obj);

        return obj;

    }

}

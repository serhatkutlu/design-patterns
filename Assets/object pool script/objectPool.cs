using System;
using System.Collections.Generic;
using UnityEngine;

public class objectPool : MonoBehaviour
{
    [Serializable]
    public struct Pools
    {
        public Queue<GameObject> pool;
        public int poolsize;
        public GameObject Object;

    }
    [SerializeField]
    private Pools[] poolarray=null;

    private void Awake()
    {
        
        for (int j = 0; j < poolarray.Length; j++)
        {
            poolarray[j].pool = new Queue<GameObject>();
            for (int i = 0; i < poolarray[j].poolsize; i++)
            {
                GameObject obj = Instantiate(poolarray[j].Object);
                obj.SetActive(false);
                poolarray[j].pool.Enqueue(obj);
            }

        }

    }

    public GameObject getpool(int j)
    {
        if (j>poolarray.Length)
        {
            return null;
        }
        GameObject obj = poolarray[j].pool.Dequeue();
        obj.SetActive(true);
        poolarray[j].pool.Enqueue(obj);
        return obj;
    }
}

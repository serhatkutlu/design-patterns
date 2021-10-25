using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obje : MonoBehaviour
{
    [SerializeField]
    private float spawninterval = 1;
    [SerializeField]
    private objectPool pool;
    private int count;
    void Start()
    {
        StartCoroutine(startcycle());
        
    }

    IEnumerator startcycle()
    {
        
        while (true)
        {
            GameObject obj = pool.getpool(count++ % 2);
            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawninterval);

        }
    }
}

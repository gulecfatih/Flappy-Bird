using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject barrier;
    public Bird birdScript;
    [SerializeField] float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(barrier, new Vector3(3, Random.Range(-1.28f, 2.9f),0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
}

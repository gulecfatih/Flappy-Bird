using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMove : MonoBehaviour
{
    [SerializeField] float speed;

    private void Start()
    {
        Destroy(gameObject, 8);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += speed * Vector3.left * Time.deltaTime;     
    }
}

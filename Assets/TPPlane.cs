using System.Diagnostics;
using UnityEngine;

public class TPPlane : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = transform.position + new Vector3(0,10,0);
    }
}

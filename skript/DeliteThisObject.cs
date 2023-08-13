using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliteThisObject : MonoBehaviour {


    public float time = 5f;


    void Start()
    {
        Destroy(gameObject, time);


    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Delit"))
        {

            Destroy(gameObject);

        }
    }
}

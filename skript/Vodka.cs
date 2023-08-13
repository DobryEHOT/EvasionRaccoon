using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vodka : MonoBehaviour {

    int z;

    private void Start()
    {
        


    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.AngleAxis(z, Vector3.up);
        z += 2;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("Morality", PlayerPrefs.GetInt("Morality") - 1);
            Destroy(gameObject);
        }
    }
}

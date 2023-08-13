using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciplionok : MonoBehaviour {

    public GameObject Raccun;

    private void Start()
    {
        Raccun = GameObject.Find("Enotnaiznanku2");


    }
    void FixedUpdate ()
    {
        transform.LookAt(Raccun.transform);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("Morality", PlayerPrefs.GetInt("Morality") + 1);
            Destroy(gameObject);
        }
    }
}

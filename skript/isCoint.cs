using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCoint : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") + 1);
            Destroy(gameObject);
        }
    }
}

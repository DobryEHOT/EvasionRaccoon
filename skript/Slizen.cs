using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slizen : MonoBehaviour {

    public GameObject Raccun;


    void Start () {
        Raccun = GameObject.Find("Enotnaiznanku2");
    }
	
	
	void FixedUpdate () {
		transform.LookAt(Raccun.transform);
	}
}

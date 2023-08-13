using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csetok_povorot : MonoBehaviour {

    public GameObject strelka_povorota;
	void FixedUpdate () {
        transform.rotation = Quaternion.Euler(0f, strelka_povorota.transform.rotation.y, 0f);
    }
}

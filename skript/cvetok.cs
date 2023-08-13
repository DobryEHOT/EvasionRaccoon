using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cvetok : MonoBehaviour {

    public Transform target;
    public GameObject trg;
    Vector3 new_target;
    public GameObject cwetok;
    public float a;

    private void Start()
    {
        trg = GameObject.Find("Enotnaiznanku2");
        target = trg.transform;
    }

    void FixedUpdate () {
        a = transform.rotation.y * 100;
      //  cwetok.transform.rotation = Quaternion.Lerp(cwetok.transform.rotation, Quaternion.Euler(0f, gameObject.transform.rotation.y * 100, 0f), Time.deltaTime*10);
        transform.LookAt(target);

	}
}

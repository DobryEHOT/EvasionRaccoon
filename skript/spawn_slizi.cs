using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_slizi : MonoBehaviour {

    public GameObject sliz;
    public GameObject go;

    void Start()
    {
        StartCoroutine(WaitOneSecond());
    }

    IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1.6f);   
            go = (GameObject)Instantiate(sliz, transform.position, transform.rotation);
            Destroy(go, 4f);
        
    }
}

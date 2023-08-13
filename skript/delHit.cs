using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delHit : MonoBehaviour {

    public GameObject gl;
    public GameObject metalalom;

    void Start () {

        

    }
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Delit"))
        {
            Instantiate(metalalom, gameObject.transform.position, Quaternion.AngleAxis(Random.Range(1, 360), Vector3.up));
            
            Destroy(gl);
            
        }
    }
}

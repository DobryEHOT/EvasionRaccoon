using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlubenSlizi : MonoBehaviour {

    public GameObject sloySlizi_1;
    public GameObject sloySlizi_2;
    public GameObject boomSliz;
    float z;
    float down = 1f;
    int popal = 0;

	void Start () {
		
	}
	

	void FixedUpdate () {

        sloySlizi_1.transform.rotation = Quaternion.AngleAxis(z, Vector3.up);
        sloySlizi_2.transform.rotation = Quaternion.AngleAxis(-z + 2f, Vector3.up);
        z += 3f;
        transform.position += transform.right * Time.deltaTime * 5;
       // transform.position -= transform.up * Time.deltaTime * down;
       // down += 0.1f;
       // down = down * 1.5f;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PolNa4Karte"))
        {

            Instantiate(boomSliz, transform.position, Quaternion.Euler(-90.00001f, 0, 0 ));
            popal++;
            if (popal == 2)
            {
                Destroy(gameObject);
            }
        }
    }
}

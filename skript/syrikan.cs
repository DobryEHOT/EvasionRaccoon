using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syrikan : MonoBehaviour {

    float run;
    float x;
    float z;

    public GameObject syrican;
    
    Quaternion pov ;
    bool f = true;
    
	void Start () {

       x = Random.Range(-10f, 0f);


    }

    
    void FixedUpdate()
    {

        transform.position -= transform.right * Time.deltaTime * 5;
        transform.rotation = Quaternion.AngleAxis( run, Vector3.up);
        syrican.transform.rotation = Quaternion.AngleAxis(z , Vector3.up);
        // pov = new Quaternion(transform.localRotation.x, transform.localRotation.y + run, transform.localRotation.z );
        // transform.localRotation = pov;
        z += 3f;

        if (f == true)
        {
            StartCoroutine(WaitOneSecond());
        }
    }

    IEnumerator WaitOneSecond()
    {
        f = false;
        yield return new WaitForSeconds(0.05f);
        run += 3f + x;
            
        f = true;
    }
}

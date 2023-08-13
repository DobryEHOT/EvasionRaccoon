using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class TPshlapaFokusnika : MonoBehaviour {

    public GameObject EHOT;
    public Transform EHOTKuda;
    public GameObject MagicEffektc;
    bool timeWait = false;
     
	void Start () {
		
	}
	

	void FixedUpdate () {

        EHOT.transform.position = Vector3.Lerp(EHOT.transform.position,EHOTKuda.position, 0.2f);

       if (CnInputManager.GetButtonDown("TpShlapaFokusnika") & timeWait == false)
        {
            Instantiate(MagicEffektc, transform.position, MagicEffektc.transform.rotation);
            StartCoroutine(WaitOneSecond());
            transform.position = EHOT.transform.position;
        transform.rotation = EHOT.transform.rotation;  
        }
        
    }

    IEnumerator WaitOneSecond()
    {
        timeWait = true;
        yield return new WaitForSeconds(0.5f);
        timeWait = false;
    }
}

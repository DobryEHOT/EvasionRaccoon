using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class RestartLVL : MonoBehaviour {

    // Use this for initialization
    public int thisLVLtwo = 0;

	void Start () {

        
	}


    public void NLpluse()
    {
        thisLVLtwo += 1;
        if (thisLVLtwo > 1)
        {
            thisLVLtwo = 1;
        }
        
    }


    void Update () {

        if (Input.GetKey(KeyCode.R) || CnInputManager.GetButtonDown("Rest"))
        {

            if (thisLVLtwo == 0)
            {
                Application.LoadLevel(1);
            }
            if (thisLVLtwo == 1)
            {
                Application.LoadLevel(2);
            }
            if (thisLVLtwo == 2)
            {
                Application.LoadLevel(3);
            }
            if (thisLVLtwo == 3)
            {
                Application.LoadLevel(4);
            }

        }


    }
}

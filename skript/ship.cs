using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {


	void FixedUpdate () {

        transform.position += transform.right * Time.deltaTime * 5;
    }
}

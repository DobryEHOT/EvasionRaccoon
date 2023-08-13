using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_ship : MonoBehaviour
{

    public GameObject ship;
    public GameObject go;

    void Start()
    {
        StartCoroutine(WaitOneSecond());
    }

    IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(0.6f);
        for (int i = 0; i <= 2; i++)
        {
            yield return new WaitForSeconds(0.5f);
            go = (GameObject)Instantiate(ship, transform.position, transform.rotation);
            Destroy(go, 4f);
        }
    }

}

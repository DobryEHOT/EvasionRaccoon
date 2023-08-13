using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : MonoBehaviour
{

    public GameObject RESTART;
    public bool murder = false;
    public bool LoX = true;
    public float HPmyCharacter = 1;
    public GameObject blood;

    public GameObject EffectVodkaShoield;

    public GameObject vzriv;

    private void Start()
    {
        if (PlayerPrefs.GetInt("NomerPredmeta") == 2 & PlayerPrefs.GetInt("2item") == 1)
        {
            HPmyCharacter = 2;
        }

        if (PlayerPrefs.GetInt("NomerPredmeta") == 4 & PlayerPrefs.GetInt("4item") == 1)
        {
            HPmyCharacter = 4;
        }
        if (PlayerPrefs.GetInt("NomerPredmeta") == 6 & PlayerPrefs.GetInt("6item") == 1)
        {
            HPmyCharacter = 4;
        }

  

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Dead"))
        {
            HPmyCharacter = HPmyCharacter - 1f;
            Instantiate(blood, gameObject.transform.position, Quaternion.AngleAxis(Random.Range(1, 360), Vector3.up));

            if (LoX == true & (HPmyCharacter <= 0))
            {
                murder = true;
                RESTART.SetActive(true);
                gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("FullDead"))
        {
            HPmyCharacter = 0;

            if (LoX == true & (HPmyCharacter <= 0))
            {
                murder = true;
                RESTART.SetActive(true);
                gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("Vodka"))
        {
            Instantiate(vzriv, transform.position, transform.rotation);
            StartCoroutine(WaitOneSecond());
        }
    }

    IEnumerator WaitOneSecond()
    {
        EffectVodkaShoield.SetActive(true);
        HPmyCharacter += 100;
        yield return new WaitForSeconds(10f);
        HPmyCharacter -= 100;
        if (HPmyCharacter <= 0)
        {
            HPmyCharacter = 1;
           
        }
        if (HPmyCharacter == 1)
        {          
            EffectVodkaShoield.SetActive(false);
        }

    }
}
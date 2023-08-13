using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CnControls;

public class BestScer : MonoBehaviour {

    public GameObject RecordAnGlMenu;
    public GameObject MoneyScear;
    public GameObject MoralityScear;
    public GameObject Scer;
    public GameObject BestedScer;
    public GameObject Enot;
    public int Scear = 0;
    public int BestScear = 0;
    public int money;
    public int OLDRecord;
    public bool golvl = false;

    void Start () {
        
        DontDestroyOnLoad(gameObject);
        if (!PlayerPrefs.HasKey("Best_Record"))
        {
            BestScear = 0;
            OLDRecord = 0;
        }
        else
        {
            BestScear = PlayerPrefs.GetInt("Best_Record");
        }
        RecordAnGlMenu.GetComponent<Text>().text = "RECORD   " + BestScear.ToString();
        if (!PlayerPrefs.HasKey("My_money"))
        {
            money = 0;
        }
        else
        {
            money = PlayerPrefs.GetInt("My_money");
        }
      //  PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") + 10000);
        MoneyScear.GetComponent<Text>().text = "MONEY " + money.ToString();
        money = 0;

        MoralityScear.GetComponent<Text>().text = "MORALITY " + PlayerPrefs.GetInt("Morality").ToString();

    }

    public void LVLStarting()
    {
        OLDRecord = BestScear;
        StartCoroutine(WaitOneSecond());
    }

	void Update () {

        if (Input.GetKey(KeyCode.R) || CnInputManager.GetButtonDown("Rest"))
        {
            Scear = 0;     
        }
        if (golvl == true)
        {
            Enot = GameObject.Find("Enotnaiznanku2");
            Scer = GameObject.Find("Scher");
            BestedScer = GameObject.Find("Scher BEST");
            golvl = false;
        }
    }

        IEnumerator WaitOneSecond()
    {
        for (int i = 0; i <= 100000; i++)
        {
            yield return new WaitForSeconds(1f);

            if (Enot.GetComponent<Die>().murder == true)
            {

            }
            else
            {
                Scear += 1;
                Scer.GetComponent<Text>().text = "this " + Scear.ToString();
                if (Scear > BestScear)
                {
                    BestScear = Scear;
                    
                }
              BestedScer.GetComponent<Text>().text = "BEST " + BestScear.ToString();
            }
            if (OLDRecord < BestScear)
            {
                PlayerPrefs.SetInt("Best_Record", BestScear);
            }
        }
    }
}

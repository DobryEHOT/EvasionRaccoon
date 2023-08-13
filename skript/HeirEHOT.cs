using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeirEHOT : MonoBehaviour
{

    public GameObject Heir1;
    public GameObject Heir2;
    public GameObject Heir3;
    public GameObject Heir4;
    public GameObject Heir5;
    public GameObject Heir6;
    public GameObject Heir7;
    public GameObject Heir8;
    public GameObject Heir9;
    public GameObject Heir10;
    public GameObject Heir11;

    //Dopolnitelniy Skin
    public GameObject trost;
    public GameObject plash_bets;
    int nameItem;

    void Start()
    {
        if (!PlayerPrefs.HasKey("NomerPredmeta"))
        {
            nameItem = 1;
        }
        
        

        ChekItem();

    }

    public void ChekItem()
    {
        nameItem = PlayerPrefs.GetInt("NomerPredmeta");
        if (nameItem == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 2 & PlayerPrefs.GetInt("2item") == 1)
        {
            Heir2.SetActive(true);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 3 & PlayerPrefs.GetInt("3item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(true);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 4 & PlayerPrefs.GetInt("4item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(true);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 5 & PlayerPrefs.GetInt("5item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(true);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 6 & PlayerPrefs.GetInt("6item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(true);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 7 & PlayerPrefs.GetInt("7item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(true);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 8 & PlayerPrefs.GetInt("8item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(true);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(true);
            plash_bets.SetActive(false);
        }
        if (nameItem == 9 & PlayerPrefs.GetInt("9item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(true);
            Heir10.SetActive(false);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(true);
        }
        if (nameItem == 10 & PlayerPrefs.GetInt("10item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(true);
            Heir11.SetActive(false);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
        if (nameItem == 11 & PlayerPrefs.GetInt("11item") == 1)
        {
            Heir2.SetActive(false);
            Heir3.SetActive(false);
            Heir4.SetActive(false);
            Heir5.SetActive(false);
            Heir6.SetActive(false);
            Heir7.SetActive(false);
            Heir8.SetActive(false);
            Heir9.SetActive(false);
            Heir10.SetActive(false);
            Heir11.SetActive(true);
            trost.SetActive(false);
            plash_bets.SetActive(false);
        }
    }


    void Update()
    {

    }

    
}

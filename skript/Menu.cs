using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject ResDropOb;
    public int thisLVL = 0;
    public GameObject Cam;

    public GameObject LVL_ONE_TochkaTPCam;
    public GameObject LVL_TWO_TochkaTPCam;
    public GameObject LVL_TREE_TochkaTPCam;
    public GameObject LVL_FHOUR_TochkaTPCam;
    public GameObject LVL_ONE_Map;
    public GameObject LVL_TWO_Map;
    public GameObject LVL_TREE_Map;
    public GameObject LVL_FHOUR_Map;
    public GameObject PlayG;
    public GameObject oneTrigerLVL;
    public GameObject twoTrigerLVL;

    public GameObject EHOT;
    public GameObject EHOT2;
    public GameObject EHOT3;
    public GameObject EHOT4;

    //Shop
    public GameObject Shoping;
    public GameObject CamShop;
    public GameObject oneTriger;
    public GameObject twoTriger;
    public int nameItem = 1;

    //CloseMap
    public GameObject Zamok;
    public GameObject Zamok2;
    public GameObject CenaNaKarty;

    //DeadMyScear
    public GameObject Dead;
    public GameObject Vibor;

    public bool isShop = false;
    public GameObject pointTPCamShop1;
    public GameObject pointTPCamShop2;
    public GameObject pointTPCamShop3;
    public GameObject pointTPCamShop4;
    public GameObject pointTPCamShop5;
    public GameObject pointTPCamShop6;
    public GameObject pointTPCamShop7;
    public GameObject pointTPCamShop8;
    public GameObject pointTPCamShop9;
    public GameObject pointTPCamShop10;
    public GameObject pointTPCamShop11;
    public GameObject ButtonShop;
    public GameObject ButtonBaskShop;
    public GameObject GlpointTpCamShop;
    public GameObject BuyButton;
    public GameObject MoneyScear;
    public GameObject MoralityScear;


    // public GameObject StartGame;
    public GameObject Options;
    public GameObject HaedGrafik;
    public GameObject LowGrafik;
    public GameObject Bask;
 

    void Awake()
    {
        Application.targetFrameRate = 60;
        if (!PlayerPrefs.HasKey("MyResolution"))
        {

        }
        else
        {
            if (PlayerPrefs.GetInt("MyResolution") == 1)
            {
                Screen.SetResolution(1920, 1080, true);
            }
            if (PlayerPrefs.GetInt("MyResolution") == 2)
            {
                Screen.SetResolution(1280, 720, true);
            }
            if (PlayerPrefs.GetInt("MyResolution") == 3)
            {
                Screen.SetResolution(800, 450, true);
            }
            if (PlayerPrefs.GetInt("MyResolution") == 4)
            {
                Screen.SetResolution(640, 360, true);
            }
            if (PlayerPrefs.GetInt("MyResolution") == 5)
            {
                Screen.SetResolution(320, 180, true);
            }
        }
    }

    void Start() {

        if (!PlayerPrefs.HasKey("NomerPredmeta"))
        {
            nameItem = 1;
        }
        else
        {
            nameItem = PlayerPrefs.GetInt("NomerPredmeta");
        }

        if (!PlayerPrefs.HasKey("MoralityShlapiVedmi-15"))
        {
            PlayerPrefs.SetInt("MoralityShlapiVedmi-15", 0);
        }

        if (!PlayerPrefs.HasKey("DostupKkartam"))
        {
            PlayerPrefs.SetInt("DostupKkartam", 0);
        }
        // PlayerPrefs.SetInt("MoralityShlapiVedmi-15", 0);
        //  PlayerPrefs.SetInt("Morality", 0);

        MoralityScear.GetComponent<Text>().text = "MORALITY " + PlayerPrefs.GetInt("Morality").ToString();

       // PlayerPrefs.SetInt("DostupKkartam", 0);
    }


    void FixedUpdate() {

        if (isShop == true)
        {
            CamShop.transform.position = Vector3.Slerp(CamShop.transform.position, GlpointTpCamShop.transform.position, Time.deltaTime * 5);
        }
    }

    public void SetResFullHd()
    {
        Screen.SetResolution(1920, 1080, true);
        PlayerPrefs.SetInt("MyResolution", 1);

    }
    public void SetResHd()
    {
        Screen.SetResolution(1280, 720, true);
        PlayerPrefs.SetInt("MyResolution", 2);

    }
    public void SetResbetLowHd()
    {
        Screen.SetResolution(800, 450, true);
        PlayerPrefs.SetInt("MyResolution", 3);

    }
    public void SetResLowHd()
    {
        Screen.SetResolution(640, 360, true);
        PlayerPrefs.SetInt("MyResolution", 4);

    }
   
    public void SetResRellyLowHd()
    {
        Screen.SetResolution(320, 180, true);
        PlayerPrefs.SetInt("MyResolution", 5);

    }

    public void Opptions()
    {
       // StartGame.SetActive(false);
        Options.SetActive(false);
        Bask.SetActive(true);
        HaedGrafik.SetActive(true);
        LowGrafik.SetActive(true);
        ButtonShop.SetActive(false);
        oneTrigerLVL.SetActive(false);
        twoTrigerLVL.SetActive(false);
        PlayG.SetActive(false);
        ResDropOb.SetActive(true);
        Zamok2.SetActive(false);
        Zamok.SetActive(false);
        Dead.SetActive(true);
    }

    public void Bakk()
    {
        Bask.SetActive(false);
       // StartGame.SetActive(true);
        Options.SetActive(true);
        HaedGrafik.SetActive(false);
        LowGrafik.SetActive(false);
        oneTrigerLVL.SetActive(true);
        twoTrigerLVL.SetActive(true);
        PlayG.SetActive(true);
        ButtonShop.SetActive(true);
        ResDropOb.SetActive(false);
        Dead.SetActive(false);
        ClosMap();
    }
    public void BakkShop()
    {
        thisLVL = 0;
        ButtonShop.SetActive(true);
        Shoping.SetActive(false);
        Bask.SetActive(false);
        oneTriger.SetActive(false);
        twoTriger.SetActive(false);
        ButtonBaskShop.SetActive(false);
        Cam.SetActive(true);
        LVL_ONE_Map.SetActive(true);
        Cam.transform.position = LVL_ONE_TochkaTPCam.transform.position;
        isShop = false;
        BuyButton.SetActive(false);
        MoneyScear.GetComponent<Text>().text = "MONEY " + PlayerPrefs.GetInt("My_money").ToString();
        EHOT.GetComponent<HeirEHOT>().ChekItem();   
        EHOT2.GetComponent<HeirEHOT>().ChekItem();
        EHOT3.GetComponent<HeirEHOT>().ChekItem();
        EHOT4.GetComponent<HeirEHOT>().ChekItem();
        if (PlayerPrefs.GetInt("4item") == 1 & nameItem == 4 & PlayerPrefs.GetInt("MoralityShlapiVedmi-15") == 0)
        {
            PlayerPrefs.SetInt("Morality", PlayerPrefs.GetInt("Morality") -15);
            PlayerPrefs.SetInt("MoralityShlapiVedmi-15", 1);
        }
        MoralityScear.GetComponent<Text>().text = "MORALITY " + PlayerPrefs.GetInt("Morality").ToString();
        NextLEVEL();
    }

    public void Hg()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void Lg()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void ClosMap()
    {

        if ((PlayerPrefs.GetInt("DostupKkartam") >= thisLVL))
        { Zamok.SetActive(false); Zamok2.SetActive(false); PlayG.SetActive(true);  }
        else {  Zamok.SetActive(true); Zamok2.SetActive(true); PlayG.SetActive(false); CenaNaKarty.GetComponent<Text>().text = "BUY FOR" +
                " " + (thisLVL * 100 * 1.5 + 50).ToString(); }

    }

    public void BuyMap()
    {
        //200 350 500
        if (thisLVL == 1 & PlayerPrefs.GetInt("My_money") >= 200)
        {
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 200);
            PlayerPrefs.SetInt("DostupKkartam", 1);
        }
        if (thisLVL == 2 & PlayerPrefs.GetInt("My_money") >= 350 & PlayerPrefs.GetInt("DostupKkartam") == 1)
        {
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 350);
            PlayerPrefs.SetInt("DostupKkartam", 2);
        }
        if (thisLVL == 3 & PlayerPrefs.GetInt("My_money") >= 500 & PlayerPrefs.GetInt("DostupKkartam") == 2)
        {
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 500);
            PlayerPrefs.SetInt("DostupKkartam", 3);
        }

        MoneyScear.GetComponent<Text>().text = "MONEY " + PlayerPrefs.GetInt("My_money").ToString();
        ClosMap();
    }

        public void NextLEVEL()
    {
        if (thisLVL == 0)
        {
            LVL_ONE_Map.SetActive(true);
            LVL_TWO_Map.SetActive(false);
            Cam.transform.position = LVL_ONE_TochkaTPCam.transform.position;
            Cam.transform.rotation = Quaternion.Euler(39.264f, 0, 0);

        }
        if (thisLVL == 1)
        {
            LVL_ONE_Map.SetActive(false);
            LVL_TREE_Map.SetActive(false);
            LVL_TWO_Map.SetActive(true);
            Cam.transform.position = LVL_TWO_TochkaTPCam.transform.position;
           
        }
        if (thisLVL == 2)
        {
            LVL_TREE_Map.SetActive(true);
            LVL_TWO_Map.SetActive(false);
            Cam.transform.position = LVL_TREE_TochkaTPCam.transform.position;
            Cam.transform.rotation = Quaternion.Euler(39.264f,0,0);
        }
        if (thisLVL == 3)
        {
            LVL_FHOUR_Map.SetActive(true);
            LVL_TREE_Map.SetActive(false);
            Cam.transform.position = LVL_FHOUR_TochkaTPCam.transform.position;
            Cam.transform.rotation = LVL_FHOUR_TochkaTPCam.transform.rotation;
        }
        ClosMap();
    }

    public void NLpluse()
    {
        thisLVL += 1;
        if (thisLVL > 3)
        {
            thisLVL = 3;
        }
        NextLEVEL();
    }

    public void NLminys()
    {
        thisLVL -= 1;
        if (thisLVL < 0)
        {
            thisLVL = 0;
        }
        NextLEVEL();
    }
    public void GOplay()

    {      
            Application.LoadLevel(thisLVL + 1);       
    }


    // Shop
    public void Shop()
    {
        Cam.SetActive(false);
        CamShop.SetActive(true);
        Options.SetActive(false);
        HaedGrafik.SetActive(false);
        LowGrafik.SetActive(false);
        LVL_TWO_Map.SetActive(false);
        LVL_ONE_Map.SetActive(false);
        LVL_TREE_Map.SetActive(false);
        oneTriger.SetActive(true);
        twoTriger.SetActive(true);
        PlayG.SetActive(false);
        Shoping.SetActive(true);
        oneTrigerLVL.SetActive(false);
        twoTrigerLVL.SetActive(false);
        ButtonShop.SetActive(false);
        ButtonBaskShop.SetActive(true);
        isShop = true;
        BuyButton.SetActive(true);
        Bask.SetActive(false);
        Zamok2.SetActive(false);
        Zamok.SetActive(false);
    }

    public void Shoppluse()
    {
        nameItem += 1;
        if (nameItem > 11)
        {
            nameItem = 11;
        }
        PlayerPrefs.SetInt("NomerPredmeta", nameItem);
        IndificationItemShop();
    }

    public void Shopminys()
    {
        nameItem -= 1;
        if (nameItem < 1)
        {
            nameItem = 1;
        }
        PlayerPrefs.SetInt("NomerPredmeta", nameItem);
        IndificationItemShop();
    }

    public void ImBuything()
    {
        if (nameItem == 1)
        {
            PlayerPrefs.SetInt("1item", 1);
        }
        if (nameItem == 2 & PlayerPrefs.GetInt("My_money") >= 25 & PlayerPrefs.GetInt("2item") == 0)
        {
            PlayerPrefs.SetInt("2item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 25);
        }
        if (nameItem == 3 & PlayerPrefs.GetInt("My_money") >= 50 & PlayerPrefs.GetInt("3item") == 0)
        {
            PlayerPrefs.SetInt("3item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 50);
        }
        if (nameItem == 4 & PlayerPrefs.GetInt("My_money") >= 5 & PlayerPrefs.GetInt("4item") == 0)
        {
            PlayerPrefs.SetInt("4item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 5);
          //  PlayerPrefs.SetInt("Ia_nadel_shapku", 1);
        }
        if (nameItem == 5 & PlayerPrefs.GetInt("My_money") >= 50 & PlayerPrefs.GetInt("5item") == 0)
        {
            PlayerPrefs.SetInt("5item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 50);
            //+morality-----------
            PlayerPrefs.SetInt("Morality", PlayerPrefs.GetInt("Morality") + 15);
            //--------------------
        }
        if (nameItem == 6 & PlayerPrefs.GetInt("My_money") >= 70 & PlayerPrefs.GetInt("6item") == 0)
        {
            PlayerPrefs.SetInt("6item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 70);
        }
        if (nameItem == 7 & PlayerPrefs.GetInt("My_money") >= 70 & PlayerPrefs.GetInt("7item") == 0)
        {
            PlayerPrefs.SetInt("7item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 70);
        }
        if (nameItem == 8 & PlayerPrefs.GetInt("My_money") >= 100 & PlayerPrefs.GetInt("8item") == 0)
        {
            PlayerPrefs.SetInt("8item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 100);
        }
        if (nameItem == 9 & PlayerPrefs.GetInt("My_money") >= 100 & PlayerPrefs.GetInt("9item") == 0)
        {
            PlayerPrefs.SetInt("9item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 100);
        }
        if (nameItem == 10 & PlayerPrefs.GetInt("My_money") >= 200 & PlayerPrefs.GetInt("10item") == 0)
        {
            PlayerPrefs.SetInt("10item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 200);
        }
        if (nameItem == 11 & PlayerPrefs.GetInt("My_money") >= 1000 & PlayerPrefs.GetInt("11item") == 0)
        {
            PlayerPrefs.SetInt("11item", 1);
            PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") - 1000);
        }
        MoneyScear.GetComponent<Text>().text = "MONEY " + PlayerPrefs.GetInt("My_money").ToString();
    }

    public void IndificationItemShop()
    {
        if (nameItem == 1)
        {
            GlpointTpCamShop = pointTPCamShop1;
        }
        if (nameItem == 2)
        {
            GlpointTpCamShop = pointTPCamShop2;
          
        }
        if (nameItem == 3)
        {
            GlpointTpCamShop = pointTPCamShop3;
           
        }
        if (nameItem == 4)
        {
            GlpointTpCamShop = pointTPCamShop4;
          
        }
        if (nameItem == 5)
        {
            GlpointTpCamShop = pointTPCamShop5;
         
        }
        if (nameItem == 6)
        {
            GlpointTpCamShop = pointTPCamShop6;
         
        }
        if (nameItem == 7)
        {
            GlpointTpCamShop = pointTPCamShop7;
         
        }
        if (nameItem == 8)
        {
            GlpointTpCamShop = pointTPCamShop8;
       
        }
        if (nameItem == 9)
        {
            GlpointTpCamShop = pointTPCamShop9;
       
        }
        if (nameItem == 10)
        {
            GlpointTpCamShop = pointTPCamShop10;
     
        }
        if (nameItem == 11)
        {
            GlpointTpCamShop = pointTPCamShop11;
     
        }
    }

   public void poluchitBabla()
    {
        PlayerPrefs.SetInt("My_money", PlayerPrefs.GetInt("My_money") + 1000);
        MoneyScear.GetComponent<Text>().text = "MONEY " + PlayerPrefs.GetInt("My_money").ToString();
    }

    public void DeadScearQuastion()
    {
       
        Bask.SetActive(false);
        HaedGrafik.SetActive(false);
        LowGrafik.SetActive(false);
        ResDropOb.SetActive(false);
        Dead.SetActive(false);
        Vibor.SetActive(true);
    
    }

    public void DeadScearYes()
    {
        PlayerPrefs.SetInt("My_money", 0);
        PlayerPrefs.SetInt("Best_Record", 0);
        PlayerPrefs.SetInt("2item", 0);
        PlayerPrefs.SetInt("3item", 0);
        PlayerPrefs.SetInt("4item", 0);
        PlayerPrefs.SetInt("5item", 0);
        PlayerPrefs.SetInt("6item", 0);
        PlayerPrefs.SetInt("7item", 0);
        PlayerPrefs.SetInt("8item", 0);
        PlayerPrefs.SetInt("9item", 0);
        PlayerPrefs.SetInt("10item", 0);
        PlayerPrefs.SetInt("11item", 0);
        PlayerPrefs.SetInt("Morality", 0);
        PlayerPrefs.SetInt("DostupKkartam", 0);
        PlayerPrefs.SetInt("MoralityShlapiVedmi-15", 0);
        Application.LoadLevel(0);
        Destroy(gameObject);
    }
    public void DeadScearNo()
    {

        Bask.SetActive(true);
        HaedGrafik.SetActive(true);
        LowGrafik.SetActive(true);
        ResDropOb.SetActive(true);
        Dead.SetActive(true);
        Vibor.SetActive(false);

    }
}

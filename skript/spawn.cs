using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public float speedSpawner = 0.7f;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;
    public GameObject spawn7;
    public GameObject spawn8;
    public GameObject spawn9;
    public GameObject spawn10;
    public GameObject spawn11;
    public GameObject spawn12;
    public GameObject spawn13;
    public GameObject spawn14;
    public GameObject spawn15;
    public GameObject spawn16;
    public GameObject spawn17;
    public GameObject spawn18;
    public GameObject spawn19;
    public GameObject spawn20;
    public GameObject glSpawn;

    // DUBA
    public GameObject DUBAspawn1;
    public GameObject DUBAspawn2;
    public GameObject DUBAspawn3;
    public GameObject GlobaleDUBAspawn;
    public GameObject DUBA;
    public float tochkaSpawnaDuba;


    //cvetok
    public GameObject cwetok;
    public GameObject spcwetok1;
    public GameObject spcwetok2;
    public GameObject spcwetok3;
    public GameObject spcwetok4;
    public GameObject spcwetok5;
    public GameObject spcwetok6;
    public GameObject spcwetokGLOB;

    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    public GameObject Bullet5;
    public GameObject glBul;

    public GameObject Schet;

    public float KakoyBullet;
    public int tochkaSpawna;
    public GameObject Res;
    GameObject go;

    //MoneySpawn
    public GameObject Coint;
    public GameObject SpawnPositionCoint1;
    public GameObject SpawnPositionCoint2;
    public GameObject SpawnPositionCoint3;
    public GameObject SpawnPositionCoint4;
    public GameObject SpawnPositionCoint5;
    public GameObject SpawnPositionCoint6;
    public GameObject SpawnPositionCoint7;
    public GameObject SpawnPositionCoint8;
    public GameObject SpawnPositionCoint9;
    public GameObject SpawnPositionCointGlobal;
    public int watMoney;
    public float MoneyspeedSpawner = 5;

    public bool OnCwetok = true;


    //Появление циплёнка
    public GameObject SpawnCipa1;
    public GameObject SpawnCipa2;
    public GameObject SpawnCipa3;
    public GameObject SpawnCipa4;
    public GameObject SpawnCipa5;
    public GameObject GlSpawnCipa;
    public GameObject Morality;
    public int speedSpawnMorality = 20;
    public int positionMorality = 0;
    int MorLifeTime = 3;


    //--------------------------
    public GameObject ButtonTeleportation;
    //--------------------------
    //Система спавна водки
    public GameObject Vodka;
    public GameObject SPvodka1;
    public GameObject SPvodka2;
    public GameObject SPvodka3;
    public GameObject SPvodkaGl;
    public int posVodka;
    



    //----------------------------------------------------------------------------------------------------

    void Start()
    {
        if (OnCwetok == true)
        {
            StartCoroutine(Cwetik());
        }
        StartCoroutine(WaitOneSecond());
        StartCoroutine(WaitOneSecondDUBA());
        StartCoroutine(SpwnerMoney());
        StartCoroutine(SpwnerMorality());
        Schet = GameObject.Find("Schet");
        Schet.GetComponent<BestScer>().golvl = true;
        Res.GetComponent<RestartLVL>().thisLVLtwo = Schet.GetComponent<Menu>().thisLVL;

        if (PlayerPrefs.GetInt("NomerPredmeta") == 10 & PlayerPrefs.GetInt("10item") == 1)
        {
            MoneyspeedSpawner = 3;
        }
        if (PlayerPrefs.GetInt("NomerPredmeta") == 8 & PlayerPrefs.GetInt("8item") == 1)
        {
            ButtonTeleportation.SetActive(true);
        }
        if (PlayerPrefs.GetInt("NomerPredmeta") == 5 & PlayerPrefs.GetInt("5item") == 1)
        {
            speedSpawnMorality = 10;
            MorLifeTime = 6;

        }

        if (PlayerPrefs.GetInt("NomerPredmeta") == 7 & PlayerPrefs.GetInt("7item") == 1)
        {
            StartCoroutine(SpwnerVodka());
            
        }

    }


    void Spawntoch()
    {
        if (tochkaSpawnaDuba < 20)
        {
            GlobaleDUBAspawn = DUBAspawn1;
        }
        if (tochkaSpawnaDuba < 60 & tochkaSpawnaDuba > 20)
        {
            GlobaleDUBAspawn = DUBAspawn2;
        }
        if (tochkaSpawnaDuba > 60)
        {
            GlobaleDUBAspawn = DUBAspawn3;
        }

        if (tochkaSpawna == 1)
        {
            glSpawn = spawn1;
        }
        if (tochkaSpawna == 2)
        {
            glSpawn = spawn2;
        }
        if (tochkaSpawna == 3)
        {
            glSpawn = spawn3;
        }
        if (tochkaSpawna == 4)
        {
            glSpawn = spawn4;
        }
        if (tochkaSpawna == 5)
        {
            glSpawn = spawn5;
        }
        if (tochkaSpawna == 6)
        {
            glSpawn = spawn6;
        }
        if (tochkaSpawna == 7)
        {
            glSpawn = spawn7;
        }
        if (tochkaSpawna == 8)
        {
            glSpawn = spawn8;
        }
        if (tochkaSpawna == 9)
        {
            glSpawn = spawn9;
        }
        if (tochkaSpawna == 10)
        {
            glSpawn = spawn10;
        }
        if (tochkaSpawna == 11)
        {
            glSpawn = spawn11;
        }
        if (tochkaSpawna == 12)
        {
            glSpawn = spawn12;
        }
        if (tochkaSpawna == 13)
        {
            glSpawn = spawn13;
        }
        if (tochkaSpawna == 14)
        {
            glSpawn = spawn14;
        }
        if (tochkaSpawna == 15)
        {
            glSpawn = spawn15;
        }
        if (tochkaSpawna == 16)
        {
            glSpawn = spawn16;
        }
        if (tochkaSpawna == 17)
        {
            glSpawn = spawn17;
        }
        if (tochkaSpawna == 18)
        {
            glSpawn = spawn18;
        }
        if (tochkaSpawna == 19)
        {
            glSpawn = spawn19;
        }
        if (tochkaSpawna == 20)
        {
            glSpawn = spawn20;
        }

    }

    void FireBullet()
    {
        if (KakoyBullet == 1)
        {
            glBul = Bullet1;
        }
        if (KakoyBullet == 2)
        {
            glBul = Bullet2;
        }
        if (KakoyBullet == 3)
        {
            glBul = Bullet3;
        }
        if (KakoyBullet == 4)
        {
            glBul = Bullet4;
        }
        if (KakoyBullet == 5)
        {
            glBul = Bullet5;
        }
    }


    IEnumerator WaitOneSecond()
    {

        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(speedSpawner);

            KakoyBullet = Random.Range(1, 5);
            tochkaSpawna = Random.Range(1, 20);
            FireBullet();
            Spawntoch();
            go = (GameObject)Instantiate(glBul, glSpawn.transform.position, glSpawn.transform.localRotation);
            Destroy(go, 6f);

        }
    }

    IEnumerator WaitOneSecondDUBA()
    {
        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(9f);


            tochkaSpawnaDuba = Random.Range(1, 100);
            FireBullet();
            Spawntoch();
            go = (GameObject)Instantiate(DUBA, GlobaleDUBAspawn.transform.position, GlobaleDUBAspawn.transform.localRotation);
            Destroy(go, 6f);

        }

    }

    IEnumerator SpwnerMoney()
    {
        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(MoneyspeedSpawner);
            watMoney = Random.Range(1,9);
            if (watMoney == 1)  SpawnPositionCointGlobal = SpawnPositionCoint1;
            if (watMoney == 2) SpawnPositionCointGlobal = SpawnPositionCoint2;
            if (watMoney == 3) SpawnPositionCointGlobal = SpawnPositionCoint3;
            if (watMoney == 4) SpawnPositionCointGlobal = SpawnPositionCoint4;
            if (watMoney == 5) SpawnPositionCointGlobal = SpawnPositionCoint5;
            if (watMoney == 6) SpawnPositionCointGlobal = SpawnPositionCoint6;
            if (watMoney == 7) SpawnPositionCointGlobal = SpawnPositionCoint7;
            if (watMoney == 8) SpawnPositionCointGlobal = SpawnPositionCoint8;
            if (watMoney == 9) SpawnPositionCointGlobal = SpawnPositionCoint9;
            GameObject spawningMoney = (GameObject)Instantiate(Coint, SpawnPositionCointGlobal.transform.position, SpawnPositionCointGlobal.transform.rotation);
            Destroy(spawningMoney, 5f);
        }
    }


    IEnumerator SpwnerMorality()
    {
        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(Random.Range(10, speedSpawnMorality));
            positionMorality = Random.Range(1, 5);
            if (positionMorality == 1) GlSpawnCipa = SpawnCipa1;
            if (positionMorality == 2) GlSpawnCipa = SpawnCipa2;
            if (positionMorality == 3) GlSpawnCipa = SpawnCipa3;
            if (positionMorality == 4) GlSpawnCipa = SpawnCipa4;
            if (positionMorality == 5) GlSpawnCipa = SpawnCipa5;

            GameObject spawningMorality = (GameObject)Instantiate(Morality, GlSpawnCipa.transform.position, GlSpawnCipa.transform.rotation);
            Destroy(spawningMorality, 3f);
        }
    }


    IEnumerator Cwetik()

    {

        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(Random.Range(5, 25));
            int kybik = Random.Range(1, 6);
            if (kybik == 1)
            {
                spcwetokGLOB = spcwetok1;
            }
            if (kybik == 2)
            {
                spcwetokGLOB = spcwetok2;
            }
            if (kybik == 3)
            {
                spcwetokGLOB = spcwetok3;
            }
            if (kybik == 4)
            {
                spcwetokGLOB = spcwetok4;
            }
            if (kybik == 5)
            {
                spcwetokGLOB = spcwetok5;
            }
            if (kybik == 6)
            {
                spcwetokGLOB = spcwetok6;
            }
            go = (GameObject)Instantiate(cwetok, spcwetokGLOB.transform.position, Quaternion.identity);
            Destroy(go, 2.7f);
        }
    }

    IEnumerator SpwnerVodka()
    {
        for (int i = 0; i <= 10000; i++)
        {
            yield return new WaitForSeconds(Random.Range(10, 15));
            posVodka = Random.Range(1, 3);
            if (posVodka == 1) SPvodkaGl = SPvodka1;
            if (posVodka == 2) SPvodkaGl = SPvodka2;
            if (posVodka == 3) SPvodkaGl = SPvodka3;


            GameObject spawningVodka = (GameObject)Instantiate(Vodka, SPvodkaGl.transform.position, SPvodkaGl.transform.rotation);
            Destroy(spawningVodka, 5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class move : MonoBehaviour
{

    Animator anim;
    CharacterController chart;
    public GameObject hitNa;
    public GameObject perINcam;
    public float speed = 5f;
    public float grav;
    public float gravOtShlapi = -5f;
    public float v;
    public float h;
    Vector3 go;
    bool OtkJ = false;

    //В воздухе
    public bool vVozduhe;



    // это дополнение к шляпе чёрного мага
    public GameObject BlackMagik;

    // это дополнение к шляпе белого мага
    public GameObject WhiteMagik;

    



    void Start()
    {

        if (PlayerPrefs.GetInt("NomerPredmeta") == 9 & PlayerPrefs.GetInt("9item") == 1)
        {
            speed = 7f;

        }
        else
        {
            speed = 5f;
        }
        if (PlayerPrefs.GetInt("NomerPredmeta") == 3 & PlayerPrefs.GetInt("3item") == 1)
        {
            gravOtShlapi = -2f;
            grav = gravOtShlapi;
        }
        anim = GetComponent<Animator>();
        chart = GetComponent<CharacterController>();


        if (PlayerPrefs.GetInt("NomerPredmeta") == 4 & PlayerPrefs.GetInt("4item") == 1)
        {
            BlackMagik.SetActive(true);
        }

        if (PlayerPrefs.GetInt("NomerPredmeta") == 5 & PlayerPrefs.GetInt("5item") == 1)
        {
            WhiteMagik.SetActive(true);

        }
        
    }


    void FixedUpdate()
    {
        v = CnInputManager.GetAxis("Vertical");
        h = CnInputManager.GetAxis("Horizontal");

        Vector3 priPadenii = transform.TransformDirection(new Vector3(0f, grav * Time.deltaTime, 0f));
            chart.Move(priPadenii);


        //Debug.DrawRay(hitNa.transform.position, -transform.up, Color.white, 0.2f);
        RaycastHit hit;
        if (Physics.Raycast(hitNa.transform.position, -transform.up, out hit, 0.1f))
        {
            anim.SetBool("inFly", false);
            vVozduhe = false;
        }
        else
        {
            anim.SetBool("inFly", true);
            vVozduhe = true;
            
        }

        if (!( v == 0  || h == 0))
        {
            anim.SetBool("idle", false);

       //     if (Input.GetKey(KeyCode.LeftShift))
       //     {
         //       anim.SetBool("run", true);
        //        anim.SetBool("walk", false);
        //        speed = 7f;
        //    }
         //   else
         //   {
          //      anim.SetBool("run", false);
               anim.SetBool("walk", true);
         //       speed = 5f;
           // }
            VectorMove();

        }
        else
        {
            anim.SetBool("walk", false);
            anim.SetBool("run", false);
            anim.SetBool("idle", true);
        }

        if (((CnInputManager.GetButtonDown("Jump"))  & vVozduhe == false))//& OtkJ == false
        {
            anim.SetBool("jamp", true);
            StartCoroutine(WaitOneSecond());
            StartCoroutine(OtkatJump());
            OtkJ = true;
        }
        else
        {
            anim.SetBool("jamp", false);
        }

        perINcam.transform.position = Vector3.Slerp(perINcam.transform.position, transform.position, 0.06f);


    }

    void VectorMove()
    {
        go = Vector3.zero;
       
        go.z = v * speed;
        go.x = h * speed;


        if (Vector3.Angle(Vector3.forward, go) > 1f || Vector3.Angle(Vector3.forward, go) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, go, speed, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        chart.Move(go * Time.deltaTime);
    }

    public void miniMeny()
    {
        Destroy(GameObject.Find("Schet"));
        Application.LoadLevel(0);
    }

    IEnumerator WaitOneSecond()
    {
        grav = 3f;
        yield return new WaitForSeconds(0.5f);
        grav = gravOtShlapi;
    }

    IEnumerator OtkatJump()
    {
        OtkJ = true;
        yield return new WaitForSeconds(1f);
        OtkJ = false;
    }
}

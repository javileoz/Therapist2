using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pocion4 : MonoBehaviour
{
    // Start is called before the first frame update.
    public CameraMovementController4 camaraposicion;
    public GameObject selloAprovado;
    public GameObject medicinaFinal;
    public GameObject elemento1;
    bool elemento1selec;
    public GameObject elemento2;
    bool elemento2selec;
    public GameObject elemento3;
    bool elemento3selec;
    public GameObject elemento4;
    bool elemento4selec;
    public GameObject elemento5;
    bool elemento5selec;
    public GameObject elemento6;
    bool elemento6selec;
    public GameObject elemento7;
    bool elemento7selec;
    public GameObject elemento8;
    bool elemento8selec;
    public GameObject elemento9;
    bool elemento9selec;
    public GameObject elemento10;
    bool elemento10selec;

    bool hasGanado = false;
    float time = 0f;

    public AudioSource victory;
    public AudioSource defeat;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            elemento1selec = !elemento1selec;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            elemento2selec = !elemento2selec;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            elemento3selec = !elemento3selec;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            elemento4selec = !elemento4selec;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            elemento5selec = !elemento5selec;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            elemento6selec = !elemento6selec;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            elemento7selec = !elemento7selec;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            elemento8selec = !elemento8selec;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            elemento9selec = !elemento9selec;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            elemento10selec = !elemento10selec;
        }


        //Elemento1
        if (elemento1selec == true)
            elemento1.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento1selec == false)
            elemento1.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento2
        if (elemento2selec == true)
            elemento2.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento3selec == false)
            elemento2.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento3
        if (elemento3selec == true)
            elemento3.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento3selec == false)
            elemento3.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento4
        if (elemento4selec == true)
            elemento4.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        else if (elemento4selec == false)
            elemento4.transform.localScale = new Vector3(0.0012f, 0.0012f, 0.0012f);
        //Elemento5
        if (elemento5selec == true)
            elemento5.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento5selec == false)
            elemento5.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento6
        if (elemento6selec == true)
            elemento6.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento6selec == false)
            elemento6.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento7
        if (elemento7selec == true)
            elemento7.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento7selec == false)
            elemento7.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento8
        if (elemento8selec == true)
            elemento8.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento8selec == false)
            elemento8.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        //Elemento9
        if (elemento9selec == true)
            elemento9.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
        else if (elemento9selec == false)
            elemento9.transform.localScale = new Vector3(0.0012f, 0.0012f, 0.0012f);
        //Elemento10
        if (elemento10selec == true)
            elemento10.transform.localScale = new Vector3(0.0018f, 0.0018f, 0.0018f);
        else if (elemento10selec == false)
            elemento10.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);


        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (elemento1selec == false && elemento2selec == false && elemento3selec == false && elemento4selec == false && elemento5selec == false && elemento6selec == true
                 && elemento7selec == false && elemento8selec == true && elemento9selec == false && elemento10selec == false)
            {
                medicinaFinal.SetActive(true);
                selloAprovado.SetActive(true);
                victory.Play();
                hasGanado = true;
            }
            else
            {
                defeat.Play();
                elemento1selec = false;
                elemento2selec = false;
                elemento3selec = false;
                elemento4selec = false;
                elemento5selec = false;
                elemento6selec = false;
                elemento7selec = false;
                elemento8selec = false;
                elemento9selec = false;
                elemento10selec = false;
                Timer.currentTimer -= 10;
            }

        }

        if (hasGanado)
        {
            time += Time.deltaTime;
            camaraposicion.posicionNotasEnfermedad();
            if (time >= 5)//al terminar pasan x segundos 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Timer.currentTimer = 150;
            }
        }
    }


}

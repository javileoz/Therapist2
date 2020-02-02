using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController3 : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    bool vistaEnfermedades = false;
    bool elegirEnfCorrecta = false;
    public AudioSource defeat;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            posicionMesa();
            vistaEnfermedades = false;
            elegirEnfCorrecta = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            posicionNotas();
            vistaEnfermedades = true;
            elegirEnfCorrecta = false;
        }

        //Condicion para cada caso en este caso el correcto es el 3
        if (Input.GetKeyDown(KeyCode.Alpha9) && vistaEnfermedades == true)
        {
            elegirEnfCorrecta = true;
        }//Es incorrecto y pierde tiempo cuando le da a cualquier numero menos le correcto en este caso 3
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5)
            || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            Timer.currentTimer -= 10; //Si no elegimos la eleccion correcta de la enfermedad perdemos tiempo
            defeat.Play();
        }

        if (elegirEnfCorrecta && vistaEnfermedades)
        {
            posicionArmario();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            posicionNotasEnfermedad();
            vistaEnfermedades = false;
            elegirEnfCorrecta = false;
        }

        Cursor.visible = false;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (currentView != null)
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

            Vector3 currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

            transform.eulerAngles = currentAngle;
        }



    }

    public void posicionMesa()
    {
        currentView = views[0];
    }

    public void posicionNotas()
    {
        currentView = views[1];
    }

    public void posicionArmario()
    {
        currentView = views[2];
    }

    public void posicionNotasEnfermedad()
    {
        currentView = views[3];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeControl : MonoBehaviour
{

    public Animator panelAnim;

    
    void Start()
    {
        panelAnim.SetTrigger("Fade");
    }

    public void FadeIntoNewScene(int index) {
        panelAnim.SetTrigger("Idle");
        StartCoroutine(SwitchScene(index));
    }

    IEnumerator SwitchScene(int index)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(index);
    }

    public void cargarEscenaSiguiente()
    {
        FadeIntoNewScene(1);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            FadeIntoNewScene(1);
        }
    }

}

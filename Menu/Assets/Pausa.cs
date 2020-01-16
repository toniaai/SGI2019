using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    // Start is called before the first frame update

    bool pausa;
    Canvas pantalla;

    void Start()
    {
        pantalla = GetComponent<Canvas>();
        pantalla.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            pausa = !pausa;
            pantalla.enabled = pausa;
            Time.timeScale = (pausa) ? 0 : 1f;
        }
    }
}

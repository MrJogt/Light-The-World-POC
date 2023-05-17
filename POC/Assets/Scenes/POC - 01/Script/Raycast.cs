using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Raycast hit;
    public new Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar si se hace clic con el bot�n izquierdo del mouse
        if (Application.isMobilePlatform)
        {
            // Detectar si se toca la pantalla en dispositivos m�viles
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                // Obtener la posici�n del toque en pantalla
                Vector3 touchPosition = Input.GetTouch(0).position;

                // Lanzar un rayo desde la c�mara hacia la posici�n del toque en pantalla
                Ray ray = mainCamera.ScreenPointToRay(touchPosition);

                // Realizar el raycast y procesar el resultado
                ProcessRaycast(ray);
            }
        }
        else
        {
            // Detectar si se hace clic con el bot�n izquierdo del mouse en PC
            if (Input.GetMouseButtonDown(0))
            {
                // Lanzar un rayo desde la c�mara hacia la posici�n del clic en pantalla
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

                // Realizar el raycast y procesar el resultado
                ProcessRaycast(ray);
            }
        }
    }


    void ProcessRaycast(Ray ray)
    {
        // Variable para almacenar informaci�n del objeto impactado por el raycast
        RaycastHit hit;

        // Realizar el raycast y comprobar si ha impactado en un objeto
        if (Physics.Raycast(ray, out hit))
        {
            // Obtener la posici�n del punto de impacto
            Vector3 clickPosition = hit.point;

            // Mostrar la posici�n en la consola
            Debug.Log("Posici�n del clic: " + clickPosition);
        }
    }

}

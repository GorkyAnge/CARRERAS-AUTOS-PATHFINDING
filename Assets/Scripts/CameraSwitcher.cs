using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // Referencia a la primera c�mara
    public Camera camera2; // Referencia a la segunda c�mara
    private bool isCamera1Active = true; // Estado de la c�mara activa

    void Start()
    {
        // Asegurarse de que solo una c�mara est� activa al inicio
        camera1.gameObject.SetActive(isCamera1Active);
        camera2.gameObject.SetActive(!isCamera1Active);
    }

    void Update()
    {
        // Verificar si se presion� la tecla "C"
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Cambiar el estado de la c�mara activa
            isCamera1Active = !isCamera1Active;

            // Activar la c�mara correspondiente
            camera1.gameObject.SetActive(isCamera1Active);
            camera2.gameObject.SetActive(!isCamera1Active);
        }
    }
}

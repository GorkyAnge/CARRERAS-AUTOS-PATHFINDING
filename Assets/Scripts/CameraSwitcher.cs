using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // Referencia a la primera cámara
    public Camera camera2; // Referencia a la segunda cámara
    private bool isCamera1Active = true; // Estado de la cámara activa

    void Start()
    {
        // Asegurarse de que solo una cámara esté activa al inicio
        camera1.gameObject.SetActive(isCamera1Active);
        camera2.gameObject.SetActive(!isCamera1Active);
    }

    void Update()
    {
        // Verificar si se presionó la tecla "C"
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Cambiar el estado de la cámara activa
            isCamera1Active = !isCamera1Active;

            // Activar la cámara correspondiente
            camera1.gameObject.SetActive(isCamera1Active);
            camera2.gameObject.SetActive(!isCamera1Active);
        }
    }
}

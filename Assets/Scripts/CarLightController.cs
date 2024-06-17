using UnityEngine;

public class CarLightController : MonoBehaviour
{
    public GameObject carLight; // Referencia al GameObject de la luz del carro


    void Update()
    {
        // Verificar si se presionó la tecla "F"
        if (Input.GetKeyDown(KeyCode.F))
        {

            carLight.SetActive(!carLight.activeSelf);
        }
    }
}

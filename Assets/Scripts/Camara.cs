using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    //Referencia del jugador
    public GameObject jugador;
    //vector que me indica el desplazamiento del jugador y la cámara
    Vector3 distancia;
    // altura fija de la cámara sobre el carro
    public float altura = 30f;

    // Start is called before the first frame update
    void Start()
    {
        // Calcula la distancia inicial sin tener en cuenta la altura
        distancia = transform.position - jugador.transform.position;
        distancia.y = 0; // Solo nos interesa la distancia en el plano horizontal
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Mantiene la cámara a una altura fija sobre el carro
        Vector3 nuevaPosicion = jugador.transform.position + jugador.transform.TransformDirection(distancia);
        nuevaPosicion.y = jugador.transform.position.y + altura;

        transform.position = nuevaPosicion;

        // La cámara rota junto con el jugador pero se mantiene en posición cenital
        transform.rotation = Quaternion.Euler(90f, jugador.transform.eulerAngles.y, 0f);
    }
}

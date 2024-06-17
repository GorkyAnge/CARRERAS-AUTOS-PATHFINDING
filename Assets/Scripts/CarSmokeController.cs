using UnityEngine;

public class CarSmokeController : MonoBehaviour
{
    public ParticleSystem smokeParticles; // Referencia al sistema de part�culas de humo


    void Update()
    {
        // Verificar si se est� presionando la tecla "W"
        if (Input.GetKey(KeyCode.W))
        {
  
            smokeParticles.Play();
        }
        else
        {

            smokeParticles.Stop();
        }
    }
}

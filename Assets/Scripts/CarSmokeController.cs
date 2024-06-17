using UnityEngine;

public class CarSmokeController : MonoBehaviour
{
    public ParticleSystem smokeParticles; // Referencia al sistema de partículas de humo


    void Update()
    {
        // Verificar si se está presionando la tecla "W"
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

using UnityEngine;

public class WheelAnimationController : MonoBehaviour
{
    public Animator[] wheelAnimators; // Referencia a los animadores de las ruedas
   

    void Start()
    {
        // Asegurarse de que los animadores estén inicialmente en el estado "Idle"
        foreach (var animator in wheelAnimators)
        {
            animator.SetBool("IsAccelerating", false);
        }
    }

    void Update()
    {
        // Verificar si se está presionando la tecla "W"
        if (Input.GetKey(KeyCode.W))
        {
            // Activar la animación de las ruedas girando

            foreach (var animator in wheelAnimators)
            {
                animator.SetBool("IsAccelerating", true);
            }
        }
        else
        {
            // Detener la animación de las ruedas girando

            foreach (var animator in wheelAnimators)
            {
                animator.SetBool("IsAccelerating", false);
            }
        }
    }
}

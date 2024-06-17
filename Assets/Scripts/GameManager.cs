using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI winText; // Referencia al UI Text para mostrar el mensaje
    private bool gameEnded = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        winText.gameObject.SetActive(false); // Ocultar el texto al inicio
    }

    public void PlayerWon()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            winText.gameObject.SetActive(true);
            winText.text = "¡Has ganado!";
            Debug.Log("¡Has ganado!");
            // Aquí puedes agregar más lógica para lo que sucede cuando el jugador gana
        }
    }

    public void PlayerLost()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            winText.gameObject.SetActive(true);
            winText.text = "Has perdido...";
            Debug.Log("Has perdido...");
            // Aquí puedes agregar más lógica para lo que sucede cuando el jugador pierde
        }
    }
}

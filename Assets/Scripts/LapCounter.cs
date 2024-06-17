using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{
    public Transform[] checkpoints;
    private int currentCheckpointIndex = 0;
    private int lapsCompleted = 0;
    public int totalLaps = 2; // Número de vueltas necesarias para ganar

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == checkpoints[currentCheckpointIndex])
        {
            currentCheckpointIndex = (currentCheckpointIndex + 1) % checkpoints.Length;

            if (currentCheckpointIndex == 0)
            {
                lapsCompleted++;
                Debug.Log("Vueltas completadas: " + lapsCompleted);

                if (lapsCompleted >= totalLaps)
                {
                    Debug.Log("¡Has ganado!");
                    GameManager.Instance.PlayerWon();
                }
            }
        }
    }
}

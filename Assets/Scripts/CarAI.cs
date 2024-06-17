using UnityEngine;
using UnityEngine.AI;

public class CarAI : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    private int lapsCompleted = 0;
    public int totalLaps = 2; // Número de vueltas necesarias para ganar/perder
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(waypoints[currentWaypointIndex].position);
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            agent.SetDestination(waypoints[currentWaypointIndex].position);

            if (currentWaypointIndex == 0)
            {
                lapsCompleted++;
                Debug.Log("Oponente vueltas completadas: " + lapsCompleted);

                if (lapsCompleted >= totalLaps)
                {
                    Debug.Log("El oponente ha ganado!");
                    // Aquí puedes agregar lógica para notificar al jugador que ha perdido
                    GameManager.Instance.PlayerLost();
                }
            }
        }
    }
}

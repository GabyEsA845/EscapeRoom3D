using UnityEngine;

// Experimento: temporizador del puzzle (todavía no aprobado para Dev)
public class PuzzleTimer : MonoBehaviour
{
    [SerializeField] private float timeLimit = 60f;
    private float elapsed;

    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timeLimit)
        {
            Debug.Log("Se acabó el tiempo del puzzle.");
            enabled = false;
        }
    }
}

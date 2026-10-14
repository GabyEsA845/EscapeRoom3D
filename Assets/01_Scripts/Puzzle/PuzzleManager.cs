using UnityEngine;
using UnityEngine.Events;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string solution = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private UnityEvent onSolved;

    private int attempts;
    private bool solved;

    public bool CheckCode(string input)
    {
        if (solved)
            return true;

        if (string.IsNullOrEmpty(input) || input.Length != solution.Length)
        {
            Debug.Log("El código debe tener " + solution.Length + " dígitos.");
            return false;
        }

        attempts++;

        if (input == solution)
        {
            solved = true;
            Debug.Log("Puzzle resuelto.");
            onSolved?.Invoke();
            return true;
        }

        Debug.Log("Código incorrecto. Intentos restantes: " + (maxAttempts - attempts));
        return false;
    }
}

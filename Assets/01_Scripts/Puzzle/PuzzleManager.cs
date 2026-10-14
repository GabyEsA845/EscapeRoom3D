using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private ChestController chest;

    private int attempts;
    private bool solved;

    public bool ValidateCode(string code)
    {
        if (solved)
            return true;

        if (string.IsNullOrEmpty(code) || code.Length != correctCode.Length)
        {
            Debug.Log("El código debe tener " + correctCode.Length + " dígitos.");
            return false;
        }

        if (attempts >= maxAttempts)
        {
            Debug.Log("No quedan intentos.");
            return false;
        }

        attempts++;

        if (code == correctCode)
        {
            solved = true;
            Debug.Log("Código correcto.");
            if (chest != null)
            {
                chest.Unlock();
            }
            return true;
        }

        Debug.Log("Código incorrecto. Intentos restantes: " + (maxAttempts - attempts));
        return false;
    }
}

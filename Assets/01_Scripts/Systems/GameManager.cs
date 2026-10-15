using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool HasKey { get; private set; }

    private int sessionsStarted;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        Debug.Log("GameManager listo");
        Initialize();
    }

    public void Initialize()
    {
        sessionsStarted++;
        HasKey = false;
        Debug.Log("Partida inicializada. Sesión #" + sessionsStarted);
    }

    public void ObtainKey()
    {
        HasKey = true;
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private PlayerInteraction interaction;

    private void Start()
    {
        interaction = GetComponent<PlayerInteraction>();
        Debug.Log("Movement system active. Interaction: " + (interaction != null));
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

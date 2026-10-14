using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float sprintMultiplier = 1.8f;

    private void Start()
    {
        Debug.Log("Movement system active");
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction key pressed");
        }
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? speed * sprintMultiplier : speed;
        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * currentSpeed * Time.deltaTime);
    }
}

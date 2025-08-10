using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");   

        Vector3 move = new Vector3(moveX, 0, moveZ);
        controller.Move(move * speed * Time.deltaTime);
    }
}

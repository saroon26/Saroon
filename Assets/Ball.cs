using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public Transform respawnPoint; // ���� ����� ����� (����� ���� ������)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���� ��� ��� Tag ����� ���� ��� ������ (������)
        Debug.Log("Entered Trigger with tag: " + other.gameObject.tag);

        // ����� ��� ����� ��� ������ ���� ���� Tag ������ "Goal"
        if (other.gameObject.CompareTag("Goal"))
        {
            Debug.Log("GOAL!");  // ����� ����� �����

            // ���� ����� �������� ������ ������ ����� ���� �����
            rb.isKinematic = true;

            // ���� ����� ����� �������
            transform.position = respawnPoint.position;

            

            // ���� �������� ��� �����
            rb.isKinematic = false;
        }
    }
}

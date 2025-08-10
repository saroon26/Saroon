using UnityEngine;
using TMPro;  // �� ������ TextMeshPro� �� ������ UnityEngine.UI �� Text ������

public class GameTimerUI : MonoBehaviour
{
    public float timeLeft = 60f; // ����� ��������
    public TMP_Text timerText;   // ��� ���� ��� (�� ������ TextMeshPro)

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeLeft / 60);
            int seconds = Mathf.FloorToInt(timeLeft % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            timeLeft = 0;
            timerText.text = "00:00";
            // ��� ���� ���� ��� ����� �����
        }
    }
}

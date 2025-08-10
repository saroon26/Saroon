using UnityEngine;
using TMPro;  // ·Ê  ” Œœ„ TextMeshPro° √Ê «” Œœ„ UnityEngine.UI „⁄ Text «·⁄«œÌ

public class GameTimerUI : MonoBehaviour
{
    public float timeLeft = 60f; // «·Êﬁ  »«·ÀÊ«‰Ì
    public TMP_Text timerText;   // —»ÿ «·‰’ Â‰« (·Ê  ” Œœ„ TextMeshPro)

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
            // Â‰« „„ﬂ‰  ÷Ì› ÕœÀ ‰Â«Ì… «·Êﬁ 
        }
    }
}

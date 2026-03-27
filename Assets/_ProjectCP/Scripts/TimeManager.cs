using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI timeText;

    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

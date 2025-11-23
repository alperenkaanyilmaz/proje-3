using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text statusText;

    void Update()
    {
        statusText.text = $"Time: {Time.timeSinceLevelLoad:F1} s";
    }
}

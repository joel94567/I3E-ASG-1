using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int collectedCount = 0;
    public int totalCollectibles = 5; // Number is able to be changed in the inspector

    public TextMeshProUGUI collectibleText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void CollectItem()
    {
        collectedCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        collectibleText.text = collectedCount + " / " + totalCollectibles;
    }
}
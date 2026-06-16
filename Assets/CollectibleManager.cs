using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager instance;

    public int score = 0;
    public int collectiblesLeft;

    public float health = 100f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI collectibleText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        collectiblesLeft = FindObjectsByType<Collectible>(FindObjectsSortMode.None).Length;
        UpdateUI();
    }

    public void CollectItem(int scoreValue)
    {
        score += scoreValue;
        collectiblesLeft--;
        UpdateUI();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        collectibleText.text = "Orbs Remaining: " + collectiblesLeft;
        healthText.text = "Health: " + Mathf.RoundToInt(health);
    }
}
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health = 3;
    public Text gameOverText;


    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            health = 0;
            GameOver();
        }
    }


    void GameOver()
    {
        gameOverText.text = "Game Over";
    }
}
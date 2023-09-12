using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{
    public Image star1;
    public Image star2;
    public Image star3;

    private int playerScore;

    // Aseg�rate de llamar a este m�todo cuando sea apropiado para establecer el puntaje del jugador
    public void SetPlayerScore(int score)
    {
        playerScore = score;
        UpdateStarStatus();
    }

    private void UpdateStarStatus()
    {
        if (playerScore >= 0 && playerScore < 10)
        {
            star1.color = Color.white;
            star2.color = Color.gray;
            star3.color = Color.gray;
        }
        else if (playerScore >= 10 && playerScore < 30)
        {
            star1.color = Color.white;
            star2.color = Color.white;
            star3.color = Color.gray;
        }
        else if (playerScore >= 30)
        {
            star1.color = Color.white;
            star2.color = Color.white;
            star3.color = Color.white;
        }
    }
}

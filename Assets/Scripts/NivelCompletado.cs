using UnityEngine;
using UnityEngine.UI;

public class StarRatingSystem : MonoBehaviour
{
    public Image star1;
    public Image star2;
    public Image star3;

    public Text totalPuntos;

    void Start()
    {
        UpdateStarRating(PlayerPrefs.GetInt("puntosAcumulados2"));
    }

    void Update()
    {
        // Si deseas actualizar el sistema de calificación en tiempo real, descomenta la siguiente línea
        // UpdateStarRating(PlayerPrefs.GetInt("puntosAcumulados2"));
    }

    void UpdateStarRating(int score)
    {
        totalPuntos.text = score.ToString();

        if (score >= 60)
        {
            SetStarColor(star1, Color.yellow);
            SetStarColor(star2, Color.yellow);
            SetStarColor(star3, Color.yellow);
        }
        else if (score >= 20)
        {
            SetStarColor(star1, Color.yellow);
            SetStarColor(star2, Color.yellow);
            SetStarColor(star3, Color.gray);
        }
        else if (score >= 0)
        {
            SetStarColor(star1, Color.yellow);
            SetStarColor(star2, Color.gray);
            SetStarColor(star3, Color.gray);
        }
        else
        {
            SetStarColor(star1, Color.gray);
            SetStarColor(star2, Color.gray);
            SetStarColor(star3, Color.gray);
        }
    }

    void SetStarColor(Image star, Color color)
    {
        star.color = color;
    }
}

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int maxManzanas = 10;
    private int currentManzanas = 0;
    public TextMeshProUGUI scoreTextMesh;

    public string victoriaSceneName = "victoria"; 
    private bool sceneLoaded = false;

    public void SetScoreText(TextMeshProUGUI textMeshProComponent)
    {
        scoreTextMesh = textMeshProComponent;
        ActualizarPuntaje();
    }

    public void RecolectarManzana()
    {
        if (currentManzanas < maxManzanas)
        {
            currentManzanas++;
            ActualizarPuntaje();

            if (currentManzanas >= maxManzanas && !sceneLoaded)
            {
                LoadVictoryScene();
                sceneLoaded = true; 
            }
        }
        else
        {
            Debug.Log("¡Has alcanzado el máximo de manzanas!");
        }
    }

    void LoadVictoryScene()
    {
        SceneManager.LoadScene(victoriaSceneName);
    }

    void ActualizarPuntaje()
    {
        if (scoreTextMesh != null)
        {
            scoreTextMesh.text = "Manzanas: " + currentManzanas + " / " + maxManzanas;
        }
        else
        {
            Debug.LogError("El componente TextMeshProUGUI no está asignado en el ScoreManager.");
        }
    }
}

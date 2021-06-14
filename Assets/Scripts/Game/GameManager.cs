using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text textScore;
    // Start is called before the first frame update

    private void Start()
    {
        
        score = 0;
        textScore.text = score.ToString();

    }
    public void UpdateScore()
    {

        FindObjectOfType<SesKontrol>().AltinSes();
        score++;
        textScore.text = score.ToString();
        if (Secenekler.PuanDegerOku() < score)
        {
            Secenekler.PuanDegerAta(score);
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");  
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}

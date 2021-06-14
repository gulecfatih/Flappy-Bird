using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMenu : MonoBehaviour
{

    [SerializeField] Text puan;
    // Start is called before the first frame update
    void Start()
    {
        
        puan.text = Secenekler.PuanDegerOku().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}

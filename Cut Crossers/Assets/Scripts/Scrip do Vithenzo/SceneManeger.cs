using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TrocaDeCena()
    {
        SceneManager.LoadScene("Start");
    }
    public void TrocaDeCena1()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void TrocaDeCena2()
    {
        SceneManager.LoadScene("Game");
    }
}

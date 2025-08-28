using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ClickMorte : MonoBehaviour
{
    public int contador = 0;    
    [SerializeField]    TMP_Text CountText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clickpositivo()
    {
        contador++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        CountText.text = "Mortes: " + contador.ToString();
    }
}

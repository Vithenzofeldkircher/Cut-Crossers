using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ClickMorte : MonoBehaviour
{
        
    [SerializeField]  TMP_Text CountText;
    public int mortesParaVitoria = 850;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtualizarTexto();
    }

    public void Clickpositivo()
    {
        GameManager.instance.TotalMortes += GameManager.instance.valorDoClick;
        AtualizarTexto();

        if(GameManager.instance.TotalMortes >= mortesParaVitoria)
        {
            SceneManager.LoadScene("Lore2");
        }
    }

    private void AtualizarTexto()
    {
        CountText.text = "Mortes: " + GameManager.instance.TotalMortes.ToString();
    }

    public void upgrade1()
    {

        int custoUpgrade = 10;
        if (GameManager.instance.TotalMortes >= custoUpgrade)
        {
            GameManager.instance.TotalMortes -= custoUpgrade;
            GameManager.instance.valorDoClick += 1;
            AtualizarTexto();
        }
    }

    public void upgradePassivo()
    {
        int custoUpgradePassivo = 50;
        if (GameManager.instance.TotalMortes >= custoUpgradePassivo)
        {
            GameManager.instance.TotalMortes -= custoUpgradePassivo;
            GameManager.instance.mortesporsegundo += 1;
            AtualizarTexto();
        }

    }
}

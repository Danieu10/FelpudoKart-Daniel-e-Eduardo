using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PontuacaoFinal : MonoBehaviour
{
    public TextMeshProUGUI pontuacaotexto;
    public float pontos;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("jogador") != null)
        {
            pontos += 1 * Time.deltaTime;

            if (pontos >= 15)
            {
          
                SceneManager.LoadScene("acabou");
            }
        }
    }
}

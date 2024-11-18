using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public TextMeshProUGUI pontuacaotexto;
    public float pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("jogador") != null)
        {
            pontuacao += 1 * Time.deltaTime;

            if (pontuacao>=15)
            {
                SceneManager.LoadScene("final boss");
            }
        }
    }
}

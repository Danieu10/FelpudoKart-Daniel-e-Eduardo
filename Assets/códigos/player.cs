using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private int vida;
    private int vidaMaxima = 3;

    [SerializeField] Image vidaOn;
    [SerializeField] Image vidaOff;

    [SerializeField] Image vidaOn2;
    [SerializeField] Image vidaOff2;






    public GameObject balaProjetil;
    public Transform arma;
    private bool tiro;
    public float forcaDoTiro;

    public Animator anim;
    public Rigidbody2D corpo;
    public float velocidade = 5f;
    public float forcapulo = 64f;
    private float contagempulo = 0f;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMaxima;
    }

    // Update is called once per frame

    void Update()
    {
        tiro = Input.GetButtonDown("Fire1");

        Atirar();

        Pulo();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("TaPulando", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("TaPulando", false);
        }

    }


    void Pulo()
    {
        if (Input.GetButtonDown("Jump") && contagempulo == 0)
        {
            corpo.AddForce(new Vector2(0f, forcapulo), ForceMode2D.Impulse);
            contagempulo++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            contagempulo = 0;
        }
        else if (collision.gameObject.tag == "morte")
        {

        }
        if (collision.gameObject.tag == "chao")
        {
            anim.SetBool("nochao", true);
        }

    }

    private void Atirar()
    {
        if (tiro == true)
        {
            GameObject temp = Instantiate(balaProjetil);
            temp.transform.position = arma.position;
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(forcaDoTiro, 0);
            Destroy(temp.gameObject, 3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("inimigo"))
        {
            DanoInimigo();
        }
    }


    private void DanoInimigo()
    {
        vida -= 1;


        if (vida == 2)
        {
            vidaOn2.enabled = true;
            vidaOff2.enabled = false;
        }
        else
        {
            vidaOn2.enabled = false;
            vidaOff2.enabled = true;
        }

        if(vida == 1)
        {
            vidaOn2.enabled = true;
            vidaOff2.enabled = false;

            vidaOn.enabled = true;
            vidaOff.enabled = false;
        }
        else
        {
            vidaOn.enabled = false;
            vidaOff.enabled = true;
        }

        if (vida <= 0)
        {
            SceneManager.LoadScene("gameovernormal");
        }











    }







}






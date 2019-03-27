using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CerdidoAI : MonoBehaviour {

    public GameObject FXExplosionProta;
    private GameObject FXExpProta;
    private int Vida = 2;
    private Animator anim;

    public GameObject NombreProtras;
    public GameObject Protras;
    public Image ImagenPerdedor;
    
    public void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        SistemaSonido.instancia.PlayAudioDolor();

        switch (Vida)
        {
            case 2:
                Vida--;
                anim.SetTrigger("Golpe1");
                break;
            case 1:
                Vida--;
                anim.SetTrigger("Golpe2");
                break;
            case 0:
                Controlador.instancia.GameOver = true;
                this.GetComponent<SpriteRenderer>().enabled = false;
                Vector3 suma = new Vector3(0, 2, 0);
                FXExpProta = Instantiate(FXExplosionProta, this.transform.position + suma, Quaternion.identity);

                StartCoroutine(DestruirCerdito());
                break;
        }
    }

    private IEnumerator DestruirCerdito()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
        Destroy(FXExpProta);

        // GameOver
        SistemaSonido.instancia.PlayPerdiste();

        NombreProtras.SetActive(false);
        Controlador.instancia.SalvarPuntuacion();

        ImagenPerdedor.sprite = this.GetComponent<SpriteRenderer>().sprite;
        ImagenPerdedor.gameObject.SetActive(true);
        Protras.SetActive(false);

        Controlador.instancia.Reinicar = true;
    }
}

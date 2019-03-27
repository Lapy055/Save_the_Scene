using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour {

    public GameObject FXExplosion;
    private GameObject FXExp;
    public Sprite botonImagen;
    private bool MostroBoton = false;

    public void Update()
    {
        if (MostroBoton == false && this.transform.position.y <= 4f && !Controlador.instancia.Fallo)
        {
            this.GetComponent<SpriteRenderer>().sprite = botonImagen;
            MostroBoton = true;            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<CircleCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;

        Controlador.instancia.Fallo = true;
        Controlador.instancia.Gravedad = 0.15f;
        SistemaSonido.instancia.PlayExplosion();
        CamaraShake.instancia.shakeDuration = 0.3f;
                       
        FXExp = Instantiate(FXExplosion, this.transform.position, Quaternion.identity);
        StartCoroutine(DestruirBomba());
    }

    private IEnumerator DestruirBomba()
    {
        yield return new WaitForSeconds(1f);
        Controlador.instancia.SoltarBomba = true;
        Destroy(FXExp.gameObject);
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro{

    /* ---------------------------------------------------------------
     * Atributos:
     * En este espacio se declaran las caracteristicas
     * --------------------------------------------------------------- */
    public Materializador materializador;
    public Carroceria carroceria;
    public Llanta[] llantas;
    public Puerta[] puertas;


    /* ---------------------------------------------------------------
     * Constructor:
     * En este espacio se inicializan los atributos
     * --------------------------------------------------------------- */
    public Carro(Vector3 _posicion) {

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);

        llantas = new Llanta[4];
        puertas = new Puerta[4];

        for (int i = 0; i < llantas.Length; i++)
        {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
        }

   
    }

    public void Pintar(Color color)
    {
        carroceria.ColorPrincipal = color;

        for(int i = 0; i < llantas.Length; i++)
        {
            puertas[i].ColorPrincipal = color;
        }
    }


    public void AbrirPuertas()
    {

        for (int i = 0; i < llantas.Length; i++)
        {
            puertas[i].Abrir();
        }
    }

    public void CerrarPuertas()
    {

        for (int i = 0; i < llantas.Length; i++)
        {
            if (Input.GetKeyDown("space"))
            {
                puertas[i].Cerrar();
            }
            
        }
    }




}

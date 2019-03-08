using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro
{

    /* ---------------------------------------------------------------
     * Atributos:
     * En este espacio se declaran las caracteristicas
     * --------------------------------------------------------------- */
    public Materializador materializador;
    public Carroceria carroceria;
    public Llanta[] llantas;
    public Puerta[] puertas;
    public Luces[] luces;


    /* ---------------------------------------------------------------
     * Constructor:
     * En este espacio se inicializan los atributos
     * --------------------------------------------------------------- */
    public Carro(Vector3 _posicion)
    {

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);

        llantas = new Llanta[4];
        puertas = new Puerta[4];
        luces = new Luces[4];

        for (int i = 0; i < llantas.Length; i++)
        {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
            luces[i] = new Luces(materializador, i);
        }

    }

    public Carro(Vector3 _posicion, Color _color)
    {

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);

        llantas = new Llanta[4];
        puertas = new Puerta[4];
        luces = new Luces[4];

        for (int i = 0; i < llantas.Length; i++)
        {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
            luces[i] = new Luces(materializador, i);
        }


        Pintar(_color);
    }


    public Carro(Vector3 _posicion, Color _color,Color _color1)
    {

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);

        llantas = new Llanta[4];
        puertas = new Puerta[4];
        luces = new Luces[4];

        for (int i = 0; i < llantas.Length; i++)
        {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
            luces[i] = new Luces(materializador, i);
        }


        Pintar(_color,_color1);
        
    }

    


    public void Pintar(Color color1)
    {
        carroceria.ColorPrincipal = color1;

        for (int i = 0; i < puertas.Length;i++)
        {
            puertas[i].ColorPrincipal = color1;
        }
    }

    public Carro(Vector3 _posicion,float[] llantass)
    {
        _posicion.y = 0;

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);

        llantas = new Llanta[4];
        puertas = new Puerta[4];
        luces = new Luces[4];

        for (int i = 0; i < llantas.Length; i++)
        {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
            luces[i] = new Luces(materializador, i);
        }

        for (int i=0;i < llantas.Length;i++)
        {
            llantas[i].Radio = llantass[i];
        }



    }






    public void Pintar(Color color2, Color color1)
    {
        carroceria.ColorPrincipal = color2;
            puertas[0].ColorPrincipal = color1;
            puertas[1].ColorPrincipal = color1;
            puertas[2].ColorPrincipal = color2;
            puertas[3].ColorPrincipal = color2;
        
    }

    public void Pintar()
    {

        float a = Random.Range(0,1);
        Color c = new Color(a,a,a);
        carroceria.ColorPrincipal = c;
        for (int i = 0; i < puertas.Length; i++)
        {
            float b = Random.Range(0, 1);
            Color c1 = new Color(b, b, b);
            puertas[i].ColorPrincipal = c;
        } 
    }


}

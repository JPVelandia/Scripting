using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program {

    public static void Main (string[] args) {

        Vector3 vector = new Vector3(0,0,1);
        Carro carro = new Carro(vector);

        Color azul = Color.blue;
        carro.Pintar(azul);

        carro.AbrirPuertas();

        carro.CerrarPuertas();

    }


   



}

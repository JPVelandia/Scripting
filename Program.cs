using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program {

    public static void Main(string[] args) {

        Color color1 = new Color(0.3f, 0.1f, 0.2f);
        Color color2 = new Color(0.01f, 0.3f, 1f);

        Vector3 pos = new Vector3(2, 2, 0);
        Vector3 pos1 = new Vector3(4, 4, 0);
        Vector3 pos2 = new Vector3(6, 6, 0);
        Vector3 pos3 = new Vector3(8, 8, 0);

        float[] radiocarros = {0.1f,0.4f,0.5f,0.5f };



        Carro carro1 = new Carro(pos,color1,color2);
        Carro carro2 = new Carro(pos1,color1);
        Carro carro3 = new Carro(pos2,radiocarros);
        Carro carro4 = new Carro(pos3);
        carro4.Pintar();

    }


}

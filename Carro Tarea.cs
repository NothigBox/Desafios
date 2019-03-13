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
    public Luces[] luces;
    public Vector3 pos0;
    Transform pos;
    public Color color, altColor;

    /* ---------------------------------------------------------------
     * Constructor:
     * En este espacio se inicializan los atributos
     * --------------------------------------------------------------- */
    public Carro(Vector3 _posicion) {

        materializador = new Materializador(_posicion);
        carroceria = new Carroceria(materializador);
        
        llantas = new Llanta[4];
        puertas = new Puerta[4];
        luces = new Luces[4];

        for (int i = 0; i < llantas.Length; i++) {
            llantas[i] = new Llanta(materializador, i);
            puertas[i] = new Puerta(materializador, i);
            luces[i] = new Luces(materializador, i);
        }
    }

    /// <summary> Recibe la posición inicial del carro, el color original y el color alternativo. </summary>
    public Carro(Vector3 _posicion, Color color0, Color color1)
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

        Conductor.EnMovimiento += Conductor_EnMovimiento;

        pos0 = _posicion;
        pos = materializador.gameObject.transform;

        color = color0;
        altColor = color1;
    }

    private void Conductor_EnMovimiento(float _x, float _z)
    {
        if (pos.position.x <= pos0.x + 5 && pos.position.y <= pos0.y + 5 && pos.position.z <= pos0.z + 5) Pintar(color);
        if ((pos.position.x > pos0.x + 5 || pos.position.y > pos0.y + 5 || pos.position.z > pos0.z + 5) ||
            (pos.position.x < pos0.x - 5 || pos.position.y < pos0.y - 5 || pos.position.z < pos0.z - 5)) Pintar(altColor);
    }

    public void Pintar(Color _color)
    {
        carroceria.ColorPrincipal = _color;
        for (int i = 0; i < puertas.Length; i++) puertas[i].ColorPrincipal = _color;
    }

    public float RadioLlantas
    {
        get { return llantas[0].Radio; }
        set
        {
            if (value >= 0.5f) for (int i = 0; i < llantas.Length; i++) llantas[i].Radio = value;
            else Console.WriteLine("Las llantas deben tener un radio mayor a 0,5.");
        }
    }

    public float AlphaVentanas
    {
        get { return Ventana.color.a; }
        set { if(0.25f <= value && value <= 0.75f) Ventana.color = new Color(0,0,0,value); }
    }
}

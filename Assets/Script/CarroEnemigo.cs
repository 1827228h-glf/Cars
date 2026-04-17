using UnityEngine;

public class CarroEnemigo : MonoBehaviour
{
    public float velocidadEnemigo = 7f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Usamos Vector3.forward para que avance hacia adelante de su propio eje
        // Si el carro está rotado mirando hacia tu carro principal, avanzará hacia él.
        transform.Translate(Vector3.forward * velocidadEnemigo * Time.deltaTime);
    }
}

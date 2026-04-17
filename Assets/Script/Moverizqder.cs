using UnityEngine;

public class Moverizqder : MonoBehaviour
{
    public float velocidad = 5f;
    // Si marcamos esta casilla en el Inspector, irá a la derecha. 
    // Si no, irá a la izquierda por defecto.
    public bool moverADerecha = false; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Determinamos la dirección basada en el booleano
        Vector3 direccion = moverADerecha ? Vector3.right : Vector3.left;

        // Movemos el objeto
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}

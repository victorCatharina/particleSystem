using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f; // Velocidade do projétil
    private Vector3 direction; // Direção do projétil
    public GameObject explosionEffect;

    // Método para definir a direção do projétil
    public void Initialize(Vector3 direction)
    {
        this.direction = direction.normalized; // Normaliza a direção
    }

    void Start()
    {    
        Destroy(this.gameObject, 5f);
    }

    void FixedUpdate()
    {
        // Move o projétil na direção especificada
        transform.position += direction * speed * Time.deltaTime;

        // Opcional: Destruir o projétil após um certo tempo
        //Destroy(gameObject, 5f);
    }

    void OnTriggerEnter(Collider other)
    {
        
        explosionEffect.transform.position = this.transform.position;
        Instantiate(explosionEffect, this.transform.position, this.transform.rotation);        
        
        if (other.gameObject.tag == "Obstaculo")
            Destroy(other.gameObject);

        Destroy(this.gameObject);
    }


}

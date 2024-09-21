using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f; // Velocidade do projétil
    private Vector3 direction; // Direção do projétil

    // Método para definir a direção do projétil
    public void Initialize(Vector3 direction)
    {
        this.direction = direction.normalized; // Normaliza a direção
    }

    void Start()
    {
        transform.Rotate(-90f, 0, 0, Space.World);
    }

    void Update()
    {
        // Move o projétil na direção especificada
        transform.position += direction * speed * Time.deltaTime;

        // Opcional: Destruir o projétil após um certo tempo
        Destroy(gameObject, 5f);
    }
}

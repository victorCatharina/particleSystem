using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab do projétil
    public Transform firePoint; // Ponto de onde o projétil será disparado
    public float projectileSpeed = 20f; // Velocidade do projétil


    void FixedUpdate()
    {
        // Verifica se a tecla de disparo é pressionada
        if (Input.GetButtonDown("Fire1")) // "Fire1" é geralmente o botão esquerdo do mouse ou Ctrl
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Cria o projétil no ponto de disparo com a rotação do firePoint
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Obtém o script Projectile e inicializa a direção
        Projectile projScript = projectile.GetComponent<Projectile>();
        projScript.Initialize(firePoint.forward); // Passa a direção para o projétil
    }
}

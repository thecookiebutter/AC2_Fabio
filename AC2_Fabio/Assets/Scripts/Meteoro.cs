using UnityEngine;

public class Meteoro : MonoBehaviour
{
    // A posição do spawner
    public Vector3 spawnPosition;

    // A força aplicada ao meteoro
    public float force;

    // Referência ao Rigidbody do meteoro
    private Rigidbody rb;

    private void Start()
    {
        // Obtém o componente Rigidbody
        rb = GetComponent<Rigidbody>();

        // Certifique-se de que o Rigidbody não está afetado pela gravidade
        rb.useGravity = false;

        // Aplica a força no meteoro, movendo-o na direção do spawner
        MoveMeteor();
    }

    private void MoveMeteor()
    {
        // Calcula a direção do movimento em relação ao spawner
        Vector3 direction = (transform.position - spawnPosition).normalized;

        // Aplica a força na direção calculada
        rb.AddForce(direction * force, ForceMode.Impulse);
    }
}

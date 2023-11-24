using UnityEngine;

public class Manzana : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RecolectarManzana();
        }
    }

    public void RecolectarManzana()
    {
        scoreManager.RecolectarManzana();
        Destroy(gameObject);
    }
}

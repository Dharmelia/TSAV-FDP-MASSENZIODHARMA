using UnityEngine;

public class InteraccionJugador : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Bot�n derecho del rat�n
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Manzana"))
                {
                    Manzana manzana = hit.collider.GetComponent<Manzana>();
                    if (manzana != null)
                    {
                        manzana.RecolectarManzana();
                    }
                }
            }
        }
    }
}

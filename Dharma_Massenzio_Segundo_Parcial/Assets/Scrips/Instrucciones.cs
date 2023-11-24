using UnityEngine;

public class InstructionsDisplay : MonoBehaviour
{
    public GameObject instructionsCanvas; 
    public GameObject menuCanvas; 

    void Start()
    {
        instructionsCanvas.SetActive(false); 
        menuCanvas.SetActive(true); 
    }

    public void ShowInstructions()
    {
        instructionsCanvas.SetActive(true); 
        menuCanvas.SetActive(false); 
    }

    public void ShowMenu()
    {
        menuCanvas.SetActive(true); 
        instructionsCanvas.SetActive(false);
}
}
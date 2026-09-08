using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(CanvasGroup);
        
    }

    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(CanvasGroup);
        isGameStarted = true;
    }
}

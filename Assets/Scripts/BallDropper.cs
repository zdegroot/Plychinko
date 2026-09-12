using UnityEngine;
using UnityEngine.InputSystem;

public class BallDropper : MonoBehaviour
{
    public GameObject BallPrefab;
    // Update is called once per frame
    void Update()
    {
        // if the left mouse button was pressed
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DropBall();
        }
    }

    private void DropBall()
    {
        // pick a position to start at
        Vector3 spawnPosition = GetSpawnPosition();
        
        // create a ball at that position
        Instantiate(BallPrefab, spawnPosition, Quaternion.identity); // what to create, where to create it, and how to rotate
    }

    public Vector3 GetSpawnPosition()
    {
        Vector3 leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 rightEdge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Camera.main.nearClipPlane));

        float randomX = Random.Range(leftEdge.x + 1, rightEdge.x - 1);

        Vector3 spawnPosition = new Vector3(randomX, 4.5f, 0f);

        return spawnPosition;

    }
}

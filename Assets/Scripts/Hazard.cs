using UnityEngine;

public class Hazard : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");

            Time.timeScale = 0f;
        }
    }
}
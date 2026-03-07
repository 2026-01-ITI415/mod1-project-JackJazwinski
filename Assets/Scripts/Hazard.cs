using UnityEngine;

public class Hazard : MonoBehaviour
{
    public GameObject warningMarker;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (warningMarker != null)
            {
                Destroy(warningMarker);
            }
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
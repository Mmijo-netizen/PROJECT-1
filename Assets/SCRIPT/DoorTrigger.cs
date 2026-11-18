using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public float disappearDelay = 0.5f;   // колку секунди чека пред да исчезне

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject, disappearDelay);
        }
    }
}
using UnityEngine;

public class BallKick : MonoBehaviour
{
    private Collider ballCollider;

    private void Awake()
    {
        ballCollider = GetComponent<Collider>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 7)
            ScoreManager.instance.AddScore();          
    }
}

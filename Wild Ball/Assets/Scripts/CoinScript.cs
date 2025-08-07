using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    private GameObject coin;
  
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ps.Play();
            ps.transform.parent = null;
            Destroy(gameObject);
            Destroy(ps.gameObject, 2f);
        }   
    }
}

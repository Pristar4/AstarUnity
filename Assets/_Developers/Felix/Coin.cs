using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _coinpickup;
    [SerializeField] private GameObject dynamic;


    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(_coinpickup, transform.position);
    }
}
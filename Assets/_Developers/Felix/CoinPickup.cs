using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class CoinPickup : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textCoins;
        private float coin = 0;


        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag("Coin"))
            {
                coin++;
                textCoins.text = "Coins: " + coin.ToString();

                Destroy(other.gameObject);
            }
        }
    }
}
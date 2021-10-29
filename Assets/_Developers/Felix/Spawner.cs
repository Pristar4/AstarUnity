using UnityEngine;

public class Spawner : MonoBehaviour
{
    //x-25 y0 z-25 -> x25 y0 z25


    [SerializeField] private GameObject _coinprefab;
    [SerializeField] private GameObject dynamic;
    [SerializeField] private int Amount;


    private void Awake()
    {
        Spawn(Amount);
    }


    private void Spawn(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            var x = Random.Range(-25, 25);
            float y = 0.5f;
            var z = Random.Range(-25, 25);
            Vector3 pos = new Vector3(x, y, z);
            Instantiate(_coinprefab, pos, Quaternion.identity, dynamic.transform);
        }
    }
}
using UnityEngine;

namespace _Developers.Felix
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private int width = 64;
        [SerializeField] private int height = 64;
        [SerializeField] private GameObject square;
        [SerializeField] private GameObject dynamic;


        private void Awake()
        {
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    var vec3 = new Vector3(j, i, 0);
                    var newsquare = Instantiate(square, dynamic.transform);
                    newsquare.transform.position = vec3;
                    newsquare.name = "X " + i + "," + "Y " + j;
                }
            }
        }
    }
}
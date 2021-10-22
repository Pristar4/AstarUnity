using System;
using UnityEngine;

namespace _Developers.Felix
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private  int Width = 64;
        [SerializeField] private  int Height = 64;
        private  int[,] _grid;
        [SerializeField] private GameObject square;
        [SerializeField] private GameObject dynamic;

        public GridManager()
        {
            _grid = new int[Height, Width];
        }


        private void Awake()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
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
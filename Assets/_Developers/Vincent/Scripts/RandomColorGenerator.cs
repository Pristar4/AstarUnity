using UnityEngine;

namespace Vincent {
  public class RandomColorGenerator {
    public Color[,] GenerateColors(int width, int height) {
      Color[,] colors = new Color[width, height];

      for (int x = 0; x < width; x++) {
        for (int y = 0; y < height; y++) {
          colors[x,y] = Random.ColorHSV();
        }
      }
      
      return colors;
    }
  }
}
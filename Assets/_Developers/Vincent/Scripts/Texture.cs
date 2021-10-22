using UnityEngine;
using UnityEngine.Assertions;

namespace Vincent {
  public class Texture {
    public Texture2D CreateTexture2D(int width, int height) {
      var texture = new Texture2D(width, height);
      texture.filterMode = FilterMode.Point;
      return texture;
    }

    public void SetColorTexture2D(Color[,] colors, Texture2D texture) {
      int width = colors.GetLength(0);
      int height = colors.GetLength(1);
      for (int x = 0; x < width; x++) {
        for (int y = 0; y < height; y++) {
          texture.SetPixel(x, y, colors[x, y]);
        }
      }
      texture.Apply();
    }
  }
}
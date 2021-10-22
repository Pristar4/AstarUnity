using System;
using UnityEngine;

namespace Vincent {
  public class Controller : UnityEngine.MonoBehaviour {
    [SerializeField] private Vector3 origin;
    [SerializeField] private Vector2Int dimensions;

    [SerializeField] private Texture2D texture2D;
    
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    
    private Texture texture;
    private RandomColorGenerator randomColorGenerator;
    
    // timer code
    [SerializeField] private float timerLength;
    [SerializeField] private float timeRemaining;
    private bool _timerIsRunning;
    
    private void Start() {
      _timerIsRunning = true;
      timeRemaining = timerLength;
      texture = new Texture();
      randomColorGenerator = new RandomColorGenerator();
      
      texture2D = texture.CreateTexture2D(dimensions.x, dimensions.y);

      meshFilter = gameObject.GetComponent<MeshFilter>();
      meshRenderer = gameObject.GetComponent<MeshRenderer>();
      
      Redraw();
    }

    private void Redraw() {
      
      meshRenderer.material.SetTexture("_MainTex", texture2D);
      
    }

    private void Update() {
      if (_timerIsRunning) {
        if (timeRemaining > 0) {
          timeRemaining -= Time.deltaTime;
        }
        else {
          var colors = randomColorGenerator.GenerateColors(dimensions.x, dimensions.y);
          texture.SetColorTexture2D(colors, texture2D);
          Redraw();
          
          timeRemaining = timerLength;
        }
      }
    }
  }
}
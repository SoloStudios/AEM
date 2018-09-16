using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpot {
  public string ID;
  public Vector2 Position;
  public GameObject Sprite;

  public FloorSpot(string id, int x, int y, GameObject sprite) {
    ID = id;
    Position = new Vector2(x, y);
    Sprite = sprite;
    Sprite.transform.position = new Vector3(x * 64, y * -64, 0f);
    Sprite.GetComponent<SpriteRenderer>().sortingLayerName = "Floor";
  }

  public void UpdateImage(Sprite sprite) {
    Sprite.GetComponent<SpriteRenderer>().sprite = sprite;
  }
}

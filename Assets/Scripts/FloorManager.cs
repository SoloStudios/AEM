using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour {
  private List<FloorMap> floorMaps = new List<FloorMap>();

  public GameObject Player;
  public GameObject FloorParent;
  public GameObject FloorSpotPrefab;
  public List<TextAsset> FloorFiles = new List<TextAsset>();

  public List<FloorSprite> FloorSprites = new List<FloorSprite>();

	// Use this for initialization
	void Start () {
    FloorFiles.ForEach((TextAsset file) => {
      floorMaps.Add(LoadFloorFromFile(file));
    });
	}
	
	// Update is called once per frame
	void Update () {
    PlayerManager player = Player.GetComponent<PlayerManager>();

    // Draw the currrent floor

    FloorMap floor = floorMaps[player.Floor - 1];

    floor.floorSpots.ForEach((FloorSpot spot) => {
      if (spot.ID.StartsWith("0")) {
        Sprite sprite = FloorSprites.Find(floorSprite => spot.ID.Contains(floorSprite.ID)).Sprite;
        if (sprite) {
          spot.UpdateImage(sprite);
        }
      } else if (!spot.ID.Contains("---")) {
        spot.UpdateImage(Resources.Load<Sprite>("Sprites/Room"));
      }
    });
	}

  public FloorMap LoadFloorFromFile(TextAsset textFile) {
    List<FloorSpot> spots = new List<FloorSpot>();
    string[] rows = textFile.text.Split('\n');
    for (int x = 0; x < rows.Length; x++) {
      string[] row = rows[x].Split(' ');
      for (int y = 0; y < row.Length; y++) {
        GameObject newSpot = Instantiate(FloorSpotPrefab);
        newSpot.transform.parent = FloorParent.transform;
        spots.Add(new FloorSpot(row[y], y, x, newSpot));
      }
    };
    return new FloorMap(spots);
  }
}

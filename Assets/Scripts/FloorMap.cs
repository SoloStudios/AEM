using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMap {
  public List<FloorSpot> floorSpots;

  public FloorMap(List<FloorSpot> spots) {
    floorSpots = spots;
  }

  // Don't really need this as a seperate class, but who knows what we might do later with the floor maps
}

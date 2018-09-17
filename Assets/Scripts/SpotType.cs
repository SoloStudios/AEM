using System.Collections;
using System.Collections.Generic;

public class SpotType {
    const string NoAction = "000";
    const string West = "001";
    const string East = "002";
    const string North = "003";
    const string WestEast = "004";
    const string WestNorth = "005";
    const string WestNorthEast = "006";
    const string NorthEast = "007";
    const string DeadEnd = "008";
    //Need to create values for all directions, for example westnortheastsouth
    //Naming convention should follow starting at west going clockwise to keep consistency
    //the top of the map is always north
}

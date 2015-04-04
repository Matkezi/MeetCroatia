#pragma strict

var terrainTop : Terrain;
var terrainBot : Terrain;
var terrainRight : Terrain;
var terrainLeft : Terrain;

function Start () {
	var thisTerrain : Terrain = GetComponent(Terrain);
	thisTerrain.SetNeighbors(terrainLeft, terrainTop, terrainRight, terrainBot);
}


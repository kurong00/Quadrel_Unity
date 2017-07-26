﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FrameWork;

public class SceneTypeManager : Singleton<SceneTypeManager>{

	GameColor colorList = new GameColor();

    public string playerName = "mushroom";
    public enum ScenesType
	{
		MONDAY = 1,
		TUESDAY,
		WENESDAY,
		THURSDAY,
		FRIDAY,
		SATERDAY,
	}

	public GameColor SelectColor(ScenesType scene)
	{
		switch (scene) {
		case ScenesType.MONDAY:
                playerName = "mushroom";
                colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (239 / 255f, 83 / 255f, 80 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (239 / 255f, 154 / 255f, 154 / 255f);
			    break;
		case ScenesType.TUESDAY:
                playerName = "cheese";
                colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    break;
		case ScenesType.WENESDAY:
			    colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    break;
		case ScenesType.THURSDAY:
			    colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    break;
		case ScenesType.FRIDAY:
			    colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    break;
		case ScenesType.SATERDAY:
			    colorList.colorOfTileOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfTileTwo = new Color (191 / 255f, 166 / 255f, 149 / 255f);
			    colorList.colorOfWall = new Color (193 / 255f, 104 / 255f, 93 / 255f);
			    colorList.colorOfMeshRenderOne = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    colorList.colorOfMeshRenderTwo = new Color (140 / 255f, 126 / 255f, 120 / 255f);
			    break;
		}
		return colorList;
	}
}
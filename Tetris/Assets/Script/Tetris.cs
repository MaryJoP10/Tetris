using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetris
{
    I, J, L, O, S, T, Z
}

[System.Serializable]
public struct TetrisData
{
    public Tile tile;
    public Tetris tetris;

    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[tetris];
        wallKicks = Data.WallKicks[tetris];
    }

}
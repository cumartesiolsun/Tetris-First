using UnityEngine;

public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] Tetrominoes;

    private void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }

    public void LeftButtonClick()
    {
        FindObjectOfType<TetrisBlock>().LeftButtonClick();
    }

    public void RightButtonClick()
    {
        FindObjectOfType<TetrisBlock>().RightButtonClick();
    }

    public void DownButtonClick()
    {
        FindObjectOfType<TetrisBlock>().DownButtonClick();
    }

    public void RotateButtonClick()
    {
        FindObjectOfType<TetrisBlock>().RotateButtonClick();
    }
}

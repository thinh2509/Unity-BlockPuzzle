using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    
    [SerializeField] private GameObject cellPrefab;

    
    private int width = 10;
    private int height = 10;

    void Start()
    {
       
        GenerateGrid();
    }

    void GenerateGrid()
    {
        
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                
                GameObject newCell = Instantiate(cellPrefab, new Vector2(x, y), Quaternion.identity);

                
                newCell.name = "Cell " + x + "," + y;

                
                newCell.transform.parent = this.transform;
            }
        }

        
        Camera.main.transform.position = new Vector3(4.5f, 4.5f, -10f);
        Camera.main.orthographicSize = 6;
    }
}
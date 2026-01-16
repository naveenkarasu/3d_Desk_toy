using UnityEngine;
using UnityEngine.SceneManagement; // REQUIRED for reloading the scene

public class GridSpawner : MonoBehaviour
{
    public GameObject toyPrefab;
    public int rows = 2;
    public int cols = 3;
    public float spacing = 2.0f;

    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        for (int x = 0; x < cols; x++)
        {
            for (int z = 0; z < rows; z++)
            {
                Vector3 spawnPos = new Vector3(x * spacing, 1, z * spacing);
                Instantiate(toyPrefab, spawnPos, Quaternion.identity);
            }
        }
    }

    // --- NEW UI FUNCTIONS BELOW ---

    public void RandomizeAllColors()
    {
        // Find every object in the scene with the tag "Toy"
        GameObject[] toys = GameObject.FindGameObjectsWithTag("Toy");

        foreach (GameObject toy in toys)
        {
            Renderer rend = toy.GetComponent<Renderer>();
            rend.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    public void ResetScene()
    {
        // Reloads the currently active scene (resets everything)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
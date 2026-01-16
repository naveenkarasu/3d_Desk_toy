using UnityEngine;

public class InputHandler : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }

    void HandleClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Toy"))
            {
                ChangeColor(hit.collider.gameObject);
            }
            Debug.Log("Clicked on: " + hit.collider.gameObject.name);
        }
    }

    void ChangeColor(GameObject obj)
    {
        Renderer toyRenderer = obj.GetComponent<Renderer>();
        
        Color newColor = new Color(Random.value, Random.value, Random.value);

        toyRenderer.material.color = newColor;
       
    }
}

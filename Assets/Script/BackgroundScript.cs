using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    [Range(-1,1)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime*scrollSpeed)/10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageScroll : MonoBehaviour
{
    Image image;
    Vector2 speed = new Vector2(0.1f, 0.1f);

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.material.mainTextureOffset += Time.deltaTime * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoader : MonoBehaviour
{
    public Image original;
    public Sprite newImage;

    public void loadImage()
    {
        original.sprite = newImage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(fileName = "Images_", menuName = "Images", order = 1)]
public class ImagesDatabase : ScriptableObject {

    [SerializeField]
    private List<Sprite> images;

    public Sprite GetRandomImage()
    {
        int index = Random.Range(0, images.Count);
        return images[index];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    private int ArraySize = 50;// количество предметов
    private float random_positionX;//случайная позиция
    private float random_positionZ;

    private GameObject Object;//объект генерации
    public Terrain tera;// текущий террейн 
    public GameObject ItemPrefab;// генирируемый объект
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i <= ArraySize; i++)
        {
            Object = new GameObject();
            Rand();//рандомизация позиции
            Vector3 newPos = new Vector3(random_positionX, this.Object.transform.position.y + 1, random_positionZ);// выбираем случайную позицию объекта генерации
            this.Object.transform.localPosition = newPos;// помещаем на позицию

            Instantiate(ItemPrefab, Object.transform.position, Object.transform.rotation);//инициализируем необходимый объект
            Destroy(Object);
        }
    }
    private void Update()
    {
        
        
        
    }
    private void Rand()
    {
        var bounds = tera.GetComponent<TerrainCollider>().bounds;// получаем размеры террейна
        random_positionX = Random.Range(bounds.size.x - 450, bounds.size.x - 50);
        random_positionZ = Random.Range(bounds.size.z - 450, bounds.size.z - 50);

    }


}

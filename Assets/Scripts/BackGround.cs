using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private float speedBG = 2f;
    [SerializeField] private float widthBG;
    private GameObject obj;

    private void Start()
    {
        obj = gameObject;
    }


    void Update()
    {
        obj.transform.Translate(Vector3.left * speedBG * Time.deltaTime);
        if (obj.transform.position.x <= - (widthBG * 2))
        {
            obj.transform.position = new Vector3(widthBG * 2, obj.transform.position.y, obj.transform.position.z);
        }
    }
}

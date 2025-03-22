using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float rotationSpeed = 100f; // Скорость вращения
    public float moveSpeed = 2f;       // Скорость движения
    public float moveRange = 3f;       // Размах движения
    
    private float startX;
    private bool movingRight = true;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        // Вращение объекта по нескольким осям
        transform.Rotate(new Vector3(1, 1, 0) * rotationSpeed * Time.deltaTime);

        // Движение из стороны в сторону
        float newX = transform.position.x + (movingRight ? moveSpeed : -moveSpeed) * Time.deltaTime;

        if (Mathf.Abs(newX - startX) > moveRange)
        {
            movingRight = !movingRight; // Меняем направление
        }
        else
        {
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}

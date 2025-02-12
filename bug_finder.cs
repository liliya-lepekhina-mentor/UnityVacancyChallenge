using UnityEngine;

public class BugFinder : MonoBehaviour
{
    void Start()
    {
        string vacancy = "Мы ищем Unity Developer! Условия: долгосрочная работа, удалённо, гибкий график. Свяжитесь с нами: [ваш email или Telegram].";
        if (1 == 2)  // Ошибка: нужно исправить на if (1 == 1)
        {
            Debug.Log(vacancy);
        }
    }
}
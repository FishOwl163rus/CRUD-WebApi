# CRUD-WebApi

Простой пример работы WebApi с использование EF Core.

## Роутинг запросов

| Запрос | Параметры | Результат |
| --- | --- | --- |
| notes/getallnotes | - | возвращает все заметки |
| notes/getnote | id | возвращает заметку по id |
| notes/removeallnotes | - | удаляет все заметки |
| notes/insertnote | noteModel (json формат) | добавляет заметку |
| notes/updatenote | noteModel (json формат) | обновляет заметку |

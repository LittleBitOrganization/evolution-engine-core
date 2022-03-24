# Импорт
```JSON
"dependencies": {
	"com.littlebitgames.coremodule": "https://github.com/LittleBitOrganization/evolution-engine-core.git"
}
```
# Введение

com.littlebitgames.coremodule  

Модуль ядра - главный модуль. Позволяет работать с другими модулями, и содержит в себе интерфейсы для работы с некоторыми сервисами, классы для работы с данными, некоторые вспомогающие ассеты.

## Зависимости и требования:
* Unity version: 2021.1.6f1 и выше
* Api compatibility level: .Net 4.x


## Данные

Для работы с данными есть пустой класс Data с пустым конструктором.  

```C#
[Serializable]
public class Data
{
    public Data()
    {
            
    }
}
```

Вам необходимо наследоваться от Data, чтобы создать данные, с которыми может работать ядро и все его модули.
У вашего класса обязательно должен быть реализован конструктор без параметров. 

Пример данных в вашем проекте:

```C#
[Serializable]
public class ObjectData : Data 
{
    public int level = 0;
    public ObjectData(int levelValue)
    {
        level = levelValue;
    }

    public ObjectData()
    {
        level = 0;
    }
}
    
```

Для сервиса работы с данными есть интерфейс IDataStorageService.


```C#
public interface IDataStorageService : IService
{
    public delegate void GenericCallback<T>(T item);
    
    //Возвращает Data с T типом по ключу.  
    public T GetData<T>(string key) where T : Data, new();
    
    //Устанавливает Data с T типом по ключу
    public void SetData<T>(string key, T data) where T : Data;
    
    //Устанавливает подписку на данные определённого типа по ключу. При вызове SetData срабатывает CallBack
    public void AddUpdateDataListener<T>(object handler,string key, GenericCallback<T> onUpdateData);

    //Удаляет подписку на данные
    public void RemoveUpdateDataListener<T>(object handler, string key,  GenericCallback<T> onUpdateData);
    
    //Удаляет все подписки, которые были созданы с объекта handler
    public void RemoveAllUpdateDataListenersOnObject(object handler);
}
```
 

## Services

Для создания сервиса реализуйте у сервиса интерфейс IService

```C#
public interface IService 
{
	
}
```

## Coroutine

Для работы с корутинами есть интерфейс ICoroutineRunner.  
Благодаря этому интерфейсу вы можете передавать в сервисы не MonoBehaviour,
а ICoroutineRunner для получения доступа к корутинам.  


```C#
        
public interface ICoroutineRunner
{
    public Coroutine StartCoroutine(IEnumerator coroutine);
}
```

Реализация интерфейса на MonoBehaviour:

```C#
public class CoroutineRunner : MonoBehaviour, ICoroutineRunner
{
        
}
```

Если вы используете Zenject вы можете забиндить реализацию этого интерфейса для простого доступа к корутинам.

## IUnified - работа с интерфейсами в инспекторе

В модуле ядра есть ассет для переноса объектов в поля инспектора по интерфейсу: https://assetstore.unity.com/packages/tools/localization/iunified-12117 .  
Для этого вам необходимо создать класс для поля, реализующий ваш интерфейс, например IInterface
```C#
[Serializable]
public class InterfaceContainer : IUnifiedContainer<IInterface>
{
        
}
```


После вы можете в вашем скрипте создать поле InterfaceContainer и перетаскивать в это поле все объекты, реализующие интерфейс IInterface
```C#
public class LevelObject : MonoBehaviour
{
    ...
    [SerializeField] private InterfaceContainer _dataHolder = null;
    ...
}

```

Получение доступа к объекту, реализовавшему IInterface

```C#
public class LevelObject : MonoBehaviour
{
    ...
    public IInterface iInterface => _dataHolder.Result
    ...
}

```






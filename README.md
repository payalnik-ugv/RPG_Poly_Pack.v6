# The Diamond Collection game on an Unity Engine (3D RPG)

Этот проект собирается на `Unity Engine 6.3 (LTS)`.

#### Решение проблемы №1
Есть проблема с импортиртом ассета [Jammo Character](https://assetstore.unity.com/packages/3d/characters/jammo-character-mix-and-jam-158456), поскольку он был разработан на старую версию `Unity Engine 2019.2.3` и содержит устаревшие методы.
Решить проблему с устаревшими методами можно загрузить исходный код этого проекта из репозитория [Jammo-Character](https://github.com/mixandjam/Jammo-Character) и принудительно собрать его на версиии `Unity Engine 6.3 (LTS)`.
А все устаревшие методы на которые будет ругаться `Unity Engine 6.3 (LTS)` можно просто удалить из проекта.
Этот проект переименовываем и далее в этот проект импортируем ассет [RPG Poly Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410)

#### Решение проблемы №2
`this project uses input manager which is market for depricated to manage input in your project use the input system package instead`
+ In `Unity 6.3`, listening for the `KeyCode.Alpha1` input depends entirely on whether you are using the Legacy Input Manager or the New `Input System Package`
  > unity 6.3 input stream KeyCode.Alpha1
    ```
	// Detects the exact frame the '1' key is pressed down
	if (Input.GetKeyDown(KeyCode.Alpha1))
	{
	}
	```
	```
	// Check if the keyboard layout contains the '1' key and if it was pressed
    if (Keyboard.current.digit1Key.wasPressedThisFrame)
    {
    }
	```
+ Чтобы перенести `Input.GetAxis("Horizontal")` в `Unity 6.3` с использованием нового `Input System Package`
  > Input.GetAxis ("Horizontal") как мигрировать на unity 6.3 input stream package
  - Настройка в редакторе Unity:
    1. Убедитесь, что новый пакет установлен (в Project Settings -> Player -> Other Settings должна быть выбрана опция Input System Package).
	2. Создайте ассет Input Actions (нажмите правой кнопкой мыши в окне проекта -> Create -> Input Actions).
	3. Откройте ассет, создайте новую Action Map (например, Player), и добавьте действие Move типа Value с контролем Vector2
	4. Добавьте привязки для движения, выбрав тип 2D Vector Composite (он объединит клавиши W, A, S, D или стрелки в оси X и Y).
	5. Сохраните изменения и сгенерируйте C#-класс (отметьте галочку Generate C# Class в настройках ассета):
       ```
	   targetHorizontal = Input.GetAxis ("Horizontal");
       ```
       ```
	   // Считываем сырой вектор (x = Horizontal, y = Vertical)
       Vector2 inputVector = moveAction.action.ReadValue<Vector2>();
       targetHorizontal = inputVector.x;
       ```
  - [Migrating from Input Manager to Input System in Unity 6.3](https://www.patreon.com/sunnyvalleystudio/posts/migrating-from-6-150988785?l=es-419)

For details inform can you refer to base tutorials [#1](https://www.youtube.com/watch?v=K5FM6bz4qO4) and [#2](https://www.youtube.com/watch?v=veFxqpw8LKI),
also [HotKes](https://docs.unity3d.com/ru/2021.1/Manual/search-overview.html), [Engine lifecycle](https://docs.unity3d.com/ru/current/Manual/ExecutionOrder.html).

Explain lessons topics: Event, Enums, Coroutines, Singleton, Generic

+ Unity API:
  - [Audio](https://docs.unity3d.com/6000.3/Documentation/Manual/Audio.html)
  - [Managing scenes in Build Profiles](https://docs.unity3d.com/6000.3/Documentation/Manual/build-profiles.html)
  - [Managing scenes in Build Profiles](https://www.easyar.com/doc/ru/develop/unity/getting-started/quickstart.html)
  - [MonoBehaviour.Start()](https://docs.unity3d.com/6000.3/Documentation/ScriptReference/MonoBehaviour.Start.html)
  - [MonoBehaviour.Update()](https://docs.unity3d.com/6000.3/Documentation/ScriptReference/MonoBehaviour.Update.html)
  - [MonoBehaviour.OnDisable()](https://docs.unity3d.com/6000.3/Documentation/ScriptReference/MonoBehaviour.OnDisable.html)
  - [MonoBehaviour.Awake()](https://docs.unity3d.com/6000.3/Documentation/ScriptReference/MonoBehaviour.Awake.html)

+ Dev Environment:
  - **Unity Engine**: [6.3 (LTS)](https://docs.unity3d.com/6000.3/Documentation/Manual)
  - **Microsoft Visual Studio**: 2022 (_Community_)
  - **Game Assets**: [RPG Poly Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410),
[Jammo Character](https://assetstore.unity.com/packages/3d/characters/jammo-character-mix-and-jam-158456),
[Coin Treasure Bundle](https://assetstore.unity.com/packages/3d/props/coin-treasure-bundle-with-animation-3d-250070)
  - **Sound Resources**: [Gaming victory](https://pixabay.com/sound-effects/search/victory),
[Game Over](https://pixabay.com/sound-effects/search/game-sad-music)

Blogs: [Создание игры на Unity с нуля](https://artean.ru/blog/igri/kak-sozdat-igru-na-unity-s-nulya-polnoe-rukovodstvo), [...](https://artean.ru/blog)

#### Game prcess:
![Start game prcess](Images/screenshot_00.png)
![Game prcess](Images/screenshot_01.png)
![Game prcess](Images/screenshot_02.png)
![Game prcess](Images/screenshot_03.png)
![Finish game prcess](Images/screenshot_04.png)

#### Source code:
![AllEnums.cs](Images/screenshot_10.png)
![CollectableObject.cs](Images/screenshot_11.png)
![Inventory.cs](Images/screenshot_12.png)
![CanvasUpdater.cs](Images/screenshot_13.png)

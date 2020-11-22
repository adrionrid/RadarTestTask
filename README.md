# RadarTestTask

## Формулировка задания
Разработать приложение Windows для чтения файлов заданного формата и вывода результатов чтения в графическом виде.

## Дано
Текстовый файл в следующем формате (данные в файле и\или их порядок могут быть изменены при проверке задания):
```
ЛИН 10.0 10.0 20.0 20.0 2 255
ТЧК 0.0 0.0 0
Тчк 15.0 15.0 16711680
ОКР 20.0 20.0 3.0 1 16711680
ПРЯМ 10.0 10.0 20.0 20.0 1 0
```
Где:
- отрезок линии, где (x, y), ( x1, y1) координаты начала и конца отрезка.
	```
	ЛИН x y x1 y1 толщина_линии цвет_линии
	```
- точка. Отображать в виде окружности, заполненной цветом. Диаметр =1мм в координатах экрана.
	```
	ТЧК x y цвет
	```
- окружность. Цвет заливки –необязательный параметр, если отсутствует – использовать прозрачную заливку
	```
	ОКР x y радиус толщина_линии цвет_границы [цвет заливки]
	```
- прямоугольник, где (x, y),( x1, y1) – координаты 1 и 3-го углов прямоугольника (левый нижний и правый верхний), цвет заливки –необязательный параметр, если отсутствует – использовать прозрачную заливку
	```
	ПРЯМ x y x1 y1 толщина_линии цвет_границы [цвет заливки]
	```

- Цвет задан в формате RGB (например: 15790320 соответствует RGB(240, 240, 240)).
- Разделитель дробной части вещественных типов в исх. файле: точка.
- Единицы измерения координат в исх. файле: метры.
- Кодировка файла (внимание): ANSI.

## Функциональные требования
Исполнитель должен реализовать в программе следующие функции:
1. Чтение данных из выбранного пользователем файла.
2. Отображение прочитанных данных
	* Отображение самих данных
	Результаты чтения должны выводиться в графическом виде. Ось X направлена вверх, ось Y вправо (геодезические координаты)
	* Отображение вспомогательной информации
	В строке статуса должен быть реализован вывод координат текущего положения курсора (Единицы измерения: метры, точность: 1мм.) и текущий масштаб в числовом виде (например: 1:1200 (что значит: в одном сантиметре 12 метров))
3. Функции управления отображением
	* Увеличить масштаб
	* Уменьшить масштаб
	* Масштабировать к экстенту данных (Показать все)
	* Переместить изображение в окне (Скроллинг или протаскивание области просмотра) Способ реализации на выбор Исполнителя. Это может быть использование стандартных полос прокрутки окна, протаскивание с зажатой клавишей мыши и т.п.
4. *Сохранение данных в указанный файл
5. *Изменение данных
6. *Получение информации об элементе
	* Тип элемента (на русском-человеческом, т.е. Точка, Линия и т.п.)
	* Координаты вершин
	* Цвет(а)

*Пункты, помеченные ***** к выполнению не обязательны, но очень даже приветствуются*

## Общие требования:
- Должен быть реализован выбор команд через основное меню и панель управления (toolbar).
- Графические элементы должны реализовывать интерфейс IGraphObject Интерфейс IGraphObject – общий для всех типов графических элементов. Должен содержать методы инициализации элемента из строки, отображения, модификации и выдачи информации для сохранения в файл. Структура интерфейса разрабатывается исполнителем задания с учетом возможного расширения списка типов обрабатываемых элементов.
- Результаты выполнения тестового задания должны быть оформлены в виде проекта Microsoft Visual Studio 2015 и более поздних выпусков.
- Используемый язык программирования: C#. Использование библиотек сторонних производителей не допускается.
- Платформа: Windows Forms(WinForms)
- Версия .NET Framework: не ниже 4.5
- Передаваемые исходные тексты программы должны компилироваться, как для x86, так и для x64 платформам Windows.
- Программа должна быть оформлена в соответствии с рекомендациями Microsoft по оформлению пользовательского интерфейса приложений для Windows.
- Интерфейс должен быть понятен даже не очень опытному пользователю.

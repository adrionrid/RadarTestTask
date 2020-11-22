# RadarTestTask

## ������������ �������
����������� ���������� Windows ��� ������ ������ ��������� ������� � ������ ����������� ������ � ����������� ����.

## ����
��������� ���� � ��������� ������� (������ � ����� �\��� �� ������� ����� ���� �������� ��� �������� �������):
```
��� 10.0 10.0 20.0 20.0 2 255
��� 0.0 0.0 0 ��� 15.0 15.0 16711680
��� 20.0 20.0 3.0 1 16711680
���� 10.0 10.0 20.0 20.0 1 0
```
���:
- ��� x y x1 y1 �������_����� ����_����� � ������� �����, ��� (x, y), ( x1, y1) ���������� ������ � ����� �������.
- ��� x y ���� � �����. ���������� � ���� ����������, ����������� ������. ������� =1�� � ����������� ������.
- ��� x y ������ �������_����� ����_������� [���� �������] � ����������. ���� ������� ��������������� ��������, ���� ����������� � ������������ ���������� �������
- ���� x y x1 y1 �������_����� ����_������� [���� �������] � �������������, ��� (x, y),( x1, y1) � ���������� 1 � 3-�� ����� �������������� (����� ������ � ������ �������), ���� ������� ��������������� ��������, ���� ����������� � ������������ ���������� �������

* ���� ����� � ������� RGB (��������: 15790320 ������������� RGB(240, 240, 240)).
* ����������� ������� ����� ������������ ����� � ���. �����: �����.
* ������� ��������� ��������� � ���. �����: �����.
* ��������� ����� (��������): ANSI.

## �������������� ����������
����������� ������ ����������� � ��������� ��������� �������:
1. ������ ������ �� ���������� ������������� �����.
2. ����������� ����������� ������
	a. ����������� ����� ������
	���������� ������ ������ ���������� � ����������� ����. ��� X ���������� �����, ��� Y ������ (������������� ����������)
	b. ����������� ��������������� ����������
	� ������ ������� ������ ���� ���������� ����� ��������� �������� ��������� ������� (������� ���������: �����, ��������: 1��.) � ������� ������� � �������� ���� (��������: 1:1200 (��� ������: � ����� ���������� 12 ������))
3. ������� ���������� ������������
	a. ��������� �������
	b. ��������� �������
	c. �������������� � �������� ������ (�������� ���)
	d. ����������� ����������� � ���� (��������� ��� ������������� ������� ���������) ������ ���������� �� ����� �����������. ��� ����� ���� ������������� ����������� ����� ��������� ����, ������������� � ������� �������� ���� � �.�.
4. *���������� ������ � ��������� ����
5. *��������� ������
6. *��������� ���������� �� ��������
	a. ��� �������� (�� �������-������������, �.�. �����, ����� � �.�.)
	b. ���������� ������
	c. ����(�)

������, ���������� * � ���������� �� �����������, �� ����� ���� ��������������,

## ����� ����������:
- ������ ���� ���������� ����� ������ ����� �������� ���� � ������ ���������� (toolbar).
- ����������� �������� ������ ������������� ��������� IGraphObject ��������� IGraphObject � ����� ��� ���� ����� ����������� ���������. ������ ��������� ������ ������������� �������� �� ������, �����������, ����������� � ������ ���������� ��� ���������� � ����. ��������� ���������� ��������������� ������������ ������� � ������ ���������� ���������� ������ ����� �������������� ���������.
- ���������� ���������� ��������� ������� ������ ���� ��������� � ���� ������� Microsoft Visual Studio 2015 � ����� ������� ��������.
- ������������ ���� ����������������: C#. ������������� ��������� ��������� �������������� �� �����������.
- ���������: Windows Forms(WinForms)
- ������ .NET Framework: �� ���� 4.5
- ������������ �������� ������ ��������� ������ ���������������, ��� ��� x86, ��� � ��� x64 ���������� Windows.
- ��������� ������ ���� ��������� � ������������ � �������������� Microsoft �� ���������� ����������������� ���������� ���������� ��� Windows.
- ��������� ������ ���� ������� ���� �� ����� �������� ������������.
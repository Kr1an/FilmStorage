   M S B A M L   `   `   `  ���� M  ISObjectApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:SObjectApplication.Views.LibraryList$SObjectApplication.Views.LibraryList  <    6SObjectApplication.Views.LibraryList.ListConstellation   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:SObjectApplication.Views.LibraryList       � Title$  ListConstellation��$	��350��$	��525��.��� ���	#FFD0EAF3 � RowDefinitions �� �� $
��71.2 �.+�� $
��Left=�$��71��$��0,0.4,0,-0.2q�$	��Top=�$	��518��$��1�� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFD7FFFE�� � Offset$ 0Q�� $ 0.298Q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 40Q�	   	Direction$	 90Q�
   Color$
 	#FFBCDDFF��   ShadowDepth$ 10Q�.+��� ���	#FF899185$��1q�$��51��$��
10,10,0,10q�$��Center=�$��78�� �� CornerRadius$ 15�����	#0C00FF03$
��Left=�._��� -    ��Name$ imgBack��$?��9/SObjectApplication;component/resources/Drawable/back.png���� ���	#FF899185$��1q�$��Right=�$��51��$��0,10,10.4,10q�$��78��$ 15�����	#0C00FF03$��4��$��Center=�$y�Hidden=�._��� -   $ imgNext��$?��9/SObjectApplication;component/resources/Drawable/next.png��� $��1��$
��Left=�$��71��$��	0.6,0,0,0q�$	��Top=�$	��315��$��4���� -   $ 
btn_delete��$��1��$��51��$��0q�$��84��$A��;/SObjectApplication;component/resources/Drawable/cancel.png���� -   $ btn_info��$��2��$��51��$��0q�$��83��$F��@/SObjectApplication;component/resources/Drawable/information.png���� -   $ btn_add��$��3��$��51��$��0q�$��84��$>��8/SObjectApplication;component/resources/Drawable/add.png��� $
��Left=�$	��230��$��	10,10,0,0q�$	��Top=�$	��498��.+��� ���	#FF000000$��0q�$ 30�����	#FFBCDDFF._��� -    ��Name$ listView��$��Hidden=�$��Disabled=�$��10,10,0,10.4q����	#359DFF8E$��Tahoma)�$
��Left=�$	��475����Z� ����  �� 
TargetType" ��.�-    �� View �� ! �� ColumnHeaderContainerStyle �� " ��.���  �� Property � �� �� Value
 ��ح���  � ��
 �������  � ��$
 Bold"���  � ��$
 30px��.P��� $��	ShortName��-   colShortName�� �� Width$
 80px�� �� DisplayMemberBinding �� *ExInfo.ShortName+�� $
��Name��-	   colName��$ 220px�� �� *Name+�� $��Stars��-
   
colStarNum��$
 55px�� �� *Stars.Length+�� $��Position��-   colPosition��$ 120px�� �� *Position.ToString+
   M S B A M L   `   `   `  ����M  ISObjectApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SObjectApplication.PropertiesSObjectApplication.Properties  5      [2clr-namespace:SObjectApplication.Views.LibraryList$SObjectApplication.Views.LibraryList  5   	   7    1SObjectApplication.Views.LibraryList.ListProducer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ;res+clr-namespace:SObjectApplication.Properties     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:SObjectApplication.Views.LibraryList     5   	     � Title$  ListProducer��5	   	   $	��350��6   $	��525��6+   
�������.��5
      � 
������� � RowDefinitions 5      �� 5      �� 5      $
��71.2 �6   .+�5      � $
��Left=�6	   $��71��6$   $��0,0.4,0,-0.2q�60   $	��Top=�6F   $	��518��6^   $��1��6j    � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   ��5      �� 5       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6+   .��5      �  � Color$ 	#FFEDEDED��6    � Offset$ 0Q�6&   � 5      $ 0.298Q�6   5      .+�5!      �� $��1q�6   $��51��6!   $��
10,10,0,10q�6-   $��Center=�6A   $��78��6\    �� CornerRadius$ 15��6g   $
��Left=�6z   ._�5"      �� -   5         ��Name$ imgBack��5"      $?��9/SObjectApplication;component/resources/Drawable/back.png��6   6`   5#      �� 5$      ���	#FF899185$��1q�6$   $��Right=�68   $��51��6T   $��0,10,10.4,10q�6`   $��78��6v   $ 15��6�   ���	#0C00FF03$��4��6�   $��Center=�6�   $y�Hidden=�6�   ._�5%      �� -   5        $ imgNext��5%      $?��9/SObjectApplication;component/resources/Drawable/next.png��6   6`   5&      � 5'      $��1��6
   $
��Left=�6   $��71��65   $��	0.6,0,0,0q�6A   $	��Top=�6T   $	��315��6l   $��4��6x   �� 5(      -   5        $ 
btn_delete��5(      $��1��6   $��51��6/   $��0q�6;   $��84��6F   $A��;/SObjectApplication;component/resources/Drawable/cancel.png��6Q   6�   �� 5)      -   5        $ btn_info��5)      $��2��6   $��51��6-   $��0q�69   $��83��6D   $F��@/SObjectApplication;component/resources/Drawable/information.png��6O   6�   �� 5*      -   5        $ btn_add��5*      $��3��6   $��51��6,   $��0q�68   $��84��6C   $>��8/SObjectApplication;component/resources/Drawable/add.png��6N   6�   5+      � 5,      $
��Left=�6
   $	��230��6%   $��	10,10,0,0q�62   $	��Top=�6E   $	��498��6]   .+�5-      �� ���	#FF000000$��0q�6%   $ 30��69   ���	#FFEDEDED._�5.      �� -   5        	 ��Name$	 listView��5.   �   $��Hidden=�6O   $��Disabled=�6�   $��10,10,0,10.4q�6�   ���	#35FFFFFF$��Tahoma)�6  $
��Left=�6T  $	��475��6o  ���	#FF001651��6�   Z� ��5/      �� 50      
 �� 
TargetType"
 ��6   .�51   	   -   5        52   	    �� View 54      �� 56      ! �� ColumnHeaderContainerStyle 58   	   �� 59   
   "
 ��6   .�5<      ��  �� Property � �� �� Value
 �����6(   �� 5=       � ��
 �����6(   �� 5>       � ��$
 Bold"�6(   �� 5?       � ��$
 30px��6$   5@      .P�5B   	   �� -   'SObjectApplication.Properties.Resources   Name#��Z 6   -   5        colShortName�� �� Width$ 120px��5B   V    �� DisplayMemberBinding 6d   �� *Name+�� 5C   	      Example#��Z 6   -	   5        colName��$ 180px��5C   T    6b   �� *Films.Sample+�� 5D   	      Films#��Z 6   -
   5        
colFilmNum��$
 55px��5D   U    6b   �� *Films.Length+�� 5E   	      Year#��Z 6   -   5        colPosition��$ 120px��5E   T    6b   �� *Info.BirthDate.Year+5F   	   5H      5I      5J      5K      5L      
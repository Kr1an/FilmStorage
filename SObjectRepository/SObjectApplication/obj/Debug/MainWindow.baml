   M S B A M L   `   `   `  ����M  ISObjectApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SObjectApplicationSObjectApplication  5   	   #    SObjectApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SObjectApplication     5   	     � 
ResizeMode$  NoResize=�5	       � Title$ 
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � -   5         �Name$ MainGrid��5       J� RenderTransformOrigin$ 0.497,0.497&�6   
������� � ColumnDefinitions 5      �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5      �� 5      $��1* �6   �� 5      $��1* �6   .+�5      �� -   5         ��Name$ 
btnLibrary��5   
   $��191,22,214.4,42q�6   $"��resources/Drawable/books.png��67    K� ZIndex$ 3��6�   $ 0.552,0.203&�6�   $��2��6�   �� 5      ���	#FF000000$��0q�6#    �� CornerRadius$	 400��67   ���	#FFEDEDED$��10,0,0,0q�6a   $	��304��6s   $	��Top=�6�   $
��Left=�6�   $	��498��6�   $ 2��6�   $��2��6�   $��2��6�   ._�5      � .+�5      �� $ 30��6   $��1q�6   $	��138��63   $��0,25,186.6,0q�6@   $	��Top=�6V   $��Right=�6o   $	��146��6�   �� 5      $ 30��6   $��1q�6   $	��114��63   $��0,225,-29.4,-35q�6@   $	��Top=�6Y   $��Right=�6q   $	��125��6�   ._�5      �� -   5        $ btn_Exit��5      $��37.2,40.2,24,28.8q�6   $#��resources/Drawable/logout.png��6:   	 J� OpacityMask	 �	#7F0000006�   5      �� 5      -   5        
 ��Name$
 label��5      $��EN��6   $
��Left=�6(   $��
0,282,0,-6q�6C   $	��Top=�6W   
���   �$��Segoe WP Black)�6�   $��16(�6�   $��28��6�   ��6o   Z� ��5      �� 5       �� 
TargetType" ��6   .�5    	   ��  �� Property �@J�Opacity �� Value$	 0.3Q�6#   61    �� Triggers 5"   	   �� 5#   
    �� Binding 6   ��  �� ElementName$ label�� �� Path$ IsMouseOver� �� Value True6N   .a�5$      ��  �@J�Opacity 6%   �� *	RuOpacity+6C   5%      5)   	   5+      �� 5,      -   5        $
 label1��5,      $��RU��6   $
��Left=�6)   $��32,282,0,-6q�6D   $	��Top=�6Y   
���   �$��Segoe UI Black)�6�   $��16(�6�   $��28��6�   ��6q   Z� ��5-      �� 5.      " ��6   .�5/   	   ��  �@J�Opacity$	 0.3Q�6#   61    51   	   �� 52   
    6   �� $ label1��$ IsMouseOver� True6O   .a�53      ��  �@J�Opacity 6%   �� *	Opacity+6A   54      58   	   5:      5<      5=      5>      5?      
   M S B A M L   `   `   `  ����?  ;menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:menumenu  5   	       menu.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:menu     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   6*   �� 5      $	��10* �6   6+   .+�5   
   � $��0��6   ���	#FFBD9964.+�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6'   66   �� 5      $��4* �6'   64   �� 5      $
��0.5* �6'   66   �� 5      $��1* �6'   64   .+�5      � $��1��6   .+�5      �� 
���   �$��Georgia)�6/   $
��Bold"�6D   $��35(�6V   $��	65,10,0,0q�6d   .��6w   Restaurant "Josephines"6�   5      � 5      $��0��6   5      � 5      $��2��6   5      � 5      $��3��6   .+�5      �� ���	#FFA5815C._�5!      �� -   5         ��Name$ comboBox��5!   #   $��0,36,0,0q�6b   $��5,10,0,0q�6t   $��Georgia)�6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�    � 	Resources 5"       �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%(  '��       �� 5#   "   " ��6(   .�5$   &   ��  � ��
 �   �6C    5%   &   P� 5&   *   	 �@J�IsMouseOver$

 True��6I   . �5'   .   ��  � ��
 �  ��6K   5(   +   P� 5)   *   	 �@��
IsSelected$

 True��6H   . �5*   .   ��  � ��
 ��  �6K   5+   +   5-   #   5.      .@�50      �� -   5         ��Name$ listOfDishes��50   +   $��Center=�6A   $��Georgia)�6_   $
��Bold"�6t   $��16(�6�   .��6�   List of dishes6�   �� 51      -   5        $ toDelete��51   +   $��Center=�6=   $��Georgia)�6[   $
��Bold"�6p   $��16(�6�   .��6�   	To delete6�   �� 52      -   5        $ toUpdate��52   +   $��Center=�6=   $��Georgia)�6[   $
��Bold"�6p   $��16(�6�   .��6�   	To update6�   �� 53      -   5        $ toAdd��53   +   $��Center=�6:   $��Georgia)�6X   $
��Bold"�6m   $��16(�6   .��6�   To add6�   55      56      58      59      �� 5:      $��Order your option:��6   $
��Left=�61   $	��Top=�6L   $��
663,10,0,0q�6d   $	��122��6x   $��Italic$�6�   $
��Bold"�6�   5;      � 5<   
   $��1��6   ���	#FFF3CA7F.+�5=       � -   5          �Name$ 	mainFrame��5=        � NavigationUIVisibility$ Hidden=�6'   5>      5@      5A      
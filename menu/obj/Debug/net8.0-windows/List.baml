   M S B A M L   `   `   `  ����?  ;menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:menumenu  5          	menu.List   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:menu     5        N� Title$
  List��5	      .��5      � ���	#FFF3CA7F � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��9* �6   6*   .+�5      � $��0��6   
������� � ColumnDefinitions 5      �� 5      $��1* �6$   61   �� 5      $��3* �6$   61   �� 5      $��3* �6$   61   �� 5      $��3* �6$   61   .+�5      �� $��0��6   $��0��6#   $��2q�63   
���   �._�5      � .+�5      �� $��Center=�6    $��Center=�6;   $��Georgia)�6X   
���   �$
��Bold"�6�   $��15(�6�   .��6�   Id6�   5      5      �� 5      $��0��6   $��1��6#   $��2q�63   
���   �._�5      � .+�5       �� $��Center=�6   $��Center=�68   $��Georgia)�6V   
���   �$
��Bold"�6~   $��15(�6�   .��6�   Name6�   5!      5"      �� 5#      $��0��6   $��2��6$   $��2q�64   
���   �._�5$      � .+�5%      �� $��Center=�6   $��Center=�64   $��Georgia)�6R   
���   �$
��Bold"�6z   $��15(�6�   .��6�   Cost6�   5&      5'      �� 5(      $��0��6   $��3��6%   $��2q�65   
���   �._�5)      � .+�5*      �� $��Center=�6   $��Center=�64   $��Georgia)�6Q   
���   �$
��Bold"�6y   $��15(�6�   .��6�   Type6�   5+      5,      5-      � 5.   
   $��1��6   .+�5/      &   System.Windows.Controls.DataGrid  $��1��6      AutoGenerateColumns$ False��6$      HeadersVisibility$
 None=�6g      
IsReadOnly$
 True��6�   ��6@   �� *DishCollection+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6)      Header$ Id��64   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *Id+
   ElementStyle
 52      �� 53       �� 
TargetType" ��6$   .�54   "   ��  �� Property � �� �� Value$ Center=�6H   55      57        58      $ 3* 6*   $
 Name��66   	 6D   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  59      $ 3* 6.   $
 Cost��69      CellTemplate 5:      �� 5;      .R�5<   "   ��  �� TextAlignment$ Center=�6,   ��6C   �� *Cost+ �� StringFormat$ {0:C}��5=      5?        5A      $ 3* 6*   $
 Type��66   	 6D   �� *Type+5C      5D      5F      5I      
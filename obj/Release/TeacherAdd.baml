   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  
 HelpMe   SampleApp.TeacherAdd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$   ��$	��500��$	��400��$	��500��$	��400��$	��400��$	��500�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $	��14* ��� $	��39* ��� $
��152* ��� $��38 ��� $��38 ��� $��6* � � ColumnDefinitions �� $��8 ��� $
��131* ��� $
��144* ��� $��10 �.+��� -    ��Name$ 
btn_Cancel��$��
Назад��$��1,7,2,5q�$��10(�$��1��$��4���� -   $ 	btn_Apply��$��Применить��$��15,7,0,5q�$��10(�$��2��$��4���� -    ��Name$ txtInput��$��2��$��24��$��3,5,10,0q�$��1�� �� TextWrapping$
 Wrap=�$�� ��$	��Top=��� $��1��$��
0,10,2.5,0q�$��1��$
��Wrap=�$	��Top=� �� TextAlignment$ Right=��� $�Введите ���� $!�нового учителя���� $�:��&   System.Windows.Controls.DataGrid  -   $��gridType��$��1��$��2,3,0,1q�$��2��   AutoGenerateColumns .  $��2��	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Учитель��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Fullname+�� -   $ 
btn_Delete��$��Удалить��$��2,11,0,1q�$��10(�$��1��$��3��$��2��
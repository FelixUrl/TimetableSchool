   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      
 HelpMe   SampleApp.WindowAdd   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah
 dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai  eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am" iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag# cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj$ fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ay	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks    	 
                        ! " # $ 6Y     � Title$  	WindowAdd��5      $	��500��5      $	��400��5	      $	��500��5
      $	��400��5      $	��600��5      $	��600��5       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value   ComboBoxToggleButton � ColumnDefinitions ��Name F�Name  ComboBoxTextBox �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation  �� Triggers! �� 
TargetName" P� 
SourceName# �� Padding��%�  '��       &	      &	 D    '�� �    7   7  '�� P    �� 5   
   " ��6   .�5      ��  � �� �	#FFF1F1F16+   �� 5       � �� �	#FF007ACC6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ���	#FF007ACC$��2q�6c   $ 5��6w   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5       P� 5!      	 �@J�IsMouseOver
 . . �5#      ��  � �� �	#FF007ACC63   5$      P� 5%      	 �@J�IsMouseOver
 . . �5&      ��  � �� �	#FFF1F1F163   5'      5)      �� 5*   
   " d�67   .R�5+      �  5,      �� 5-      �� 5.      $��20 �6'   .+�50      �� $ Border��51      $��2��52      $ 5��53      ���	#FF007ACC���	#FF007ACC$��1,0,0,0q�56      �� 57      $��0��58      $ 5��59      $��1q�5:      ���	#FFF1F1F1���	#FF007ACC$��0,0,1,0q�5=      F� 5>      $ Arrow��5?      $��1��5@      ���	#FFF1F1F1$��Center=�5B      $��Center=�5C      =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	5D      5F      5G      �� 5H   
   " ��62   .R�5I      �� $ PART_ContentHost��6   |�.  #��z��6A   5J      �� 5K   
   " ��6*   .�5L      ��  �@J�SnapsToDevicePixels . 64   �� 5M       �@�OverridesDefaultStyle . 66   �� 5N       � ��$
 Auto=�6K   �� 5O       � ��$
 Auto=�6I   �� 5P       � �� . 6>   �� 5Q       � ��$	 120��6)   �� 5R       � ��$ 20��6*   �� 5S       � �� �	#FF2E2E2E6+   �� 5T       � �� 5U      �� 5V      " ��6&   .R�5W      � .+�5X      d� $��ToggleButton��5Y      8��  $��2��5[      |�.  $ Press=�5^       5]      �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5_      �� 5`      $��ContentSite��6/    .  #��z 6\   #��z 5a      #��z��5b      $��3,3,23,3q�5c      $��Center=�5d      $
��Left=�5e      �� 5f      $ PART_EditableTextBox��6&   8�� $
��Left=�5i      $��Center=�5j      $��3,3,23,3q�5k      |�. 
���  ��
��� � �$y�Hidden=�5o      # z 5p      ��5g      Z� 5p      � 5q      $��Popup��5r      $��Bottom=�5s      #��z 5t       . |�.  $��Slide=�5w      .��5y   "   � $��DropDown��6'    . #��z 5{      #��z 5|      .+�5}   &   �� $ DropDownBorder��5~   !   ���	#FFF1F1F1$ 2,2,5,5��5�   !   $��1.1,0.8,1.1,1.1q�5�   !   ���	#FF007ACC5�   !   �� 5�   &   $��4,6,4,6q�63    . .��5�   *   ��  . $ 	Contained=�6H   5�   '   5�   #   5�      5�        5�      P� 5�      	 �@��HasItems
 .  . �5�   "   �� $! DropDownBorder��6)    � ��$ 95��6Z   5�      P� 5�      	 � {�
 .  . �5�   "   ��  � �� �#8888886?   5�      P� 5�      	 �@��
IsGrouping
 . . �5�   "   ��  � �� .  6R   5�      P� 5�      $" Popup��6&   	 �@�AllowsTransparency
 . . �5�   "   �� $! DropDownBorder��6)    �@��CornerRadius$ 2,2,5,5��6]   �� 5�   "   $! DropDownBorder��6)    � ��$ 0,0,0,0q�6W   5�      P� 5�      	 �@��
IsEditable
 . . �5�   "   ��  � �� .  6>   �� 5�   "   $! PART_EditableTextBox��6)    � y�$ Visible=�6a   �� 5�   "   $! ContentSite��6)    � y�$ Hidden=�6X   5�      5�      5�       5�      5�      �� 5�   
   " ��6.   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       � �� �	#FF2E2E2E6+   �� 5�       �@�OverridesDefaultStyle . 66   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $��Border��6!   $# 2q�5�       . ._�5�      �� 5�        5�      P� 5�      	 �@��IsHighlighted
 . . �5�   "   �� $! Border��6)    � �� �	#FF007ACC6S   5�      P� 5�      	 � {�
 .  . �5�   "   ��  � �� �#8888886?   5�      5�      5�      5�      5�      .��5�      � $ � RowDefinitions$ 5�   
   �� 5�      $��4* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      $��2* �6   �� 5�      $��27 �6   �� 5�      �� 5�      $
��162* �6    5�   
   �� 5�      $��9 �6   �� 5�      $��78 �6   �� 5�      $��2 �6   �� 5�      �� 5�      $��27 �6   �� 5�      $��10 �6   .+�5�   
   �� $
��Wrap=�6   $��Группа:��6(   $��0,5,1,6q�67   % �� TextAlignment$% Right=�6H   $��1��6^   $��1��6n   �� 5�   
   $
��Wrap=�6   $��Аудитория:��6(   $��0,4,1,4q�6:   $% Right=�6K   $��1��6a   $��3��6q   �� 5�   
   $
��Wrap=�6   $��Дисциплина:��6(   $��1,4,0,4q�6;   $% Right=�6L   $��1��6b   $��5��6r   �� 5�   
   $
��Wrap=�6   $��Учитель:��6(   $��0,4,1,4q�68   $% Right=�6I   $��1��6_   $��7��6o   �� 5�   
   $
��Wrap=�6   $��Номер пары:��6(   $	��1,4q�6;   $% Right=�6H   $��1��6^   $��13��6n   �� 5�   
   $
��Wrap=�6   $��Тип занятия:��6(   $��0,5,2,3q�6<   $% Right=�6M   $��9��6c   $��1��6p   �� 5�   
   -   5        $��cmbGroup��5�      $��3��6#   $��1��63   $��0,0,1,1q�6@   & �� DisplayMemberPath$
& Name��6Q   �� 5�   
   -   5        ' ��Name$' cmbAudition��5�      $��3��6(   $��3��68   $��0,0,1,1q�6E   $
& Name��6V   �� 5�   
   -   5        $' cmbDiscipline��5�      $��3��6*   $��5��6:   $��0,0,1,1q�6G   $
& Name��6X   �� 5�   
   -   5        $' 
cmbTeacher��5�      $��3��6'   $��7��67   $��0,0,1,1q�6D   $& Fullname��6U   �� 5�   
   -   5        $' 	cmbNumber��5�      $��3��6&   $��13��66   $��1,0,1,1q�6D   $& Number��6U   �� 5�   
   -   5        $' cmbTypeOfLesson��5�      $��9��6,   $��0,1,2,0q�69   $
& Type��6J   $��3��6c   �� 5�   
   -   5        $��btnAdd_Group��5�      $��4��6f   $��1q�6v   $��1��6�   ��6%   2  ,MahApps.Metro.IconPacks.FontAwesomeExtension  *	PlusSolid+3  -MahApps.Metro.IconPacks.BasePackIconExtension(   Width$( 11Q�)   Height$) 11Q�6�   �� 5�   
   -   5        $��btnAdd_Audition��5�      $��4��6i   $��1q�6y   $��3��6�   ��6(     *	PlusSolid+$( 11Q�$) 11Q�6�   �� 5�   
   -	   5        $��btnAdd_Discipline��5�      $��4��6k   $��1q�6{   $��5��6�   ��6*     *	PlusSolid+$( 11Q�$) 11Q�6�   �� 5�   
   -
   5        $��btnAdd_Teacher��5�      $��4��6h   $��1q�6x   $��7��6�   ��6'     *	PlusSolid+$( 11Q�$) 11Q�6�   �� 5�   
   -   5        * ��Name$* btnAdd_TypeOfLesson��5�      $��0,2,1,0q�6o   $��9��6�   $��4��6�   ��6.     *	PlusSolid+$) 11Q�$( 11Q�6�   � 5�   
   $��4��6   $��1��6#   $��13��63   $��3��6A    5�      �� 5�      $	��46* �6#   �� 5�      $	��45* �6#   $ 5�      �� 5�      $
��Auto �6    �� 5�      $��5* �6    �� 5�      $��30 �6    �� 5�      .+�5�      �� -   5        $��
btn_Cancel��5�      $��Отмена��6'   $��0,3,30,0q�68   $��10(�6J   $��2��6X   6e   �� 5�      -   5        $��	btn_Apply��5�      $��Применить��6&   $��27,3,0,0q�6:   $��10(�6L   $��2��6Z   $��1��6g   6w   5�      �� 5�   
   $
��Wrap=�6   $��1,4,0,4q�6(   $% Right=�69   $��11��6O   $��1��6]   �� 6n   $�	Дата:��6r   6�   �� 5�   
   $��11��6   $��3��6   ���	#FFF1F1F1$��1q�6F   ���	#FF007ACC$��	189,0,1,0q�6r   $ 5��6�   ._�5�      (  "System.Windows.Controls.DatePicker  -   5        $��	date_Date��5�   _   $��4,0,2,2q�6   ���	#FFF1F1F1$��13��6A   $��3��6O   $��0q�6p   5�      �� 5�   
   -   5        $' cmbDate��5�      $��3��6$   $��11��64   $��	1,0,188,1q�6B   $
& Date��6U   + �� ItemStringFormat$+ 
dd.MM.yyyy��6n   �� 5�   
   -   5        $* btnAdd_Date��5�      $��0,1,1,1q�6g   $��11��6x   $��4��6�   ��6&     *	PlusSolid+$) 11Q�$( 11Q�6�   5      5     
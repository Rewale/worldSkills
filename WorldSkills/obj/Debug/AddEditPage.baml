   M S B A M L   `   `   `  ����F  BWorldSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WorldSkillsWorldSkills  5          WorldSkills.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WorldSkills     5        N� Title$  AddEditPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $
��Name��6   $��Center=�6    $��Center=�6=   6Z   �� 5   
   $��Stars��6   $��1��6!   $��Center=�6.   $��Center=�6K   6h   �� 5   
   $��Country��6   $��2��6#   $��Center=�60   $��Center=�6M   6j   �� 5   
   $��1��6(   $��35��68   $��5q�6D   ��6   �� *Name+6Q   �� 5   
   $��1��60   $��1��6@   $��35��6M   $��50��6Y   $��5q�6d   $
��Left=�6o   ��6   �� *CountOfStars+6�   �� 5   
   -   5         ��Name$ ComboCountries��5   h   $��1��64   $��2��6D   $��35��6Q   $��5q�6]    �� DisplayMemberPath$
 Name��6�    �� SelectedItem 6   �� *	Country+6�   �� 5   
   -   5        $��BtnSave��5   A   $
��Save��6   $��2��6    $��3��64   6h   5      5       
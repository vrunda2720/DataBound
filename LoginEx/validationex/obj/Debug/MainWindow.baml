   M S B A M L   `   `   `  ����G  Cvalidationex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:validationexvalidationex  5   	       validationex.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:validationex     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��20q�62   .+�5      �� -   5        $��	blockname��5   )   $��Name:��6   $��15(�6:   $��20��6H   $��70��6T   $
��Left=�6_   6|   �� 5      -   5        $��boxname��5      $��20��6)   $	��100��65   6D   5      �� 5      $ 
Horizontal=�6   $��20q�62   .+�5      �� -   5        $��blockage��5   (   $
��Age:��6   $��15(�68   $��20��6F   $��70��6R   $
��Left=�6]   6z   �� 5      -   5        $��boxage��5      $��20��6(   $	��100��64   6C   5      �� 5      -   5        $��S3��5      $ 
Horizontal=�6#   $��20q�6<   .+�5      �� -   5        $��	blockdate��5   .   $��
Birthdate:��6   $��15(�6?   $��20��6M   $��70��6Y   $
��Left=�6d   6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��Picker��5      $
��Left=�6+   $	��Top=�5      5      �� 5      $ 
Horizontal=�6   $��20q�62   .+�5      �� -   5        $��blockNoSpecial��5   2   $��Nospecialchar:��6   $��15(�6H   $��20��6V   $	��120��6b   $
��Left=�6n   6�   �� 5      -	   5        $��boxNospecial��5      $��20��6.   $	��130��6:   6I   5      �� 5!      $ 
Horizontal=�6   $��20q�62   .+�5"      �� -
   5        $��blockOnespecial��5"   3   $��Onespecialchar:��6   $��15(�6J   $��20��6X   $	��120��6d   $
��Left=�6p   6�   �� 5#      -   5        $��boxonespecial��5#      $��20��6/   $	��130��6;   6J   5$      �� 5&      $��20q�6   .+�5'      �� -   5        $��validbtn��5'      $��Validate��6)   $��30��6<   $	��100��6H   $��Center=�6T   6�   5(      5)      5*      5+      